#pragma checksum "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dd46d3b6aa39b4b1f1e31e092d91a7c8ae19e3d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<BlazorApp.Pages.Counter>(1);
            __builder.AddAttribute(2, "IncrementAmount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Index.razor"
                          10

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
