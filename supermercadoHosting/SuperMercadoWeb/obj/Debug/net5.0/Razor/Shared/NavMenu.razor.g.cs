#pragma checksum "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2109dc7d308cf91cba7b447723941f2dbf796c15"
// <auto-generated/>
#pragma warning disable 1591
namespace SuperMercadoWeb.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light my-3");
            __builder.AddAttribute(2, "style", "background-color: #e3f2fd;");
            __builder.AddAttribute(3, "b-ssr5y23emw");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container px-4 px-lg-5");
            __builder.AddAttribute(6, "b-ssr5y23emw");
            __builder.AddMarkupContent(7, "<a class=\"navbar-brand\" href b-ssr5y23emw><svg width=\"56px\" height=\"39px\" viewBox=\"0 0 256 239\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" preserveAspectRatio=\"xMidYMid\" b-ssr5y23emw><g b-ssr5y23emw><path d=\"M224.021661,173.15874 L131.06335,173.15874 C108.582501,173.15874 95.9932253,188.895334 95.9932253,205.643566 C95.9932253,221.09915 106.671629,238.128393 131.06335,238.128393 L224.021661,238.128393 L224.021661,173.15874 Z\" fill=\"#669DF6\" b-ssr5y23emw></path>\r\n                    <ellipse fill=\"#1A73E8\" cx=\"224.021661\" cy=\"205.587364\" rx=\"31.9790077\" ry=\"32.4848268\" b-ssr5y23emw></ellipse>\r\n                    <path d=\"M128.028435,86.5512687 L35.0701245,86.5512687 C12.5892755,86.5512687 0,102.287863 0,119.036096 C0,134.491679 10.6784033,151.520922 35.0701245,151.520922 L128.028435,151.520922 L128.028435,86.5512687 Z\" fill=\"#669DF6\" b-ssr5y23emw></path>\r\n                    <ellipse fill=\"#1A73E8\" cx=\"128.028435\" cy=\"119.036096\" rx=\"31.9790077\" ry=\"32.4848268\" b-ssr5y23emw></ellipse>\r\n                    <path d=\"M224.021661,7.10542736e-15 L131.06335,7.10542736e-15 C108.582501,7.10542736e-15 95.9932253,15.7365943 95.9932253,32.4848268 C95.9932253,47.9404105 106.671629,64.9696537 131.06335,64.9696537 L224.021661,64.9696537 L224.021661,7.10542736e-15 Z\" fill=\"#669DF6\" b-ssr5y23emw></path>\r\n                    <ellipse fill=\"#1A73E8\" cx=\"224.021661\" cy=\"32.4848268\" rx=\"31.9790077\" ry=\"32.4848268\" b-ssr5y23emw></ellipse></g></svg>\r\n            Supermercado Web\r\n        </a>\r\n\r\n        ");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "navbar-nav mr-auto mb-2 mb-lg-0 ms-lg-4 align-items-baseline container");
            __builder.AddAttribute(10, "b-ssr5y23emw");
            __builder.AddMarkupContent(11, "<li class=\"nav-item\" b-ssr5y23emw><a class=\"nav-link active\" aria-current=\"page\" href=\"Products\" b-ssr5y23emw>Productos</a></li>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(12);
            __builder.AddAttribute(13, "Roles", "Administrator");
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "<li class=\"nav-item\" b-ssr5y23emw><a class=\"nav-link active\" aria-current=\"page\" href=\"Config\" b-ssr5y23emw>Configuracion</a></li>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(17);
            __builder.AddAttribute(18, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "<li class=\"nav-item\" b-ssr5y23emw><a class=\"nav-link active\" aria-current=\"page\" href=\"/MisPedidos\" b-ssr5y23emw>Mis pedidos</a></li>\r\n                    ");
                __builder2.AddMarkupContent(20, "<li class=\"nav-item\" b-ssr5y23emw><a class=\"nav-link active\" aria-current=\"page\" href=\"Identity/Account/Manage\" b-ssr5y23emw>Cuenta</a></li>\r\n                    ");
                __builder2.AddMarkupContent(21, "<li class=\"nav-item\" b-ssr5y23emw><a class=\"nav-link active\" aria-current=\"page\" href=\"Identity/Account/Logout\" b-ssr5y23emw>Cerrar sesión</a></li>");
            }
            ));
            __builder.AddAttribute(22, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(23, "<li class=\"nav-item\" b-ssr5y23emw><a class=\"nav-link active\" aria-current=\"page\" href=\"Identity/Account/Login\" b-ssr5y23emw>Iniciar sesión</a></li>\r\n                    ");
                __builder2.AddMarkupContent(24, "<li class=\"nav-item\" b-ssr5y23emw><a class=\"nav-link active\" aria-current=\"page\" href=\"Identity/Account/Register\" b-ssr5y23emw>Registrarse</a></li>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<form class=\"d-flex\" style=\"width: 30%\" b-ssr5y23emw><a class=\"btn btn-outline-primary\" type=\"submit\" href=\"/Cart\" b-ssr5y23emw><i class=\"bi-cart-fill me-1\" ht b-ssr5y23emw>Carrito</i></a></form>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductsService ProductsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataContext dataContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SuperMercadoContext DbLogin { get; set; }
    }
}
#pragma warning restore 1591