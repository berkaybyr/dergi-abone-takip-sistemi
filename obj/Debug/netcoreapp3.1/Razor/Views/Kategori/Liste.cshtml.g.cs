#pragma checksum "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Liste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8885c40742dc16e0224079fbbde5e7a5c56eaae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kategori_Liste), @"mvc.1.0.view", @"/Views/Kategori/Liste.cshtml")]
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
#line 1 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\_ViewImports.cshtml"
using DAboneTakip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\_ViewImports.cshtml"
using DAboneTakip.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Liste.cshtml"
using DergiAboneProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Liste.cshtml"
using DergiAboneProje.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8885c40742dc16e0224079fbbde5e7a5c56eaae", @"/Views/Kategori/Liste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da3daaf701e9a129f2e18589ab3a9a401fbd2ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Kategori_Liste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Kategoriler>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Liste.cshtml"
  
    ViewData["Title"] = "Kategoriler";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div>


    <div>
        <table id=""KategoriTable"" class=""row-border stripe hover table-bordered"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Kategori Adı</th>
                    <th>Dergi Sayısı</th>
                    <th>Düzenle</th>
                    <th>Sil</th>
                    <th>Detaylar</th>
                </tr>
            </thead>

");
#nullable restore
#line 27 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Liste.cshtml"
             foreach (var x in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Liste.cshtml"
                   Write(x.KategoriID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Liste.cshtml"
                   Write(x.KategoriAD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Liste.cshtml"
                   Write(x.Dergilers.Where(x => x.KategoriID == x.KategoriID).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 907, "\"", 945, 2);
            WriteAttributeValue("", 914, "/Kategori/Duzenle/", 914, 18, true);
#nullable restore
#line 34 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Liste.cshtml"
WriteAttributeValue("", 932, x.KategoriID, 932, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Düzenle</a></td>\r\n                    <td><a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1024, "\"", 1056, 3);
            WriteAttributeValue("", 1034, "Confirm(", 1034, 8, true);
#nullable restore
#line 35 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Liste.cshtml"
WriteAttributeValue("", 1042, x.KategoriID, 1042, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1055, ")", 1055, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger ksilbtn\">Sil</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1129, "\"", 1165, 2);
            WriteAttributeValue("", 1136, "/Kategori/Detay/", 1136, 16, true);
#nullable restore
#line 36 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Liste.cshtml"
WriteAttributeValue("", 1152, x.KategoriID, 1152, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Detaylar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 38 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Liste.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </table>
    </div>

    <a href=""/Kategori/Ekle/"" class=""btn btn-success"">Yeni Kategori Ekle</a>

    <script>
        function Confirm(id) {
            swal({
                title: ""Silmek istediğinize emin misiniz ? (ID: "" + id + "")"",
                icon: ""warning"",
                buttons: {
                    cancel: ""Hayır"",
                    true: ""Evet"",
                },
            })
                .then((willDelete) => {
                    if (willDelete) {
                        window.location.href = ""/Kategori/Sil/"" + id; 
                        swal({
                            title: ""Kategori silme işlemi başarılı!"",
                            icon: ""success"",
                            buttons: ""Tamam"",
                        }).then(value => {
                            window.location.href = ""/Kategori/Liste/"";
                        });
                    }
                    
                });
        }

        $(document).read");
            WriteLiteral(@"y(function () {
            $('#KategoriTable').DataTable({
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Kategoriler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
