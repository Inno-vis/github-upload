using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using OrganizedCrimeApp.Server.Library;
using OrganizedCrimeApp.Shared.Library;

namespace OrganizedCrimeApp.Server.Hubs
{
  public class ChatHub : Hub
  {
    private string msg;
    private List<string> activePlayerIds => Players.GetActivePlayerIds();
    private List<string> possibleTargetNames => Players.GetPossibleTargetNames();
    public async Task SendMessage(string user, string message)
    {
      if (String.IsNullOrEmpty(user))
      {
        return;
      }
      else
      {
        if (!Players.PlayerExists(user, Context.ConnectionId))
        {
          await Register(user);
        }
        if (!String.IsNullOrEmpty(message))
        {
          msg = user + " says " + message;
          await SendToAll(msg);
        }
      }
    }

    public async Task Register(string userName)
    {
      var connId = Context.ConnectionId;
      msg = Players.AddPlayer(userName, connId);

      await SendToAll(msg);
    }

    public async Task AdvanceGame(string targetedPlayerName, string action)
    {
      await SendActionConfirmationToCurrentPlayer(targetedPlayerName, action);

      #region PERFORM ACTION OF CURRENT PLAYER
      if (Game.IsNightMafiaTime)
      {
        Players.SetTarget(targetedPlayerName);
      }
      else if (Game.IsNightDoctorTime)
      {
        Players.TrySaveTarget(targetedPlayerName);
      }
      else if (Game.IsNightSherrifTime)
      {
        string answer = Players.IsMafia(targetedPlayerName) ? string.Empty : " not";
        msg = targetedPlayerName + " is" + answer + " a member of the kartel";
        await SendToSingle(activePlayerIds.First(), msg);
      }
      else if (Game.IsDayTime)
      {
        if (targetedPlayerName == MagicString.NO_ONE)
        {
          msg = "You will regret this.";
          await SendToAll(msg);
        }
        else
        {
          msg = targetedPlayerName + " may now say goodbye and leave the city.";
          await SendToAll(msg);

          Thread.Sleep(2000);
          Players.KillTarget(targetedPlayerName);

          IsGameOver();
          if (isGameOver)
          {
            return;
          }
        }
      }


      await PromptAllActivePlayersToCloseEyes();
      #endregion

      Game.MoveToNextGameState();

      #region SET UP NEXT GAMESTATE
      await PromptActivePlayersToOpenEyes();

      if (Game.IsDayTime)
      {
        if (String.IsNullOrEmpty(Players.TargetName))
        {
          msg = "Everyone survived the night.";
        }
        else
        {
          Players.KillTarget(Players.TargetName);
          msg = Players.TargetName + " is sleeping with the fish.";

          IsGameOver();
          if (isGameOver)
          {
            return;
          }
        }
        await SendToAll(msg);
      }

      await Clients.All.SendAsync(AsyncMethod.Game_LOAD,
      Game.GameState.ToString(),
      possibleTargetNames,
      activePlayerIds);
      #endregion
      await Clients.All.SendAsync(AsyncMethod.Log_CONSOLE);
    }

    private bool isGameOver = false;
    private async void IsGameOver()
    {
      if (Players.EqualMafiaCivilians() || Players.NoMoreMafia())
      {
        if (Players.EqualMafiaCivilians())
        {
          Game.GameState = GameState.GameOverMafiaWins;
        }
        else
        {
          Game.GameState = GameState.GameOverCiviliansWin;
        }

        Players.ResetGame();
        var activePlayerIds = Players.GetActivePlayerIds();
        var possibleTargets = new List<string>();
        await Clients.All.SendAsync(AsyncMethod.Game_LOAD,
        Game.GameState.ToString(),
        possibleTargets,
        activePlayerIds);
        isGameOver = true;
      }
      else
      {
        isGameOver = false;
      }
    }

    private async Task SendActionConfirmationToCurrentPlayer(string targetedPlayerName, string action)
    {
      if (Game.IsIntroductionRound)
      {
        return;
      }
      msg = "You are trying to " + action + " " + targetedPlayerName;

      foreach (var connId in activePlayerIds)
      {
        await SendToSingle(connId, msg);
      }
    }

    private async Task PromptAllActivePlayersToCloseEyes()
    {
      msg = "Close your eyes";
      foreach (var connId in activePlayerIds)
      {
        await SendToSingle(connId, msg);
      }
    }


    public async Task PromptActivePlayersToOpenEyes()
    {
      if (Game.IsNightMafiaTime
      || Game.IsNightDoctorTime
      || Game.IsNightSherrifTime
      || Game.IsDayTime)
      {
        Thread.Sleep(2000);
        await PlayAlertSound();
        msg = "Open your eyes";
        foreach (var connId in activePlayerIds)
        {
          await SendToSingle(connId, msg);
        }
      }
    }

    private async Task PlayAlertSound()
    {
      await Clients.All.SendAsync(AsyncMethod.Sound_PLAY);
    }

    public async Task StartGame()
    {
      if (Players.Enough)
      {
        Players.DivideRoles();

        msg = "The game has started. " + Players.GetPlayerNames() + " are playing.";
        await SendToAll(msg);

        foreach (var player in Players.PlayersList)
        {
          msg = "You are " + player.RoleToString();
          await SendToSingle(player.ConnectionId, msg);
        }

        msg = "Please present yourself";
        await SendToAll(msg);

        Game.MoveToNextGameState();
        await Clients.All.SendAsync(AsyncMethod.Game_LOAD,
        Game.GameState.ToString(),
        possibleTargetNames,
        activePlayerIds);

        await Log("activeplayers " + activePlayerIds + " gamestate " + Game.GameState.ToString());
      }
      else
      {
        msg = "You need at least 4 people to play. ";
        if (Players.PlayerCount > 1)
        {
          msg = String.Concat(msg, Players.GetPlayerNames() + " are playing.");
        }
        else if (Players.PlayerCount == 1)
        {
          msg = String.Concat(msg, Players.GetPlayerNames() + " is playing.");
        }

        await SendToAll(msg);
      }
    }

    private async Task SendToAll(string msg)
    {
      await Clients.All.SendAsync(AsyncMethod.Msg_RECEIVE, msg);
    }

    private async Task SendToSingle(string connectionId, string msg)
    {
      await Clients.Client(connectionId).SendAsync(AsyncMethod.Msg_RECEIVE, msg);
    }
    private async Task Log(string msg)
    {
      await Clients.All.SendAsync(AsyncMethod.Log_CONSOLE, msg);
    }
  }
}