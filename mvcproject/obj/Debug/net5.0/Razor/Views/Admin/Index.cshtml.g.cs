#pragma checksum "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c75eedae072817bf1a945761f4655bc168176b4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\_ViewImports.cshtml"
using mvcproject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\_ViewImports.cshtml"
using mvcproject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c75eedae072817bf1a945761f4655bc168176b4a", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"899233e96cc852233039d0981f740e8b0d2d7dc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<mvcproject.Models.ArtWork>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
   
    ViewBag.Title = "Product List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c75eedae072817bf1a945761f4655bc168176b4a3981", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <!--\r\n    <th>\r\n        ");
            WriteLiteral("@Html.DisplayNameFor(model => model.art_id)\r\n    </th>-->\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.category_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.file_location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.user_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.product_explanation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><!--\r\n            <td>\r\n                ");
            WriteLiteral("@Html.DisplayFor(modelItem => item.art_id)\r\n            </td>-->\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.category_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL\r\n            </td>\r\n            <td>\r\n                <img class=\"card-img-top\" style=\"width:130px;height:130px;\"");
            BeginWriteAttribute("src", " src=\"", 1552, "\"", 1577, 1);
#nullable restore
#line 53 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1558, item.file_location, 1558, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.user_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.product_explanation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.art_id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                <!--");
            WriteLiteral("@Html.ActionLink(\"Details\", \"Details\", new { /* id=item.PrimaryKey */ }) |-->\r\n                ");
#nullable restore
#line 64 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete",new { id = item.art_id}, new { onclick = "return confirm('Are you sure want to delete ?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 67 "C:\Users\alpercanboyraz\source\repos\mvcproject\mvcproject\Views\Admin\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<mvcproject.Models.ArtWork>> Html { get; private set; }
    }
}
#pragma warning restore 1591
