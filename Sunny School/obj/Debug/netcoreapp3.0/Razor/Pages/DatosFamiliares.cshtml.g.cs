#pragma checksum "C:\Users\natal\Desktop\Aplicaciones Web\Sunny School\Sunny School\Pages\DatosFamiliares.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a41e455672bfd98e055615dfdffa15abf45bc551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Sunny_School.Pages.Pages_DatosFamiliares), @"mvc.1.0.razor-page", @"/Pages/DatosFamiliares.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a41e455672bfd98e055615dfdffa15abf45bc551", @"/Pages/DatosFamiliares.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22cf997ad1fdcc946fbe52b76a78607bc1fe7ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DatosFamiliares : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bgcolor", new global::Microsoft.AspNetCore.Html.HtmlString("black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\natal\Desktop\Aplicaciones Web\Sunny School\Sunny School\Pages\DatosFamiliares.cshtml"
  
    ViewData["Title"] = "DatosFamiliares";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a41e455672bfd98e055615dfdffa15abf45bc5513521", async() => {
                WriteLiteral("\r\n        <a class=\"navbar-brand\" href=\"DatosGenerales\">Datos Genreales</a>\r\n        <a class=\"navbar-brand\" href=\"DatosAcademicos\">Datos Academicos</a>\r\n        <a class=\"navbar-brand\" href=\"DatosFamiliares\">Datos Familiares</a>\r\n    ");
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
        <div class=""text-justify"">
            <h1 class=""display-4"">Datos Familiares</h1>
            <br />
            <div class=""text-left side"">
                <h2>Datos del tutor</h2>
            </div>
            <br />

            <label for=""Nombre_Tutor"">Nombre del tutor: </label>
            <input type=""text""  name=""nombre"" />
            <br />
            <label for=""Apellido_paterno"">Apellido Paterno: </label>
            <input type=""text""  name=""Apellido_paterno"" />
            <br />
            <label for=""Apellido_materno"">Apellido materno: </label>
            <input type=""text"" name=""Apellido_maetrno"" />
            <br />
            <label for=""Fecha_nacimiento"">Fecha de nacimiento: </label>
            <input type=""text"" name=""Fecha_nacimiento"" />
            <br />
            <label for=""Nacionalidad"">Nacionalidad: </label>
            <input type=""text""  name=""Nacionalidad"" />
            <br />
            <label for=""Ocupacion"">Ocupacion: </label>
  ");
            WriteLiteral(@"          <input type=""text""  name=""Ocupacion"" />
            <br />
            <label for=""Ingresos"">Ingresos: </label>
            <input type=""text"" name=""Ingresos"" />
            <br />
            <label for=""Telefono"">Telefono: </label>
            <input type=""text""  name=""Telefono"" />
            <br />
            <div class=""text-left side"">
                <h3>Datos del la madre</h3>
            </div>
            <br />
            <label for=""Nombre_Madre"">Nombre de la madre: </label>
            <input type=""text"" name=""nombre de la madre"" />
            <br />
            <label for=""Apellido_paterno"">Apellido Paterno: </label>
            <input type=""text"" name=""Apellido_paterno"" />
            <br />
            <label for=""Apellido_materno"">Apellido materno: </label>
            <input type=""text"" name=""Apellido_maetrno"" />
            <br />
            <label for=""Fecha_nacimiento"">Fecha de nacimiento: </label>
            <input type=""text"" name=""Fecha_nacimiento"" ");
            WriteLiteral(@"/>
            <br />
            <label for=""Nacionalidad"">Nacionalidad: </label>
            <input type=""text"" name=""Nacionalidad"" />
            <br />
            <label for=""Ocupacion"">Ocupacion: </label>
            <input type=""text"" name=""Ocupacion"" />
            <br />
            <label for=""Telefono"">Telefono: </label>
            <input type=""text"" name=""Telefono"" />
            <br />
            <div class=""text-left side"">
                <h4>Datos de los padres</h4>
            </div>
            <br />
            <label for=""Domicilio_padres"">Domicilio de los padres: </label>
            <input type=""text"" name=""Ingresos"" />
            <br />
            <label for=""Municipio"">Municipio: </label>
            <input type=""text"" name=""municipio"" />
            <br />
            <label for=""colonia"">Colonia: </label>
            <input type=""text"" name=""Colonia"" />
            <br />
            <label for=""Comunidad"">Comunidad: </label>
            <input type=""tex");
            WriteLiteral("t\" name=\"Comunidad\" />\r\n            <br />\r\n            <label for=\"Estado_civil\">Estado Civil: </label>\r\n            <input type=\"text\" name=\"estado civil\" />\r\n            <br />\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sunny_School.Pages.DatosFamiliaresModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sunny_School.Pages.DatosFamiliaresModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sunny_School.Pages.DatosFamiliaresModel>)PageContext?.ViewData;
        public Sunny_School.Pages.DatosFamiliaresModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
