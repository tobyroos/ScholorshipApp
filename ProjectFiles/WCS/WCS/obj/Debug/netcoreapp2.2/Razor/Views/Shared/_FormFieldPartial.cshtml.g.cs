#pragma checksum "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d4cec34b3aa2f1c286fe641c74875ca85348c9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FormFieldPartial), @"mvc.1.0.view", @"/Views/Shared/_FormFieldPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FormFieldPartial.cshtml", typeof(AspNetCore.Views_Shared__FormFieldPartial))]
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
#line 1 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 2 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
using WCS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d4cec34b3aa2f1c286fe641c74875ca85348c9e", @"/Views/Shared/_FormFieldPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e73dd4adf41d0d298c34d6b0c518752349a4b1d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FormFieldPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentResponsePack>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 25, true);
            WriteLiteral("\r\n<div class=\"form-field\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 98, "\"", 122, 1);
#line 6 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
WriteAttributeValue("", 103, Model.FormField.Id, 103, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(123, 51, true);
            WriteLiteral(">\r\n    <input type=\"hidden\" class=\"form-field-data\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 174, "\"", 227, 1);
#line 7 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
WriteAttributeValue("", 182, JsonConvert.SerializeObject(Model.FormField), 182, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(228, 56, true);
            WriteLiteral(" />\r\n    <input type=\"hidden\" class=\"form-response-data\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 284, "\"", 340, 1);
#line 8 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
WriteAttributeValue("", 292, JsonConvert.SerializeObject(Model.FormResponse), 292, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(341, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 9 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
     if (Model.FormField.Required)
    {

#line default
#line hidden
            BeginContext(389, 52, true);
            WriteLiteral("        <span class=\"form-field-required\">*</span>\r\n");
            EndContext();
#line 12 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
    }

#line default
#line hidden
            BeginContext(448, 35, true);
            WriteLiteral("    <span class=\"form-field-title\">");
            EndContext();
            BeginContext(484, 21, false);
#line 13 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
                              Write(Model.FormField.Title);

#line default
#line hidden
            EndContext();
            BeginContext(505, 11, true);
            WriteLiteral("</span>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
     switch (Model.FormField.Type)
    {
        case "Number Box":

#line default
#line hidden
            BeginContext(587, 75, true);
            WriteLiteral("            <input type=\"number\" class=\"form-field-input form-input-number\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 662, "\"", 686, 1);
#line 18 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
WriteAttributeValue("", 667, Model.FormField.Id, 667, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 687, "\"", 723, 1);
#line 18 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
WriteAttributeValue("", 695, Model.FormResponse.Response, 695, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(724, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 19 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
            break;

        case "Text Box":

#line default
#line hidden
            BeginContext(777, 74, true);
            WriteLiteral("            <input type=\"text\" class=\"form-field-input form-input-textbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 851, "\"", 875, 1);
#line 22 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
WriteAttributeValue("", 856, Model.FormField.Id, 856, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 876, "\"", 912, 1);
#line 22 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
WriteAttributeValue("", 884, Model.FormResponse.Response, 884, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(913, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 23 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
            break;

        case "Text Area":

#line default
#line hidden
            BeginContext(967, 117, true);
            WriteLiteral("            <div class=\"form-field-textarea\">\r\n                <textarea class=\"form-field-input form-input-textarea\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1084, "\"", 1108, 1);
#line 27 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
WriteAttributeValue("", 1089, Model.FormField.Id, 1089, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1109, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1111, 27, false);
#line 27 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
                                                                                           Write(Model.FormResponse.Response);

#line default
#line hidden
            EndContext();
            BeginContext(1138, 13, true);
            WriteLiteral("</textarea>\r\n");
            EndContext();
#line 28 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
                  
                    dynamic taoptions = JsonConvert.DeserializeObject(Model.FormField.Options);
                    string wordsmin;

                    if (taoptions.MinWords < 1)
                    {
                        wordsmin = "Any";
                    }
                    else
                    {
                        wordsmin = taoptions.MinWords;
                    }
                

#line default
#line hidden
            BeginContext(1593, 227, true);
            WriteLiteral("                <div class=\"form-field-wordcount\"><span class=\"wordcount-label\">Word Count: </span><span class=\"wordcount-count\"></span>\r\n                <span class=\"wordcount-min-label\">Suggested: <span class=\"wordcount-min\">");
            EndContext();
            BeginContext(1821, 8, false);
#line 42 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
                                                                                    Write(wordsmin);

#line default
#line hidden
            EndContext();
            BeginContext(1829, 42, true);
            WriteLiteral("</span></span></div>\r\n            </div>\r\n");
            EndContext();
#line 44 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
            break;

        case "Selection Box":

#line default
#line hidden
            BeginContext(1924, 68, true);
            WriteLiteral("            <select class=\"form-field-input form-input-selectionbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1992, "\"", 2016, 1);
#line 47 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
WriteAttributeValue("", 1997, Model.FormField.Id, 1997, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2017, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(2036, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d4cec34b3aa2f1c286fe641c74875ca85348c9e12603", async() => {
                BeginContext(2044, 16, true);
                WriteLiteral("Make a Selection");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2069, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
                  
                    dynamic field = JsonConvert.DeserializeObject(Model.FormField.Options);

                    

#line default
#line hidden
#line 52 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
                     foreach (string item in field.Items)
                    {

                        if (Model.FormResponse.Response == item)
                        {

#line default
#line hidden
            BeginContext(2363, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2391, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d4cec34b3aa2f1c286fe641c74875ca85348c9e14511", async() => {
                BeginContext(2420, 4, false);
#line 57 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
                                                   Write(item);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2433, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 58 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2519, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2547, 22, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d4cec34b3aa2f1c286fe641c74875ca85348c9e16286", async() => {
                BeginContext(2556, 4, false);
#line 61 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
                               Write(item);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2569, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 62 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
                        }

                    }

#line default
#line hidden
            BeginContext(2642, 23, true);
            WriteLiteral("            </select>\r\n");
            EndContext();
#line 67 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldPartial.cshtml"
            break;
    }

#line default
#line hidden
            BeginContext(2692, 52, true);
            WriteLiteral("    <span class=\"form-field-error\"></span>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentResponsePack> Html { get; private set; }
    }
}
#pragma warning restore 1591
