#pragma checksum "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1246eee249a1c05e0d6e71f474c50af573b533b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
#line 1 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1246eee249a1c05e0d6e71f474c50af573b533b9", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "15", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Empréstimos";
    string Classe = "";

    int FiltroPorPag = Int32.Parse(ViewData["emprestimoPorPag"].ToString());
    int PaginaAtual = Int32.Parse(ViewData["PaginaAtual"].ToString());

    int NumEmprestimoPorPag =(Model.Count<FiltroPorPag ? Model.Count : FiltroPorPag);

    int NumTotalDePag = 0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
     if(NumEmprestimoPorPag>0){
        NumTotalDePag = Model.Count / NumEmprestimoPorPag + (Model.Count%NumEmprestimoPorPag == 0 ? 0 : 1);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"row justify-content-md-center\">Listagem de Empréstimos</h1>\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1246eee249a1c05e0d6e71f474c50af573b533b96778", async() => {
                WriteLiteral("\n            <div class=\"form-group mb-2\">\n                <select name=\"TipoFiltro\" class=\"form-control\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1246eee249a1c05e0d6e71f474c50af573b533b97168", async() => {
                    WriteLiteral("Usuário");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1246eee249a1c05e0d6e71f474c50af573b533b98410", async() => {
                    WriteLiteral("Livro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group mb-2 mx-sm-3"">
                <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
            </div>

             <div class=""form-group col-2"">    
                <select name=""itensPorPagina"" id=""itensPorPagina"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1246eee249a1c05e0d6e71f474c50af573b533b99990", async() => {
                    WriteLiteral("10 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1246eee249a1c05e0d6e71f474c50af573b533b911234", async() => {
                    WriteLiteral("15 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1246eee249a1c05e0d6e71f474c50af573b533b912479", async() => {
                    WriteLiteral("30 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1246eee249a1c05e0d6e71f474c50af573b533b913724", async() => {
                    WriteLiteral("50 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1246eee249a1c05e0d6e71f474c50af573b533b914969", async() => {
                    WriteLiteral("Todos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                      WriteLiteral(Model.Count);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </select>\n            </div>  \n\n            <button type=\"submit\" class=\"btn btn-primary mb-2\">Pesquisar</button>\n       \n             <div class=\"form-group col-3\" id=\"SeletorPaginas\">\n                <span>Página:</span>\n");
#nullable restore
#line 44 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                 for (int i = 1; i <= NumTotalDePag; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span><a");
                BeginWriteAttribute("href", " href=\"", 1865, "\"", 1902, 2);
                WriteAttributeValue("", 1872, "/Livro/Listagem?PaginaAtual=", 1872, 28, true);
#nullable restore
#line 46 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 1900, i, 1900, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                                                              Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(",</a></span>\n");
#nullable restore
#line 47 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\n       \n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n\n\n\n        <table class=\"table table-striped\">\n");
#nullable restore
#line 60 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
             if (Model.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Usuario</th>
                        <th>Data Empréstimo</th>
                        <th>Data Devolução</th>
                        <th>Livro</th>
                        <th>Autor</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 74 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                     if (Model.Count > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                         foreach (Emprestimo e in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                             if ((System.DateTime.Compare(System.DateTime.Now, e.DataDevolucao) > 0))
                            {
                                Classe = "text-danger";
                            }
                            else
                            {
                                Classe = "";
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=\"", 3084, "\"", 3099, 1);
#nullable restore
#line 86 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 3092, Classe, 3092, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <td>");
#nullable restore
#line 87 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                               Write(e.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 88 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                               Write(e.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 89 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                               Write(e.DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 90 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                               Write(e.DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 91 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                               Write(e.Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 92 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                               Write(e.Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                \n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 3552, "\"", 3583, 2);
            WriteAttributeValue("", 3559, "/Emprestimo/Edicao/", 3559, 19, true);
#nullable restore
#line 94 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 3578, e.Id, 3578, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\n                            \n");
#nullable restore
#line 96 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                                 if(DateTime.Today >= @e.DataDevolucao)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"color: red\">ATRASADO</td>\n");
#nullable restore
#line 99 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                                }
                                else{
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                                     if(DateTime.Today <= @e.DataDevolucao){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"color: blue\">EMPRESTADO</td>\n");
#nullable restore
#line 103 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\n");
#nullable restore
#line 106 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </tbody>\n");
#nullable restore
#line 110 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Nenhum registro encontrado</p>\n");
#nullable restore
#line 114 "C:\Users\natha\Downloads\Pimpo\SENAC\Senac-UC-07 - Copia\Views\Emprestimo\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
