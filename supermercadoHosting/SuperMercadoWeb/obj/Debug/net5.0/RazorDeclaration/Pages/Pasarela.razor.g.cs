// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Pasarela.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Pasarela")]
    public partial class Pasarela : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\supermercadoHosting\SuperMercadoWeb\Pages\Pasarela.razor"
      
    Pago pago = new Pago();
    string userId;
    double cantidadTotal;
    List<Carrito> carritos = new List<Carrito>();
    List<Producto> products = new List<Producto>();
    async Task Comprar()
    {
        if (userId != null) {
            actualizarPrecioTotal();
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "El precio total es: "+cantidadTotal+"\nDesea proseguir con el pago?");

            if (confirmed)
            {
                bool ok = true;
                foreach(Carrito carrito in carritos)
                {
                    var producto = products.Where(x => x.Id == carrito.ProductoId).FirstOrDefault();
                    if(producto != null)
                    {
                        if (carrito.Cantidad > producto.Cantidad)
                        {
                            await alerta($"Solo quedan {producto.Cantidad} del producto {producto.Nombre} y tú pides {carrito.Cantidad}");
                            ok = false;
                            break;
                        }
                    }
                }
                if (ok)
                {
                    Pedido pedido = new Pedido();
                    pedido.PrecioTotal = 0;
                    List<PedidosItem> pedidosItems = new List<PedidosItem>();
                    foreach (Carrito carrito in carritos)
                    {
                        Producto producto = products.Where(x => x.Id == carrito.ProductoId).FirstOrDefault();
                        if (producto != null)
                        {
                            pedido.PrecioTotal = pedido.PrecioTotal + (producto.Precio * carrito.Cantidad);
                            producto.Cantidad = producto.Cantidad - carrito.Cantidad;
                            pedidosItems.Add(new PedidosItem { ProductoId = producto.Id, Cantidad = carrito.Cantidad, PrecioUnidad = producto.Cantidad });
                        }

                        dataContext.Remove(carrito);
                    }
                    pedido.Telefono = pago.Telefono;
                    pedido.Latitud = pago.Latitud;
                    pedido.Longitud = pago.Longitud;
                    pedido.Direccion = pago.Direccion;
                    pedido.Estado = "Proceso";
                    pedido.UserId = userId;
                    pedido.Comentario = pago.comentario;
                    await dataContext.AddAsync(pedido);
                    await dataContext.SaveChangesAsync();
                    foreach (var pedidoItem in pedidosItems)
                    {
                        pedidoItem.IdPedido = pedido.Id;
                        dataContext.PedidosItems.Add(pedidoItem);
                    }
                    await dataContext.SaveChangesAsync();
                    NavigationManager.NavigateTo("/MisPedidos");

                }
            }
        }
    }
    void actualizarPrecioTotal()
    {
        double resultado = 0;
        foreach(Carrito carrito in carritos)
        {
            var producto = products.Where(x => x.Id == carrito.ProductoId).FirstOrDefault();
            if (producto != null)
            {
                resultado += carrito.Cantidad * producto.Precio;
            }

        }
        cantidadTotal = resultado;
    }
    protected override void OnInitialized()
    {
        var principal = HttpContextAccessor.HttpContext.User;
        userId = principal.FindFirstValue(ClaimTypes.NameIdentifier);

        if (userId != null)
        {
            carritos = dataContext.Carritos.Where(x => x.UserId == userId).ToList();
            products = dataContext.Productos.ToList();
            actualizarPrecioTotal();
        }
        else
        {
            alerta("Debe estar logeado para esto");
        }
    }
    async Task alerta(string mensaje)
    {
        await JsRuntime.InvokeVoidAsync("alert", mensaje);
    }
    class Pago
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string NombreTarjeta { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}",
     ErrorMessage = "Las tarjetas son xxxx-xxxx-xxxx-xxxx")]
        public string NumeroTarjeta { get; set; }

        [Required(ErrorMessage = "El mes es obligatorio")]
        [Range(1,12, ErrorMessage = "El mes debe de ser entre 1 y 12")]
        public int mesExpiracion { get; set; }

        [Required(ErrorMessage = "El año es obligatorio")]
        [Range(21, 99, ErrorMessage = "El año debe de ser entre 20 y 99")]
        public int anioExpiracion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"[0-9]{3}",
     ErrorMessage = "El cvv son 3 digitos")]
        public int Cvv { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"[0-9]{10}",
     ErrorMessage = "El telefono debe ser xxxxxxxxxx")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public double Latitud { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public double Longitud { get; set; }

        public string comentario { get; set; }
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
