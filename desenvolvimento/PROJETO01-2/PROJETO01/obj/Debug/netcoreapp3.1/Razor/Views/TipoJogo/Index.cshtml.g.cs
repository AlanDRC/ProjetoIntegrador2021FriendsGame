#pragma checksum "C:\Users\040157\Desktop\PROJETO01-2\PROJETO01\Views\TipoJogo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7155d5c627a7413d6b9b8fecac7c5856d6e1bc8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoJogo_Index), @"mvc.1.0.view", @"/Views/TipoJogo/Index.cshtml")]
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
#line 1 "C:\Users\040157\Desktop\PROJETO01-2\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\040157\Desktop\PROJETO01-2\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7155d5c627a7413d6b9b8fecac7c5856d6e1bc8b", @"/Views/TipoJogo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a24eea2b15d20d16798ed9e4b0c9c93903b076", @"/Views/_ViewImports.cshtml")]
    public class Views_TipoJogo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROJETO01.Modelos.TipoJogos>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>\r\n    ");
#nullable restore
#line 4 "C:\Users\040157\Desktop\PROJETO01-2\PROJETO01\Views\TipoJogo\Index.cshtml"
Write(Model.codTipoJogo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n\r\n<h4>\r\n    ");
#nullable restore
#line 8 "C:\Users\040157\Desktop\PROJETO01-2\PROJETO01\Views\TipoJogo\Index.cshtml"
Write(Model.descrisaoTipoJogo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h4>\r\n\r\n\r\n    <div class=\"alert alert-warning\">\r\n        OOOHH NOO.\r\n    </div>\r\n\r\n\r\n<input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 217, "\"", 243, 1);
#nullable restore
#line 17 "C:\Users\040157\Desktop\PROJETO01-2\PROJETO01\Views\TipoJogo\Index.cshtml"
WriteAttributeValue("", 225, Model.codTipoJogo, 225, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n<br />\r\n<input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 296, "\"", 328, 1);
#nullable restore
#line 19 "C:\Users\040157\Desktop\PROJETO01-2\PROJETO01\Views\TipoJogo\Index.cshtml"
WriteAttributeValue("", 304, Model.descrisaoTipoJogo, 304, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n<br /><br />\r\n<button class=\"btn btn-block btn-success\">\r\n    SUCESSO!\r\n</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROJETO01.Modelos.TipoJogos> Html { get; private set; }
    }
}
#pragma warning restore 1591
