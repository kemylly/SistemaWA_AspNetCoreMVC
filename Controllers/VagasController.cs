using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using desafio_mvc.Data;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace desafio_mvc.Controllers
{
    public class VagasController : Controller
    {
        private readonly ApplicationDbContext database;
        public VagasController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(VagaDTO vagaTemporaria)
        {
            if(ModelState.IsValid)
            {
                //gerar um numerico raleatorio para o codigo da vaga
                Vaga vaga = new Vaga();
                Random r = new Random();
                int codigo = r.Next(1000000);
                
                vaga.Abertura_vaga = vagaTemporaria.Abertura_vaga;
                vaga.Codigo_vaga = codigo.ToString();
                vaga.Descricao_vaga = vagaTemporaria.Descricao_vaga;
                vaga.ProjetoCad = database.Projetos.First(v => v.Id == vagaTemporaria.ProjetoCad);
                vaga.Qtd_vaga = vagaTemporaria.Qtd_vaga;
                vaga.Status = true;
                //vaga.Tecnologias = vagaTemporaria.

                database.Vagas.Add(vaga);
                database.SaveChanges();

                Tecnologia tec = new Tecnologia();
                Vaga_Tecnologia VagTec = new Vaga_Tecnologia();

                VagTec.Vaga = database.Vagas.First(v => v.Id == vaga.Id);
                VagTec.Tecnologia = database.Tecnologias.First(t => t.Id == vagaTemporaria.Tecnologias);
                
                database.Vaga_Tecnologias.Add(VagTec);
                database.SaveChanges();

                return RedirectToAction("Vagas", "wa");
            }
            else{
                //return Content("Erro");
                return View("../wa/CadastrarVaga");
            }
        }

        [HttpPost]
        public IActionResult Editar(VagaDTO vagaTemporaria)
        {
             if(ModelState.IsValid)
            {
                var vaga = database.Vagas.First(v => v.Id == vagaTemporaria.Id);
                vaga.Abertura_vaga = vagaTemporaria.Abertura_vaga;
                //vaga.Codigo_vaga = vagaTemporaria.Codigo_vaga;
                vaga.Descricao_vaga = vagaTemporaria.Descricao_vaga;
                vaga.ProjetoCad = database.Projetos.First(v => v.Id == vagaTemporaria.ProjetoCad);
                vaga.Qtd_vaga = vagaTemporaria.Qtd_vaga;
                database.SaveChanges();
                return RedirectToAction("Vagas", "wa");
            }
            else{
                return View("../wa/EditarVaga");
            }
        }

        
        // public IActionResult Deletar(int id)
        // {
        //     if(id > 0)
        //     {
        //         Vaga vaga = database.Vagas.First(v => v.Id == id);
        //         database.Vagas.Remove(vaga);
        //         database.SaveChanges();
        //     }
        //     return RedirectToAction("Vagas", "wa");
        // }

        [Authorize(Policy = "TipoAdm")]
         public IActionResult Deletar(int id)
        {
            if(id > 0)
            {
                var vaga = database.Vagas.First(va => va.Id == id);
                vaga.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Vagas", "wa");
        }
    }
}