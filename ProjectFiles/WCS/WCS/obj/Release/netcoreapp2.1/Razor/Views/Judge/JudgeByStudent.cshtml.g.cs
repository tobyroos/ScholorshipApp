#pragma checksum "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a043"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Judge_JudgeByStudent), @"mvc.1.0.view", @"/Views/Judge/JudgeByStudent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Judge/JudgeByStudent.cshtml", typeof(AspNetCore.Views_Judge_JudgeByStudent))]
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
#line 1 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using WCS;

#line default
#line hidden
#line 4 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using WCS.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using WCS.Models.ManageViewModels;

#line default
#line hidden
#line 2 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
using WCS.Models;

#line default
#line hidden
#line 3 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
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
#line 4 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
  
    ViewData["Title"] = "WCS - Judge By Student";

#line default
#line hidden
            BeginContext(133, 159, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-9 judge-cycle-header\">\r\n        <div class=\"judge-cycle-inner clearfix\">\r\n            <span class=\"award-cycle-name\">");
            EndContext();
            BeginContext(293, 26, false);
#line 10 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                      Write(Model.AwardCycle.CycleName);

#line default
#line hidden
            EndContext();
            BeginContext(319, 23, true);
            WriteLiteral("</span>\r\n            [ ");
            EndContext();
            BeginContext(343, 48, false);
#line 11 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
         Write(Html.DisplayFor(i => Model.AwardCycle.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(391, 4, true);
            WriteLiteral(" to ");
            EndContext();
            BeginContext(396, 46, false);
#line 11 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                                              Write(Html.DisplayFor(i => Model.AwardCycle.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(442, 245, true);
            WriteLiteral(" ]\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-3 judge-cycle-header\">\r\n        <div class=\"award-btn judge-btn\" title=\"Click to toggle rating style\" onclick=\"switchMethod()\">\r\n            <span class=\"judge-btn-selected\">Students</span> ");
            EndContext();
            BeginContext(687, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a0439409", async() => {
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
            BeginContext(746, 147, true);
            WriteLiteral(" Forms\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-5 judge-list-container\">\r\n        <div class=\"judge-list-header clearfix\">\r\n            ");
            EndContext();
            BeginContext(893, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a04310819", async() => {
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
            EndContext();
            BeginContext(955, 311, true);
            WriteLiteral(@"<span class=""judge-list-title"">Students</span>
            <button class=""btn btn-primary judge-list-button-toggle"" data-toggle=""button"" id=""filterStudents"" title=""Toggle Unrated Only View"">Unrated <small id=""allUnrated"" style=""color: yellow; margin-left: 5px;"">0 / 0</small></button>
        </div>
        ");
            EndContext();
            BeginContext(1267, 59, false);
#line 24 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
   Write(await Html.PartialAsync("_StudentList", Model.StudentPacks));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 103, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-7 judge-view-container\">\r\n        <div class=\"judge-view-inner\">\r\n");
            EndContext();
#line 28 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
             foreach (StudentPack studentPack in Model.StudentPacks)
            {
                

#line default
#line hidden
#line 30 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                 if (studentPack.Student != null && studentPack.TotalApplicationsCount > 0)
                {
                    string packId = "studentpack" + studentPack.Student.Id;

#line default
#line hidden
            BeginContext(1703, 45, true);
            WriteLiteral("                    <div class=\"student-pack\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1748, "\"", 1760, 1);
#line 33 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
WriteAttributeValue("", 1753, packId, 1753, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1761, 128, true);
            WriteLiteral(">\r\n                        <div class=\"student-profile-container\">\r\n                            <div class=\"student-pack-title\">");
            EndContext();
            BeginContext(1890, 28, false);
#line 35 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                                       Write(studentPack.Student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1918, 36, true);
            WriteLiteral("</div>\r\n                            ");
            EndContext();
            BeginContext(1955, 63, false);
#line 36 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                       Write(await Html.PartialAsync("_StudentProfile", studentPack.Student));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 57, true);
            WriteLiteral("\r\n                            <div class=\"student-rating\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2075, "\"", 2135, 1);
#line 37 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
WriteAttributeValue("", 2080, JsonConvert.SerializeObject(studentPack.StudentRating), 2080, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2136, 41, true);
            WriteLiteral("></div>\r\n                        </div>\r\n");
            EndContext();
#line 39 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                           string accordionId = "accordion" + studentPack.Student.Id;

#line default
#line hidden
            BeginContext(2265, 48, true);
            WriteLiteral("                        <div class=\"panel-group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2313, "\"", 2330, 1);
#line 40 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
WriteAttributeValue("", 2318, accordionId, 2318, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2331, 46, true);
            WriteLiteral(" role=\"tablist\" aria-multiselectable=\"true\">\r\n");
            EndContext();
#line 41 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                             foreach (StudentFormPack pack in studentPack.StudentFormPacks)
                            {
                                string panelId = "form" + pack.StudentForm.Id;
                                string ratedClass = "";
                                if (pack.IsRatedFull) { ratedClass = "form-rated"; }

#line default
#line hidden
            BeginContext(2724, 36, true);
            WriteLiteral("                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2760, "\"", 2814, 4);
            WriteAttributeValue("", 2768, "panel", 2768, 5, true);
            WriteAttributeValue(" ", 2773, "panel-default", 2774, 14, true);
            WriteAttributeValue(" ", 2787, "form-container", 2788, 15, true);
#line 46 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
WriteAttributeValue(" ", 2802, ratedClass, 2803, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2815, 213, true);
            WriteLiteral(">\r\n                                    <div class=\"accordion-header collapsed panel-heading clearfix form-title-container\" role=\"tab\" data-toggle=\"collapse\"\r\n                                         data-target=\"#");
            EndContext();
            BeginContext(3029, 7, false);
#line 48 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                                  Write(panelId);

#line default
#line hidden
            EndContext();
            BeginContext(3036, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 3037, "\"", 3061, 1);
#line 48 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
WriteAttributeValue("", 3053, panelId, 3053, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3062, 15, true);
            WriteLiteral(" data-parent=\"#");
            EndContext();
            BeginContext(3078, 11, false);
#line 48 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                                                                                   Write(accordionId);

#line default
#line hidden
            EndContext();
            BeginContext(3089, 4, true);
            WriteLiteral("\">\r\n");
            EndContext();
#line 49 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                           string ratedText;

#line default
#line hidden
#line 50 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                         if (pack.IsRatedFull)
                                        {
                                            ratedText = "You have rated this application";

#line default
#line hidden
            BeginContext(3355, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(3399, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a04319673", async() => {
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
            EndContext();
            BeginContext(3462, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                        }
                                        else if (pack.IsRatedPartial)
                                        {
                                            ratedText = "You have partially rated this application";

#line default
#line hidden
            BeginContext(3723, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(3767, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a04321461", async() => {
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
            EndContext();
            BeginContext(3831, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 59 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                        }
                                        else
                                        {
                                            ratedText = "You have not rated this application";

#line default
#line hidden
            BeginContext(4061, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(4105, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a04323218", async() => {
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
            EndContext();
            BeginContext(4166, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 64 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4211, 123, true);
            WriteLiteral("                                        <span class=\"form-title panel-title\">\r\n                                            ");
            EndContext();
            BeginContext(4335, 25, false);
#line 66 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                       Write(Html.Raw(pack.Form.Title));

#line default
#line hidden
            EndContext();
            BeginContext(4360, 86, true);
            WriteLiteral("\r\n                                        </span><br /><span class=\"form-title-rated\">");
            EndContext();
            BeginContext(4447, 9, false);
#line 67 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                                                               Write(ratedText);

#line default
#line hidden
            EndContext();
            BeginContext(4456, 161, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div class=\"panel-collapse collapse accordion-container\" role=\"tabpanel\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4617, "\"", 4630, 1);
#line 69 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
WriteAttributeValue("", 4622, panelId, 4622, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4631, 43, true);
            WriteLiteral(">\r\n                                        ");
            EndContext();
            BeginContext(4675, 48, false);
#line 70 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                                   Write(await Html.PartialAsync("_FormForJudging", pack));

#line default
#line hidden
            EndContext();
            BeginContext(4723, 86, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 73 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                            }

#line default
#line hidden
            BeginContext(4840, 60, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 76 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                }

#line default
#line hidden
#line 76 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(4934, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(4972, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a04327620", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 82 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
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
            BeginContext(5041, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5043, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45bad2c70b3f9fab2c4fc7d66d154d97cbd9a04329612", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#line 83 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Judge\JudgeByStudent.cshtml"
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
            BeginContext(5119, 129, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    function switchMethod() {\r\n        location.href = \"/Judge/JudgeByForm\";\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JudgeByStudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
