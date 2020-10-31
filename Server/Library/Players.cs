using System;
using System.Linq;
using System.Collections.Generic;
using OrganizedCrimeApp.Shared.Library;

namespace OrganizedCrimeApp.Server.Library
{
  public static class Players
  {
    public static List<Player> PlayersList = new List<Player>();
    public static string TargetName = string.Empty;
    public static int PlayerCount => PlayersList.Count;
    public static bool Enough => PlayerCount > 3;

    public static string AddPlayer(string playerName, string connectionId)
    {

      string succesMessage;
      if (!PlayerExists(playerName, connectionId))
      {
        PlayersList.Add(new Player()
        {
          Name = playerName,
          ConnectionId = connectionId,
          PlayerState = PlayerState.Alive
        });
        ///todo
        ///if !Game.IsLobby Role = Role.Tourist
        ///PlayerState = Tourist

        succesMessage = playerName + " has joined";
      }
      else if (GetPlayerByConnectionId(connectionId) == null)
      {
        var player = GetPlayerByConnectionId(connectionId);
        player.ConnectionId = connectionId;
        succesMessage = player.Name + " is back";
      }
      else
      {
        succesMessage = ChangeName(playerName, connectionId);
      }
      return succesMessage;
    }

    private static string ChangeName(string playerName, string connectionId)
    {
      ///test
      string succesMessage;
      var player = PlayersList.FirstOrDefault(p => p.ConnectionId == connectionId);
      if (player == null)
      {
        succesMessage = "error in changename";
      }
      else
      {
        var oldName = player.Name;
        player.Name = playerName;
        succesMessage = oldName + " is now known as " + playerName;
      }

      // var player = GetPlayerByConnectionId(connectionId);
      // var oldName = player.Name;
      // userList.Remove(oldName);
      // userList.Add(playerName, player);
      return succesMessage;
    }

    public static List<Player> GetActivePlayersByRole(Role role)
    {
      return PlayersList.Where(p => !p.IsGone && p.Role == role).ToList();
    }

    internal static void KillTarget(string targetedPlayerName)
    {
      var targetPlayer = PlayersList.FirstOrDefault(p => p.Name == targetedPlayerName);
      if (targetPlayer == null) { throw new Exception(); }
      targetPlayer.PlayerState = PlayerState.DeadOrOutcast;
    }

    internal static List<string> GetPossibleTargetNames()
    {
      if (Game.GameState == GameState.NightMafia)
      {
        return GetRemainingPlayers()
         .Where(p => p.Role != Role.Mafia)
         .Select(p => p.Name)
         .ToList();
      }
      else if (Game.GameState == GameState.NightDoctor)
      {
        return GetRemainingPlayers()
        .Select(p => p.Name)
        .ToList();
      }
      else if (Game.GameState == GameState.NightSherrif)
      {
        return GetRemainingPlayers()
        .Where(p => p.Role != Role.Sherrif)
        .Select(p => p.Name)
        .ToList();
      }
      else if (Game.GameState == GameState.Day)
      {
        var targetNames = GetRemainingPlayers()
        .Select(p => p.Name)
        .ToList();
        targetNames.Add(MagicString.NO_ONE);
        return targetNames;
      }
      else
      { return new List<string>(); }

    }

    internal static void ResetGame()
    {
      foreach (var player in PlayersList)
      {
        player.PlayerState = PlayerState.Alive;
      }
    }


    public static void SetTarget(string playerName)
    {
      TargetName = playerName;
    }

    public static void TrySaveTarget(string playerName)
    {
      if (TargetName == playerName)
      {
        TargetName = string.Empty;
      }
    }

    internal static List<Player> GetRemainingPlayers()
    => PlayersList.Where(p => !p.IsGone).ToList();

    internal static bool IsMafia(string targetedPlayerName) => PlayersList.FirstOrDefault(p => p.Name == targetedPlayerName).Role == Role.Mafia;

    public static Player GetPlayerByConnectionId(string connectionId)
    {
      ///test
      return PlayersList.FirstOrDefault(p => p.ConnectionId == connectionId);
      // foreach (var player in userList)
      // {
      //   if (player.Value.ConnectionId == connectionId)
      //   {
      //     return player.Value;
      //   }
      // }
      // return null;
    }

    public static bool PlayerExists(string playerName, string connectionId)
   => PlayersList.FirstOrDefault(p => p.Name == playerName || p.ConnectionId == connectionId) != null;

    internal static bool EqualMafiaCivilians()
    {
      var mafia = GetRemainingPlayers().Where(p => p.Role == Role.Mafia).ToList().Count;
      var civilians = GetRemainingPlayers().Where(p => p.Role != Role.Mafia).ToList().Count;

      return mafia == civilians;
    }

    internal static bool NoMoreMafia()
    => GetActivePlayersByRole(Role.Mafia).Count == 0;

    internal static bool SherrifIsGone => PlayersList.FirstOrDefault(p => p.Role == Role.Sherrif && p.IsGone) != null;

    internal static bool DoctorIsGone => GetActivePlayersByGameState().Where(p => p.Role == Role.Doctor).FirstOrDefault() == null;

    internal static List<Player> GetActivePlayersByGameState()
    {
      if (Game.IsDayTime
      || Game.IsIntroductionRound
       || Game.IsGameOverCiviliansWin
      || Game.IsGameOverMafiaWins
      || Game.IsLobbyTime)
      {
        return GetRemainingPlayers();
      }
      else if (Game.IsNightMafiaTime)
      {
        return GetActivePlayersByRole(Role.Mafia);
      }
      else
      if (Game.IsNightDoctorTime)
      {
        return GetActivePlayersByRole(Role.Doctor);
      }
      else
      if (Game.IsNightSherrifTime)
      {
        return GetActivePlayersByRole(Role.Sherrif);
      }
      else
      {
        throw new Exception();
      }
    }

    internal static List<string> GetActivePlayerIds()
    => GetActivePlayersByGameState().Select(p => p.ConnectionId).ToList();

    public static string GetPlayerNames()
    {
      ///todo
      var playerList = PlayersList.Select(p => p.Name).ToList();

      return String.Join(", ", playerList);
    }

    public static void DivideRoles()
    {
      int x = PlayerCount / 4;
      Role[] roles = new Role[PlayerCount];
      for (int i = 0; i < x; i++)
      {
        roles[i] = Role.Mafia;
      }

      roles[x] = Role.Doctor;
      roles[x + 1] = Role.Sherrif;
      for (int i = x + 2; i < PlayerCount; i++)
      {
        roles[i] = Role.Civilian;
      }

      Helper.Shuffle(roles);

      var j = 0;
      foreach (var player in PlayersList)
      {
        player.Role = roles[j];
        player.PlayerState = PlayerState.Alive;
        j++;
      }
    }
  }
}