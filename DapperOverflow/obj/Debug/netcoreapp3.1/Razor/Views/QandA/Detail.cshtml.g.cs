#pragma checksum "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9d2244be80cf9829a2a029a94ccdb1fa2be361e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_Detail), @"mvc.1.0.view", @"/Views/QandA/Detail.cshtml")]
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
#line 1 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\_ViewImports.cshtml"
using DapperOverflow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\_ViewImports.cshtml"
using DapperOverflow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9d2244be80cf9829a2a029a94ccdb1fa2be361e", @"/Views/QandA/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14bd00d17f4bd890ab5f401ea4a830e86779818e", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Question>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    p.groove {\r\n        border-style: groove;\r\n    }\r\n</style>\r\n<a href=\"/QandA/Index\">Back to Questions</a>\r\n<h1>");
#nullable restore
#line 8 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h6><i>");
#nullable restore
#line 9 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
  Write(Model.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i> by: ");
#nullable restore
#line 9 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
                        Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<br />\r\n<p class=\"groove\">");
#nullable restore
#line 11 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
             Write(Model.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n");
#nullable restore
#line 13 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
 if (Model.Username == ViewBag.activeUser)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 321, "\"", 372, 3);
            WriteAttributeValue("", 331, "location.href=\'/QandA/Edit?_id=", 331, 31, true);
#nullable restore
#line 15 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 362, Model.id, 362, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 371, "\'", 371, 1, true);
            EndWriteAttribute();
            WriteLiteral(">EDIT</button>\r\n    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 400, "\"", 453, 3);
            WriteAttributeValue("", 410, "location.href=\'/QandA/Delete?_id=", 410, 33, true);
#nullable restore
#line 16 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 443, Model.id, 443, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 452, "\'", 452, 1, true);
            EndWriteAttribute();
            WriteLiteral(">DELETE</button>\r\n");
#nullable restore
#line 17 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n");
#nullable restore
#line 20 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
 if (ViewBag.Answerlist.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Answers</h4>\r\n");
#nullable restore
#line 23 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
    foreach (Answer answer in ViewBag.Answerlist)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><i>");
#nullable restore
#line 25 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
         Write(answer.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - by: ");
#nullable restore
#line 25 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
                              Write(answer.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </i>\r\n");
#nullable restore
#line 26 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
            if (answer.Username == ViewBag.activeUser)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 752, "\"", 790, 2);
            WriteAttributeValue("", 759, "/QandA/GetAnswer?_id=", 759, 21, true);
#nullable restore
#line 28 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 780, answer.id, 780, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">EDIT ANSWER</a>\r\n");
#nullable restore
#line 29 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
           }
           else
           {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i style=\"color:gray\">EDIT ANSWER </i> ");
#nullable restore
#line 31 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\r\n        <p class=\"groove\">");
#nullable restore
#line 33 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
                     Write(answer.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 37 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
 if (@Model.Status != 1 )
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<button");
            BeginWriteAttribute("onclick", " onclick=\"", 1010, "\"", 1066, 3);
            WriteAttributeValue("", 1020, "location.href=\'/QandA/AddAnswer?_id=", 1020, 36, true);
#nullable restore
#line 39 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 1056, Model.id, 1056, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1065, "\'", 1065, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add an Answer</button>\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 1099, "\"", 1160, 3);
            WriteAttributeValue("", 1109, "location.href=\'/QandA/Close?_id=", 1109, 32, true);
#nullable restore
#line 40 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 1141, Model.id, 1141, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1150, "&status=1\'", 1150, 10, true);
            EndWriteAttribute();
            WriteLiteral(">Mark as Resolved</button>\r\n");
#nullable restore
#line 41 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
