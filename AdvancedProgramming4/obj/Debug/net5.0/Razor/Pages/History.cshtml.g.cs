#pragma checksum "C:\Users\walko\OneDrive\Pulpit\studnia\programowanie zaawansownae\AdvancedProgramming4\AdvancedProgramming4\Pages\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fda804de3b55bf21b1417139a08f418cd07a22a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AdvancedProgramming4.Pages.Pages_History), @"mvc.1.0.razor-page", @"/Pages/History.cshtml")]
namespace AdvancedProgramming4.Pages
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
#line 1 "C:\Users\walko\OneDrive\Pulpit\studnia\programowanie zaawansownae\AdvancedProgramming4\AdvancedProgramming4\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\walko\OneDrive\Pulpit\studnia\programowanie zaawansownae\AdvancedProgramming4\AdvancedProgramming4\Pages\_ViewImports.cshtml"
using AdvancedProgramming4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\walko\OneDrive\Pulpit\studnia\programowanie zaawansownae\AdvancedProgramming4\AdvancedProgramming4\Pages\_ViewImports.cshtml"
using AdvancedProgramming4.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fda804de3b55bf21b1417139a08f418cd07a22a2", @"/Pages/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7e3cba7a504af0444c87ae541a7df5b42b978e2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_History : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\walko\OneDrive\Pulpit\studnia\programowanie zaawansownae\AdvancedProgramming4\AdvancedProgramming4\Pages\History.cshtml"
  
    ViewData["Title"] = "History";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Historia moich wiadomo??ci</h1>\r\n\r\n<table border=\"1\" cellpadding=\"5\" width=\"100%\">\r\n    <thead>\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Wiadomo????</th>\r\n        <th>Data</th>\r\n    </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\walko\OneDrive\Pulpit\studnia\programowanie zaawansownae\AdvancedProgramming4\AdvancedProgramming4\Pages\History.cshtml"
     foreach (var user in Model.MessagesHistory)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\walko\OneDrive\Pulpit\studnia\programowanie zaawansownae\AdvancedProgramming4\AdvancedProgramming4\Pages\History.cshtml"
           Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\walko\OneDrive\Pulpit\studnia\programowanie zaawansownae\AdvancedProgramming4\AdvancedProgramming4\Pages\History.cshtml"
           Write(user.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\walko\OneDrive\Pulpit\studnia\programowanie zaawansownae\AdvancedProgramming4\AdvancedProgramming4\Pages\History.cshtml"
           Write(user.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\walko\OneDrive\Pulpit\studnia\programowanie zaawansownae\AdvancedProgramming4\AdvancedProgramming4\Pages\History.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvancedProgramming4.Pages.History> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdvancedProgramming4.Pages.History> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdvancedProgramming4.Pages.History>)PageContext?.ViewData;
        public AdvancedProgramming4.Pages.History Model => ViewData.Model;
    }
}
#pragma warning restore 1591
