#pragma checksum "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b83513403f158eed19b11bb24711cbe145d0c645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Resultados), @"mvc.1.0.view", @"/Views/Home/Resultados.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Resultados.cshtml", typeof(AspNetCore.Views_Home_Resultados))]
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
#line 1 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\_ViewImports.cshtml"
using sia;

#line default
#line hidden
#line 2 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\_ViewImports.cshtml"
using sia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b83513403f158eed19b11bb24711cbe145d0c645", @"/Views/Home/Resultados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b9a12ee0757dcc7bd35e0077c1a819dac32532", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Resultados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultadosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Carregar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
  
    ViewData["Title"] = "Resultados";
    

#line default
#line hidden
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
 if(Model != null && Model.ListaLojas != null && Model.ListaLojas.Any())
{
    // Dados de graficos de torta
    var XLabels = Newtonsoft.Json.JsonConvert.SerializeObject( Model.ListaLojas.OrderBy(x => x.Nome).Select( x => x.Nome ).ToList() );  
    var YValues = Newtonsoft.Json.JsonConvert.SerializeObject( Model.ListaLojas.OrderBy(x => x.Nome).Select( x => x.VendasTotais ).ToList() );
    var ZValues = Newtonsoft.Json.JsonConvert.SerializeObject( Model.ListaLojas.OrderBy(x => x.Nome).Select( x => x.ValorVendido ).ToList() );
    var valorDeVenda = new List<double>();
    foreach(var venda in Model.ListaLojas.OrderBy(x => x.Nome))
    {
        valorDeVenda.Add(venda.ValorVendido / venda.VendasTotais);
    }
    var TValues = Newtonsoft.Json.JsonConvert.SerializeObject(valorDeVenda);

    // Dados de graficos de barra
    var Anos = Newtonsoft.Json.JsonConvert.SerializeObject( Model.ResultadoAnual.Anos );
    var VendasAnuais = Newtonsoft.Json.JsonConvert.SerializeObject( Model.ResultadoAnual.VendasAnuais );
    var ValoresAnuais = Newtonsoft.Json.JsonConvert.SerializeObject( Model.ResultadoAnual.ValoresAnuais );

    // Hraficos de tipo


#line default
#line hidden
            BeginContext(1259, 256, true);
            WriteLiteral(@"    <table id=""tabela"" class=""table table-responsive"">
        <thead>
            <tr>
                <th>Loja</th>
                <th>Valor Vendido</th>
                <th>Vendas Totais</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 36 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
             foreach(var item in Model.ListaLojas)
            {

#line default
#line hidden
            BeginContext(1582, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1629, 9, false);
#line 39 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1638, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1670, 17, false);
#line 40 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                   Write(item.ValorVendido);

#line default
#line hidden
            EndContext();
            BeginContext(1687, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1719, 17, false);
#line 41 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                   Write(item.VendasTotais);

#line default
#line hidden
            EndContext();
            BeginContext(1736, 33, true);
            WriteLiteral("</td>\r\n                </tr>   \r\n");
            EndContext();
#line 43 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
            }

#line default
#line hidden
            BeginContext(1784, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
            BeginContext(1818, 164, true);
            WriteLiteral("    <div class=\"chart-container col-md-4\">\r\n        <p>Vendas Totais</p>\r\n        <canvas id=\"chart-vendas\" style=\"width:100%; height:500px\"></canvas>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1984, 165, true);
            WriteLiteral("    <div class=\"chart-container col-md-4\">\r\n        <p>Vendas por Loja</p>\r\n        <canvas id=\"chart-lojas\" style=\"width:100%; height:500px\"></canvas>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2151, 173, true);
            WriteLiteral("    <div class=\"chart-container col-md-4\">\r\n        <p>Média de valor de venda</p>\r\n        <canvas id=\"chart-media\" style=\"width:100%; height:500px\"></canvas>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2326, 171, true);
            WriteLiteral("    <div class=\"chart-container col-md-4\">\r\n        <p>Vendas Anuais</p>\r\n        <canvas id=\"chart-vendas-anuais\" style=\"width:100%; height:500px\"></canvas>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2499, 173, true);
            WriteLiteral("    <div class=\"chart-container col-md-4\">\r\n        <p>Valores Anuais</p>\r\n        <canvas id=\"chart-valores-anuais\" style=\"width:100%; height:500px\"></canvas>\r\n    </div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2699, 319, true);
                WriteLiteral(@"
        <script>
            // $(document).ready(function () {
            //     $('#tabela').dataTable( {} );  
            // });
            jQuery(document).ready(function($){
                $('#tabela').dataTable( {} );  

                //Inicio chart

                gerarGrafico(""chart-vendas"", ");
                EndContext();
                BeginContext(3019, 17, false);
#line 82 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                                        Write(Html.Raw(XLabels));

#line default
#line hidden
                EndContext();
                BeginContext(3036, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(3039, 17, false);
#line 82 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                                                            Write(Html.Raw(YValues));

#line default
#line hidden
                EndContext();
                BeginContext(3056, 60, true);
                WriteLiteral(", \"doughnut\");\r\n                gerarGrafico(\"chart-lojas\", ");
                EndContext();
                BeginContext(3117, 17, false);
#line 83 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                                       Write(Html.Raw(XLabels));

#line default
#line hidden
                EndContext();
                BeginContext(3134, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(3137, 17, false);
#line 83 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                                                           Write(Html.Raw(ZValues));

#line default
#line hidden
                EndContext();
                BeginContext(3154, 60, true);
                WriteLiteral(", \"doughnut\");\r\n                gerarGrafico(\"chart-media\", ");
                EndContext();
                BeginContext(3215, 17, false);
#line 84 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                                       Write(Html.Raw(XLabels));

#line default
#line hidden
                EndContext();
                BeginContext(3232, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(3235, 17, false);
#line 84 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                                                           Write(Html.Raw(TValues));

#line default
#line hidden
                EndContext();
                BeginContext(3252, 69, true);
                WriteLiteral(", \"doughnut\");\r\n                gerarGrafico(\"chart-valores-anuais\", ");
                EndContext();
                BeginContext(3322, 14, false);
#line 85 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                                                Write(Html.Raw(Anos));

#line default
#line hidden
                EndContext();
                BeginContext(3336, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(3339, 23, false);
#line 85 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                                                                 Write(Html.Raw(ValoresAnuais));

#line default
#line hidden
                EndContext();
                BeginContext(3362, 64, true);
                WriteLiteral(", \"line\");\r\n                gerarGrafico(\"chart-vendas-anuais\", ");
                EndContext();
                BeginContext(3427, 14, false);
#line 86 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                                               Write(Html.Raw(Anos));

#line default
#line hidden
                EndContext();
                BeginContext(3441, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(3444, 22, false);
#line 86 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
                                                                Write(Html.Raw(VendasAnuais));

#line default
#line hidden
                EndContext();
                BeginContext(3466, 3257, true);
                WriteLiteral(@", ""line"");

                //Fim chart
                });


            function Shuffle(o) {
	            for(var j, x, i = o.length; i; j = parseInt(Math.random() * i), x = o[--i], o[i] = o[j], o[j] = x);
	            return o;
            };
            
            function gerarGrafico(container, labels, values, tipo){                
                var ctx = document.getElementById(container).getContext('2d');  
                var backColors = [  
                    'rgba(255, 99, 132)',  
                    'rgba(54, 162, 235)', 
                    'rgba(255, 206, 86)',  
                    'rgba(75, 192, 192)',  
                    'rgba(153, 102, 255)',  
                    'rgba(255, 159, 64)',  
                    'rgba(255, 0, 0)',  
                    'rgba(0, 255, 0)',  
                    'rgba(0, 0, 255)',  
                    'rgba(192, 192, 192)',  
                    'rgba(255, 255, 0)',  
                    'rgba(255, 0, 255)' 
                ]
 ");
                WriteLiteral(@"               var data = {  
                    labels: labels,  
                    datasets: [{  
                        label: ""Gráfico"",  
                        backgroundColor: backColors,  
                        borderColor: [  
                            'rgba(255,99,132,1)',  
                            'rgba(54, 162, 235, 1)',  
                            'rgba(255, 206, 86, 1)',  
                            'rgba(75, 192, 192, 1)',  
                            'rgba(153, 102, 255, 1)',  
                            'rgba(255, 159, 64, 1)',  
                            'rgba(255, 0, 0)',  
                            'rgba(0, 255, 0)',  
                            'rgba(0, 0, 255)',  
                            'rgba(192, 192, 192)',  
                            'rgba(255, 255, 0)',  
                            'rgba(255, 0, 255)'  
                        ],  
                        borderWidth: 1,  
                        data: values  
                    }");
                WriteLiteral(@"]  
                };
                var options = {  
                    maintainAspectRatio: true,  
                    scales: {  
                        yAxes: [{  
                            ticks: {  
                                min: 0,  
                                beginAtZero: true  
                            },  
                            gridLines: {  
                                display: false,  
                                color: ""rgba(255,99,164,0.2)""  
                            }  
                        }],  
                        xAxes: [{  
                            ticks: {  
                                min: 0,  
                                beginAtZero: true  
                            },  
                            gridLines: {  
                                display: false  
                            }  
                        }]  
                    }  
                };  

                var myChart = new  Ch");
                WriteLiteral("art(ctx, {  \r\n                    options: options,  \r\n                    data: data,  \r\n                    type: tipo  \r\n                });\r\n            }\r\n\r\n        </script>\r\n    ");
                EndContext();
            }
            );
#line 169 "C:\Users\hadagalberto.junior\Source\Repos\Atividade-SIA\Views\Home\Resultados.cshtml"
     
}

#line default
#line hidden
            BeginContext(6729, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6731, 246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d940d4e5cda64271aa2b7373ab30bce4", async() => {
                BeginContext(6801, 169, true);
                WriteLiteral("\r\n    <input type=\"file\" name=\"files\" class=\"form-control list-group-item\" value=\"Anexo\" multiple />\r\n    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultadosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
