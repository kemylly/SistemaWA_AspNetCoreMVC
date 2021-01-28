using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using desafio_mvc.Data;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using Microsoft.AspNetCore.Authorization;

namespace desafio_mvc.Controllers
{
    public class ProjetoController : Controller
    {
        private readonly ApplicationDbContext database;
        public ProjetoController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(ProjetoDTO projTemp)
        {
            if(ModelState.IsValid)
            {
                Projeto proj = new Projeto();

                proj.Nome = projTemp.Nome;
                proj.Status = true;

                database.Projetos.Add(proj);
                database.SaveChanges();

                return RedirectToAction("Projetos", "wa");
            }
            else{
                return View("../wa/CadastrarProjeto");
            }
            
        }

        [HttpPost]
        public IActionResult Editar(ProjetoDTO projTemp)
        {
            if(ModelState.IsValid)
            {
                var proj = database.Projetos.First(p => p.Id == projTemp.Id);

                proj.Nome = projTemp.Nome;

                database.SaveChanges();

                return RedirectToAction("Projetos", "wa");
            }
            else{
                return View("../wa/CadastrarProjeto");
            }
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult Deletar (int id)
        {
            if(id > 0)
            {
                var proj = database.Projetos.First(p => p.Id == id);
                proj.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Projetos", "wa");
        }
    }
}