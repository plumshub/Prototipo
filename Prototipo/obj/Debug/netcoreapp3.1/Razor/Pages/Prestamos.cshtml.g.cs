#pragma checksum "C:\Users\josem\Desktop\Prototipo Diseno\Prototipo\Prototipo\Pages\Prestamos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f0044b443bb69c3edaf99860132c0cabe8cc9c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Prototipo.Pages.Pages_Prestamos), @"mvc.1.0.razor-page", @"/Pages/Prestamos.cshtml")]
namespace Prototipo.Pages
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
#line 1 "C:\Users\josem\Desktop\Prototipo Diseno\Prototipo\Prototipo\Pages\_ViewImports.cshtml"
using Prototipo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f0044b443bb69c3edaf99860132c0cabe8cc9c0", @"/Pages/Prestamos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b387b50e884e560930cab4026cbe6897618240f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Prestamos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\josem\Desktop\Prototipo Diseno\Prototipo\Prototipo\Pages\Prestamos.cshtml"
  

    ViewData["Title"] = "Prestamos";
    Layout = "_LayoutCliente";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<center>
    <h1>Prestamos</h1>
</center>
<hr size=""2"">
<br />

<div style=""border-bottom:1px solid rgba(10, 0, 0, .3);  height:50%;"">

    <center> <h2> No hay prestamos solicitados </h2></center>
    <br />
    <center> <button> Aplicar para prestamo </button> </center>
    <br />
    <br />
    <br />

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prototipo.Pages.PrestamosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Prototipo.Pages.PrestamosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Prototipo.Pages.PrestamosModel>)PageContext?.ViewData;
        public Prototipo.Pages.PrestamosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591