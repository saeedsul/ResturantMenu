#pragma checksum "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\Tabs\Tab.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04a2c43df9abc32907854adb2baa2c864262d384"
// <auto-generated/>
#pragma warning disable 1591
namespace ResturantMenu.Main.Components.Tabs
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using ResturantMenu.Main;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using ResturantMenu.Main.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using ResturantMenu.Main.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using BlazorDataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\Tabs\Tab.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class Tab : TabBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .nav-tabs .active {
        border-top: 4px solid #00ff21 !important;
        padding-top: 5px;
        border-bottom: 1px solid transparent;
        background-color: white;
    }

    .nav-link {
        cursor: pointer;
        margin-right: 3px;
    }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\Tabs\Tab.razor"
                Activate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", (
#nullable restore
#line 17 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\Tabs\Tab.razor"
                                  ClassCss

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 17 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\Tabs\Tab.razor"
                                            Active

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 18 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\Tabs\Tab.razor"
     if (TabHeader == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 20 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\Tabs\Tab.razor"
         Title

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 20 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\Tabs\Tab.razor"
              
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, 
#nullable restore
#line 24 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\Tabs\Tab.razor"
         TabHeader

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 24 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\Tabs\Tab.razor"
                  
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
