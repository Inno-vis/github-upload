using OrganizedCrimeApp.Shared.Library;

namespace OrganizedCrimeApp.Server.Library
{
  public static class Game
  {
    public static GameState GameState = GameState.Lobby;
    public static bool IsDayTime => Game.GameState == GameState.Day;
    public static bool IsNightMafiaTime => Game.GameState == GameState.NightMafia;
    public static bool IsNightDoctorTime => Game.GameState == GameState.NightDoctor;
    public static bool IsNightSherrifTime => Game.GameState == GameState.NightSherrif;
    public static bool IsLobbyTime => Game.GameState == GameState.Lobby;
    public static bool IsGameOverMafiaWins => Game.GameState == GameState.GameOverMafiaWins;
    public static bool IsGameOverCiviliansWin => Game.GameState == GameState.GameOverCiviliansWin;
    public static bool IsIntroductionRound => Game.GameState == GameState.IntroductionRound;

    public static void EndGame()
    {
      ///todo
      GameState = GameState.Lobby;
    }

    public static GameState MoveToNextGameState()
    {
      switch (GameState)
      {
        case GameState.Lobby:
          GameState = GameState.IntroductionRound;
          break;

        case GameState.GameOverCiviliansWin:
          GameState = GameState.IntroductionRound;
          break;

        case GameState.GameOverMafiaWins:
          GameState = GameState.IntroductionRound;
          break;

        case GameState.IntroductionRound:
          GameState = GameState.NightMafia;
          break;

        case GameState.Day:
          GameState = GameState.NightMafia;
          break;

        case GameState.NightMafia:
          GameState = GameState.NightSherrif;
          if (Players.SherrifIsGone)
          {
            MoveToNextGameState();
          }
          break;

        case GameState.NightSherrif:
          GameState = GameState.NightDoctor;

          if (Players.DoctorIsGone)
          {
            MoveToNextGameState();
          }
          break;

        default:
          GameState = GameState.Day;
          break;
      }

      return GameState;
    }
  }
}