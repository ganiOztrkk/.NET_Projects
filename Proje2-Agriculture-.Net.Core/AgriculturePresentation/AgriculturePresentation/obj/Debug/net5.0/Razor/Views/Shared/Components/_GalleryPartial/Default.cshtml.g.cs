#pragma checksum "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48864e5b5c3564f417aa43a653568ec4e728e7ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__GalleryPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_GalleryPartial/Default.cshtml")]
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
#line 1 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48864e5b5c3564f417aa43a653568ec4e728e7ee", @"/Views/Shared/Components/_GalleryPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ffff724fe34f91470fb11811ab6f488238ce75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__GalleryPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Image>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""gallery"" id=""gallery"">
	<div class=""container"">
		<h3 class=""tittle"">Fotoğraf Galerisi</h3>
		<p class=""heading-btm-w3ls"">Organik ürünlerimiz ve bahçelerimizden görüntüler.</p>
		<div class=""agile_gallery_grids w3-agile"">
			<ul class=""clearfix demo"">
");
#nullable restore
#line 10 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
                 foreach (var item in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<li>\n\t\t\t\t\t<div class=\"gallery-grid1\">\n\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 404, "\"", 424, 1);
#nullable restore
#line 14 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
WriteAttributeValue("", 410, item.ImageUrl, 410, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" \" class=\"img-responsive\" />\n\t\t\t\t\t\t<div class=\"p-mask\">\n\t\t\t\t\t\t\t<h4><span>");
#nullable restore
#line 16 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\n\t\t\t\t\t\t\t<p>");
#nullable restore
#line 17 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n\t\t\t\t</li>\n");
#nullable restore
#line 21 "C:\Users\gani9\Documents\GitHub\.NET_Projects\Proje2-Agriculture-.Net.Core\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_GalleryPartial\Default.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</ul>\n\t\t</div>\n\t</div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Image>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591