#pragma checksum "D:\Andres Carpeta\U\diseno conceptual del software\proyectofintech\Prototipo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c878e10e161819adcbdce79885b437bdcb208900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Prototipo.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
#line 1 "D:\Andres Carpeta\U\diseno conceptual del software\proyectofintech\Prototipo\Pages\_ViewImports.cshtml"
using Prototipo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c878e10e161819adcbdce79885b437bdcb208900", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b387b50e884e560930cab4026cbe6897618240f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Andres Carpeta\U\diseno conceptual del software\proyectofintech\Prototipo\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<header class=""masthead text-white text-center"" style=""background: url(image/landing.jpg);background-size: cover;"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xl-9 align-self-center"" style=""height: 161px;width: 720px;"">
                <h1 class=""text-center mb-5"" style=""margin: 0px;margin-top: 48px;margin-bottom: 0px;height: auto;"">PROTOTIPO FINTECH</h1>
            </div>
            <div class=""col-auto mx-auto"" style=""width: auto;padding-right: 0px;padding-left: 0px;max-width: auto;margin: 0px;margin-right: 0px;margin-left: 0px;"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c878e10e161819adcbdce79885b437bdcb2089005113", async() => {
                WriteLiteral(@"
                    <h2 class=""sr-only"">Login Form</h2>
                    <div class=""form-group""><input class=""form-control"" type=""email"" name=""email"" placeholder=""Email""></div>
                    <div class=""form-group""><input type=""password"" class=""form-control"" name=""password"" placeholder=""Password"" /></div>
                    <div class=""form-group""><button class=""btn btn-primary btn-block"" type=""submit"" style=""background-color: #2c3134;border-color: #2c3134;"">Log In</button></div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""container"" style=""height: auto;margin: 0px;margin-left: 14.5px;margin-bottom: 0px;margin-right: 14.5px;width: auto;"">
        <div class=""row"" style=""margin: 0px;"">
            <div class=""col-auto"" style=""width: auto;padding: 0px;padding-right: 0px;background-color: rgba(255,255,255,0.33);margin: auto;margin-right: auto;margin-left: auto;"">
                <div class=""row"" style=""margin: 0px;"">
                    <div class=""col"">
                        <h3 style=""color: #2c3134;"">Tipo de cambio</h3>
                    </div>
                </div>
                <div class=""row"" style=""margin-right: 0px;margin-left: 0px;"">
                    <div class=""col"" style=""padding: 0px;"">
                        <div class=""row"" style=""margin: 0px;"">
                            <div class=""col"">
                                <h4 style=""color: #2c3134;"">Compra</h4>
                            </div>
                        </div>");
            WriteLiteral(@"
                        <div class=""row"" style=""margin: 0px;"">
                            <div class=""col"">
                                <h5 style=""color: #2c3134;""><strong>₡</strong>583.00</h5>
                            </div>
                        </div>
                    </div>
                    <div class=""col"" style=""padding: 0px;"">
                        <div class=""row"" style=""margin: 0px;"">
                            <div class=""col"">
                                <h4 style=""color: #2c3134;"">Venta</h4>
                            </div>
                        </div>
                        <div class=""row"" style=""margin: 0px;"">
                            <div class=""col"">
                                <h5 style=""color: #2c3134;""><strong>₡</strong>596.00</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</header>

<footer class=""footer bg-light");
            WriteLiteral(@""">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 my-auto h-100 text-center text-lg-left"">
                <ul class=""list-inline mb-2"">
                    <li class=""list-inline-item""><a href=""#"">Contacto</a></li>
                    <li class=""list-inline-item""><span>⋅</span></li>
                    <li class=""list-inline-item""><a href=""#"">Términos y condiciones</a></li>
                    <li class=""list-inline-item""></li>
                    <li class=""list-inline-item""></li>
                </ul>
                <p class=""text-muted small mb-4 mb-lg-0"">Diseño Conceptual del Software</p>
            </div>
            <div class=""col-lg-6 my-auto h-100 text-center text-lg-right"">
                <ul class=""list-inline mb-0"">
                    <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook fa-2x fa-fw""></i></a></li>
                    <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter fa-2x fa-fw""></i></a></li>");
            WriteLiteral("\r\n                    <li class=\"list-inline-item\"><a href=\"#\"><i class=\"fab fa-instagram fa-2x fa-fw\"></i></a></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</footer>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c878e10e161819adcbdce79885b437bdcb20890010583", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c878e10e161819adcbdce79885b437bdcb20890011623", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
