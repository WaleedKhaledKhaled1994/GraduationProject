#pragma checksum "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f9af08a91f265e8bafd3f4b84d9043b64bde464"
// <auto-generated/>
#pragma warning disable 1591
namespace PWA.Client.Pages.Products
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class IndexProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<PWA.Client.Shared.Header>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 9 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor"
     if (products == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.AddMarkupContent(6, "<h1>Loading</h1>\r\n");
#nullable restore
#line 12 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __Blazor.PWA.Client.Pages.Products.IndexProduct.TypeInference.CreateTelerikListView_0(__builder, 8, 9, 
#nullable restore
#line 15 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor"
                               products

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line 15 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor"
                                                  true

#line default
#line hidden
#nullable disable
            , 11, 
#nullable restore
#line 15 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor"
                                                                  5

#line default
#line hidden
#nullable disable
            , 12, (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "a");
                __builder2.AddAttribute(15, "href", "/product/create");
                __builder2.AddAttribute(16, "style", "margin-left:20px;");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikButton>(17);
                __builder2.AddAttribute(18, "Icon", "add");
                __builder2.AddAttribute(19, "Class", "btn-primary");
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(21, "Add");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.AddMarkupContent(23, "<h3 style=\"text-align:center; color:black\">\r\n                    Products\r\n                </h3>\r\n            ");
            }
            , 24, (context) => (__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "k-card k-card-horizontal");
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "k-vbox k-column");
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "k-card-body");
                __builder2.AddMarkupContent(34, "\r\n                            ");
                __builder2.OpenElement(35, "h4");
                __builder2.AddAttribute(36, "class", "k-card-title");
                __builder2.AddAttribute(37, "style", "color:black");
                __builder2.AddContent(38, 
#nullable restore
#line 27 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor"
                                                                          context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.OpenElement(40, "h5");
                __builder2.AddAttribute(41, "class", "k-card-subtitle");
                __builder2.AddAttribute(42, "style", "color:grey");
                __builder2.AddContent(43, 
#nullable restore
#line 28 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor"
                                                                            context.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "k-card-actions k-card-actions-horizontal k-card-actions-start");
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.OpenElement(49, "a");
                __builder2.AddAttribute(50, "href", "/product/Edit/" + (
#nullable restore
#line 31 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor"
                                                    context.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikButton>(51);
                __builder2.AddAttribute(52, "Icon", "edit");
                __builder2.AddAttribute(53, "Class", "btn-dark");
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(55, "Edit");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                            &nbsp;&nbsp;\r\n                            ");
                __builder2.OpenComponent<PWA.Client.Shared.ConfirmButton>(57);
                __builder2.AddAttribute(58, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 33 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor"
                                                      () => DeleteRow(@context.Id)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(59, "ConfirmText", "Are you sure you want to delete this Product?");
                __builder2.AddAttribute(60, "ButtonText", "Delete");
                __builder2.AddAttribute(61, "ConfirmTitle", "Delete Product!");
                __builder2.AddAttribute(62, "Icon", "delete");
                __builder2.AddAttribute(63, "ButtonType", "btn-danger");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.OpenElement(67, "img");
                __builder2.AddAttribute(68, "class", "k-card-image img-thumbnail");
                __builder2.AddAttribute(69, "alt", "SubCategory Image");
                __builder2.AddAttribute(70, "src", 
#nullable restore
#line 36 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor"
                                                                                          context.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n            ");
            }
            );
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 40 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(74, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
            __builder.OpenComponent<PWA.Client.Shared.Footer>(76);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\ENG\Desktop\MyProj\PWA\PWA\Client\Pages\Products\IndexProduct.razor"
      
    private List<Product> products;
    


    protected async override Task OnInitializedAsync()
    {
        products = await productRepository.GetProducts();
    }


    private async Task DeleteRow(long id)
    {
        await productRepository.DeleteProduct(id);
        products = await productRepository.GetProducts();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProduct productRepository { get; set; }
    }
}
namespace __Blazor.PWA.Client.Pages.Products.IndexProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikListView_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Int32 __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg4)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikListView<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Pageable", __arg1);
        __builder.AddAttribute(__seq2, "PageSize", __arg2);
        __builder.AddAttribute(__seq3, "HeaderTemplate", __arg3);
        __builder.AddAttribute(__seq4, "Template", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
