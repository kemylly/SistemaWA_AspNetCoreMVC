using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using desafio_mvc.Data;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace desafio_mvc.Controllers
{
    public class AlocacaoController : Controller
    {
        private readonly ApplicationDbContext database;
        public AlocacaoController(ApplicationDbContext database)
        {
            this.database = database;
        }

        public IActionResult Alocar(AlocarDTO aloTemp) //botao de alocar
        {
                var alo = database.Alocars.First(a => a.Id == aloTemp.Id);
            
                //pegar o id de funcionario e guardar sua vaga e seu status
                Funcionario func = new Funcionario();
            
                var func2 = database.Funcionarios.First(f => f.Id == aloTemp.FuncionarioID);
                func2.Vaga_Id = database.Vagas.First(v => v.Id == aloTemp.VagaID);
                func2.Status = false;
                database.SaveChanges();

                //diminuir a quantidade de vagas
                var vaga = database.Vagas.FirstOrDefault(v => v.Id == aloTemp.VagaID);
                vaga.Qtd_vaga = vaga.Qtd_vaga - 1;
                database.SaveChanges();

                
            return RedirectToAction("Alocar", "wa");
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult Sugestao()
        {
            Alocar alo = new Alocar();
            //gera sugestoes de possiveis alocacoes
            var funcionarios = database.Funcionarios.Include(t => t.FuncTecnologia).ThenInclude(te => te.Tecnologia).Where(p => p.Status == true).ToList();
            var vagas = database.Vagas.Include(t => t.Tecnologias).ThenInclude(te => te.Tecnologia).Where(p => p.Status == true).ToList();
            foreach (var fun in funcionarios)
            {
                //int funcid = fun.Id;
                foreach (var ftec in fun.FuncTecnologia.Select(f => f.Tecnologia))
                {
                    foreach(var vag in vagas)
                    {
                        //int vagaid = vag.Id;
                        foreach (var vtec in vag.Tecnologias.Select(f => f.Tecnologia))
                        {
                            if(ftec.Nome.ToUpper() == vtec.Nome.ToUpper() && fun.Cargo.ToUpper() == vag.Descricao_vaga.ToUpper())
                            {
                                alo.VagaID = database.Vagas.First(v => v.Id == vag.Id);
                                alo.FuncionarioID = database.Funcionarios.First(f => f.Id == fun.Id);
                                database.Alocars.Add(alo);
                                database.SaveChanges();
                            }
                        }
                    }
                }
            }
            return RedirectToAction("Alocar", "wa");
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult Dispensar(int id)
        {
            //dispensar uma sugestao
            Alocar alocar = database.Alocars.First(alo => alo.Id == id);
            database.Alocars.Remove(alocar);
            database.SaveChanges();
            return RedirectToAction("Alocar", "wa");
        }
    }
}