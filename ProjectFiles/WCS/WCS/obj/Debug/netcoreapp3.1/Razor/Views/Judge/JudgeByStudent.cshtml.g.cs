#pragma checksum "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a043"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Judge_JudgeByStudent), @"mvc.1.0.view", @"/Views/Judge/JudgeByStudent.cshtml")]
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
#line 1 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using WCS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using WCS.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using WCS.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
using WCS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45bad2c70b3f9fab2c4fc7d66d154d97cbd9a043", @"/Views/Judge/JudgeByStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e73dd4adf41d0d298c34d6b0c518752349a4b1d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Judge_JudgeByStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JudgeByStudentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-judge-swap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/swap_left.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("judge-list-expander"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/enlarge.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-title-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/shield_green.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/shield_orange.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/shield_red.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/wcs.judging.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/wcs.judgebystudent.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
  
    ViewData["Title"] = "WCS - Judge By Student";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-9 judge-cycle-header\">\r\n        <div class=\"judge-cycle-inner clearfix\">\r\n            <span class=\"award-cycle-name\">");
#nullable restore
#line 10 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                      Write(Model.AwardCycle.CycleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            [ ");
#nullable restore
#line 11 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
         Write(Html.DisplayFor(i => Model.AwardCycle.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 11 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                                              Write(Html.DisplayFor(i => Model.AwardCycle.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ]\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-3 judge-cycle-header\">\r\n        <div class=\"award-btn judge-btn\" title=\"Click to toggle rating style\" onclick=\"switchMethod()\">\r\n            <span class=\"judge-btn-selected\">Students</span> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a0439091", async() => {
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
            WriteLiteral(" Forms\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-5 judge-list-container\">\r\n        <div class=\"judge-list-header clearfix\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a04310361", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<span class=""judge-list-title"">Students</span>
            <button class=""btn btn-primary judge-list-button-toggle"" data-toggle=""button"" id=""filterStudents"" title=""Toggle Unrated Only View"">Unrated <small id=""allUnrated"" style=""color: yellow; margin-left: 5px;"">0 / 0</small></button>
        </div>
        ");
#nullable restore
#line 24 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
   Write(await Html.PartialAsync("_StudentList", Model.StudentPacks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-7 judge-view-container\">\r\n        <div class=\"judge-view-inner\">\r\n");
#nullable restore
#line 28 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
             foreach (StudentPack studentPack in Model.StudentPacks)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                 if (studentPack.Student != null && studentPack.TotalApplicationsCount > 0)
                {
                    string packId = "studentpack" + studentPack.Student.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"student-pack\"");
            BeginWriteAttribute("id", " id=\"", 1748, "\"", 1760, 1);
#nullable restore
#line 33 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
WriteAttributeValue("", 1753, packId, 1753, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"student-profile-container\">\r\n                            <div class=\"student-pack-title\">");
#nullable restore
#line 35 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                                       Write(studentPack.Student.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            ");
#nullable restore
#line 36 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                       Write(await Html.PartialAsync("_StudentProfile", studentPack.Student));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"student-rating\"");
            BeginWriteAttribute("id", " id=\"", 2075, "\"", 2135, 1);
#nullable restore
#line 37 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
WriteAttributeValue("", 2080, JsonConvert.SerializeObject(studentPack.StudentRating), 2080, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        </div>\r\n");
#nullable restore
#line 39 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                           string accordionId = "accordion" + studentPack.Student.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"panel-group\"");
            BeginWriteAttribute("id", " id=\"", 2313, "\"", 2330, 1);
#nullable restore
#line 40 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
WriteAttributeValue("", 2318, accordionId, 2318, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tablist\" aria-multiselectable=\"true\">\r\n");
#nullable restore
#line 41 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                             foreach (StudentFormPack pack in studentPack.StudentFormPacks)
                            {
                                string panelId = "form" + pack.StudentForm.Id;
                                string ratedClass = "";
                                if (pack.IsRatedFull) { ratedClass = "form-rated"; }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 2760, "\"", 2814, 4);
            WriteAttributeValue("", 2768, "panel", 2768, 5, true);
            WriteAttributeValue(" ", 2773, "panel-default", 2774, 14, true);
            WriteAttributeValue(" ", 2787, "form-container", 2788, 15, true);
#nullable restore
#line 46 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
WriteAttributeValue(" ", 2802, ratedClass, 2803, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"accordion-header collapsed panel-heading clearfix form-title-container\" role=\"tab\" data-toggle=\"collapse\"\r\n                                         data-target=\"#");
#nullable restore
#line 48 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                                  Write(panelId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 3037, "\"", 3061, 1);
#nullable restore
#line 48 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
WriteAttributeValue("", 3053, panelId, 3053, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#");
#nullable restore
#line 48 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                                                                                   Write(accordionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 49 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                           string ratedText;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                         if (pack.IsRatedFull)
                                        {
                                            ratedText = "You have rated this application";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a04318347", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                        }
                                        else if (pack.IsRatedPartial)
                                        {
                                            ratedText = "You have partially rated this application";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a04319963", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                        }
                                        else
                                        {
                                            ratedText = "You have not rated this application";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a04321548", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"form-title panel-title\">\r\n                                            ");
#nullable restore
#line 66 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                       Write(Html.Raw(pack.Form.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </span><br /><span class=\"form-title-rated\">");
#nullable restore
#line 67 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                                                               Write(ratedText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div class=\"panel-collapse collapse accordion-container\" role=\"tabpanel\"");
            BeginWriteAttribute("id", " id=\"", 4617, "\"", 4630, 1);
#nullable restore
#line 69 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
WriteAttributeValue("", 4622, panelId, 4622, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 70 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                   Write(await Html.PartialAsync("_FormForJudging", pack));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 73 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 76 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a04325410", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 82 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a04327300", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#nullable restore
#line 83 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    function switchMethod() {\r\n        location.href = \"/Judge/JudgeByForm\";\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JudgeByStudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591