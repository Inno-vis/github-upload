namespace OrganizedCrimeApp.Shared.Library
{
  public static class AsyncMethod
  {
    public static string Msg_RECEIVE = "ReceiveMessage";
    public static string Msg_SEND = "SendMessage";
    public static string Game_START = "StartGame";
    public static string Game_ADVANCE = "AdvanceGame";
    public static string Game_LOAD = "SetGameUp";
    public static string Prompt_OPEN = "PromptActivePlayersToOpenEyes";
    public static string Prompt_CLOSE = "PromptActivePlayersToCloseEyes";
    public static string Sound_PLAY = "PlaySound";
    public static string Log_CONSOLE = "ConsoleWriteline";

  }

  public static class MagicString
  {
    public static string NO_ONE = "no one";
  }


  public enum Role
  {
    Mafia,
    Doctor,
    Sherrif,
    Civilian,
    Tourist

  }

  public enum PlayerState
  {
    Alive,
    DeadOrOutcast,
    Tourist
  }

  public enum GameState
  {
    Lobby,
    NightMafia,
    NightSherrif,
    NightDoctor,
    Day,
    IntroductionRound,
    GameOverCiviliansWin,
    GameOverMafiaWins
  }
}