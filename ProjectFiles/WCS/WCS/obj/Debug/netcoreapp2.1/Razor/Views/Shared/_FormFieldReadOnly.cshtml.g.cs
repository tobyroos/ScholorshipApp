#pragma checksum "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c233dc5f3eb9a6895375d9994306342a6b86f8f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FormFieldReadOnly), @"mvc.1.0.view", @"/Views/Shared/_FormFieldReadOnly.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FormFieldReadOnly.cshtml", typeof(AspNetCore.Views_Shared__FormFieldReadOnly))]
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
#line 1 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 2 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
using WCS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c233dc5f3eb9a6895375d9994306342a6b86f8f2", @"/Views/Shared/_FormFieldReadOnly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e73dd4adf41d0d298c34d6b0c518752349a4b1d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FormFieldReadOnly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentResponsePack>
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
            BeginContext(71, 23, true);
            WriteLiteral("<div class=\"form-field\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 94, "\"", 118, 1);
#line 4 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
WriteAttributeValue("", 99, Model.FormField.Id, 99, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(119, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 5 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
     if (Model.FormField.Required)
    {

#line default
#line hidden
            BeginContext(165, 52, true);
            WriteLiteral("        <span class=\"form-field-required\">*</span>\r\n");
            EndContext();
#line 8 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
    }

#line default
#line hidden
            BeginContext(224, 35, true);
            WriteLiteral("    <span class=\"form-field-title\">");
            EndContext();
            BeginContext(260, 21, false);
#line 9 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
                              Write(Model.FormField.Title);

#line default
#line hidden
            EndContext();
            BeginContext(281, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 10 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
     switch (Model.FormField.Type)
    {
        case "Number Box":

#line default
#line hidden
            BeginContext(361, 73, true);
            WriteLiteral("            <input type=\"text\" class=\"form-field-input form-input-number\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 434, "\"", 458, 1);
#line 13 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
WriteAttributeValue("", 439, Model.FormField.Id, 439, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 459, "\"", 495, 1);
#line 13 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
WriteAttributeValue("", 467, Model.FormResponse.Response, 467, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(496, 13, true);
            WriteLiteral(" readonly/>\r\n");
            EndContext();
#line 14 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
            break;

        case "Text Box":

#line default
#line hidden
            BeginContext(557, 74, true);
            WriteLiteral("            <input type=\"text\" class=\"form-field-input form-input-textbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 631, "\"", 655, 1);
#line 17 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
WriteAttributeValue("", 636, Model.FormField.Id, 636, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 656, "\"", 692, 1);
#line 17 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
WriteAttributeValue("", 664, Model.FormResponse.Response, 664, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(693, 13, true);
            WriteLiteral(" readonly/>\r\n");
            EndContext();
#line 18 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
            break;

        case "Text Area":

#line default
#line hidden
            BeginContext(755, 117, true);
            WriteLiteral("            <div class=\"form-field-textarea\">\r\n                <textarea class=\"form-field-input form-input-textarea\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 872, "\"", 896, 1);
#line 22 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
WriteAttributeValue("", 877, Model.FormField.Id, 877, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(897, 10, true);
            WriteLiteral(" readonly>");
            EndContext();
            BeginContext(908, 27, false);
#line 22 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
                                                                                                    Write(Model.FormResponse.Response);

#line default
#line hidden
            EndContext();
            BeginContext(935, 13, true);
            WriteLiteral("</textarea>\r\n");
            EndContext();
#line 23 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
                  
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
            BeginContext(1390, 253, true);
            WriteLiteral("                <div class=\"form-field-wordcount\">\r\n                    <span class=\"wordcount-label\">Word Count: </span><span class=\"wordcount-count\"></span>\r\n                    <span class=\"wordcount-min-label\">Suggested: <span class=\"wordcount-min\">");
            EndContext();
            BeginContext(1644, 8, false);
#line 38 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
                                                                                        Write(wordsmin);

#line default
#line hidden
            EndContext();
            BeginContext(1652, 60, true);
            WriteLiteral("</span></span>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 41 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
            break;

        case "Selection Box":

#line default
#line hidden
            BeginContext(1765, 68, true);
            WriteLiteral("            <select class=\"form-field-input form-input-selectionbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1833, "\"", 1857, 1);
#line 44 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
WriteAttributeValue("", 1838, Model.FormField.Id, 1838, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1858, 28, true);
            WriteLiteral(" disabled>\r\n                ");
            EndContext();
            BeginContext(1886, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c233dc5f3eb9a6895375d9994306342a6b86f8f211479", async() => {
                BeginContext(1894, 16, true);
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
            BeginContext(1919, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
                  
                    dynamic field = JsonConvert.DeserializeObject(Model.FormField.Options);

                    

#line default
#line hidden
#line 49 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
                     foreach (string item in field.Items)
                    {

                        if (Model.FormResponse.Response == item)
                        {

#line default
#line hidden
            BeginContext(2213, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2241, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c233dc5f3eb9a6895375d9994306342a6b86f8f213379", async() => {
                BeginContext(2270, 4, false);
#line 54 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
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
            BeginContext(2283, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2369, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2397, 22, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c233dc5f3eb9a6895375d9994306342a6b86f8f215146", async() => {
                BeginContext(2406, 4, false);
#line 58 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
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
            BeginContext(2419, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 59 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
                        }

                    }

#line default
#line hidden
            BeginContext(2492, 23, true);
            WriteLiteral("            </select>\r\n");
            EndContext();
#line 64 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_FormFieldReadOnly.cshtml"
            break;
    }

#line default
#line hidden
            BeginContext(2542, 52, true);
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