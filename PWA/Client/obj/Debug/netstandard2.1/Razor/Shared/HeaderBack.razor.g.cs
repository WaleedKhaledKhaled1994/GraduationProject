#pragma checksum "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Shared\HeaderBack.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61bd57ffb62d811d5a4eca78042884328c35e74e"
// <auto-generated/>
#pragma warning disable 1591
namespace PWA.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using PWA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Repositories.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using PWA.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using PWA.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    public partial class HeaderBack : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "header-area");
            __builder.AddAttribute(2, "id", "headerArea");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container h-100 d-flex align-items-center justify-content-between");
            __builder.AddMarkupContent(6, "\r\n        \r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "back-button");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "href", 
#nullable restore
#line 7 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Shared\HeaderBack.razor"
                                           link

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "<i class=\"lni-arrow-left\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        \r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "page-heading");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "h6");
            __builder.AddAttribute(17, "class", "mb-0");
            __builder.AddContent(18, 
#nullable restore
#line 10 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Shared\HeaderBack.razor"
                              Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        \r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "suha-navbar-toggler d-flex justify-content-between flex-wrap");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Shared\HeaderBack.razor"
                                                                                             NavbarToggler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "id", "suhaNavbarToggler");
            __builder.AddMarkupContent(25, "<span></span><span></span><span></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "sidenav-black-overlay");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Shared\HeaderBack.razor"
                                              SidenavBlackOverlay

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "suha-sidenav-wrapper");
            __builder.AddAttribute(35, "id", "sidenavWrapper");
            __builder.AddMarkupContent(36, "\r\n    \r\n    ");
            __builder.AddMarkupContent(37, @"<div class=""sidenav-profile"">
        <div class=""user-profile""><img src=""img/bg-img/9.jpg"" alt></div>
        <div class=""user-info"">
            <h6 class=""user-name mb-0"">Suha Jannat</h6>
            <p class=""available-balance"">Balance <span>$<span class=""counter"">379.23</span></span></p>
        </div>
    </div>
    
    ");
            __builder.AddMarkupContent(38, @"<ul class=""sidenav-nav"">
        <li><a href=""profile.html""><i class=""lni-user""></i>My Profile</a></li>
        <li><a href=""notifications.html""><i class=""lni-alarm lni-tada-effect""></i>Notifications<span class=""ml-3 badge badge-warning"">3</span></a></li>
        <li><a href=""pages.html""><i class=""lni-empty-file""></i>All Pages</a></li>
        <li><a href=""wishlist-grid.html""><i class=""lni-heart-filled""></i>My Wishlist</a></li>
        <li><a href=""settings.html""><i class=""lni-cog""></i>Settings</a></li>
        <li><a href=""intro.html""><i class=""lni-power-switch""></i>Sign Out</a></li>
    </ul>
    
    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "go-home-btn");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Shared\HeaderBack.razor"
                                       goHomeBtn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "id", "goHomeBtn");
            __builder.AddMarkupContent(43, "<i class=\"lni-arrow-left\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Shared\HeaderBack.razor"
      
    [Parameter] public string Title { get; set; }

    [Parameter] public string link { get; set; }

    protected async Task NavbarToggler()
    {
        await js.InvokeVoidAsync("NavbarToggler");
    }
    protected async Task goHomeBtn()
    {
        await js.InvokeVoidAsync("goHomeBtn");
    }
    protected async Task SidenavBlackOverlay()
    {
        await js.InvokeVoidAsync("SidenavBlackOverlay");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
