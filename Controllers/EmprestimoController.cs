using Biblioteca.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace Biblioteca.Controllers
{
    
    public class EmprestimoController : Controller
    {
        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this);/* adicionado da video aula */
            LivroService livroService = new LivroService();
            EmprestimoService emprestimoService = new EmprestimoService();

            CadEmprestimoViewModel cadModel = new CadEmprestimoViewModel();
           
            cadModel.Livros = livroService.ListarDisponiveis();/* anteriormente cadModel.Livros = livroService.ListarTodos(); */
            return View(cadModel);
        }

        [HttpPost]
        public IActionResult Cadastro(CadEmprestimoViewModel viewModel)
     
       {
            if(!string.IsNullOrEmpty(viewModel.Emprestimo.NomeUsuario) ) /* adicionado da video aula */
            {   

                    EmprestimoService emprestimoService = new EmprestimoService();
            
                    if(viewModel.Emprestimo.Id == 0)
                    {
                        emprestimoService.Inserir(viewModel.Emprestimo);
                    }
                    else
                    {
                        emprestimoService.Atualizar(viewModel.Emprestimo);
                    }

                    return RedirectToAction("Listagem");
                }
                else
                {       
                    ViewData["mensagem"] = "Por favor, Preencha todos os campos";  

                    LivroService livroService = new LivroService();
                    EmprestimoService emprestimoService = new EmprestimoService();

                    CadEmprestimoViewModel cadModel = new CadEmprestimoViewModel();

                    cadModel.Livros = livroService.ListarDisponiveis();

                    return View(cadModel);
                }
        }   

            public IActionResult Listagem(string tipoFiltro, string filtro)
            {
                Autenticacao.CheckLogin(this);/* adicionado da video aula */
                FiltrosEmprestimos objFiltro = null;

                if(!string.IsNullOrEmpty(filtro))
                {
                    objFiltro = new FiltrosEmprestimos();
                    objFiltro.Filtro = filtro;
                    objFiltro.TipoFiltro = tipoFiltro;
                }

                EmprestimoService emprestimoService = new EmprestimoService();
                return View(emprestimoService.ListarTodos(objFiltro));
            }

            public IActionResult Edicao(int id)
            {
                Autenticacao.CheckLogin(this);/* adicionado da video aula */
                LivroService livroService = new LivroService();
                EmprestimoService em = new EmprestimoService();
                Emprestimo e = em.ObterPorId(id);

                CadEmprestimoViewModel cadModel = new CadEmprestimoViewModel();
                cadModel.Livros = livroService.ListarDisponiveis(); /* anteriormente cadModel.Livros = livroService.ListarTodos(); */
                cadModel.Livros.Add(livroService.ObterPorId(e.LivroId)); /* adicionado da video aula */
                cadModel.Emprestimo = e;
                
                return View(cadModel);
            }
     }
}