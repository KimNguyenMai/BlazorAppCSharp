#pragma checksum "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/Pages/Login copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "532ad38de2e236e0020100fbf7296f2282cfc0e9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/Pages/Login copy.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login_copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/Pages/Login copy.razor"
       
    private string account;
    private string password;
    private int status { get; set; } = 0; //1 means login; 0 means not login
    
    private MemberData member; 

    async Task login() //Task is a built in class, to perform asynchronous operations
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorApp/Pages/Login copy.razor"
                                             
        MyLogin.setlogin(1); 
        status= MyLogin.getlogin();
        this.member = await db.querymember();
       
    }

    protected override async Task OnInitializedAsync()
    {
        db.connectDB();
        db.createTable();
        db.createNewMember();
        this.status = await MyLogin.GetLoginAsync();        
    }


    void logout(){
        MyLogin.setlogin(0);
        status= MyLogin.getlogin();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SqliteService db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginService MyLogin { get; set; }
    }
}
#pragma warning restore 1591
