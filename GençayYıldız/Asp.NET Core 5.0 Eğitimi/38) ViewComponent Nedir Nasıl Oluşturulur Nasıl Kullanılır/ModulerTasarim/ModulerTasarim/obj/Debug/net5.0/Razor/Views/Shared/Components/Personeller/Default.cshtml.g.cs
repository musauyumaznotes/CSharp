#pragma checksum "D:\GithubRepom\CSharp\Gençay Yıldız\Asp.NET Core 5.0 Eğitimi\38) Asp.NET Core 5.0 - ViewComponent Nedir Nasıl Oluşturulur Nasıl Kullanılır\ModulerTasarim\ModulerTasarim\Views\Shared\Components\Personeller\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33f43e53aaabe4d2ec7a32068393eae4818efd6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Personeller_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Personeller/Default.cshtml")]
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
#line 1 "D:\GithubRepom\CSharp\Gençay Yıldız\Asp.NET Core 5.0 Eğitimi\38) Asp.NET Core 5.0 - ViewComponent Nedir Nasıl Oluşturulur Nasıl Kullanılır\ModulerTasarim\ModulerTasarim\Views\_ViewImports.cshtml"
using ModulerTasarim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GithubRepom\CSharp\Gençay Yıldız\Asp.NET Core 5.0 Eğitimi\38) Asp.NET Core 5.0 - ViewComponent Nedir Nasıl Oluşturulur Nasıl Kullanılır\ModulerTasarim\ModulerTasarim\Views\_ViewImports.cshtml"
using ModulerTasarim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33f43e53aaabe4d2ec7a32068393eae4818efd6a", @"/Views/Shared/Components/Personeller/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebe8f1cfb77d553a087e3e705e8530ca525d159f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Personeller_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n<thead>\r\n                        <tr>\r\n                            <th scope=\"col\">Adı</th>\r\n                            <th scope=\"col\">Soyadı</th>\r\n                        </tr>\r\n</thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 11 "D:\GithubRepom\CSharp\Gençay Yıldız\Asp.NET Core 5.0 Eğitimi\38) Asp.NET Core 5.0 - ViewComponent Nedir Nasıl Oluşturulur Nasıl Kullanılır\ModulerTasarim\ModulerTasarim\Views\Shared\Components\Personeller\Default.cshtml"
         foreach (var personel in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                                <td>");
#nullable restore
#line 14 "D:\GithubRepom\CSharp\Gençay Yıldız\Asp.NET Core 5.0 Eğitimi\38) Asp.NET Core 5.0 - ViewComponent Nedir Nasıl Oluşturulur Nasıl Kullanılır\ModulerTasarim\ModulerTasarim\Views\Shared\Components\Personeller\Default.cshtml"
                               Write(personel.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 15 "D:\GithubRepom\CSharp\Gençay Yıldız\Asp.NET Core 5.0 Eğitimi\38) Asp.NET Core 5.0 - ViewComponent Nedir Nasıl Oluşturulur Nasıl Kullanılır\ModulerTasarim\ModulerTasarim\Views\Shared\Components\Personeller\Default.cshtml"
                               Write(personel.Soyadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                               \r\n                            </tr>\r\n");
#nullable restore
#line 18 "D:\GithubRepom\CSharp\Gençay Yıldız\Asp.NET Core 5.0 Eğitimi\38) Asp.NET Core 5.0 - ViewComponent Nedir Nasıl Oluşturulur Nasıl Kullanılır\ModulerTasarim\ModulerTasarim\Views\Shared\Components\Personeller\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>                  \r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
