#pragma checksum "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcc0bc7e67b1c3afbb437ab789107b42dee86f9b"
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
#nullable restore
#line 2 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/SignUp.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/signup")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/SignUp.razor"
       
    private string account { get; set; }
    private string password { get; set; }

    string exist{ get; set; }
    string warning{ get; set; }

    async Task signup()
    {
        bool memberInDB = await db.CheckUsernameInDB(account);
        if(memberInDB == true){ //check if username already exists
            exist = "Username already exist";
        }
        else{
            //check password's strength  
            if(this.password!= null && this.password.Length >= 6 ){
                db.createNewMember(account, password); //write to database
                NavigationManager.NavigateTo("/login"); //redirect to login page
            }
            else{
                warning = "Password must be at least 6 characters";
            }
            
        }
        
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SqliteService db { get; set; }
    }
}
#pragma warning restore 1591