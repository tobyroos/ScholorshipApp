#pragma checksum "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a599f239e4870261e4d923d96147b31172be98ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Index.cshtml", typeof(AspNetCore.Views_Student_Index))]
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
#line 1 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using WCS;

#line default
#line hidden
#line 4 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using WCS.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using WCS.Models.ManageViewModels;

#line default
#line hidden
#line 2 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
using WCS.Models;

#line default
#line hidden
#line 3 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a599f239e4870261e4d923d96147b31172be98ea", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e73dd4adf41d0d298c34d6b0c518752349a4b1d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WCS.Models.StudentFormPack>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-title-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/shield.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/shield_green.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/wcs.studentapplications.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Student Controller";
    bool applyHR = false; //Fancy bool for applying HR between forms

#line default
#line hidden
            BeginContext(252, 190, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"form-instructions col-md-5\">\r\n        <div class=\"form-instructions-deadline\">\r\n            Application Deadline:\r\n            <span class=\"deadline-date\">");
            EndContext();
            BeginContext(443, 72, false);
#line 13 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                                   Write(Assistant.GetCurrentApplicationCycle(context).EndDate.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(515, 86, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"form-instructions-process\">\r\n            ");
            EndContext();
            BeginContext(602, 33, false);
#line 16 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
       Write(Html.Raw(ViewBag.HelpPageMessage));

#line default
#line hidden
            EndContext();
            BeginContext(635, 614, true);
            WriteLiteral(@"
        </div>
        <br />
        <p><span style=""font-weight: bold; color: darkred;"">Notice: </span>Eligibility for scholarships is based on your answers to the questions in addition to information found in your student profile.</p>
        <span class=""text-success"">You can review and edit your profile information by clicking on the ""Profile Information"" link above.</span>
    </div>
    <div class=""col-md-7 form-list-container"">
        <h2 class=""form-header text-center"">Available Scholarships</h2>
        <div class=""panel-group"" id=""accordion"" role=""tablist"" aria-multiselectable=""true"">
");
            EndContext();
#line 25 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
             foreach (StudentFormPack pack in Model)
            {
                if (pack.StudentForm.Id != 0 && applyHR)
                {
                    applyHR = false;

#line default
#line hidden
            BeginContext(1433, 28, true);
            WriteLiteral("                    <hr />\r\n");
            EndContext();
#line 31 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                }
                else if (pack.StudentForm.Id == 0)
                {
                    applyHR = true;
                }
                string panelId = "form" + pack.Form.Id;

#line default
#line hidden
            BeginContext(1664, 223, true);
            WriteLiteral("                <div class=\"panel panel-default form-container\">\r\n                    <div class=\"accordion-header collapsed panel-heading clearfix\" role=\"tab\" data-toggle=\"collapse\"\r\n                         data-target=\"#");
            EndContext();
            BeginContext(1888, 7, false);
#line 39 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                                  Write(panelId);

#line default
#line hidden
            EndContext();
            BeginContext(1895, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1896, "\"", 1920, 1);
#line 39 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
WriteAttributeValue("", 1912, panelId, 1912, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1921, 28, true);
            WriteLiteral(" data-parent=\"#accordion\">\r\n");
            EndContext();
#line 40 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                          
                            string applytext;

                            if (pack.StudentForm.Id == 0)
                            {
                                applytext = "Click To <strong>Apply</strong> For This Scholarship";

                            }
                            else
                            {
                                applytext = "<span class='form-title-submitted'>Application Submitted</span> - Click to <strong>Edit</strong>";
                            }
                        

#line default
#line hidden
#line 53 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                           if (pack.StudentForm.Id == 0)
                            {

#line default
#line hidden
            BeginContext(2605, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2606, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a599f239e4870261e4d923d96147b31172be98ea10708", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2663, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 54 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                                                                                        }
                            else
                            {

#line default
#line hidden
            BeginContext(2730, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2731, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a599f239e4870261e4d923d96147b31172be98ea12344", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
#line 56 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                                                                                             } 

#line default
#line hidden
            BeginContext(2799, 91, true);
            WriteLiteral("                        <span class=\"form-title panel-title\">\r\n                            ");
            EndContext();
            BeginContext(2891, 25, false);
#line 58 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                       Write(Html.Raw(pack.Form.Title));

#line default
#line hidden
            EndContext();
            BeginContext(2916, 70, true);
            WriteLiteral("\r\n                        </span><br /><span class=\"form-title-apply\">");
            EndContext();
            BeginContext(2987, 19, false);
#line 59 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                                                               Write(Html.Raw(applytext));

#line default
#line hidden
            EndContext();
            BeginContext(3006, 129, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"panel-collapse collapse accordion-container\" role=\"tabpanel\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3135, "\"", 3148, 1);
#line 61 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
WriteAttributeValue("", 3140, panelId, 3140, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3149, 44, true);
            WriteLiteral(">\r\n                        <div class=\"form\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3193, "\"", 3211, 1);
#line 62 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
WriteAttributeValue("", 3198, pack.Form.Id, 3198, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3212, 76, true);
            WriteLiteral(">\r\n                            <input type=\"hidden\" class=\"studentform-data\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3288, "\"", 3342, 1);
#line 63 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
WriteAttributeValue("", 3296, JsonConvert.SerializeObject(pack.StudentForm), 3296, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3343, 63, true);
            WriteLiteral(" />\r\n                            <div class=\"form-description\">");
            EndContext();
            BeginContext(3407, 31, false);
#line 64 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                                                     Write(Html.Raw(pack.Form.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3438, 176, true);
            WriteLiteral("</div>\r\n                            <hr />\r\n                            <div style=\"font-size: 75%;\"><span class=\"form-field-required\">*</span> denotes a required field</div>\r\n");
            EndContext();
#line 67 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                             foreach (StudentResponsePack responsepack in pack.StudentResponsePacks)
                            {
                                

#line default
#line hidden
            BeginContext(3780, 47, false);
#line 69 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                           Write(Html.Partial("_FormFieldPartial", responsepack));

#line default
#line hidden
            EndContext();
#line 69 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
                                                                                
                            }

#line default
#line hidden
            BeginContext(3860, 93, true);
            WriteLiteral("                            <hr />\r\n                            <button class=\"form-btn-save\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3953, "\"", 3971, 1);
#line 72 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
WriteAttributeValue("", 3958, pack.Form.Id, 3958, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3972, 112, true);
            WriteLiteral(">Save Application</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 76 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4099, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(4135, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a599f239e4870261e4d923d96147b31172be98ea18701", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 80 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Student\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public WCS.Data.WcsContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WCS.Models.StudentFormPack>> Html { get; private set; }
    }
}
#pragma warning restore 1591
