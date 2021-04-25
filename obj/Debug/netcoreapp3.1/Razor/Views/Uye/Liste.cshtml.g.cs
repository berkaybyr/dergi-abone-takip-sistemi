#pragma checksum "C:\Users\berka\source\repos\DAboneTakip\Views\Uye\Liste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41044c078603bd10f14e46476dc1a38899b76722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uye_Liste), @"mvc.1.0.view", @"/Views/Uye/Liste.cshtml")]
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
#line 1 "C:\Users\berka\source\repos\DAboneTakip\Views\Uye\Liste.cshtml"
using DergiAboneProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41044c078603bd10f14e46476dc1a38899b76722", @"/Views/Uye/Liste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da3daaf701e9a129f2e18589ab3a9a401fbd2ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Uye_Liste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Uyeler>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\berka\source\repos\DAboneTakip\Views\Uye\Liste.cshtml"
  
    ViewData["Title"] = "Üye Liste";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<div>
    <script>
        $(document).ready(function () {
            $('#AboneTable').DataTable();
        });
    </script>
    <h2 class=""my-header"">Üyeler</h2>
    <br />

    <table id=""AboneTable"" class=""row-border stripe hover table-bordered"">
        <thead>
            <tr>
                <th>Üye ID</th>
                <th>Üye Adı Soyadı</th>
                <th>Email</th>
                <th>Tel No</th>
                <th>Doğum Tarihi</th>
                <th>Düzenle</th>
                <th>Sil</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "C:\Users\berka\source\repos\DAboneTakip\Views\Uye\Liste.cshtml"
             foreach (var x in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\berka\source\repos\DAboneTakip\Views\Uye\Liste.cshtml"
                   Write(x.UyeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\berka\source\repos\DAboneTakip\Views\Uye\Liste.cshtml"
                   Write(x.UyeAD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\berka\source\repos\DAboneTakip\Views\Uye\Liste.cshtml"
                   Write(x.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\berka\source\repos\DAboneTakip\Views\Uye\Liste.cshtml"
                   Write(x.TelNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\berka\source\repos\DAboneTakip\Views\Uye\Liste.cshtml"
                   Write(x.Tarih.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1069, "\"", 1102, 2);
            WriteAttributeValue("", 1076, "/Aboneler/Duzenle/", 1076, 18, true);
#nullable restore
#line 42 "C:\Users\berka\source\repos\DAboneTakip\Views\Uye\Liste.cshtml"
WriteAttributeValue("", 1094, x.UyeID, 1094, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Düzenle</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1172, "\"", 1198, 2);
            WriteAttributeValue("", 1179, "/Abone/Sil/", 1179, 11, true);
#nullable restore
#line 43 "C:\Users\berka\source\repos\DAboneTakip\Views\Uye\Liste.cshtml"
WriteAttributeValue("", 1190, x.UyeID, 1190, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>                    \r\n                </tr>\r\n");
#nullable restore
#line 45 "C:\Users\berka\source\repos\DAboneTakip\Views\Uye\Liste.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <br />\r\n    <a href=\"/Uye/Ekle/\" class=\"btn btn-success\">Yeni Üye Ekle</a>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Uyeler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
