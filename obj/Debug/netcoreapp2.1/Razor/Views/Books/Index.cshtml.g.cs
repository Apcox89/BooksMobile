#pragma checksum "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31ba8cfc501f52b69848dffa886e0d4c2dd3b411"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Index.cshtml", typeof(AspNetCore.Views_Books_Index))]
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
#line 1 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\_ViewImports.cshtml"
using BooksMobile;

#line default
#line hidden
#line 2 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\_ViewImports.cshtml"
using BooksMobile.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31ba8cfc501f52b69848dffa886e0d4c2dd3b411", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49969cd1ca3b1ddd26d789d2f41d88c1a837566e", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BooksMobile.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(101, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
  
    ViewData["Title"] = "Index";

    //initialize local variable values to return correct View results of exam[4]pt.2
    bool chckbox = false;

    DateTime dt = new DateTime(12 / 31 / 2000);

    //site.css contains "hidden" property for html elements.

#line default
#line hidden
            BeginContext(374, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(403, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b12338cd6f564603a12872a0c4acf8b7", async() => {
                BeginContext(427, 13, true);
                WriteLiteral(" Create new: ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(444, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(537, 45, false);
#line 27 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BookTitle));

#line default
#line hidden
            EndContext();
            BeginContext(582, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(638, 42, false);
#line 30 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(680, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(736, 49, false);
#line 33 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YearPublished));

#line default
#line hidden
            EndContext();
            BeginContext(785, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(841, 46, false);
#line 36 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CallNumber));

#line default
#line hidden
            EndContext();
            BeginContext(887, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(943, 46, false);
#line 39 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CheckedOut));

#line default
#line hidden
            EndContext();
            BeginContext(989, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1045, 43, false);
#line 42 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateDue));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1144, 42, false);
#line 45 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Patron));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n\r\n");
            EndContext();
            BeginContext(1332, 17, true);
            WriteLiteral("\r\n\r\n    <tbody>\r\n");
            EndContext();
#line 55 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(1400, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1461, 44, false);
#line 60 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BookTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1505, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1573, 41, false);
#line 63 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1682, 48, false);
#line 66 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.YearPublished));

#line default
#line hidden
            EndContext();
            BeginContext(1730, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1798, 45, false);
#line 69 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CallNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1843, 49, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n");
            EndContext();
#line 73 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
                       //No display of Checkboxes for Books' not checked out.
                        chckbox = item.CheckedOut;
                        if (chckbox == false)
                        {

#line default
#line hidden
            BeginContext(2097, 50, true);
            WriteLiteral("                            <span class=\"hidden\"> ");
            EndContext();
            BeginContext(2148, 45, false);
#line 77 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.CheckedOut));

#line default
#line hidden
            EndContext();
            BeginContext(2193, 10, true);
            WriteLiteral(" </span>\r\n");
            EndContext();
#line 78 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"

                        }
                        else
                        {
                            

#line default
#line hidden
            BeginContext(2318, 45, false);
#line 82 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
                       Write(Html.DisplayFor(modelitem => item.CheckedOut));

#line default
#line hidden
            EndContext();
#line 82 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
                                                                          
                        }

                    

#line default
#line hidden
            BeginContext(2417, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 88 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
                       dt = item.DateDue;
                        if (dt == Convert.ToDateTime("12/31/3000"))
                        {

#line default
#line hidden
            BeginContext(2601, 51, true);
            WriteLiteral("                            <span class=\"hidden\">  ");
            EndContext();
            BeginContext(2653, 42, false);
#line 91 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.DateDue));

#line default
#line hidden
            EndContext();
            BeginContext(2695, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 92 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
                        }
                        else
                        { 

#line default
#line hidden
            BeginContext(2788, 42, false);
#line 94 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
                     Write(Html.DisplayFor(modelItem => item.DateDue));

#line default
#line hidden
            EndContext();
#line 94 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
                                                                      }
                    

#line default
#line hidden
            BeginContext(2857, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2923, 51, false);
#line 98 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Patron.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2974, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3041, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe4d2962e3bf4b10a1d55064ab445ca4", async() => {
                BeginContext(3090, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 101 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
                                           WriteLiteral(item.BookId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3098, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(3122, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a626a19971f04e6cb6353f8c6c643794", async() => {
                BeginContext(3174, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
                                              WriteLiteral(item.BookId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3185, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(3209, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad012cf12a0e4e1689bfe12a01776204", async() => {
                BeginContext(3260, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 103 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"
                                             WriteLiteral(item.BookId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3270, 56, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>            \r\n");
            EndContext();
#line 106 "C:\Users\Palmer\Desktop\SD733-WebDevServerSide\BooksMobile\Views\Books\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(3339, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BooksMobile.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
