#pragma checksum "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbb3151258f3a2b72231c42ab45faaf822a329cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_Index), @"mvc.1.0.view", @"/Views/QandA/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb3151258f3a2b72231c42ab45faaf822a329cd", @"/Views/QandA/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7b7bd5b064afa45257eb3b31fb61903d4618b9", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Questions>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/qanda/SearchQuestion/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Welcome ");
#nullable restore
#line 6 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
       Write(DAL.currentuser);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h2>\r\n<br/>\r\n<table>\r\n    <tr>\r\n        <td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbb3151258f3a2b72231c42ab45faaf822a329cd4685", async() => {
                WriteLiteral("\r\n                Details: <input type=\"text\" name=\"aString\" /><input type=\"submit\" value=\"Search\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </td>
    </tr>
</table>
<br/>
<table>
    <tr>
        <th></th>
        <th>Username</th>
        <th>Title</th>
        <th>Details</th>
        <th>Date Posted</th>
        <th>Category</th>
        <th>Status</th>
    </tr>
    <tbody>
");
#nullable restore
#line 29 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
         foreach (Questions cur in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 681, "\"", 713, 2);
            WriteAttributeValue("", 688, "/qanda/answerform/", 688, 18, true);
#nullable restore
#line 32 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
WriteAttributeValue("", 706, cur.id, 706, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Answer it!</a></td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
           Write(cur.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
           Write(cur.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
           Write(cur.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
           Write(cur.posted.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
           Write(cur.category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
           Write(cur.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1002, "\"", 1043, 2);
            WriteAttributeValue("", 1009, "/qanda/answersbyquestionid/", 1009, 27, true);
#nullable restore
#line 39 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
WriteAttributeValue("", 1036, cur.id, 1036, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\">Answers</a></td>\r\n");
#nullable restore
#line 40 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
             if (DAL.currentuser == cur.username || DAL.currentuser.ToLower() == "admin")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><a");
            BeginWriteAttribute("href", " href=\"", 1220, "\"", 1250, 2);
            WriteAttributeValue("", 1227, "/qanda/editform/", 1227, 16, true);
#nullable restore
#line 42 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
WriteAttributeValue("", 1243, cur.id, 1243, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1313, "\"", 1349, 2);
            WriteAttributeValue("", 1320, "/qanda/questiondelete/", 1320, 22, true);
#nullable restore
#line 43 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
WriteAttributeValue("", 1342, cur.id, 1342, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n");
#nullable restore
#line 44 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n<a href=\"/qanda/addform\" class=\"btn btn-success\">Ask a Question</a>\r\n<a href=\"/qanda/answersindex\" class=\"btn btn-success\">See all answers</a>\r\n\r\n");
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
