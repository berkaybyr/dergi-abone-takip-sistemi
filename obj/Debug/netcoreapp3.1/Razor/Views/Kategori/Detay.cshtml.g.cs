#pragma checksum "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d276e56cc1f33d9d2b4762817bf883aafdb102a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kategori_Detay), @"mvc.1.0.view", @"/Views/Kategori/Detay.cshtml")]
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
#line 1 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Detay.cshtml"
using DergiAboneProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d276e56cc1f33d9d2b4762817bf883aafdb102a0", @"/Views/Kategori/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da3daaf701e9a129f2e18589ab3a9a401fbd2ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Kategori_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dergiler>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Detay.cshtml"
  
    ViewData["Title"] = @ViewBag.kategoriad + " Kategorisindeki Dergiler || Kategori ID: " + @ViewBag.ktgid;
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div>

    

    
    <table id=""DergiTable"" class=""row-border stripe hover table-bordered"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Dergi Adı</th>
                <th>Dergi Kayıt Tarih(Gün/Ay/Yıl)</th>
                <th>Düzenle</th>
                <th>Sil</th>
                <th>Detaylar</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Detay.cshtml"
             foreach (var x in Model)
            {   

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Detay.cshtml"
               Write(x.DergiID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Detay.cshtml"
               Write(x.DergiAD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Detay.cshtml"
               Write(x.DergiTARIH.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 869, "\"", 901, 2);
            WriteAttributeValue("", 876, "/Dergi/Duzenle/", 876, 15, true);
#nullable restore
#line 32 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Detay.cshtml"
WriteAttributeValue("", 891, x.DergiID, 891, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Düzenle</a></td>\r\n                <td><a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 976, "\"", 1005, 3);
            WriteAttributeValue("", 986, "Confirm(", 986, 8, true);
#nullable restore
#line 33 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Detay.cshtml"
WriteAttributeValue("", 994, x.DergiID, 994, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1004, ")", 1004, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1066, "\"", 1096, 2);
            WriteAttributeValue("", 1073, "/Dergi/Detay/", 1073, 13, true);
#nullable restore
#line 34 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Detay.cshtml"
WriteAttributeValue("", 1086, x.DergiID, 1086, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Detaylar</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Detay.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <tbody>

    </table>
    
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
                        window.location.href = ""/Dergi/Sil/"" + id;
                        swal({
                            title: ""Dergi silme işlemi başarılı!"",
                            icon: ""success"",
                            buttons: ""Tamam"",
                        }).then(value => {
                            window.location.href = ""/Kategori/Detay/"" + ");
#nullable restore
#line 59 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Kategori\Detay.cshtml"
                                                                   Write(ViewBag.ktgid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
                        });
                    }

                });
        }
        $(document).ready(function () {
            $('#DergiTable').DataTable({
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dergiler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
