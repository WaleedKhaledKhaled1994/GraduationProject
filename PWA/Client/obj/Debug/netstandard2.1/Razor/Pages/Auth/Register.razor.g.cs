#pragma checksum "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bcf5aa50ef7290d0c656ac320faf9b99a8911cf"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "login-wrapper d-flex align-items-center justify-content-center text-center");
            __builder.AddMarkupContent(2, "\r\n    \r\n    <div class=\"background-shape\"></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n        <img class=\"big-logo\" src=\"img/core-img/logo-white.png\" alt>\r\n        \r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "register-form mt-5 px-4");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
                             userRegister

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
                                                          CreateUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group text-left mb-4");
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.AddMarkupContent(19, "<span>Email</span>\r\n                    ");
                __builder2.AddMarkupContent(20, "<label><i class=\"lni-envelope\"></i></label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "id", "email");
                __builder2.AddAttribute(24, "type", "email");
                __builder2.AddAttribute(25, "placeholder", "user@company.com");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
                                                                                                                         userRegister.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userRegister.Email = __value, userRegister.Email))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userRegister.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                    ");
                __Blazor.PWA.Client.Pages.Auth.Register.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 21 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
                                              () => userRegister.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group text-left mb-4");
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.AddMarkupContent(37, "<span>Phone</span>\r\n                    ");
                __builder2.AddMarkupContent(38, "<label><i class=\"lni-user\"></i></label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "id", "phoneNumber");
                __builder2.AddAttribute(42, "type", "text");
                __builder2.AddAttribute(43, "placeholder", "0941425818");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
                                                                                                                        userRegister.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userRegister.PhoneNumber = __value, userRegister.PhoneNumber))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userRegister.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __Blazor.PWA.Client.Pages.Auth.Register.TypeInference.CreateValidationMessage_1(__builder2, 48, 49, 
#nullable restore
#line 27 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
                                              () => userRegister.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group text-left mb-4");
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.AddMarkupContent(55, "<span>Password</span>\r\n                    ");
                __builder2.AddMarkupContent(56, "<label><i class=\"lni-lock\"></i></label>\r\n                    ");
                __builder2.OpenComponent<PWA.Client.Shared.InputPassword>(57);
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "id", "registerPassword");
                __builder2.AddAttribute(60, "type", "password");
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
                                                                                                            userRegister.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userRegister.Password = __value, userRegister.Password))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userRegister.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n                    ");
                __Blazor.PWA.Client.Pages.Auth.Register.TypeInference.CreateValidationMessage_2(__builder2, 65, 66, 
#nullable restore
#line 33 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
                                              () => userRegister.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group text-left mb-4");
                __builder2.AddMarkupContent(71, "\r\n                    ");
                __builder2.AddMarkupContent(72, "<span>Confirm Password</span>\r\n                    ");
                __builder2.AddMarkupContent(73, "<label><i class=\"lni-lock\"></i></label>\r\n                    ");
                __builder2.OpenComponent<PWA.Client.Shared.InputPassword>(74);
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "id", "registerConfirmPassword");
                __builder2.AddAttribute(77, "type", "password");
                __builder2.AddAttribute(78, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
                                                                                                                   userRegister.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userRegister.ConfirmPassword = __value, userRegister.ConfirmPassword))));
                __builder2.AddAttribute(80, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userRegister.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n                    ");
                __Blazor.PWA.Client.Pages.Auth.Register.TypeInference.CreateValidationMessage_3(__builder2, 82, 83, 
#nullable restore
#line 39 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
                                              () => userRegister.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(84, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n\r\n                ");
                __builder2.AddMarkupContent(86, "<button class=\"btn btn-success btn-lg w-100\">Register Now</button>\r\n\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 45 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
             if (!string.IsNullOrEmpty(error))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "                ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "alert alert-danger mt-3 mb-0");
            __builder.AddContent(91, 
#nullable restore
#line 47 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
                                                           error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 48 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n        \r\n        ");
            __builder.AddMarkupContent(95, "<div class=\"login-meta-data\">\r\n            <p class=\"text-white mt-3 mb-0\">Already have an account?<a class=\"ml-2\" href=\"login\">Login</a></p>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Auth\Register.razor"
      
    private UserRegister userRegister = new UserRegister();
    private string error;

    private async Task CreateUser()
    {
        try
        {
            var userToken = await accountsRepository.Register(userRegister);
            await loginService.Login(userToken);
            navigationManager.NavigateTo("");
        }
        catch (Exception ex)
        {
            error = ex.Message;
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccounts accountsRepository { get; set; }
    }
}
namespace __Blazor.PWA.Client.Pages.Auth.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
