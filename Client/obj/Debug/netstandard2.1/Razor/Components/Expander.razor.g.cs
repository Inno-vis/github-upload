#pragma checksum "/home/carebear/Projects/OrganizedCrimeApp/Client/Components/Expander.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b19760e1f269d9e1379c82eff91bb3ce73f6cd3"
// <auto-generated/>
#pragma warning disable 1591
namespace OrganizedCrimeApp.Client.Components
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
    public partial class Expander : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "/home/carebear/Projects/OrganizedCrimeApp/Client/Components/Expander.razor"
                Toggle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "card bg-light mb-3");
            __builder.AddAttribute(3, "style", "width:30rem");
            __builder.AddMarkupContent(4, "\n  ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "\n    ");
            __builder.OpenElement(8, "h2");
            __builder.AddAttribute(9, "class", "card-title");
            __builder.AddContent(10, "Toggle (");
            __builder.AddMarkupContent(11, "<code>Expanded</code> = ");
            __builder.AddContent(12, 
#nullable restore
#line 3 "/home/carebear/Projects/OrganizedCrimeApp/Client/Components/Expander.razor"
                                                            Expanded

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\n");
#nullable restore
#line 5 "/home/carebear/Projects/OrganizedCrimeApp/Client/Components/Expander.razor"
     if (Expanded)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "      ");
            __builder.OpenElement(16, "p");
            __builder.AddAttribute(17, "class", "card-text");
            __builder.AddContent(18, 
#nullable restore
#line 7 "/home/carebear/Projects/OrganizedCrimeApp/Client/Components/Expander.razor"
                            ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
#nullable restore
#line 8 "/home/carebear/Projects/OrganizedCrimeApp/Client/Components/Expander.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/home/carebear/Projects/OrganizedCrimeApp/Client/Components/Expander.razor"
       
  [Parameter]
  public bool Expanded { get; set; }

  [Parameter]
  public RenderFragment ChildContent { get; set; }

  private void Toggle()
  {
    Expanded = !Expanded;
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
