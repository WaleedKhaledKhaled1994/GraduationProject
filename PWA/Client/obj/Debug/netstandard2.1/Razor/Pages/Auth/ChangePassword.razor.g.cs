#pragma checksum "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\ChangePassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "460437d93684a21f3a239718bdcc079f939af9db"
// <auto-generated/>
#pragma warning disable 1591
namespace PWA.Client.Pages.Auth
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/changePassword")]
    public partial class ChangePassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<PWA.Client.Shared.Header>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.AddMarkupContent(2, "<div class=\"page-content-wrapper\">\r\n    <div class=\"container\">\r\n        \r\n        <div class=\"profile-wrapper-area py-3\">\r\n            \r\n            <div class=\"card user-info-card\">\r\n                <div class=\"card-body p-4 d-flex align-items-center\">\r\n                    <div class=\"user-profile mr-3\"><img src=\"img/bg-img/9.jpg\" alt></div>\r\n                    <div class=\"user-info\">\r\n                        <p class=\"mb-0 text-white\">designing-world</p>\r\n                        <h5 class=\"mb-0\">Suha Jannat</h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            \r\n            <div class=\"card user-data-card\">\r\n                <div class=\"card-body\">\r\n                    <form action=\"#\" method=\"POST\">\r\n                        <div class=\"form-group\">\r\n                            <div class=\"title mb-2\"><i class=\"lni-key\"></i><span>Old Password</span></div>\r\n                            <input class=\"form-control\" type=\"password\">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <div class=\"title mb-2\"><i class=\"lni-key\"></i><span>New Password</span></div>\r\n                            <input class=\"form-control\" type=\"password\">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <div class=\"title mb-2\"><i class=\"lni-key\"></i><span>Repeat New Password</span></div>\r\n                            <input class=\"form-control\" type=\"password\">\r\n                        </div>\r\n                        <button class=\"btn btn-success w-100\" type=\"submit\">Update Password</button>\r\n                    </form>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __builder.OpenComponent<PWA.Client.Shared.Footer>(3);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
