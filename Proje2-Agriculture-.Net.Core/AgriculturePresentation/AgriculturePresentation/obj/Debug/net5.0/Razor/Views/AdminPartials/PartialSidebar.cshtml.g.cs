#pragma checksum "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\AdminPartials\PartialSidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce1aa1799539c4fcfff3adf6d473214206c68dd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPartials_PartialSidebar), @"mvc.1.0.view", @"/Views/AdminPartials/PartialSidebar.cshtml")]
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
#line 1 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce1aa1799539c4fcfff3adf6d473214206c68dd6", @"/Views/AdminPartials/PartialSidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ffff724fe34f91470fb11811ab6f488238ce75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminPartials_PartialSidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <!-- partial:../../partials/_sidebar.html -->
    <nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
        <ul class=""nav"">
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Dashboard/Index/"">
                    <i class=""mdi mdi-chart-bar menu-icon""></i>
                    <span class=""menu-title"">Dashboard</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Service/Index/"">
                    <i class=""mdi mdi-select-all menu-icon""></i>
                    <span class=""menu-title"">Hizmetlerimiz</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Employee/Index/"">
                    <i class=""mdi mdi-face-agent menu-icon""></i>
                    <span class=""menu-title"">Personeller</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Chart/Index/"">
           ");
            WriteLiteral(@"         <i class=""mdi mdi-chart-pie menu-icon""></i>
                    <span class=""menu-title"">Grafikler</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Announcement/Index/"">
                    <i class=""mdi mdi-message-alert menu-icon""></i>
                    <span class=""menu-title"">Duyurular</span>
                </a>
            </li>
             <li class=""nav-item"">
                <a class=""nav-link"" href=""/Contact/Index/"">
                    <i class=""mdi mdi-message menu-icon""></i>
                    <span class=""menu-title"">Gelen Mesajlar</span>
                </a>
            </li>
             <li class=""nav-item"">
                <a class=""nav-link"" href=""/Address/Index"">
                    <i class=""mdi mdi-map menu-icon""></i>
                    <span class=""menu-title"">Adres Bilgileri</span>
                </a>
            </li>
             <li class=""nav-item"">
                <a class=""nav-link"" href=""/Im");
            WriteLiteral(@"age/Index"">
                    <i class=""mdi mdi-image menu-icon""></i>
                    <span class=""menu-title"">Görseller</span>
                </a>
            </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Report/Index"">
                <i class=""mdi mdi-file-document menu-icon""></i>
                <span class=""menu-title"">Raporlar</span>
            </a>
        </li>
               <li class=""nav-item"">
                <a class=""nav-link"" href=""/Admin/Index/"">
                    <i class=""mdi mdi-key menu-icon""></i>
                    <span class=""menu-title"">Admin İşlemleri</span>
                </a>
            </li>
             <li class=""nav-item"">
                <a class=""nav-link"" href=""/Profile/Index/"">
                    <i class=""mdi mdi-settings menu-icon""></i>
                    <span class=""menu-title"">Ayarlar</span>
                </a>
            </li>
            <li class=""nav-item"">
            <a class=""nav-link"" href=""/Default/Index"">
         ");
            WriteLiteral("           <i class=\"mdi mdi-exit-run menu-icon\"></i>\n                    <span class=\"menu-title\">Çıkış Yap</span>\n                </a>\n            </li>\n        </ul>\n    </nav>\n    <!-- partial -->\n    \n    <!-- main-panel ends -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591