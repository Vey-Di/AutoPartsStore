#pragma checksum "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\Home\PartsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13e762a74b755e723cea8a6f641329340910b49f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PartsList), @"mvc.1.0.view", @"/Views/Home/PartsList.cshtml")]
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
#line 1 "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\_ViewImports.cshtml"
using AutoPartsStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\_ViewImports.cshtml"
using AutoPartsStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13e762a74b755e723cea8a6f641329340910b49f", @"/Views/Home/PartsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"321441080f569f5ce2bc5f94b010101acd847bb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PartsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutoPartsStore.Models.ViewModels.PartListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Title</th>\r\n            <th>Quantity</th>\r\n            <th>Price</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\Home\PartsList.cshtml"
         foreach (var part in Model.Parts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 15 "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\Home\PartsList.cshtml"
               Write(part.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 16 "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\Home\PartsList.cshtml"
               Write(part.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 17 "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\Home\PartsList.cshtml"
               Write(part.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 452, "\"", 494, 2);
            WriteAttributeValue("", 459, "/Home/PartShow/?partId=", 459, 23, true);
#nullable restore
#line 18 "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\Home\PartsList.cshtml"
WriteAttributeValue("", 482, part.PartId, 482, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">More info</a></td>\r\n                <td>\r\n");
#nullable restore
#line 20 "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\Home\PartsList.cshtml"
                     using (Html.BeginForm("AddToCart", "Cart"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 671, "\"", 691, 1);
#nullable restore
#line 22 "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\Home\PartsList.cshtml"
WriteAttributeValue("", 679, part.PartId, 679, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"PartId\" />\r\n");
#nullable restore
#line 23 "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\Home\PartsList.cshtml"
                   Write(Html.Hidden("returnUrl", "/Home/Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"submit\" value=\"+ Add to Cart\" class=\"btn btn-secondary\" />\r\n");
#nullable restore
#line 25 "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\Home\PartsList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "D:\AutoPartsStore\AutoPartsStore\AutoPartsStore\Views\Home\PartsList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutoPartsStore.Models.ViewModels.PartListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
