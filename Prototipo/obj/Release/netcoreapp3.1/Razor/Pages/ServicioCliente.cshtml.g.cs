#pragma checksum "C:\Users\josem\Desktop\Prototipo Diseno\Prototipo\Prototipo\Pages\ServicioCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c05d49843fe7e55e721a49f1e7f763872bd86cf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Prototipo.Pages.Pages_ServicioCliente), @"mvc.1.0.razor-page", @"/Pages/ServicioCliente.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c05d49843fe7e55e721a49f1e7f763872bd86cf3", @"/Pages/ServicioCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b387b50e884e560930cab4026cbe6897618240f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ServicioCliente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\josem\Desktop\Prototipo Diseno\Prototipo\Prototipo\Pages\ServicioCliente.cshtml"
  
    ViewData["Title"] = "RecursosHumanos";
    Layout = "_ServicioCliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c05d49843fe7e55e721a49f1e7f763872bd86cf33327", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>
        * {
            box-sizing: border-box;
        }

        .column {
            float: left;
            width: 25%;
            padding: 10px;
            height: 50px;
            margin-left: 50px;
            border: 1px solid black;
            width: 180px;
        }

        .row:after {
            content: """";
            display: table;
            clear: both;
        }

        .row {
            margin: auto;
            text-align: left;
            width: 1000px;
        }

        #buttons {
            float: left;
            width: 200px;
            margin-left: 50px;
            margin-top: 20px;
        }
        #mi{
            margin-left: 200px;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c05d49843fe7e55e721a49f1e7f763872bd86cf35133", async() => {
                WriteLiteral(@"
    <h1>Servicio al Cliente</h1>
    <h2 id=""mi"">Tickets</h2>
    <div id=""wrapper"" class=""row"">
        <div class=""column"" style=""        background-color: #bbb;"">
            <h2>ID </h2>
        </div>
        <div class=""column"" style=""background-color: #bbb;"">
            <h2>Nombre</h2>
        </div>
        <div class=""column"" style=""background-color: #bbb;"">
            <h2>Correo</h2>
        </div>
        <div class=""column"" style=""        background-color: #bbb;"">
            <p># Telefono</p>
        </div>
        <!--column-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>2</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Jose</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Jose@gmail.com</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>654651651</p>
    ");
                WriteLiteral(@"    </div>
        <!--column-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>3</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Daniel</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Daniel@gmail.com</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>658484684</p>
        </div>
        <!--column-->
        <!--column-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>4</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Carmen</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>carmen@gmail.com</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>89894897</p>
        </div>
");
                WriteLiteral(@"        <!--column-->
        <!--column-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>5</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Garmio</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>garmio@gmail.com</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>8994984895</p>
        </div>
        <!--column-->
        <!--column-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>6</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Andres</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>andres@gmail.com</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>88898548</p>
    ");
                WriteLiteral(@"    </div>
        <!--column-->
        <!--column-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>7</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Andres</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>andres@gmail.com</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>88898548</p>
        </div>
        <!--column-->
        <!--column-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>8</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Andres</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>andres@gmail.com</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>88898548");
                WriteLiteral("</p>\r\n        </div>\r\n        </div>\r\n        <!--column-->\r\n        \r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prototipo.Pages.ServicioClienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Prototipo.Pages.ServicioClienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Prototipo.Pages.ServicioClienteModel>)PageContext?.ViewData;
        public Prototipo.Pages.ServicioClienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
