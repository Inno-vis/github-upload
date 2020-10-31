using OrganizedCrimeApp.Shared.Library;

namespace OrganizedCrimeApp.Shared.Library
{
  public class Player
  {
    public string Name { get; set; }
    public string ConnectionId { get; set; }
    public Role Role { get; set; }
    public PlayerState PlayerState { get; set; }
    public bool IsGone => PlayerState != PlayerState.Alive;

    public string RoleToString()
    {
      switch (Role)
      {
        case Role.Mafia:
          return "Mafia";

        case Role.Doctor:
          return "the Doctor";

        case Role.Sherrif:
          return "the Sherrif";
        default:
          return "a Civilian";
      }
    }
  }
}