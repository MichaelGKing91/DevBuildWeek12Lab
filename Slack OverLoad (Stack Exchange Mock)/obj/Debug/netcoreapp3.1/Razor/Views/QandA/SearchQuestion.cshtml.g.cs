#pragma checksum "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\SearchQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf413e1f30611b43f3787b52005bcc5b141646a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_SearchQuestion), @"mvc.1.0.view", @"/Views/QandA/SearchQuestion.cshtml")]
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
#line 1 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\_ViewImports.cshtml"
using Slack_OverLoad__Stack_Exchange_Mock_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\_ViewImports.cshtml"
using Slack_OverLoad__Stack_Exchange_Mock_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf413e1f30611b43f3787b52005bcc5b141646a9", @"/Views/QandA/SearchQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7b7bd5b064afa45257eb3b31fb61903d4618b9", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_SearchQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Questions>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\SearchQuestion.cshtml"
  
    ViewData["Title"] = "SearchQuestion";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Question Details</h3>\r\n<table>\r\n    <tr>\r\n        <th>Username</th>\r\n        <th>Title</th>\r\n        <th>Details</th>\r\n        <th>Date Posted</th>\r\n        <th>Category</th>\r\n        <th>Status</th>\r\n    </tr>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\SearchQuestion.cshtml"
         foreach (Questions cur in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\SearchQuestion.cshtml"
               Write(cur.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\SearchQuestion.cshtml"
               Write(cur.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\SearchQuestion.cshtml"
               Write(cur.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\SearchQuestion.cshtml"
               Write(cur.posted.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\SearchQuestion.cshtml"
               Write(cur.category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\SearchQuestion.cshtml"
               Write(cur.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a href=\"/qanda/\" class=\"btn btn-success\">Go Back!</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\SearchQuestion.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>\r\n<br />\r\n<br />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Questions>> Html { get; private set; }
    }
}
#pragma warning restore 1591
