#pragma checksum "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d2dfbadcd41260f30b10714d8b4017de80ad52c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Abonelik_Liste), @"mvc.1.0.view", @"/Views/Abonelik/Liste.cshtml")]
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
#nullable restore
#line 1 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
using DergiAboneProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d2dfbadcd41260f30b10714d8b4017de80ad52c", @"/Views/Abonelik/Liste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da3daaf701e9a129f2e18589ab3a9a401fbd2ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Abonelik_Liste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Abonelikler>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/tableactive.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
  
    ViewData["Title"] = "Abonelikler";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7d2dfbadcd41260f30b10714d8b4017de80ad52c4243", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div>

    <div class=""w3-bar"" id=""tabDIV"">
        <a class=""btn zbtn zactive"" style=""font-size:20px"" onclick=""openTable('AktifT')"">Aktif Abonelikleri Listele</a>
        <a class=""btn zbtn"" style=""font-size:20px"" onclick=""openTable('PasifT')"">Pasif Abonelikleri Listele</a>
    </div>
    <br />
    <div id=""AktifT"" class=""table"">
        <table id=""AktifTable"" class=""row-border stripe hover table-bordered"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Kayıt Tarihi(Ay/Gün/Yıl)</th>
                    <th>Kalan Gün</th>
                    <th>Üye ID</th>
                    <th>Üye Adı</th>
                    <th>Dergi ID</th>
                    <th>Dergi Adı</th>
                    <th>Düzenle</th>
                    <th>İptal</th>
                </tr>
            </thead>

");
#nullable restore
#line 33 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
             foreach (var x in Model)
            {

                if ((x.KayıtTarihi.AddDays(x.KayıtSuresi) - DateTime.Now).Days <= 0)
                {
                    continue;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                   Write(x.KayıtID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                   Write(x.KayıtTarihi.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                    Write((x.KayıtTarihi.AddDays(x.KayıtSuresi) - DateTime.Now).Days);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                   Write(x.UyeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                   Write(x.Uye.UyeAD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                   Write(x.DergiID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                   Write(x.Dergi.DergiAD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1711, "\"", 1746, 2);
            WriteAttributeValue("", 1718, "/Abonelik/Duzenle/", 1718, 18, true);
#nullable restore
#line 48 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
WriteAttributeValue("", 1736, x.KayıtID, 1736, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Düzenle</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1816, "\"", 1849, 2);
            WriteAttributeValue("", 1823, "/Abonelik/Iptal/", 1823, 16, true);
#nullable restore
#line 49 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
WriteAttributeValue("", 1839, x.KayıtID, 1839, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">İptal</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 51 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </table>
    </div>
    <div id=""PasifT"" class=""table""  style=""display:none""> 
        <table id=""PasifTable"" class=""row-border stripe hover table-bordered"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Kayıt Tarihi(Ay/Gün/Yıl)</th>
                    <th>Gün Önce Bitti</th>
                    <th>Üye ID</th>
                    <th>Üye Adı</th>
                    <th>Dergi ID</th>
                    <th>Dergi Adı</th>
                    <th>Kaydı Sil</th>
                </tr>
            </thead>

");
#nullable restore
#line 70 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
             foreach (var x in Model)
            {
                if ((x.KayıtTarihi.AddDays(x.KayıtSuresi) - DateTime.Now).Days > 0)
                {
                    continue;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr id=\"ptb\">\r\n                    <td>");
#nullable restore
#line 77 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                   Write(x.KayıtID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 78 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                   Write(x.KayıtTarihi.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 79 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                    Write((DateTime.Now - x.KayıtTarihi.AddDays(x.KayıtSuresi)).Days);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 80 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                   Write(x.UyeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 81 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                   Write(x.Uye.UyeAD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 82 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                   Write(x.DergiID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 83 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
                   Write(x.Dergi.DergiAD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 3150, "\"", 3181, 2);
            WriteAttributeValue("", 3157, "/Abonelik/Sil/", 3157, 14, true);
#nullable restore
#line 84 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
WriteAttributeValue("", 3171, x.KayıtID, 3171, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Kaydı Sil</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 86 "C:\Users\berka\source\repos\DAboneTakip\Views\Abonelik\Liste.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </table>
    </div>
    <br />
    <a href=""/Abonelik/Ekle/"" class=""btn btn-success"">Yeni Abonelik Ekle</a>
    
   


    <script>

        var header = document.getElementById(""tabDIV"");
        var btns = header.getElementsByClassName(""zbtn"");
        for (var i = 0; i < btns.length; i++) {
            btns[i].addEventListener(""click"", function () {
                var current = document.getElementsByClassName(""zactive"");
                current[0].className = current[0].className.replace("" zactive"", """");
                this.className += "" zactive"";
            });
        }
        function openTable(tableName) {
            var i;
            var x = document.getElementsByClassName(""table"");
            for (i = 0; i < x.length; i++) {
                x[i].style.display = ""none"";
            }
            document.getElementById(tableName).style.display = ""block"";
        }
        $(document).ready(function () {
            $('#AktifTable').DataTable({
           ");
            WriteLiteral(@"     ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Turkish.json""
                }
            });
        });
        $(document).ready(function () {
            $('#PasifTable').DataTable({
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Turkish.json""
                }
            });
        });
    </script>

</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Abonelikler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
