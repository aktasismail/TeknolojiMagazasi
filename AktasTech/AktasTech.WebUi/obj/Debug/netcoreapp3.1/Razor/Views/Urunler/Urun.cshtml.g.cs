#pragma checksum "D:\Visual Studio\aktastech notemplate\AktasTech - Kopya2\AktasTech.WebUi\Views\Urunler\Urun.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f9b58799c05e2da97b96d5a40f03227ecc5b88a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Urunler_Urun), @"mvc.1.0.view", @"/Views/Urunler/Urun.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9b58799c05e2da97b96d5a40f03227ecc5b88a", @"/Views/Urunler/Urun.cshtml")]
    public class Views_Urunler_Urun : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AktasTech.WebUi.Models.UrunListeleme>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Visual Studio\aktastech notemplate\AktasTech - Kopya2\AktasTech.WebUi\Views\Urunler\Urun.cshtml"
  
    ViewData["Title"] = "Urun";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n\r\n    <div class=\"row panel pane-default\">\r\n");
#nullable restore
#line 11 "D:\Visual Studio\aktastech notemplate\AktasTech - Kopya2\AktasTech.WebUi\Views\Urunler\Urun.cshtml"
         foreach (var product in Model.Urunlers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 text-center\">\r\n                <img class=\"img-fluid img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 352, "\"", 373, 1);
#nullable restore
#line 14 "D:\Visual Studio\aktastech notemplate\AktasTech - Kopya2\AktasTech.WebUi\Views\Urunler\Urun.cshtml"
WriteAttributeValue("", 358, product.Gorsel, 358, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\"");
            BeginWriteAttribute("onclick", " onclick=\"", 386, "\"", 454, 3);
            WriteAttributeValue("", 396, "this.src=\'", 396, 10, true);
#nullable restore
#line 14 "D:\Visual Studio\aktastech notemplate\AktasTech - Kopya2\AktasTech.WebUi\Views\Urunler\Urun.cshtml"
WriteAttributeValue("", 406, product.Gorsel, 406, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 421, "\';this.height=500;this.width=500", 422, 33, true);
            EndWriteAttribute();
            BeginWriteAttribute("ondblclick", "\r\n ondblclick=\"", 455, "\"", 529, 4);
            WriteAttributeValue("", 470, "this.src=\'", 470, 10, true);
#nullable restore
#line 15 "D:\Visual Studio\aktastech notemplate\AktasTech - Kopya2\AktasTech.WebUi\Views\Urunler\Urun.cshtml"
WriteAttributeValue("", 480, product.Gorsel, 480, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 495, "\';this.width=100;", 495, 17, true);
            WriteAttributeValue(" ", 512, "this.height=100;", 513, 17, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <div><h2>");
#nullable restore
#line 16 "D:\Visual Studio\aktastech notemplate\AktasTech - Kopya2\AktasTech.WebUi\Views\Urunler\Urun.cshtml"
                    Write(product.UrunAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n                <div>");
#nullable restore
#line 17 "D:\Visual Studio\aktastech notemplate\AktasTech - Kopya2\AktasTech.WebUi\Views\Urunler\Urun.cshtml"
                Write(product.Stok);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>");
#nullable restore
#line 18 "D:\Visual Studio\aktastech notemplate\AktasTech - Kopya2\AktasTech.WebUi\Views\Urunler\Urun.cshtml"
                Write(product.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 21 "D:\Visual Studio\aktastech notemplate\AktasTech - Kopya2\AktasTech.WebUi\Views\Urunler\Urun.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AktasTech.WebUi.Models.UrunListeleme> Html { get; private set; }
    }
}
#pragma warning restore 1591
