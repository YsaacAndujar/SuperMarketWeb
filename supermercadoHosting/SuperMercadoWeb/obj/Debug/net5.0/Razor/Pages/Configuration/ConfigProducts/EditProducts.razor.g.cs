#pragma checksum "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "863e3fb5edced836d53f2bdd51d50ef2d3eed59f"
// <auto-generated/>
#pragma warning disable 1591
namespace SuperMercadoWeb.Pages.Configuration.ConfigProducts
{
    #line hidden
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using SuperMercadoWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using SuperMercadoWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using SuperMercadoWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using SuperMercadoWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using SuperMercadoWeb.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
           [Authorize(Roles = "Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Config/EditProducts/{id:int}")]
    public partial class EditProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Datos del Producto</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
                __builder2.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                          producto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                   Editar

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(8, "\r\n            ");
                    __builder3.OpenElement(9, "div");
                    __builder3.AddAttribute(10, "class", "form-horizontal");
                    __builder3.OpenElement(11, "div");
                    __builder3.AddAttribute(12, "class", "form-group");
                    __builder3.AddMarkupContent(13, "<label class=\"control-label col-md-2\">Nombre:</label>\r\n                    ");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "col-md-10");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                    __builder3.AddAttribute(17, "type", "text");
                    __builder3.AddAttribute(18, "class", "form-control");
                    __builder3.AddAttribute(19, "placeholder", "Ingrese el nombre del producto");
                    __builder3.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                                                 producto.Nombre

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => producto.Nombre = __value, producto.Nombre))));
                    __builder3.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => producto.Nombre));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n                        ");
                    __Blazor.SuperMercadoWeb.Pages.Configuration.ConfigProducts.EditProducts.TypeInference.CreateValidationMessage_0(__builder3, 24, 25, 
#nullable restore
#line 14 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                  () => producto.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(26, "\r\n\r\n                ");
                    __builder3.OpenElement(27, "div");
                    __builder3.AddAttribute(28, "class", "form-group");
                    __builder3.AddMarkupContent(29, "<label class=\"control-label col-md-2\">Precio:</label>\r\n                    ");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "class", "col-md-10");
                    __Blazor.SuperMercadoWeb.Pages.Configuration.ConfigProducts.EditProducts.TypeInference.CreateInputNumber_1(__builder3, 32, 33, "number", 34, "form-control", 35, "Ingrese el precio", 36, 
#nullable restore
#line 21 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                                                     producto.Precio

#line default
#line hidden
#nullable disable
                    , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => producto.Precio = __value, producto.Precio)), 38, () => producto.Precio);
                    __builder3.AddMarkupContent(39, "\r\n                        ");
                    __Blazor.SuperMercadoWeb.Pages.Configuration.ConfigProducts.EditProducts.TypeInference.CreateValidationMessage_2(__builder3, 40, 41, 
#nullable restore
#line 22 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                  () => producto.Precio

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n\r\n                ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "class", "form-group");
                    __builder3.AddMarkupContent(45, "<label class=\"control-label col-md-2\">Categoria:</label>\r\n                    ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "col-md-10");
                    __Blazor.SuperMercadoWeb.Pages.Configuration.ConfigProducts.EditProducts.TypeInference.CreateInputSelect_3(__builder3, 48, 49, "form-control", 50, 
#nullable restore
#line 29 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                  producto.CategoriaId

#line default
#line hidden
#nullable disable
                    , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => producto.CategoriaId = __value, producto.CategoriaId)), 52, () => producto.CategoriaId, 53, (__builder4) => {
                        __builder4.AddMarkupContent(54, "<option value=\"0\" selected disabled hidden>-- Selecciona una cateogria --</option>");
#nullable restore
#line 31 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                             foreach (var categoria in categorias)
                            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(55, "option");
                        __builder4.AddAttribute(56, "value", 
#nullable restore
#line 33 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                categoria.Id

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(57, 
#nullable restore
#line 33 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                               categoria.Nombre

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 34 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                            }

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.AddMarkupContent(58, "\r\n                        ");
                    __Blazor.SuperMercadoWeb.Pages.Configuration.ConfigProducts.EditProducts.TypeInference.CreateValidationMessage_4(__builder3, 59, 60, 
#nullable restore
#line 36 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                  () => producto.CategoriaId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n\r\n                ");
                    __builder3.OpenElement(62, "div");
                    __builder3.AddAttribute(63, "class", "form-group");
                    __builder3.AddMarkupContent(64, "<label class=\"control-label col-md-2\">Cantidad:</label>\r\n                    ");
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "class", "col-md-10");
                    __Blazor.SuperMercadoWeb.Pages.Configuration.ConfigProducts.EditProducts.TypeInference.CreateInputNumber_5(__builder3, 67, 68, "form-control", 69, 
#nullable restore
#line 43 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                                       producto.Cantidad

#line default
#line hidden
#nullable disable
                    , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => producto.Cantidad = __value, producto.Cantidad)), 71, () => producto.Cantidad);
                    __builder3.AddMarkupContent(72, "\r\n                        ");
                    __Blazor.SuperMercadoWeb.Pages.Configuration.ConfigProducts.EditProducts.TypeInference.CreateValidationMessage_6(__builder3, 73, 74, 
#nullable restore
#line 44 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                  () => producto.Cantidad

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\r\n\r\n                ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "form-group");
                    __builder3.OpenElement(78, "label");
                    __builder3.AddAttribute(79, "class", "control-label col-md-2");
                    __builder3.AddContent(80, "Marcar para editar Imagen: ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(81);
                    __builder3.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                                                                                 check

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => check = __value, check))));
                    __builder3.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => check));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\r\n                    ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-md-10");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(88);
                    __builder3.AddAttribute(89, "accept", "png, jpeg, jpg");
                    __builder3.AddAttribute(90, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                                     HandleFileSelected

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\r\n                        ");
                    __Blazor.SuperMercadoWeb.Pages.Configuration.ConfigProducts.EditProducts.TypeInference.CreateValidationMessage_7(__builder3, 92, 93, 
#nullable restore
#line 52 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                                  () => producto.Imagen

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 54 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                     if (imageUrl != null)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(94, "img");
                    __builder3.AddAttribute(95, "src", 
#nullable restore
#line 56 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                                   imageUrl

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(96, "width", "200");
                    __builder3.AddAttribute(97, "height", "200");
                    __builder3.CloseElement();
#nullable restore
#line 57 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\r\n\r\n                ");
                    __builder3.AddMarkupContent(99, @"<div class=""form-group""><div class=""col-md-offset-2 col-md-10""><button type=""submit"" class=""btn btn-success""><i class=""oi oi-plus""> Editar Producto</i></button>
                        <a class=""btn btn-primary"" href=""/Config/ListProduct"">Regresar a la lista</a></div></div>");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(100, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.AddMarkupContent(101, "<label>Solo los administradores pueden usar esta función</label>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigProducts\EditProducts.razor"
       
    [Parameter]
    public int id { get; set; }

    private Producto producto = new Producto();
    List<Categoria> categorias = new List<Categoria>();
    string imageUrl = null;
    bool check = false;
    async Task HandleFileSelected(InputFileChangeEventArgs e)
    {
        if (check == true)
        {
            var imagenFile = e.GetMultipleFiles().FirstOrDefault();
            string format = "image/jpg";
            if (imagenFile != null)
            {
                var resized = await imagenFile.RequestImageFileAsync(format, 100, 100);
                var buffer = new Byte[resized.Size];
                await resized.OpenReadStream().ReadAsync(buffer);
                producto.Imagen = buffer;
                imageUrl = $"data:image/jpg; base64,{Convert.ToBase64String(buffer)}";
            }
        }
    }
    protected override async Task OnInitializedAsync()
    {
        producto = await ProductsService.GetProduct(id);
        imageUrl = $"data:image/jpg; base64,{Convert.ToBase64String(producto.Imagen)}";
    }
    protected override void OnInitialized()
    {
        categorias = dataContext.Categorias.ToList();
    }
    protected async Task Editar()
    {
        await ProductsService.SaveProduct(producto);
        NavigationManager.NavigateTo("/Config/ListProducts");
    }

    private void EditFoto()
    {
        imageUrl = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductsService ProductsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataContext dataContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SuperMercadoContext DbLogin { get; set; }
    }
}
namespace __Blazor.SuperMercadoWeb.Pages.Configuration.ConfigProducts.EditProducts
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
