#pragma checksum "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31450fc366457920258160909be61e0a62c47a04"
// <auto-generated/>
#pragma warning disable 1591
namespace SuperMercadoWeb.Pages.Configuration.ConfigPedidos
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
#line 2 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
           [Authorize(Roles = "Administrator, Standard")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Config/ListPedidos")]
    public partial class ListPedidos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lista de pedidos</h3>\r\n");
            __builder.AddMarkupContent(1, "<label>Filtrar por estado: </label>\r\n");
            __builder.OpenElement(2, "select");
            __builder.AddAttribute(3, "class", "form-control");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
               filtro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filtro = __value, filtro));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(6, "option");
            __builder.AddAttribute(7, "value", "0");
            __builder.AddAttribute(8, "selected", "selected");
            __builder.AddContent(9, "Todos");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", "1");
            __builder.AddContent(13, "Proceso");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", "2");
            __builder.AddContent(17, "Enviados");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", "3");
            __builder.AddContent(21, "Completados");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n<br>\r\n");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-primary");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                                          actualizar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Filtrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n<br>\r\n");
            __builder.AddMarkupContent(28, "<label>Buscar Id: </label>\r\n");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "number");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                            Id

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Id = __value, Id, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n<br>\r\n");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                                          buscar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Buscar");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n<br>\r\n<br>");
#nullable restore
#line 22 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
 if (cargando)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "<p><em>Cargando...</em></p>");
#nullable restore
#line 25 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-x1-6");
            __builder.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(44);
            __builder.AddAttribute(45, "Style", "height: 400px; width: 600px; ");
            __builder.AddAttribute(46, "zoom", 
#nullable restore
#line 30 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                                                                          zoom

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 30 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                                                                                          new GoogleMapPosition() {Lat = 0, Lng = 0}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "Markers", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 32 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                     foreach (var pedido in pedidos)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenGoogleMapMarker>(49);
                __builder2.AddAttribute(50, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                                                       pedido.Id.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                                                                                     pedido.Estado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 34 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                                                                                                                new GoogleMapPosition() {Lat = pedido.Latitud, Lng = pedido.Longitud}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 35 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    <br>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(54, "table");
            __builder.AddAttribute(55, "class", "table");
            __builder.AddMarkupContent(56, @"<thead class=""thead-dark""><tr style=""text-align:center;""><th scope=""col"">Id</th>
                <th scope=""col"">Usuairo</th>
                <th scope=""col"">Total</th>
                <th scope=""col"">Estado</th>
                <th scope=""col""></th></tr></thead>
        ");
            __builder.OpenElement(57, "tbody");
#nullable restore
#line 54 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
             foreach (var pedido in pedidos)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "tr");
            __builder.AddAttribute(59, "style", "text-align:center;");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 57 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                         pedido.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 58 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                         pedido.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 59 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                         pedido.PrecioTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#nullable restore
#line 60 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                         pedido.Estado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "td");
            __builder.OpenElement(73, "a");
            __builder.AddAttribute(74, "href", "/Config/EditPedidos/" + (
#nullable restore
#line 62 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                                                      pedido.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "class", "btn btn-primary btn-xs");
            __builder.AddAttribute(76, "title", "Editar");
            __builder.AddMarkupContent(77, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.OpenElement(79, "a");
            __builder.AddAttribute(80, "href", "/Config/DetailsPedidos/" + (
#nullable restore
#line 65 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
                                                         pedido.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "class", "btn btn-primary btn-xs");
            __builder.AddAttribute(82, "title", "Detalles");
            __builder.AddMarkupContent(83, "\r\n                            detalles\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Configuration\ConfigPedidos\ListPedidos.razor"
       
    string filtro = "0";
    double zoom = 3;
    List<Pedido> pedidos;
    bool cargando = true;
    int Id = 0;
    void actualizar()
    {
        cargando = true;
        switch (filtro)
        {
            case "1":
                pedidos = dataContext.Pedidos.Where(x => x.Estado.ToLower().Trim() == "proceso").ToList();
                break;
            case "2":
                pedidos = dataContext.Pedidos.Where(x => x.Estado.ToLower().Trim() == "enviado").ToList();
                break;
            case "3":
                pedidos = dataContext.Pedidos.Where(x => x.Estado.ToLower().Trim() == "completado").ToList();
                break;
            default:
                pedidos = dataContext.Pedidos.ToList();
                break;
        }
        cargando = false;
    }
    void buscar()
    {
        pedidos = dataContext.Pedidos.Where(x => x.Id == Id).ToList();
    }
    protected override void OnInitialized()
    {
        pedidos = dataContext.Pedidos.ToList();
        cargando = false;
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
#pragma warning restore 1591