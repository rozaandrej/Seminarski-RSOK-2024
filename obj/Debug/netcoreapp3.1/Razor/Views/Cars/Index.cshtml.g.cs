#pragma checksum "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ba29bb7ee3dc5affec83632fd97b62721ed512f117cd7d9e2c020d61e222a28a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\_ViewImports.cshtml"
using tfzr_rsok_autosalon

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ba29bb7ee3dc5affec83632fd97b62721ed512f117cd7d9e2c020d61e222a28a", @"/Views/Cars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"35dc7de3e3e91716dd6edc0b8f4478e0f3b6c13723a69ab4b5214dd4e4bcff8e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<tfzr_rsok_autosalon.Viewmodels.CarsViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h1>VOZILA</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba29bb7ee3dc5affec83632fd97b62721ed512f117cd7d9e2c020d61e222a28a4445", async() => {
                WriteLiteral("Dodaj");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
    <tr>
        <th>Proizvodjac</th>
        <th>Kategorija</th>
        <th>Model</th>
        <th>Konjaza</th>
        <th>Obrtni moment</th>
        <th>Broj vrata</th>
        <th>Opis</th>
        <th>Opcije</th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\n            <td>\n                ");
            Write(
#nullable restore
#line 30 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
                 item.Model.Manufacturers.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </td>\n\n            <td>\n                ");
            Write(
#nullable restore
#line 34 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
                 item.Model.Categorizes.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </td>\n\n            <td>\n                ");
            Write(
#nullable restore
#line 38 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
                 item.Model.CarModels.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </td>\n\n            <td>\n                ");
            Write(
#nullable restore
#line 42 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
                 item.Model.HorsePower

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" <span>KS</span>\n            </td>\n            <td>\n                ");
            Write(
#nullable restore
#line 45 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
                 item.Model.Torque

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" <span>Nm</span>\n            </td>\n            <td>\n                ");
            Write(
#nullable restore
#line 48 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
                 item.Model.NumberOfDoors

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" <span>vrata</span>\n            </td>\n            <td>\n                ");
            Write(
#nullable restore
#line 51 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
                 item.Model.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </td>\n            <td>\n                ");
            Write(
#nullable restore
#line 54 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
                 Html.ActionLink("Izmeni", "Edit", new { id = item.Model.Id }, new { @class = "btn btn-warning" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                ");
            Write(
#nullable restore
#line 55 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
                 Html.ActionLink("Detaljno", "Details", new { id = item.Model.Id }, new { @class = "btn btn-primary" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                ");
            Write(
#nullable restore
#line 56 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
                 Html.ActionLink("Obrisi", "Delete", new { id = item.Model.Id }, new { @class = "btn btn-danger" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 59 "F:\Smece za skolu\rsok\TFZR-2021-RSOK-AutoSalon-main\tfzr-rsok-autosalon\Views\Cars\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<tfzr_rsok_autosalon.Viewmodels.CarsViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
