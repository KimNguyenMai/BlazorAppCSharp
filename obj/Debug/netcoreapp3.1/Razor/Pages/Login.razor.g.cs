#pragma checksum "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "285f577ce7b1ddb6d98f1bde980b68c918810188"
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
#nullable restore
#line 2 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 6 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
     status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\n\n");
#nullable restore
#line 8 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
 if (@status==1)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Welcome ");
            __builder.AddContent(6, 
#nullable restore
#line 10 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
                member.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    ");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, " ");
            __builder.AddContent(10, 
#nullable restore
#line 11 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
         member.Password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
                      logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Logout ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 13 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
}
else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.AddMarkupContent(17, "<p>Welcome, please login</p>\n    ");
            __builder.AddMarkupContent(18, "<label for=\"fname\">Account:</label>\n    ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "id", "account");
            __builder.AddAttribute(22, "name", "account");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
                               account

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => account = __value, account));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "<br><br>\n    ");
            __builder.AddMarkupContent(26, "<label for=\"lname\">Password:</label>\n    ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "text");
            __builder.AddAttribute(29, "id", "password");
            __builder.AddAttribute(30, "name", "password");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
                               password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "<br><br>\n    ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
                                              login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n");
#nullable restore
#line 21 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
       
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
#line 34 "/Users/kimnguyen/Desktop/Fall Course Dev/CS504/HOP Dev/BlazorAppCSharp/Pages/Login.razor"
                                             
        MyLogin.setlogin(1); 
        status= MyLogin.getlogin();
        this.member = await db.querymember();
       
    }

    protected override async Task OnInitializedAsync()
    {
        db.connectDB();
        db.createTable();
        db.createNewMember("Kim", "cityu");
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
