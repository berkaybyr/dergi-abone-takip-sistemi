#pragma checksum "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0bbc042345e4420570f675a6a5cd4f50a8b25a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dergi_Duzenle), @"mvc.1.0.view", @"/Views/Dergi/Duzenle.cshtml")]
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
#line 1 "C:\Users\berka\source\repos\DAboneTakip\Views\_ViewImports.cshtml"
using DAboneTakip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\berka\source\repos\DAboneTakip\Views\_ViewImports.cshtml"
using DAboneTakip.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0bbc042345e4420570f675a6a5cd4f50a8b25a0", @"/Views/Dergi/Duzenle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da3daaf701e9a129f2e18589ab3a9a401fbd2ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Dergi_Duzenle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DergiAboneProje.Models.Dergiler>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control chosen-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml"
  
    ViewData["Title"] = "Dergi Düzenle";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml"
 using (Html.BeginForm("Duzenle", "Dergi", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"eklediv\">\r\n    <h4>Dergi ID : ");
#nullable restore
#line 13 "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml"
              Write(Model.DergiID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    ");
#nullable restore
#line 14 "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml"
Write(Html.TextBoxFor(x => x.DergiID, new { @class = "form-control", @readonly = "readonly", style = "display: none;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <h4>Dergi Kayıt Tarihi: ");
#nullable restore
#line 16 "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml"
                       Write(Model.DergiTARIH.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
            WriteLiteral("    <br />\r\n    <h4>Dergi Adı</h4>\r\n    ");
#nullable restore
#line 20 "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml"
Write(Html.TextBoxFor(x => x.DergiAD, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <h4>Kategori Adı</h4>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0bbc042345e4420570f675a6a5cd4f50a8b25a05336", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml"
             foreach (var item in (List<SelectListItem>)ViewBag.dgr)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0bbc042345e4420570f675a6a5cd4f50a8b25a05880", async() => {
#nullable restore
#line 27 "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml"
                                        Write( "("+ item.Value + ")" + item.Text);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml"
                   WriteLiteral(item.Value);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 24 "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.KategoriID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <button class=\"btn btn-info\" onclick=\"BlankCheck();\" type=\"submit\">Düzenlemeyi Kaydet</button>\r\n</div>\r\n");
#nullable restore
#line 34 "C:\Users\berka\source\repos\DAboneTakip\Views\Dergi\Duzenle.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $(""#KategoriID"").chosen({
        no_results_text: ""Eşleşme bulunamadı!""
    })
    var BlankCheck = function () {
        var DergiAD = $('#DergiAD').val();

        if (DergiAD == """" || DergiAD == undefined) {
            swal(""Uyarı"", ""Dergi adı boş bırakılamaz!"", ""error"")
            return false;
        }
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DergiAboneProje.Models.Dergiler> Html { get; private set; }
    }
}
#pragma warning restore 1591
