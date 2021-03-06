#pragma checksum "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e1b9c4bfa392ad1c2d7b47481a3871ae94d253c"
// <auto-generated/>
#pragma warning disable 1591
namespace OrganizedCrimeApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/carebear/Projects/OrganizedCrimeApp/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/carebear/Projects/OrganizedCrimeApp/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/carebear/Projects/OrganizedCrimeApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/carebear/Projects/OrganizedCrimeApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/carebear/Projects/OrganizedCrimeApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/carebear/Projects/OrganizedCrimeApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/carebear/Projects/OrganizedCrimeApp/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/carebear/Projects/OrganizedCrimeApp/Client/_Imports.razor"
using OrganizedCrimeApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/carebear/Projects/OrganizedCrimeApp/Client/_Imports.razor"
using OrganizedCrimeApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
using OrganizedCrimeApp.Shared.Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\n  ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row text-center");
            __builder.OpenElement(5, "h3");
            __builder.AddContent(6, 
#nullable restore
#line 13 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                    labelGameState

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n  \n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddMarkupContent(10, "\n  ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-6 col-sm-4 links bg-secondary text-white p-5 border border-white rounded");
            __builder.AddMarkupContent(13, "\n    \n    <hr>\n     \n");
#nullable restore
#line 20 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
         if (isIntroductionRound)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "      ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "class", "btn btn-outline-secondary btn-block");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                                                                  Advance

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "disabled", 
#nullable restore
#line 22 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                                                                                       !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, 
#nullable restore
#line 22 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                                                                                                       labelAdvanceButton

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
#nullable restore
#line 23 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
    } else if(isGameOverCiviliansWin
      || isGameOverMafiaWins
    ||isLobbyTime)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "      ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", "btn btn-danger btn-lg");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                                                    Start

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "disabled", 
#nullable restore
#line 27 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                                                                       !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, "Start Game");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
#nullable restore
#line 28 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
    }
    else if (!isLobbyTime)
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
       if (!isIntroductionRound && isActivePlayer)
      {


#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "          ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "  \n        \n         \n            ");
            __builder.OpenElement(34, "p");
            __builder.AddContent(35, "You want to ");
            __builder.AddContent(36, 
#nullable restore
#line 37 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                            labelTargetAction

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n\n");
#nullable restore
#line 39 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
             foreach (var t in possibleTargets)
            { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "              ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group row");
            __builder.AddMarkupContent(41, "\n              ");
            __builder.OpenElement(42, "label");
            __builder.AddContent(43, 
#nullable restore
#line 42 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                      t

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "name", "targetName");
            __builder.AddAttribute(48, "type", "radio");
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 43 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                                                                        () => { @inputTargetedPerson = @t; }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n              ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n               ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n");
#nullable restore
#line 46 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "  \n        \n        ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "type", "button");
            __builder.AddAttribute(56, "class", "btn btn-outline-secondary btn-block");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                                                                    Advance

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "disabled", 
#nullable restore
#line 49 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                                                                                         !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, 
#nullable restore
#line 49 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                                                                                                         labelAdvanceButton

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n");
#nullable restore
#line 51 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"

      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
       
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(62, "   \n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n\n  ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col-6 col-sm-4 midden text-secondary p-5 border border-secondary rounded");
            __builder.AddMarkupContent(66, "\n    ");
            __builder.OpenElement(67, "ul");
            __builder.AddAttribute(68, "id", "messagesList");
            __builder.AddMarkupContent(69, "\n");
#nullable restore
#line 59 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
       foreach (var message in messages)
      {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "        ");
            __builder.OpenElement(71, "li");
            __builder.AddContent(72, 
#nullable restore
#line 61 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n");
#nullable restore
#line 62 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n\n  ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "col-6 col-sm-4 rechts bg-secondary text-white p-5 border border-white rounded");
            __builder.AddMarkupContent(79, "\n   \n");
#nullable restore
#line 68 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
       if (gameState == GameState.Lobby.ToString())
      {

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "        ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "form-group");
            __builder.AddMarkupContent(83, "\n          ");
            __builder.OpenElement(84, "label");
            __builder.AddMarkupContent(85, "\n            Naam:\n            ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "class", "form-control");
            __builder.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 73 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                               userInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInput = __value, userInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\n");
#nullable restore
#line 76 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
      }
      else
      {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "        ");
            __builder.OpenElement(94, "p");
            __builder.AddContent(95, 
#nullable restore
#line 80 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
            userInput

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n");
#nullable restore
#line 81 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(97, "\n      ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "form-group");
            __builder.AddMarkupContent(100, "\n        ");
            __builder.OpenElement(101, "label");
            __builder.AddMarkupContent(102, "\n          Bericht:\n          ");
            __builder.OpenElement(103, "input");
            __builder.AddAttribute(104, "class", "form-control");
            __builder.AddAttribute(105, "size", "50");
            __builder.AddAttribute(106, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                             messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\n      ");
            __builder.OpenElement(111, "button");
            __builder.AddAttribute(112, "type", "button");
            __builder.AddAttribute(113, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                                                         Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(115, "disabled", 
#nullable restore
#line 89 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                                                                                           !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(116, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\n    \n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\n");
            __builder.OpenElement(120, "div");
            __builder.AddMarkupContent(121, "\n");
#nullable restore
#line 94 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
   if (isNightMafiaTime)
  {

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "    ");
            __builder.OpenElement(123, "audio");
            __builder.AddAttribute(124, "autoplay", true);
            __builder.AddMarkupContent(125, "\n      ");
            __builder.OpenElement(126, "source");
            __builder.AddAttribute(127, "src", 
#nullable restore
#line 97 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                    srcSoundMafia

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(128, "type", "audio/wav");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\n      Your browser does not support the audio element.\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\n");
#nullable restore
#line 100 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
  }
  else if (isNightSherrifTime)
  {

#line default
#line hidden
#nullable disable
            __builder.AddContent(131, "    ");
            __builder.OpenElement(132, "audio");
            __builder.AddAttribute(133, "autoplay", true);
            __builder.AddMarkupContent(134, "\n      ");
            __builder.OpenElement(135, "source");
            __builder.AddAttribute(136, "src", 
#nullable restore
#line 104 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                    srcSoundSherrif

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(137, "type", "audio/wav");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\n      Your browser does not support the audio element.\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\n");
#nullable restore
#line 107 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
  }
  else if (isNightDoctorTime)
  {

#line default
#line hidden
#nullable disable
            __builder.AddContent(140, "    ");
            __builder.OpenElement(141, "audio");
            __builder.AddAttribute(142, "autoplay", true);
            __builder.AddMarkupContent(143, "\n      ");
            __builder.OpenElement(144, "source");
            __builder.AddAttribute(145, "src", 
#nullable restore
#line 111 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                    srcSoundDoctor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(146, "type", "audio/wav");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\n      Your browser does not support the audio element.\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\n");
#nullable restore
#line 114 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
  }
  else if (isDayTime)
  {

#line default
#line hidden
#nullable disable
            __builder.AddContent(149, "    ");
            __builder.OpenElement(150, "audio");
            __builder.AddAttribute(151, "autoplay", true);
            __builder.AddMarkupContent(152, "\n      ");
            __builder.OpenElement(153, "source");
            __builder.AddAttribute(154, "src", 
#nullable restore
#line 118 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
                    srcSoundEverybody

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(155, "type", "audio/wav");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\n      Your browser does not support the audio element.\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\n");
#nullable restore
#line 121 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\n<hr>\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
       
  private HubConnection hubConnection;
  private List<string> messages = new List<string>();
  private string userInput;
  private string messageInput;
  private string inputTargetedPerson = string.Empty;
  private string labelTargetAction = "StartFirstNight";
  private string labelAdvanceButton = "Go To Sleep";
  private List<string> possibleTargets = new List<string>();
  private string gameState = GameState.Lobby.ToString();
  private string labelGameState = string.Empty;
  private List<string> activePlayers = new List<string>();
  private bool isActivePlayer = false;
  private string labelCountdown = string.Empty;
  private string srcSoundMafia = "/sounds/MafiaWakeUp.wav";
  private string srcSoundDoctor = "/sounds/DoctorWakeUp.wav";
  private string srcSoundSherrif = "/sounds/SherrifWakeUp.wav";
  private string srcSoundEverybody = "/sounds/EverybodyWakeUp.wav";
  private bool isNightMafiaTime => gameState == GameState.NightMafia.ToString();
  private bool isDayTime => gameState == GameState.Day.ToString();
  private bool isNightDoctorTime => gameState == GameState.NightDoctor.ToString();
  private bool isNightSherrifTime => gameState == GameState.NightSherrif.ToString();
  private bool isLobbyTime => gameState == GameState.Lobby.ToString();
  private bool isGameOverCiviliansWin => gameState == GameState.GameOverCiviliansWin.ToString();
  private bool isGameOverMafiaWins => gameState == GameState.GameOverMafiaWins.ToString();
  private bool isIntroductionRound => gameState == GameState.IntroductionRound.ToString();

  protected override async Task OnInitializedAsync()
  {
    hubConnection = new HubConnectionBuilder()
      .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
    .Build();

    UpdateLabelGameState();

    hubConnection.On<string>(AsyncMethod.Msg_RECEIVE, (message) =>
    {
      messages.Insert(0, message);
      StateHasChanged();
    });

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 170 "/home/carebear/Projects/OrganizedCrimeApp/Client/Pages/Index.razor"
            


    hubConnection.On<string>(AsyncMethod.Log_CONSOLE, (message) =>
      {
      Log(message);
      // StateHasChanged();
    });

    hubConnection.On<string, List<string>, List<string>>(AsyncMethod.Game_LOAD, (newGameState,
      targetList, activePlayerList) =>
    {
      activePlayers = activePlayerList;
      var thisPlayerId = hubConnection.ConnectionId;

      isActivePlayer = activePlayers.Contains(thisPlayerId); // refactor?

      gameState = newGameState;

      UpdateLabelGameState();
      possibleTargets = targetList;

      if (isDayTime)
      {
        labelTargetAction = "kick out of town";
      }
      else
      if (isNightMafiaTime)
      {
        labelTargetAction = "kill: ";
      }
      else
      if (isNightDoctorTime)
      {
        labelTargetAction = "save: ";

      }
      else
      if (isNightSherrifTime)
      {
        labelTargetAction = "spy on: ";
      }
      else
      if (isIntroductionRound)
      {
        labelAdvanceButton = "The First Night...";
      }
      else
      {
        labelTargetAction = "No action available";
      }

      StateHasChanged();
    });

    await hubConnection.StartAsync();
  }

  Task Send() =>
    hubConnection.SendAsync(AsyncMethod.Msg_SEND, userInput, messageInput);

  Task Start() => hubConnection.InvokeAsync(AsyncMethod.Game_START);

  Task Advance() => hubConnection.InvokeAsync(AsyncMethod.Game_ADVANCE, inputTargetedPerson, labelTargetAction);

  public bool IsConnected =>
    hubConnection.State == HubConnectionState.Connected;

  public void Dispose()
  {
    _ = hubConnection.DisposeAsync();
  }

  public void UpdateLabelGameState()
  {
    if (isDayTime)
    {
      labelGameState = "Day Time - City Hall Meeting";
      labelAdvanceButton = "Confirm Vote & Close Eyes";
    }
    else if (isNightDoctorTime)
    {
      labelGameState = "Night Time - The Doctor is on call";
      labelAdvanceButton = "Rescue";
    }
    else if (isNightMafiaTime)
    {
      labelGameState = "Night Time - Crime Time";
      labelAdvanceButton = "Attack";
    }
    else if (isNightSherrifTime)
    {
      labelGameState = "Night Time - Sherrif is on duty";

      labelAdvanceButton = "Spy";

    }
    else if (isLobbyTime)
    {
      messages.Clear();
      labelGameState = "Click Start once everyone has joined";
    }
    else if (isIntroductionRound)
    {
      labelGameState = "Day Time - First City Hall Meeting";
    }
    else if (isGameOverCiviliansWin)
    {
      labelGameState = "Game OVER - The Civilians Win";


    }
    else if (isGameOverMafiaWins)
    {
      labelGameState = "GAME OVER - The Mafia Wins";

    }
    else
    {
      labelGameState = "unexpected GameState";
    }
  }

  public void Log(string message)
  {
    Console.WriteLine(message);
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
