#pragma checksum "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0ff382691b8b0d6750640c297c9f712daf7ede1"
// <auto-generated/>
#pragma warning disable 1591
namespace WarehouseManger.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.RoleClaims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Preferences;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Catalog.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Catalog.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Communication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Audit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Misc.Document;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Misc.DocumentType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Shared.Constants.Permission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Shared.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Application.Requests.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<WarehouseManger.Client.Shared.Error>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(5);
                    __builder3.AddAttribute(6, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 4 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.OpenComponent<WarehouseManger.Client.Pages.Authentication.Login>(9);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(10, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(13);
                        __builder4.AddAttribute(14, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 12 "C:\Users\zynls\Masaüstü\Kurs\WarehouseManger\src\Client\App.razor"
                                     typeof(NotFoundLayout)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(16, "<p>Sorry, there\'s nothing at this address.</p>");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserManager _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientPreferenceManager _clientPreferenceManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpInterceptorManager _interceptor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService _dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorizationService _authorizationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorHeroStateProvider _stateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountManager _accountManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationManager _authenticationManager { get; set; }
    }
}
#pragma warning restore 1591