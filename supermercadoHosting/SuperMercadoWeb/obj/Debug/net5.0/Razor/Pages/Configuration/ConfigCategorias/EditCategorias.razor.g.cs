#pragma checksum "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigCategorias\EditCategorias.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a582c25b02e54dc2adf6ac667241ebe5be32fc8a"
// <auto-generated/>
#pragma warning disable 1591
namespace SuperMercadoWeb.Pages.Configuration.ConfigCategorias
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
#line 3 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigCategorias\EditCategorias.razor"
           [Authorize(Roles = "Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Config/EditCategorias/{id:int}")]
    public partial class EditCategorias : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddCategorias</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigCategorias\EditCategorias.razor"
                  categoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigCategorias\EditCategorias.razor"
                                            Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-horizontal");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label class=\"control-label col-md-2\">Nombre:</label>\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "placeholder", "Ingrese el nombre de la categoría");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigCategorias\EditCategorias.razor"
                                                                         categoria.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => categoria.Nombre = __value, categoria.Nombre))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => categoria.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __Blazor.SuperMercadoWeb.Pages.Configuration.ConfigCategorias.EditCategorias.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 13 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigCategorias\EditCategorias.razor"
                                          () => categoria.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.AddMarkupContent(25, "<div class=\"form-group\"><div class=\"col-md-offset-2 col-md-10\"><button type=\"submit\" class=\"btn btn-success\"><i class=\"oi oi-plus\"> Editar categoria</i></button></div></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigCategorias\EditCategorias.razor"
       
    [Parameter]
    public int id { get; set; }
    Categoria categoria;
    async Task Save()
    {
        await dataContext.SaveChangesAsync();
        await JsRuntime.InvokeVoidAsync("alert", "Categoria editada correctamente");
    }
    protected override void OnInitialized()
    {
        categoria = dataContext.Categorias.Find(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductsService ProductsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataContext dataContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SuperMercadoContext DbLogin { get; set; }
    }
}
namespace __Blazor.SuperMercadoWeb.Pages.Configuration.ConfigCategorias.EditCategorias
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
    }
}
#pragma warning restore 1591
