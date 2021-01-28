using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using desafio_mvc.Data;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace desafio_mvc.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly ApplicationDbContext database;
        private readonly IWebHostEnvironment webHostEnvironment;
        public FuncionariosController(ApplicationDbContext database, IWebHostEnvironment hostEnvironment)
        {
            this.database = database;
            webHostEnvironment = hostEnvironment;
        }

        [HttpPost]
        public async Task<IActionResult> Salvar(FuncionarioDTO funcTemporario)
        {
            if(ModelState.IsValid)
            {
                string nomeArquivo = UploadedFile(funcTemporario);
                Funcionario func = new Funcionario();

                func.Nome = funcTemporario.Nome;
                func.Matricula = funcTemporario.Matricula;
                func.Cargo = funcTemporario.Cargo;
                func.Inicio_wa = funcTemporario.Inicio_wa;
                func.Termino_wa = funcTemporario.Inicio_wa.AddDays(17);
                func.Gft_Id = database.Gfts.First(f => f.Id == funcTemporario.Gft_Id);
                func.Status = true;
                func.Level =  funcTemporario.Level;
                func.Foto = nomeArquivo;

                database.Funcionarios.Add(func);
                await database.SaveChangesAsync();

                Tecnologia tec = new Tecnologia();
                Funcionario_Tecnologia FunTec = new Funcionario_Tecnologia();

                //func.FuncTecnologia = database.Funcionario_Tecnologias.First(f => f.Id == funcTemporario.FuncTecnologia);
                FunTec.Funcionario = database.Funcionarios.First(f => f.Id == func.Id);
                FunTec.Tecnologia = database.Tecnologias.First(t => t.Id == funcTemporario.FuncTecnologia);
                
                database.Funcionario_Tecnologias.Add(FunTec);
                await database.SaveChangesAsync();

                return RedirectToAction("Funcionarios", "wa");
            }
            else{
                return View("../wa/Cadastrar");
            }
        }

        private string UploadedFile(FuncionarioDTO model)
        {
            string nomeArquivo = null;
            if (model.Foto != null)
            {
                string pastaFotos = Path.Combine(webHostEnvironment.WebRootPath, "Imagens2");
                nomeArquivo = Guid.NewGuid().ToString() + "_" + model.Foto.FileName;
                string caminhoArquivo = Path.Combine(pastaFotos, nomeArquivo);
                using (var fileStream = new FileStream(caminhoArquivo, FileMode.Create))
                {
                    model.Foto.CopyTo(fileStream);
                }
            }
            return nomeArquivo;
        }

        [HttpPost]
        public IActionResult Editar(FuncionarioDTO funcTemporario)
        {
            if(ModelState.IsValid)
            {
                var func = database.Funcionarios.First(f => f.Id == funcTemporario.Id);
                func.Nome = funcTemporario.Nome;
                func.Matricula = funcTemporario.Matricula;
                func.Cargo = funcTemporario.Cargo;
                func.Inicio_wa = funcTemporario.Inicio_wa;
                func.Termino_wa = funcTemporario.Inicio_wa.AddDays(17);
                func.Gft_Id = database.Gfts.First(f => f.Id == funcTemporario.Gft_Id);
                func.Level = funcTemporario.Level;
                
                database.SaveChanges();

                Funcionario_Tecnologia FunTec = new Funcionario_Tecnologia();
                FunTec.Funcionario = database.Funcionarios.First(f => f.Id == func.Id);
                FunTec.Tecnologia = database.Tecnologias.First(t => t.Id == funcTemporario.FuncTecnologia);
                
                database.SaveChanges();

                return RedirectToAction("Funcionarios", "wa");
            }
            else{
                return View("../wa/EditarFuncionario");
            }
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult Deletar(int id)
        {
            if(id > 0)
            {
                var func = database.Funcionarios.First(f => f.Id == id);
                func.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Funcionarios", "wa");
        }
    }
}