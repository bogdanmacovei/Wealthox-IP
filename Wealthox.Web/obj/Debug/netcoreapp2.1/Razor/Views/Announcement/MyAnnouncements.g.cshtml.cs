#pragma checksum "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e834f539a63a8267a410f22be3ed25b68295eee3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Wealthox.Web.Pages.Announcement.Views_Announcement_MyAnnouncements), @"mvc.1.0.view", @"/Views/Announcement/MyAnnouncements.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Announcement/MyAnnouncements.cshtml", typeof(Wealthox.Web.Pages.Announcement.Views_Announcement_MyAnnouncements))]
namespace Wealthox.Web.Pages.Announcement
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\_ViewImports.cshtml"
using Wealthox.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e834f539a63a8267a410f22be3ed25b68295eee3", @"/Views/Announcement/MyAnnouncements.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0805bf69416ba2f79649573552536bcdaf8b29e", @"/Views/_ViewImports.cshtml")]
    public class Views_Announcement_MyAnnouncements : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wealthox.Web.Models.AnnouncementItemVm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/myAnnouncements.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(53, 34, true);
            WriteLiteral("\r\n<div style=\"margin-top:15px;\">\r\n");
            EndContext();
#line 4 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
     foreach (var announcement in Model)
    {

#line default
#line hidden
            BeginContext(136, 211, true);
            WriteLiteral("        <div class=\"announcement-wrap\">\r\n            <div class=\"announcement-item\">\r\n                <div class=\"announcement-top\" style=\"overflow:hidden\">\r\n                    <div style=\"text-align:center\">\r\n");
            EndContext();
#line 10 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                         if (announcement.ImageUrl != null)
                        {

#line default
#line hidden
            BeginContext(435, 32, true);
            WriteLiteral("                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 467, "\"", 495, 1);
#line 12 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
WriteAttributeValue("", 473, announcement.ImageUrl, 473, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(496, 54, true);
            WriteLiteral(" alt=\"\" class=\"\" style=\"height:130px; width:130px;\">\r\n");
            EndContext();
#line 13 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(634, 113, true);
            WriteLiteral("                            <img src=\"../images/house3.png\" alt=\"\" class=\"\" style=\"height:130px; width:130px;\">\r\n");
            EndContext();
#line 17 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                        }

#line default
#line hidden
            BeginContext(774, 207, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"announcement-bottom\" style=\"text-align:center;\">\r\n                    <label class=\"specifications-label announcement-title\">");
            EndContext();
            BeginContext(982, 18, false);
#line 22 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                                                                      Write(announcement.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1000, 113, true);
            WriteLiteral("</label>\r\n                    <br/>\r\n                    <label class=\"house-quality announcement-title\">Price : ");
            EndContext();
            BeginContext(1114, 18, false);
#line 24 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                                                                       Write(announcement.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1132, 195, true);
            WriteLiteral("</label>                  \r\n                    <label class=\"house-conditions announcement-title\">Created on:</label>\r\n                  \r\n                    <label class=\"announcement-title\"> ");
            EndContext();
            BeginContext(1328, 22, false);
#line 27 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                                                  Write(announcement.CreatedOn);

#line default
#line hidden
            EndContext();
            BeginContext(1350, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 28 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                     if (announcement.IsApproved == true)
                    {

#line default
#line hidden
            BeginContext(1442, 79, true);
            WriteLiteral("                        <label class=\"house-status\">Status : Approved</label>\r\n");
            EndContext();
#line 31 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                    }

#line default
#line hidden
            BeginContext(1544, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 32 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                     if (announcement.IsApproved == false)
                    {

#line default
#line hidden
            BeginContext(1627, 82, true);
            WriteLiteral("                        <label class=\"house-status\">Status : In Approval</label>\r\n");
            EndContext();
#line 35 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                    }

#line default
#line hidden
            BeginContext(1732, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 36 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                     if (announcement.IsSold == true)
                    {

#line default
#line hidden
            BeginContext(1810, 69, true);
            WriteLiteral("                        <label class=\"house-status\">Vandut!</label>\r\n");
            EndContext();
#line 39 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                    }

#line default
#line hidden
            BeginContext(1902, 157, true);
            WriteLiteral("                    <div style=\"text-align:center;\">\r\n                        <button class=\"house-item-button DeleteAnnouncement\" data-delete-announcement=\"");
            EndContext();
            BeginContext(2060, 15, false);
#line 41 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
                                                                                                  Write(announcement.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2075, 163, true);
            WriteLiteral("\">\r\n                            Remove\r\n                        </button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 48 "C:\Users\bogdan.macovei\source\repos\Wealthox.Web\Wealthox.Web\Views\Announcement\MyAnnouncements.cshtml"
    }

#line default
#line hidden
            BeginContext(2245, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2272, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2278, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6fc19dc77c2464aaec17cb3c225744b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2325, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wealthox.Web.Models.AnnouncementItemVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591