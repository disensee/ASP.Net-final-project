#pragma checksum "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "373ecfda1d5dae6b5f9de8aeaa4bea2f98cb244f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BuildOrder_List), @"mvc.1.0.view", @"/Views/BuildOrder/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BuildOrder/List.cshtml", typeof(AspNetCore.Views_BuildOrder_List))]
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
#line 1 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\_ViewImports.cshtml"
using HardwareEFCore.Models;

#line default
#line hidden
#line 2 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\_ViewImports.cshtml"
using HardwareEFCore.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\_ViewImports.cshtml"
using HardwareEFCore.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"373ecfda1d5dae6b5f9de8aeaa4bea2f98cb244f", @"/Views/BuildOrder/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4eb756fbbb1762be327268bae35d25a1c7ff89a", @"/Views/_ViewImports.cshtml")]
    public class Views_BuildOrder_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BuildOrder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkShipped", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
  
    ViewBag.Title = "BuildOrders";
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(107, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(137, 137, true);
            WriteLiteral("    <table class=\"table table-bordered table-striped\">\r\n        <tr><th>Name</th><th>Zip</th><th colspan=\"2\">Details</th><th></th></tr>\r\n");
            EndContext();
#line 12 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
         foreach (BuildOrder bo in Model)
        {

#line default
#line hidden
            BeginContext(328, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(367, 7, false);
#line 15 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
               Write(bo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(374, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(402, 6, false);
#line 16 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
               Write(bo.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(408, 115, true);
            WriteLiteral("</td>\r\n                <th>Item</th>\r\n                <th>Quantity</th>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(523, 259, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "522ae497c63540039dd6bce335fa9e26", async() => {
                BeginContext(568, 66, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"buildOrderId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 634, "\"", 658, 1);
#line 21 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
WriteAttributeValue("", 642, bo.BuildOrderId, 642, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(659, 116, true);
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">Ship</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(782, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
             foreach (CartLine line in bo.Lines)
            {

#line default
#line hidden
            BeginContext(891, 89, true);
            WriteLiteral("                <tr>\r\n                    <td colspan=\"2\"></td>\r\n                    <td>");
            EndContext();
            BeginContext(981, 23, false);
#line 30 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
                   Write(line.Drive.Manufacturer);

#line default
#line hidden
            EndContext();
            BeginContext(1004, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1006, 16, false);
#line 30 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
                                            Write(line.Drive.Model);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1054, 13, false);
#line 31 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
                   Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1067, 61, true);
            WriteLiteral("</td>\r\n                    <td></td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
            }

#line default
#line hidden
#line 34 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1154, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 37 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1180, 56, true);
            WriteLiteral("    <div class=\"text-center\">No Unshipped Builds</div>\r\n");
            EndContext();
#line 41 "C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\Views\BuildOrder\List.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BuildOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
