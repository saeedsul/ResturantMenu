#pragma checksum "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1cfef76137dd380c470ffac56d3343a8a8e8dd3"
// <auto-generated/>
#pragma warning disable 1591
namespace ResturantMenu.Main.Components
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
#line 2 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
using ResturantMenu.Shared;

#line default
#line hidden
    public partial class AddCategoryDialog : AddCategoryDialogBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 5 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
 if (ShowDialog)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show d-block");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddAttribute(9, "role", "document");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-content");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<h5 class=\"modal-title\" id=\"titleLabel\">Employee Quick Add</h5>\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "close");
            __builder.AddAttribute(21, "data-dismiss", "modal");
            __builder.AddAttribute(22, "aria-label", "Close");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 12 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
                                                                                                          Close

#line default
#line hidden
            ));
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "modal-body");
            __builder.AddMarkupContent(30, "\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(31);
            __builder.AddAttribute(32, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 18 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
                                      Category

#line default
#line hidden
            ));
            __builder.AddAttribute(33, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 18 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
                                                                HandleValidSubmit

#line default
#line hidden
            )));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(36);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                        \r\n                        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __builder2.AddMarkupContent(41, "<label for=\"name\">Name: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "id", "name");
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "placeholder", "Enter category name");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 24 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
                                                                                   Category.Name

#line default
#line hidden
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Name = __value, Category.Name))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Category.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n                            ");
                __Blazor.ResturantMenu.Main.Components.AddCategoryDialog.TypeInference.CreateValidationMessage_0(__builder2, 50, 51, 
#line 25 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
                                                      () => Category.Name

#line default
#line hidden
                );
                __builder2.AddMarkupContent(52, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddMarkupContent(56, "\r\n                            ");
                __builder2.AddMarkupContent(57, "<label for=\"name\">Description: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "id", "description");
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "placeholder", "Enter category description");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 29 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
                                                                                          Category.Description

#line default
#line hidden
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Description = __value, Category.Description))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Category.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.AddMarkupContent(69, "\r\n                            ");
                __builder2.AddMarkupContent(70, "<label for=\"name\">Sequence: </label>\r\n                            ");
                __Blazor.ResturantMenu.Main.Components.AddCategoryDialog.TypeInference.CreateInputNumber_1(__builder2, 71, 72, "sequence", 73, "form-control", 74, 
#line 33 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
                                                                                         Category.Sequence

#line default
#line hidden
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Sequence = __value, Category.Sequence)), 76, () => Category.Sequence);
                __builder2.AddMarkupContent(77, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group");
                __builder2.AddMarkupContent(81, "\r\n                            ");
                __builder2.AddMarkupContent(82, "<label for=\"image\">Image: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(83);
                __builder2.AddAttribute(84, "id", "image");
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "placeholder", "Enter category image");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 37 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
                                                                                    Category.Image

#line default
#line hidden
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Image = __value, Category.Image))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Category.Image));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                        ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group");
                __builder2.AddMarkupContent(94, "\r\n                            ");
                __builder2.AddMarkupContent(95, "<label for=\"isAvailable\">Is Available: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(96);
                __builder2.AddAttribute(97, "id", "isAvailable");
                __builder2.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 41 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
                                                                         Category.IsAvailable

#line default
#line hidden
                ));
                __builder2.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.IsAvailable = __value, Category.IsAvailable))));
                __builder2.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Category.IsAvailable));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                        ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "align-content-center");
                __builder2.AddMarkupContent(105, "\r\n                            ");
                __builder2.AddMarkupContent(106, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n                            ");
                __builder2.OpenElement(107, "a");
                __builder2.AddAttribute(108, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 45 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
                                                                          Close

#line default
#line hidden
                ));
                __builder2.AddContent(110, "Close");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(113, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
#line 53 "F:\Saeed-Code\ResturantMenu\ResturantMenu.Main\Components\AddCategoryDialog.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ResturantMenu.Main.Components.AddCategoryDialog
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
