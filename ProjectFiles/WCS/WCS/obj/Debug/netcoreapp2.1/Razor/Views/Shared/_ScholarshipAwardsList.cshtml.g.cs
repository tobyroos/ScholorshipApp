#pragma checksum "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4d5ecc378dfe443c3f11311b758c9539152f4aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScholarshipAwardsList), @"mvc.1.0.view", @"/Views/Shared/_ScholarshipAwardsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ScholarshipAwardsList.cshtml", typeof(AspNetCore.Views_Shared__ScholarshipAwardsList))]
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
#line 2 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
using WCS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4d5ecc378dfe443c3f11311b758c9539152f4aa", @"/Views/Shared/_ScholarshipAwardsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e73dd4adf41d0d298c34d6b0c518752349a4b1d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ScholarshipAwardsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WCS.Models.ScholarshipAwardsListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/form/edit.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-award btn-award-edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit this award"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/form/cancel.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-award btn-award-remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("remove this award"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/wcs.scholarshipawards.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
 if (Model.AllowEdit)
{
    

#line default
#line hidden
#line 6 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
    User currentUser = await userManager.GetUserAsync(User);
    Model.AllowEdit = await userManager.IsInRoleAsync(currentUser, "Administrator");
}

#line default
#line hidden
            BeginContext(285, 136, true);
            WriteLiteral("\r\n<div class=\"list-awards\">\r\n    <table class=\"table table-list table-list-awards\">\r\n        <caption>\r\n            Scholarship Awards\r\n");
            EndContext();
#line 14 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
             if (Model.AllowEdit)
            {

#line default
#line hidden
            BeginContext(471, 120, true);
            WriteLiteral("                <button class=\"list-btn-new list-btn-caption\" onclick=\"initAwardEditor()\">Award a Scholarship</button>\r\n");
            EndContext();
#line 17 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
            }

#line default
#line hidden
            BeginContext(606, 366, true);
            WriteLiteral(@"        </caption>
        <thead>
            <tr>
                <th>
                    Date
                </th>
                <th>
                    Scholarship Name
                </th>
                <th>
                    Student Name
                </th>
                <th>
                    Total Award
                </th>
");
            EndContext();
#line 33 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                 if (Model.AllowEdit)
                {

#line default
#line hidden
            BeginContext(1030, 31, true);
            WriteLiteral("                    <th></th>\r\n");
            EndContext();
#line 36 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                }

#line default
#line hidden
            BeginContext(1080, 54, true);
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
             foreach (var award in Model.Awards)
            {
                string even = "";
                if (Model.Awards.IndexOf(award) % 2 != 0)
                {
                    even = "even";
                }

#line default
#line hidden
            BeginContext(1367, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1386, "\"", 1421, 2);
            WriteAttributeValue("", 1394, "award-row-scholarship", 1394, 21, true);
#line 47 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
WriteAttributeValue(" ", 1415, even, 1416, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1422, "\"", 1436, 1);
#line 47 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
WriteAttributeValue("", 1427, award.Id, 1427, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1437, 93, true);
            WriteLiteral(" title=\"Click to toggle funding sources\">\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1531, 39, false);
#line 49 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                   Write(Html.DisplayFor(i => award.DateAwarded));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1650, 44, false);
#line 52 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                   Write(Html.DisplayFor(i => award.Scholarship.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1774, 51, false);
#line 55 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                   Write(Html.DisplayFor(i => award.StudentProfile.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1825, 81, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        $ ");
            EndContext();
            BeginContext(1907, 43, false);
#line 58 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                     Write(Html.DisplayFor(i => award.TotalAwardMoney));

#line default
#line hidden
            EndContext();
            BeginContext(1950, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 60 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                     if (Model.AllowEdit)
                    {

#line default
#line hidden
            BeginContext(2045, 97, true);
            WriteLiteral("                        <td class=\"notrow\" title=\"Admin Functions\">\r\n                            ");
            EndContext();
            BeginContext(2142, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4d5ecc378dfe443c3f11311b758c9539152f4aa12708", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 63 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
AddHtmlAttributeValue("", 2180, award.StudentProfileId, 2180, 23, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2264, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2294, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4d5ecc378dfe443c3f11311b758c9539152f4aa14522", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 64 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
AddHtmlAttributeValue("", 2334, award.Id, 2334, 9, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(2408, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 66 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                    }

#line default
#line hidden
            BeginContext(2464, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 69 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                 foreach (var money in award.AwardMonies)
                {

#line default
#line hidden
            BeginContext(2567, 49, true);
            WriteLiteral("                    <tr class=\"award-row-funding\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2616, "\"", 2630, 1);
#line 71 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
WriteAttributeValue("", 2621, award.Id, 2621, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2631, 147, true);
            WriteLiteral(" style=\"display: none;\">\r\n                        <td></td>\r\n                        <td colspan=\"2\" class=\"fundbox\">\r\n                            ");
            EndContext();
            BeginContext(2779, 48, false);
#line 74 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                       Write(Html.DisplayFor(i => money.ScholarshipFund.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2827, 93, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            $ ");
            EndContext();
            BeginContext(2921, 34, false);
#line 77 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                         Write(Html.DisplayFor(i => money.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2955, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 80 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                }

#line default
#line hidden
#line 80 "C:\Users\tobyr\scholarship_repo\ProjectFiles\WCS\WCS\Views\Shared\_ScholarshipAwardsList.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(3049, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            EndContext();
            BeginContext(3089, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4d5ecc378dfe443c3f11311b758c9539152f4aa18960", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3153, 344, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function (event) {
        $("".award-row-scholarship"").click(function () {
            $(""#"" + $(this).attr(""id"") + "".award-row-funding"").fadeToggle(1);
        });

        $("".notrow"").click(function (event) {
            event.stopPropagation();
        });
    });
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WCS.Models.ScholarshipAwardsListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
