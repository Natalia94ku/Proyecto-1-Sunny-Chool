#pragma checksum "C:\Users\natal\Desktop\Aplicaciones Web\Sunny School\Sunny School\Pages\DatosAcademicos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f49ae41eff65a485f20dfdd6e6f730e87fe893a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Sunny_School.Pages.Pages_DatosAcademicos), @"mvc.1.0.razor-page", @"/Pages/DatosAcademicos.cshtml")]
namespace Sunny_School.Pages
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
#line 1 "C:\Users\natal\Desktop\Aplicaciones Web\Sunny School\Sunny School\Pages\_ViewImports.cshtml"
using Sunny_School;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f49ae41eff65a485f20dfdd6e6f730e87fe893a", @"/Pages/DatosAcademicos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22cf997ad1fdcc946fbe52b76a78607bc1fe7ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DatosAcademicos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bgcolor", new global::Microsoft.AspNetCore.Html.HtmlString("Black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\natal\Desktop\Aplicaciones Web\Sunny School\Sunny School\Pages\DatosAcademicos.cshtml"
  
    ViewData["Title"] = "DatosAcademicos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f49ae41eff65a485f20dfdd6e6f730e87fe893a3521", async() => {
                WriteLiteral("\r\n    <a class=\"navbar-brand\" href=\"DatosGenerales\">Datos Genreales</a>\r\n    <a class=\"navbar-brand\" href=\"DatosAcademicos\">Datos Academicos</a>\r\n    <a class=\"navbar-brand\" href=\"DatosFamiliares\">Datos Familiares</a>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""text-left side"">
    <h1 class=""display-4"">Datos Academicos</h1>

    <label for=""Escuela"">Escuela: </label>
    <input type=""text"" size=""50"" name=""Escuela"" />
    <br />
    <label for=""Nivel_escolar"">Nivel escolar: </label>
    <input type=""text"" size=""50"" name=""Nivel_escolar"" />
    <br />
    <label for=""Direccion"">Direccion: </label>
    <input type=""text"" size=""50"" name=""Direccion"" />
    <br />
    <label for=""Matricula"">Matricula: </label>
    <input type=""text"" size=""50"" name=""Matricula"" />
    <br />
    <label for=""Carrera"">Carrera: </label>
    <input type=""text"" size=""50"" name=""Carrera"" />
    <br />
    <label for=""Cuatrimestre"">Cuatrimestre: </label>
    <input type=""text"" size=""50"" name=""Cuatrimestre"" />
    <br />
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sunny_School.Pages.DatosAcademicosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sunny_School.Pages.DatosAcademicosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sunny_School.Pages.DatosAcademicosModel>)PageContext?.ViewData;
        public Sunny_School.Pages.DatosAcademicosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
