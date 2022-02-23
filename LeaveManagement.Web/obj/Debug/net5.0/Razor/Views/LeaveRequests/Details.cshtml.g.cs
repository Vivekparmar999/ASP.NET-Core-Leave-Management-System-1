#pragma checksum "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d6d9fe0a6e6645e45206c5abbc480a1b19614b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveRequests_Details), @"mvc.1.0.view", @"/Views/LeaveRequests/Details.cshtml")]
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
#line 1 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\_ViewImports.cshtml"
using LeaveManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\_ViewImports.cshtml"
using LeaveManagement.Common.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\_ViewImports.cshtml"
using LeaveManagement.Common.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d6d9fe0a6e6645e45206c5abbc480a1b19614b", @"/Views/LeaveRequests/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"797f347515f5991438b58419b6cec153c3e55b1f", @"/Views/_ViewImports.cshtml")]
    public class Views_LeaveRequests_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeaveRequestVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApprovedRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
  
    ViewData["Title"] = "Leave Request Details";
    string className;
    string headingText;
    if (Model.Approved == null)
    {
        headingText = "Pending Approval";
        className = "warning";
    }
    else if (Model.Approved == true)
    {
        headingText = "Approved";
        className = "success";
    }
    else {
        headingText = "Rejected";
        className = "danger";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Leave Request Details</h1>\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 496, "\"", 526, 3);
            WriteAttributeValue("", 504, "alert", 504, 5, true);
            WriteAttributeValue(" ", 509, "alert-", 510, 7, true);
#nullable restore
#line 25 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
WriteAttributeValue("", 516, className, 516, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n    <h4 class=\"alert-heading\">");
#nullable restore
#line 26 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
                         Write(headingText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <p>\r\n        <strong>Employee Name:</strong> ");
#nullable restore
#line 29 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
                                   Write(Model.Employee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
                                                             Write(Model.Employee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <hr />\r\n    <p>\r\n        <strong>Data Requested:</strong> ");
#nullable restore
#line 33 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
                                    Write(Html.DisplayFor(Model =>  Model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    </p>\r\n</div>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LeaveType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.LeaveType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequestComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 68 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
     if (Model.Approved == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"d-flex flex-row p-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25d6d9fe0a6e6645e45206c5abbc480a1b19614b10414", async() => {
                WriteLiteral("\r\n            <input name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1931, "\"", 1948, 1);
#nullable restore
#line 72 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
WriteAttributeValue("", 1939, Model.Id, 1939, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\">\r\n            <input name=\"approved\" type=\"hidden\" value=\"true\" />\r\n            <button type=\"submit\" class=\"btn btn-success\">Approve</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25d6d9fe0a6e6645e45206c5abbc480a1b19614b12549", async() => {
                WriteLiteral("\r\n            <input name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 2198, "\"", 2215, 1);
#nullable restore
#line 77 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
WriteAttributeValue("", 2206, Model.Id, 2206, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\">\r\n            <input name=\"approved\" type=\"hidden\" value=\"false\" />\r\n            <button type=\"submit\" class=\"btn btn-danger\">Reject</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 83 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\LeaveRequests\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25d6d9fe0a6e6645e45206c5abbc480a1b19614b14837", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeaveRequestVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
