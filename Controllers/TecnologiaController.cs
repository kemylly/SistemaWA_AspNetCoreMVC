using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using desafio_mvc.Data;
using desafio_mvc.DTO;
using desafio_mvc.Models;

namespace desafio_mvc.Controllers
{
    public class TecnologiaController : Controller
    {
        private readonly ApplicationDbContext database;
        public TecnologiaController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(TecnologiaDTO tecTemporario)
        {
            if(ModelState.IsValid)
            {
                Tecnologia tec = new Tecnologia();
                tec.Nome = tecTemporario.Nome;

                database.Tecnologias.Add(tec);
                database.SaveChanges();
                return RedirectToAction("Tecnologia", "wa");
            }
            else{
                return View("../wa/CadastrarTecnologia");
            }
        }
        [HttpPost]
        public IActionResult Editar(TecnologiaDTO tecTemporario)
        {
            if(ModelState.IsValid)
            {
                var tec = database.Tecnologias.First(t => t.Id == tecTemporario.Id);
                tec.Nome = tecTemporario.Nome;

                database.SaveChanges();
                return RedirectToAction("Tecnologia", "wa");
            }
            else{
                return View("../wa/EditarTecnologia");
            }
           
        }
    }
}