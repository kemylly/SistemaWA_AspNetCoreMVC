using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using desafio_mvc.Data;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace desafio_mvc.Controllers
{
    public class GftController : Controller
    {
        private readonly ApplicationDbContext database;
        private readonly IWebHostEnvironment webHostEnvironment;
        
        public GftController(ApplicationDbContext database, IWebHostEnvironment hostEnvironment)
        {
            this.database = database;
            webHostEnvironment = hostEnvironment;
        }

        [HttpPost]
        public IActionResult Editar(GftDTO gfttemporaria)
        {
            if(ModelState.IsValid)
            {
                var gfts = database.Gfts.First(v => v.Id == gfttemporaria.Id);
                gfts.Nome = gfttemporaria.Nome;
                gfts.Cep = gfttemporaria.Cep;
                gfts.Cidade = gfttemporaria.Cidade;
                gfts.Endereco = gfttemporaria.Endereco;
                gfts.Estado = gfttemporaria.Estado;
                gfts.Telefone = gfttemporaria.Telefone;
                //gfts.Foto = gfttemporaria.Foto;
                database.SaveChanges();
                return RedirectToAction("Gft", "wa");
            }
            else{
                return View("../wa/EditarGft");
            }
            
        }

        [HttpPost]
        [Authorize(Policy = "TipoAdm")]
        public IActionResult Deletar(int id)
        {
            if(id > 0)
            {
                var gft = database.Gfts.First(g => g.Id == id);
                gft.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Gft", "wa");
        }

        public async Task<IActionResult> Salvar(GftDTO gfttemporaria)
        {
            if (ModelState.IsValid)
            {
                string nomeUnicoArquivo = UploadedFile(gfttemporaria);
                Gft gfts = new Gft();

                    gfts.Nome = gfttemporaria.Nome;
                    gfts.Cep = gfttemporaria.Cep;
                    gfts.Cidade = gfttemporaria.Cidade;
                    gfts.Endereco = gfttemporaria.Endereco;
                    gfts.Estado = gfttemporaria.Estado;
                    gfts.Telefone = gfttemporaria.Telefone;
                    gfts.Foto = nomeUnicoArquivo;
                    gfts.Status = true;
                
                database.Gfts.Add(gfts);
                await database.SaveChangesAsync();
                return RedirectToAction("Gft", "wa");
            }
            return View("CadastrarGft", "wa");
        }

        private string UploadedFile(GftDTO model)
        {
            string nomeUnicoArquivo = null;
            if (model.Foto != null)
            {
                string pastaFotos = Path.Combine(webHostEnvironment.WebRootPath, "Imagens");
                nomeUnicoArquivo = Guid.NewGuid().ToString() + "_" + model.Foto.FileName;
                string caminhoArquivo = Path.Combine(pastaFotos, nomeUnicoArquivo);
                using (var fileStream = new FileStream(caminhoArquivo, FileMode.Create))
                {
                    model.Foto.CopyTo(fileStream);
                }
            }
            return nomeUnicoArquivo;
        }
    }
}