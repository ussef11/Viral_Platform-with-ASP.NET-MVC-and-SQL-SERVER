#pragma checksum "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\Employee\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "947e1f0072ae51019be442596a8714c2c5fa8f2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index1), @"mvc.1.0.view", @"/Views/Employee/Index1.cshtml")]
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
#nullable restore
#line 1 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\_ViewImports.cshtml"
using MyProjet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\_ViewImports.cshtml"
using MyProjet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"947e1f0072ae51019be442596a8714c2c5fa8f2d", @"/Views/Employee/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3769524b1f3f1408335fc6162de5f8bb9c9f00", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyProjet.Models.Account>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\Employee\Index1.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\Employee\Index1.cshtml"
 if (Model.Count() > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered table-striped"" style=""width:100%"">
        <thead>
            <tr>
                <th> LoginName </th>
                <th> Password </th>
                <th> Categorie </th>
            </tr>

        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\Employee\Index1.cshtml"
             foreach (var obj in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th> ");
#nullable restore
#line 23 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\Employee\Index1.cshtml"
                    Write(obj.LoginName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </th>\r\n                    <th> ");
#nullable restore
#line 24 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\Employee\Index1.cshtml"
                    Write(obj.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th> ");
#nullable restore
#line 25 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\Employee\Index1.cshtml"
                    Write(obj.Categorie);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </th>\r\n                </tr>\r\n");
#nullable restore
#line 27 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\Employee\Index1.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 31 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\Employee\Index1.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No Result To Show</p>\r\n");
#nullable restore
#line 36 "C:\Users\youssef\Desktop\MyProjet\MyProjet\Views\Employee\Index1.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyProjet.Models.Account>> Html { get; private set; }
    }
}
#pragma warning restore 1591
