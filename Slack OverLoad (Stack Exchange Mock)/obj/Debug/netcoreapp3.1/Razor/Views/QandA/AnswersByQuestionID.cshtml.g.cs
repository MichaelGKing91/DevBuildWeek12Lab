#pragma checksum "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5285ff8e126c7272b4cd3663ed3f9fc0f886ad3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_AnswersByQuestionID), @"mvc.1.0.view", @"/Views/QandA/AnswersByQuestionID.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5285ff8e126c7272b4cd3663ed3f9fc0f886ad3a", @"/Views/QandA/AnswersByQuestionID.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7b7bd5b064afa45257eb3b31fb61903d4618b9", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_AnswersByQuestionID : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Answers>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
  
    ViewData["Title"] = "AnswersByQuestionID";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Question Details:</h3>
<table>
    <tr>
        <th>Username</th>
        <th>Title</th>
        <th>Details</th>
        <th>Date Posted</th>
        <th>Category</th>
        <th>Status</th>
    </tr>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 18 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
           Write(ViewData["aQuestion.UserName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
           Write(ViewData["aQuestion.Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
           Write(ViewData["aQuestion.Detail"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
           Write(ViewData["aQuestion.Posted"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
           Write(ViewData["aQuestion.Category"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
           Write(ViewData["aQuestion.Status"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
            <td><a href=""/qanda/"" class=""btn btn-success"">Go Back!</a></td>
        </tr>
    </tbody>
</table>
<br />
<br />
<h3>All answers for this question:</h3>
<table>
    <tr>
        <th>Username</th>
        <th>Details</th>
        <th>Date Posted</th>
        <th>Up Votes</th>
    </tr>
    <tbody>
");
#nullable restore
#line 39 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
         foreach (Answers cur in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
           Write(cur.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
           Write(cur.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
           Write(cur.posted.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
           Write(cur.upvotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1209, "\"", 1248, 2);
            WriteAttributeValue("", 1216, "/qanda/addupvotetoabyqid/", 1216, 25, true);
#nullable restore
#line 46 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
WriteAttributeValue("", 1241, cur.id, 1241, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Up Vote</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1315, "\"", 1351, 2);
            WriteAttributeValue("", 1322, "/qanda/editanswerform/", 1322, 22, true);
#nullable restore
#line 47 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
WriteAttributeValue("", 1344, cur.id, 1344, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1410, "\"", 1451, 2);
            WriteAttributeValue("", 1417, "/qanda/answerdeletewarning/", 1417, 27, true);
#nullable restore
#line 48 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
WriteAttributeValue("", 1444, cur.id, 1444, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\mking10\source\repos\Slack OverLoad (Stack Exchange Mock)\Slack OverLoad (Stack Exchange Mock)\Views\QandA\AnswersByQuestionID.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Answers>> Html { get; private set; }
    }
}
#pragma warning restore 1591