// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
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
