#pragma checksum "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_DashboardTablePartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "652c5fd96ac0ac3383da3e79bddd844c9b63eea7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__DashboardTablePartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_DashboardTablePartial/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_DashboardTablePartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"652c5fd96ac0ac3383da3e79bddd844c9b63eea7", @"/Views/Shared/Components/_DashboardTablePartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ffff724fe34f91470fb11811ab6f488238ce75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__DashboardTablePartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12 stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <p class=""card-title"">Son Mesajlar</p>
                <div class=""table-responsive"">
                    <table id=""recent-purchases-listing"" class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Ad Soyad</th>
                                <th>Mail</th>
                                <th>Tarih</th>
                                <th>Mesjaı Gör</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 20 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_DashboardTablePartial\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 23 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_DashboardTablePartial\Default.cshtml"
                                   Write(item.ContactID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 24 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_DashboardTablePartial\Default.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 25 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_DashboardTablePartial\Default.cshtml"
                                   Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 26 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_DashboardTablePartial\Default.cshtml"
                                   Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td><a href=\"#\" class=\"btn btn-primary\">Mesajı Gör</a></td>\n                                </tr>\n");
#nullable restore
#line 29 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_DashboardTablePartial\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591