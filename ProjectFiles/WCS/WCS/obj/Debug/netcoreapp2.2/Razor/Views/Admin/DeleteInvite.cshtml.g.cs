#pragma checksum "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d5c2082ee35e3382f03a91dd518385964abf51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DeleteInvite), @"mvc.1.0.view", @"/Views/Admin/DeleteInvite.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/DeleteInvite.cshtml", typeof(AspNetCore.Views_Admin_DeleteInvite))]
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
#line 3 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\_ViewImports.cshtml"
using WCS.Models;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d5c2082ee35e3382f03a91dd518385964abf51", @"/Views/Admin/DeleteInvite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e73dd4adf41d0d298c34d6b0c518752349a4b1d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DeleteInvite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WCS.Models.Invite>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Invites", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteInvite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml"
  
    ViewData["Title"] = "Delete Invite";

#line default
#line hidden
            BeginContext(75, 161, true);
            WriteLiteral("<h2>Delete</h2>\r\n<h4>Invite</h4>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(237, 45, false);
#line 13 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(282, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(326, 41, false);
#line 16 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(411, 44, false);
#line 19 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(455, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(499, 40, false);
#line 22 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(539, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(583, 48, false);
#line 25 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(675, 44, false);
#line 28 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml"
       Write(Html.DisplayFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(719, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(763, 40, false);
#line 31 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml"
       Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
            EndContext();
            BeginContext(803, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(847, 36, false);
#line 34 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml"
       Write(Html.DisplayFor(model => model.Role));

#line default
#line hidden
            EndContext();
            BeginContext(883, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(927, 50, false);
#line 37 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml"
       Write(Html.DisplayNameFor(model => model.ExpirationDate));

#line default
#line hidden
            EndContext();
            BeginContext(977, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1021, 46, false);
#line 40 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml"
       Write(Html.DisplayFor(model => model.ExpirationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1101, 240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61d5c2082ee35e3382f03a91dd518385964abf519951", async() => {
                BeginContext(1133, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1143, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61d5c2082ee35e3382f03a91dd518385964abf5110343", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 45 "C:\Users\tobyr\scholarship_repo_copy\ProjectFiles\WCS\WCS\Views\Admin\DeleteInvite.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1179, 81, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n        ");
                EndContext();
                BeginContext(1260, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61d5c2082ee35e3382f03a91dd518385964abf5112257", async() => {
                    BeginContext(1313, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1328, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1341, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WCS.Models.Invite> Html { get; private set; }
    }
}
#pragma warning restore 1591