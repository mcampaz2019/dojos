#pragma checksum "C:\DotNetDev\Projects\PracticeDojo\dojos\ViewModelFun\Views\Home\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a17ef8635b7022b16fd05b6cd0cfe12d756ca061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Users.cshtml", typeof(AspNetCore.Views_Home_Users))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\DotNetDev\Projects\PracticeDojo\dojos\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 5 "C:\DotNetDev\Projects\PracticeDojo\dojos\ViewModelFun\Views\Home\Users.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a17ef8635b7022b16fd05b6cd0cfe12d756ca061", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\DotNetDev\Projects\PracticeDojo\dojos\ViewModelFun\Views\Home\Users.cshtml"
  
    ViewData["Title"] = "User";
    

#line default
#line hidden
            BeginContext(95, 98, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    \r\n        <h1>Here is a User!</h1>\r\n    <div class=\"jumbotron\">\r\n");
            EndContext();
#line 12 "C:\DotNetDev\Projects\PracticeDojo\dojos\ViewModelFun\Views\Home\Users.cshtml"
         foreach(User name in Model)
        {

#line default
#line hidden
            BeginContext(242, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(258, 14, false);
#line 14 "C:\DotNetDev\Projects\PracticeDojo\dojos\ViewModelFun\Views\Home\Users.cshtml"
          Write(name.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(272, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(274, 13, false);
#line 14 "C:\DotNetDev\Projects\PracticeDojo\dojos\ViewModelFun\Views\Home\Users.cshtml"
                          Write(name.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(287, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 15 "C:\DotNetDev\Projects\PracticeDojo\dojos\ViewModelFun\Views\Home\Users.cshtml"
        }

#line default
#line hidden
            BeginContext(304, 21, true);
            WriteLiteral("    </div>   \r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
