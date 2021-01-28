using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using desafio_mvc.Data;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using Microsoft.AspNetCore.Authorization;

namespace desafio_mvc.Controllers
{
    [Authorize]
    public class waController : Controller
    {
        private readonly ApplicationDbContext database;
        public waController(ApplicationDbContext database)
        {
            this.database = database;
        }

        public IActionResult Index() //index
        {
            return View();
        }

        public IActionResult Funcionarios() //listar funcionarios
        {
            var funcionarios = database.Funcionarios.Include(f => f.Gft_Id).Include(t => t.FuncTecnologia).ThenInclude(te => te.Tecnologia).Where(p => p.Status == true).ToList();
            return View(funcionarios);
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult Cadastrar() //cadastrar funcionario no wa
        {
            ViewBag.Gfts = database.Gfts.Where(p => p.Status == true).ToList();
            ViewBag.FunTec = database.Funcionario_Tecnologias.ToList();
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            return View();
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult EditarFuncionario(int id) //editar funcionarios cadastrados
        {
            var fun = database.Funcionarios.First(f => f.Id == id);
            FuncionarioDTO funView = new FuncionarioDTO();

            funView.Id = fun.Id;
            funView.Nome = fun.Nome;
            funView.Matricula = fun.Matricula;
            funView.Cargo = fun.Cargo;
            funView.Inicio_wa = fun.Inicio_wa;
            funView.Termino_wa = fun.Termino_wa;
            funView.Level = fun.Level;
    
            ViewBag.Gfts = database.Gfts.Where(p => p.Status == true).ToList();
            ViewBag.FunTec = database.Funcionario_Tecnologias.ToList();
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            return View(funView);
        }

        [Authorize(Policy = "TipoUser")]
        public IActionResult PerfilFuncionario(int id) //lista cada funcionario
        {
            var fun = database.Funcionarios.First(f => f.Id == id);
            FuncionarioDTO funView = new FuncionarioDTO();

            funView.Id = fun.Id;
            funView.Nome = fun.Nome;
            funView.Matricula = fun.Matricula;
            funView.Cargo = fun.Cargo;
            funView.Inicio_wa = fun.Inicio_wa;
            funView.Termino_wa = fun.Termino_wa;
            //funView.Foto = fun.Foto;
    
            ViewBag.Gfts = database.Gfts.ToList();

            //var funcio = database.Funcionarios.Include(f => f.Gft_Id).ThenInclude(g => g.Nome).Include(t => t.FuncTecnologia).ThenInclude(te => te.Tecnologia).Where(p => p.Id == id).ToList();
            return View(funView);
        }

        public IActionResult Gft() //lista gfts
        {
            var gfts = database.Gfts.Where(g => g.Status == true).ToList();
            return View(gfts);
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult CadastrarGft() //cadastra uma gft
        {
            return View();
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult EditarGft(int id)
        {
            var gft = database.Gfts.First(g => g.Id == id);
            GftDTO gftView = new GftDTO();
            gftView.Id = gft.Id;
            gftView.Cep = gft.Cep;
            gftView.Cidade = gft.Cidade;
            gftView.Endereco = gft.Endereco;
            gftView.Estado = gft.Estado;
            gftView.Nome = gft.Nome;
            gftView.Telefone = gft.Telefone;
            //gftView.Foto = gft.Foto;
            return View(gftView);
        }

        //listar, ditar e cdastrar projetos
        public IActionResult Projetos()
        {
            var proj = database.Projetos.Where(p => p.Status == true).ToList();
            return View(proj);
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult CadastrarProjeto()
        {
            return View();
        }
        
        [Authorize(Policy = "TipoAdm")]
        public IActionResult EditarProjeto(int id)
        {
            var proj = database.Projetos.First(p => p.Id == id);
            ProjetoDTO projView = new ProjetoDTO();

            projView.Id = proj.Id;
            projView.Nome = proj.Nome;

            return View(projView);
        }

        public IActionResult Vagas() //lista as vagas
        {
            var vaga = database.Vagas.Include(v => v.ProjetoCad).Include(t => t.Tecnologias).ThenInclude(te => te.Tecnologia).Where(v => v.Qtd_vaga > 0 && v.Status == true).ToList();
            return View(vaga);
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult CadastrarVaga()  //cadastra vagas
        {
            ViewBag.Projetos = database.Projetos.Where(v => v.Status == true).ToList();
            ViewBag.VagTec = database.Vaga_Tecnologias.ToList();
            ViewBag.Tec = database.Tecnologias.ToList();
            return View();
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult EditarVaga(int id)
        {
            var vaga = database.Vagas.First(vag => vag.Id == id);
            VagaDTO vagaView = new VagaDTO();

            vagaView.Id = vaga.Id;
            vagaView.Abertura_vaga = vaga.Abertura_vaga;
            //vagaView.Codigo_vaga = vaga.Codigo_vaga;
            vagaView.Descricao_vaga = vaga.Descricao_vaga;
            //vagaView.Projeto = vaga.Projeto;
            vagaView.Qtd_vaga = vaga.Qtd_vaga;
            ViewBag.Projetos = database.Projetos.Where(v => v.Status == true).ToList();

            return View(vagaView);
        }

        public IActionResult Tecnologia() //listar tecnologia
        {
            var tec = database.Tecnologias.ToList();
            return View(tec);
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult CadastrarTecnologia() //cadastrar tecnologia
        {
            return View();
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult EditarTecnologia(int id) //editar tecnologia
        {
            var tec = database.Tecnologias.First(t => t.Id == id);
            TecnologiaDTO tecView = new TecnologiaDTO();
            tecView.Id = tec.Id;
            tecView.Nome = tec.Nome;
            
            return View(tecView);
        }

        public IActionResult Alocar() //alocacao
        {
            var alocar = database.Alocars.Include(a => a.FuncionarioID).ThenInclude(ao => ao.FuncTecnologia).ThenInclude(ac => ac.Tecnologia).Include(al => al.VagaID).ThenInclude(alo => alo.Tecnologias).ThenInclude(ar => ar.Tecnologia).ToList();
            //var alocar1 = database.Alocars.Include(a => a.FuncionarioID).ThenInclude(a => a.FuncTecnologia).ThenInclude(a => a.Tecnologia).Include(al => al.VagaID).ThenInclude(al => al.Tecnologias).ThenInclude(al => al.Tecnologia).Include(al => al.VagaID).ThenInclude(al => al.ProjetoCad).ThenInclude(al => al.Nome).ToList();
            return View(alocar);
        }

        [Authorize(Policy = "TipoAdm")]
        public IActionResult CadastrarAlocacao(int id)
        {
            var alo = database.Alocars.First(al => al.Id == id);
            AlocarDTO aloView = new AlocarDTO();
            aloView.Id = alo.Id;
            ViewBag.Funcionarios = database.Funcionarios.Where(v => v.Status == true).ToList();
            ViewBag.Vagas = database.Vagas.Where(v => v.Status == true).ToList();
            //ViewBag.Tec = database.Tecnologias.ToList();
            return View(aloView);
        }

        public IActionResult Historico() //historico
        {
            var funcionarios = database.Funcionarios.Include(f => f.Gft_Id).Include(t => t.FuncTecnologia).ThenInclude(te => te.Tecnologia).Include(al => al.Vaga_Id).ThenInclude(al => al.Tecnologias).ThenInclude(alr => alr.Tecnologia).Where(p => p.Status == false && p.Vaga_Id != null).ToList();
            return View(funcionarios);
        }
    }
}