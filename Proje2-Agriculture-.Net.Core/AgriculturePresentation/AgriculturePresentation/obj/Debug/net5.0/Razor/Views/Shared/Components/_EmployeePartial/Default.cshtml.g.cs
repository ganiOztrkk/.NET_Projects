#pragma checksum "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_EmployeePartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b4889c30ec877eb41f6c4a87f964428601e54d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__EmployeePartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_EmployeePartial/Default.cshtml")]
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
#line 1 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_EmployeePartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b4889c30ec877eb41f6c4a87f964428601e54d1", @"/Views/Shared/Components/_EmployeePartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ffff724fe34f91470fb11811ab6f488238ce75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__EmployeePartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""team"" id=""team"">
    <div class=""container"">
        <h3 class=""tittle"">Ekip Arkadaşlarımız</h3>
        <p class=""heading-btm-w3ls"">Birbirinden farklı konularda oldukça donanımlı ekip arkadaşlarımız</p>
        <div class=""wthree_team_grids"">
");
#nullable restore
#line 8 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_EmployeePartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 wthree_team_grid\">\n                    <div class=\"hovereffect\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 491, "\"", 511, 1);
#nullable restore
#line 12 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_EmployeePartial\Default.cshtml"
WriteAttributeValue("", 497, item.ImageUrl, 497, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" \" class=\"img-responsive\" />\n                        <div class=\"overlay\">\n                            <div class=\"rotate\">\n                                <p class=\"group1\">\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 731, "\"", 754, 1);
#nullable restore
#line 16 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_EmployeePartial\Default.cshtml"
WriteAttributeValue("", 738, item.TwitterUrl, 738, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                        <i class=\"fa fa-twitter\"></i>\n                                    </a>\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 906, "\"", 930, 1);
#nullable restore
#line 19 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_EmployeePartial\Default.cshtml"
WriteAttributeValue("", 913, item.FacebookUrl, 913, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fa fa-facebook""></i>
                                    </a>
                                </p>
                                <hr>
                                <hr>
                                <p class=""group2"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1245, "\"", 1270, 1);
#nullable restore
#line 26 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_EmployeePartial\Default.cshtml"
WriteAttributeValue("", 1252, item.InstagramUrl, 1252, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                        <i class=\"fa fa-instagram\"></i>\n                                    </a>\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1424, "\"", 1447, 1);
#nullable restore
#line 29 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_EmployeePartial\Default.cshtml"
WriteAttributeValue("", 1431, item.WebsiteUrl, 1431, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fa fa-dribbble""></i>
                                    </a>
                                </p>
                            </div>
                        </div>
                    </div>
                    <h4>");
#nullable restore
#line 36 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_EmployeePartial\Default.cshtml"
                   Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                    <p>");
#nullable restore
#line 37 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_EmployeePartial\Default.cshtml"
                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n");
#nullable restore
#line 39 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_EmployeePartial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"clearfix\"> </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591