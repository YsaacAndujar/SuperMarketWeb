#pragma checksum "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "749b047dee9eeea039608c32ec5b002b5e45a166"
// <auto-generated/>
#pragma warning disable 1591
namespace SuperMercadoWeb.Pages
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
#line 2 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cart")]
    public partial class Cart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"text-center mb-3 border-bottom\"><h1 class=\"mb-3\"> Tu carrito de compras </h1>\r\n    <a class=\"btn btn-outline-primary mb-2\" role=\"button\" href=\"Pasarela\"><i class=\"bi bi-credit-card\"></i>\r\n        Comprar todo\r\n    </a></div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row row-cols-2 row-cols-md-3 justify-content-center");
#nullable restore
#line 16 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
     foreach (var carrito in carritos)
    {
        var producto = products.Where(x => x.Id == carrito.ProductoId).FirstOrDefault();

        if (producto != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-3 mb-3");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card h-100");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "class", "card-img-top");
            __builder.AddAttribute(9, "style", "width: 100%; max-height: 200px; min-height: 150px;");
            __builder.AddAttribute(10, "src", "data:image/jpg;base64," + (
#nullable restore
#line 26 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
                                                     Convert.ToBase64String(producto.Imagen)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "alt", "...");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    \r\n                    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "text-center");
            __builder.OpenElement(17, "h5");
            __builder.AddAttribute(18, "class", "fw-bolder");
            __builder.AddContent(19, 
#nullable restore
#line 30 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
                                                   producto.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                            <br>\r\n                            ");
            __builder.AddContent(21, 
#nullable restore
#line 32 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
                             producto.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, " DOP$\r\n                            <br>\r\n                            Cantidad restante: ");
            __builder.AddContent(23, 
#nullable restore
#line 34 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
                                                producto.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "\r\n                            <br>\r\n\r\n                            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-inline");
            __builder.OpenElement(27, "label");
            __builder.AddAttribute(28, "for");
            __builder.AddContent(29, "Cantidad: ");
            __builder.AddContent(30, 
#nullable restore
#line 38 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
                                                         carrito.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-outline-primary btn-sm m-1");
            __builder.AddAttribute(34, "href", "#");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
                                                    ()=>actualizar(carrito,1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n                                    +\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-outline-danger btn-sm m-1");
            __builder.AddAttribute(40, "href", "#");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
                                                    ()=>actualizar(carrito,0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\r\n                                    -\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    \r\n\r\n                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "card-footer border-top-0 bg-transparent");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "text-center");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn btn-outline-danger mt-auto");
            __builder.AddAttribute(50, "href", "#");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
                                                ()=> eliminar(carrito)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "\r\n                                Eliminar del carrito\r\n                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Cart.razor"
       
    List<Carrito> carritos = new List<Carrito>();
    List<Producto> products = new List<Producto>();
    async Task alerta(string mensaje)
    {
        await JsRuntime.InvokeVoidAsync("alert", mensaje);
    }

    void actualizar(Carrito carrito, int n)
    {
        if (n > 0)
        {
            carrito.Cantidad += 1;
        }
        else if (carrito.Cantidad > 1)
        {
            carrito.Cantidad -= 1;
        }

        dataContext.SaveChanges();
    }

    void eliminar(Carrito carrito)
    {
        var principal = HttpContextAccessor.HttpContext.User;
        var userId = principal.FindFirstValue(ClaimTypes.NameIdentifier);

        if (userId != null)
        {
            dataContext.Remove(carrito);
            dataContext.SaveChanges();
            carritos = dataContext.Carritos.Where(x => x.UserId == userId).ToList();
            products = dataContext.Productos.ToList();
        }
        else
        {
            alerta("Debe estar logeado para esto");
        }
    }

    protected override void OnInitialized()
    {
        var principal = HttpContextAccessor.HttpContext.User;
        var userId = principal.FindFirstValue(ClaimTypes.NameIdentifier);

        if (userId != null)
        {
            carritos = dataContext.Carritos.Where(x => x.UserId == userId).ToList();
            products = dataContext.Productos.ToList();
        }
        else
        {
            alerta("Debe estar logeado para agregar productos al carrito");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor HttpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductsService ProductsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataContext dataContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SuperMercadoContext DbLogin { get; set; }
    }
}
#pragma warning restore 1591
