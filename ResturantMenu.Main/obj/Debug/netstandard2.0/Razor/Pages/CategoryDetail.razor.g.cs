#pragma checksum "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3391c68f740090a666005f1dab919fb3de8c8af6"
// <auto-generated/>
#pragma warning disable 1591
namespace ResturantMenu.Main.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 3 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 4 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using ResturantMenu.Main;

#line default
#line hidden
#line 8 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using ResturantMenu.Main.Shared;

#line default
#line hidden
#line 9 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\_Imports.razor"
using ResturantMenu.Main.Components;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/categorydetail/{CategoryId}")]
    public partial class CategoryDetail : CategoryDetailBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "category-edit");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "h1");
            __builder.AddAttribute(4, "class", "page-title");
            __builder.AddContent(5, "Details for ");
            __builder.AddContent(6, 
#line 6 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                        Category.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#line 7 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
     if (ShowError)
    {

#line default
#line hidden
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "validation-message");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "ul");
            __builder.AddMarkupContent(13, "\r\n");
#line 11 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                 foreach (var error in Errors)
                {

#line default
#line hidden
            __builder.AddContent(14, "                    ");
            __builder.OpenElement(15, "li");
            __builder.AddContent(16, 
#line 13 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                         error.FieldName

#line default
#line hidden
            );
            __builder.AddContent(17, " ");
            __builder.AddContent(18, 
#line 13 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                          error.Description

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#line 14 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                }

#line default
#line hidden
            __builder.AddContent(20, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#line 17 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
    }

#line default
#line hidden
            __builder.AddContent(23, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(24);
            __builder.AddAttribute(25, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 18 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                      Category

#line default
#line hidden
            ));
            __builder.AddAttribute(26, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 18 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                                 () => HandleValidSubmit()

#line default
#line hidden
            )));
            __builder.AddAttribute(27, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 18 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                                                                                () => HandleInvalidSubmit()

#line default
#line hidden
            )));
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(30);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.AddMarkupContent(35, "<label for=\"name\">Name: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "id", "name");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "placeholder", "Enter category name");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 23 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                                                   Category.Name

#line default
#line hidden
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Name = __value, Category.Name))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Category.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __Blazor.ResturantMenu.Main.Pages.CategoryDetail.TypeInference.CreateValidationMessage_0(__builder2, 44, 45, 
#line 24 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                      () => Category.Name

#line default
#line hidden
                );
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.AddMarkupContent(51, "<label for=\"name\">Description: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "id", "description");
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "placeholder", "Enter category description");
                __builder2.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 28 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                                                          Category.Description

#line default
#line hidden
                ));
                __builder2.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Description = __value, Category.Description))));
                __builder2.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Category.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.AddMarkupContent(64, "<label for=\"name\">Sequence: </label>\r\n            ");
                __Blazor.ResturantMenu.Main.Pages.CategoryDetail.TypeInference.CreateInputNumber_1(__builder2, 65, 66, "sequence", 67, "form-control", 68, 
#line 32 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                                                         Category.Sequence

#line default
#line hidden
                , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Sequence = __value, Category.Sequence)), 70, () => Category.Sequence);
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group");
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.AddMarkupContent(76, "<label for=\"image\">Image: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(77);
                __builder2.AddAttribute(78, "id", "image");
                __builder2.AddAttribute(79, "class", "form-control");
                __builder2.AddAttribute(80, "placeholder", "Enter category image");
                __builder2.AddAttribute(81, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 36 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                                                    Category.Image

#line default
#line hidden
                ));
                __builder2.AddAttribute(82, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Image = __value, Category.Image))));
                __builder2.AddAttribute(83, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Category.Image));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group");
                __builder2.AddMarkupContent(88, "\r\n            ");
                __builder2.AddMarkupContent(89, "<label for=\"isAvailable\">Is Available: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(90);
                __builder2.AddAttribute(91, "id", "isAvailable");
                __builder2.AddAttribute(92, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 40 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                                         Category.IsAvailable

#line default
#line hidden
                ));
                __builder2.AddAttribute(93, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.IsAvailable = __value, Category.IsAvailable))));
                __builder2.AddAttribute(94, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Category.IsAvailable));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(95, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n        ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "align-content-center");
                __builder2.AddMarkupContent(99, "\r\n            ");
                __builder2.AddMarkupContent(100, "<button type=\"submit\" class=\"btn btn-primary\">Save category</button>\r\n            ");
                __builder2.OpenElement(101, "a");
                __builder2.AddAttribute(102, "class", "btn btn-outline-primary edit-outline-btn");
                __builder2.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 44 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                                                           NavigateToMainMenu

#line default
#line hidden
                ));
                __builder2.AddContent(104, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(107, "\r\n\r\n    ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "alert" + " " + (
#line 48 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                       StatusClass

#line default
#line hidden
            ));
            __builder.AddContent(110, 
#line 48 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                     Message

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n    ");
            __builder.OpenElement(112, "a");
            __builder.AddAttribute(113, "class", "btn btn-outline-primary");
            __builder.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 49 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Pages\CategoryDetail.razor"
                                                  NavigateToMainMenu

#line default
#line hidden
            ));
            __builder.AddContent(115, "Back to overview");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ResturantMenu.Main.Pages.CategoryDetail
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
