using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using desafio_mvc.Data;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using desafio_mvc.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Security.Claims;

namespace desafio_mvc.Controllers
{
    public class PopularController : Controller
    {
        private readonly ApplicationDbContext database;
        //private readonly UserManager<IdentityUser> _userManager;
    
        public PopularController(ApplicationDbContext database)
        {
            this.database = database;
        }

        public IActionResult Popular(){
            //registrar um login
            // var user = await _userManager.GetUserAsync(User);

            // var user1 = new IdentityUser { UserName = user.Email="kemyllycavalcante@gmail.com", Email = user.Email="kemyllycavalcante@gmail.com" };
            // var result = await _userManager.CreateAsync(user1, user.PasswordHash);

            // user.Email = "kemyllycavalcante@gmail.com";
            // user.EmailConfirmed = true;
            // user.UserName = "kemyllycavalcante@gmail.com";

            //cadastrar gft
            Gft gft = new Gft(); //gft alphaville
            gft.Cep = "06454-000";
            gft.Cidade = "Barueri";
            gft.Estado = "SP";
            gft.Nome = "GFT Brasil - Alphaville";
            gft.Status = true;
            gft.Telefone = "+55 11 2176-3253";
            gft.Endereco = "Alameda Rio Negro, n° 585 Ed. Padauiri, 10° andar - Alphaville";
            //gft.Foto = "";

            database.Gfts.Add(gft);
            database.SaveChanges();

            Gft gft1 = new Gft(); //gft sorocaba
            gft1.Cep = "18095-450";
            gft1.Cidade = "Sorocaba";
            gft1.Estado = "SP";
            gft1.Nome = "GFT Brasil - Sorocaba";
            gft1.Status = true;
            gft1.Telefone = "+55 11 2176-3253";
            gft1.Endereco = " Av. São Francisco, 98 Jardim Sta. Rosália";
            //gft1.Foto = "";

            database.Gfts.Add(gft1);
            database.SaveChanges();

            Gft gft2 = new Gft();  //gft curitiba
            gft2.Cep = "80230-010";
            gft2.Cidade = "Curitiba";
            gft2.Estado = "PR";
            gft2.Nome = "GFT Brasil - Curitiba";
            gft2.Status = true;
            gft2.Telefone = "+55 41 4009 5700";
            gft2.Endereco = "Av. Sete de Setembro, 2451 Torre Trinity Corporate 6º andar – Rebouças";
            //gft2.Foto = "";

            database.Gfts.Add(gft2);
            database.SaveChanges();

            //popular projetos
            Projeto proj = new Projeto();
            proj.Nome = "Banco Itau";
            proj.Status = true;
            database.Projetos.Add(proj);
            database.SaveChanges();

            Projeto proj1 = new Projeto();
            proj1.Nome = "Banco Santander";
            proj1.Status = true;
            database.Projetos.Add(proj1);
            database.SaveChanges();

            Projeto proj2 = new Projeto();
            proj2.Nome = "Banco Original";
            proj2.Status = true;
            database.Projetos.Add(proj2);
            database.SaveChanges();

            Projeto proj3 = new Projeto();
            proj3.Nome = "Sulamerica";
            proj3.Status = true;
            database.Projetos.Add(proj3);
            database.SaveChanges();


            //chamando tecnologias
            Tecnologia tec1 = new Tecnologia();
            tec1.Nome = "Mainframe";
            database.Tecnologias.Add(tec1);
            database.SaveChanges();

            Tecnologia tec2 = new Tecnologia();
            tec2.Nome = "Java";
            database.Tecnologias.Add(tec2);
            database.SaveChanges();

            Tecnologia tec3 = new Tecnologia();
            tec3.Nome = "Aspnet";
            database.Tecnologias.Add(tec3);
            database.SaveChanges();

            Tecnologia tec4 = new Tecnologia();
            tec4.Nome = "SalesForce";
            database.Tecnologias.Add(tec4);
            database.SaveChanges();

            Tecnologia tec5 = new Tecnologia();
            tec5.Nome = "AWS";
            database.Tecnologias.Add(tec5);
            database.SaveChanges();

            Tecnologia tec6 = new Tecnologia();
            tec6.Nome = "Azure";
            database.Tecnologias.Add(tec6);
            database.SaveChanges();

            Tecnologia tec7 = new Tecnologia();
            tec7.Nome = "Angular";
            database.Tecnologias.Add(tec7);
            database.SaveChanges();

            Tecnologia tec8 = new Tecnologia();
            tec8.Nome = "MySql";
            database.Tecnologias.Add(tec8);
            database.SaveChanges();

            Tecnologia tec9 = new Tecnologia();
            tec9.Nome = "Python";
            database.Tecnologias.Add(tec9);
            database.SaveChanges();

            Tecnologia tec10 = new Tecnologia();
            tec10.Nome = "Linux";
            database.Tecnologias.Add(tec10);
            database.SaveChanges();

            Tecnologia tec11 = new Tecnologia();
            tec11.Nome = "Mobile";
            database.Tecnologias.Add(tec11);
            database.SaveChanges();
            
            //cadastrar vaga
            Random r = new Random();
            DateTime dataHoje = DateTime.Today;

            Vaga vaga = new Vaga();  //precisa de qualquer linguagem e mysql
            int codigo = r.Next(1000000);
            vaga.Abertura_vaga = dataHoje.AddDays(-2);
            vaga.Codigo_vaga = codigo.ToString();
            vaga.Descricao_vaga = "Desenvolvedor Pleno";
            vaga.ProjetoCad = database.Projetos.First(v => v.Id == 1); //projeto itau
            vaga.Qtd_vaga = 3;
            vaga.Status = true;
            database.Vagas.Add(vaga);
            database.SaveChanges();

            Vaga vaga1 = new Vaga(); //precisa de java e mysql
            int codigo1 = r.Next(1000000);
            vaga1.Abertura_vaga = dataHoje.AddDays(-7);
            vaga1.Codigo_vaga = codigo1.ToString();
            vaga1.Descricao_vaga = "Desenvolvedor Java";
            vaga1.ProjetoCad = database.Projetos.First(v => v.Id == 2);  //projeto santander
            vaga1.Qtd_vaga = 3;
            vaga.Status = true;
            database.Vagas.Add(vaga1);
            database.SaveChanges();

            Vaga vaga2 = new Vaga(); //precisa de salesforce
            int codigo2 = r.Next(1000000);
            vaga2.Abertura_vaga = dataHoje.AddDays(2);
            vaga2.Codigo_vaga = codigo2.ToString();
            vaga2.Descricao_vaga = "Desenvolvedor SalesForce";
            vaga2.ProjetoCad = database.Projetos.First(v => v.Id == 3);  //projeto original
            vaga2.Qtd_vaga = 3;
            vaga2.Status = true;
            database.Vagas.Add(vaga2);
            database.SaveChanges();

            Vaga vaga3 = new Vaga(); //precisa de anugular
            int codigo3 = r.Next(1000000);
            vaga3.Abertura_vaga = dataHoje;
            vaga3.Codigo_vaga = codigo3.ToString();
            vaga3.Descricao_vaga = "Front-end";
            vaga3.ProjetoCad = database.Projetos.First(v => v.Id == 4);  //projeto sulamerica
            vaga3.Qtd_vaga = 3;
            vaga3.Status = true;
            database.Vagas.Add(vaga3);
            database.SaveChanges();

            Vaga vaga5 = new Vaga(); //precisa de linux e python
            int codigo5 = r.Next(1000000);
            vaga5.Abertura_vaga = dataHoje.AddDays(1);
            vaga5.Codigo_vaga = codigo5.ToString();
            vaga5.Descricao_vaga = "DevOps";
            vaga5.ProjetoCad = database.Projetos.First(v => v.Id == 2);  //projeto santander
            vaga5.Qtd_vaga = 3;
            vaga5.Status = true;
            database.Vagas.Add(vaga5);
            database.SaveChanges();

            //cadastrar funcionario
            DateTime dataHoje1 = DateTime.Today;

            Funcionario func = new Funcionario(); //desenvolvedor pleno de aspnet
            func.Nome = "Frida Khalo";
            func.Matricula = "234567";
            func.Cargo = "Desenvolvedor Pleno";
            func.Inicio_wa = dataHoje1.AddDays(2);
            func.Termino_wa = func.Inicio_wa.AddDays(17);
            func.Gft_Id = database.Gfts.First(f => f.Id == 1);
            func.Level = "L1";
            func.Status = true;
            //func.Foto = "";
            database.Funcionarios.Add(func);
            database.SaveChanges();
            Funcionario_Tecnologia FunTec = new Funcionario_Tecnologia();
            FunTec.Funcionario = database.Funcionarios.First(f => f.Id == 1);
            FunTec.Tecnologia = database.Tecnologias.First(t => t.Id == 3); //tecnologia aspnet
            database.Funcionario_Tecnologias.Add(FunTec);
            database.SaveChanges();

            Funcionario func1 = new Funcionario();
            func1.Nome = "Jorge Amado";
            func1.Matricula = "124763";
            func1.Cargo = "Desenvolvedor Java";
            func1.Inicio_wa = dataHoje1.AddDays(-2);
            func1.Termino_wa = func.Inicio_wa.AddDays(17);
            func1.Gft_Id = database.Gfts.First(f => f.Id == 2);
            func1.Level = "L2";
            func1.Status = true;
            //func1.Foto = "";
            database.Funcionarios.Add(func1);
            database.SaveChanges();
            Funcionario_Tecnologia FunTec1 = new Funcionario_Tecnologia();
            FunTec1.Funcionario = database.Funcionarios.First(f => f.Id == 2);
            FunTec1.Tecnologia = database.Tecnologias.First(t => t.Id == 2); //tecnologia java
            database.Funcionario_Tecnologias.Add(FunTec1);
            database.SaveChanges();

            Funcionario func2 = new Funcionario();
            func2.Nome = "Stephen Hawking";
            func2.Matricula = "234588";
            func2.Cargo = "Desenvolvedor SalesForce";
            func2.Inicio_wa = dataHoje1.AddDays(-3);
            func2.Termino_wa = func.Inicio_wa.AddDays(17);
            func2.Gft_Id = database.Gfts.First(f => f.Id == 3);
            func2.Level = "L3";
            func2.Status = true;
            //func2.Foto = "";
            database.Funcionarios.Add(func2);
            database.SaveChanges();
            Funcionario_Tecnologia FunTec2 = new Funcionario_Tecnologia();
            FunTec2.Funcionario = database.Funcionarios.First(f => f.Id == 3);
            FunTec2.Tecnologia = database.Tecnologias.First(t => t.Id == 4); //tecnologia salesforce
            database.Funcionario_Tecnologias.Add(FunTec2);
            database.SaveChanges();

            Funcionario func3 = new Funcionario();
            func3.Nome = "Jojo Moyes";
            func3.Matricula = "237713";
            func3.Cargo = "Desenvolvedor Front-end";
            func3.Inicio_wa = dataHoje1.AddDays(2);
            func3.Termino_wa = func.Inicio_wa.AddDays(17);
            func3.Gft_Id = database.Gfts.First(f => f.Id == 1);
            func3.Level = "L2";
            func3.Status = true;
            //func3.Foto = "";
            database.Funcionarios.Add(func3);
            database.SaveChanges();
            Funcionario_Tecnologia FunTec3 = new Funcionario_Tecnologia();
            FunTec3.Funcionario = database.Funcionarios.First(f => f.Id == 4);
            FunTec3.Tecnologia = database.Tecnologias.First(t => t.Id == 7); //tecnologia angular
            database.Funcionario_Tecnologias.Add(FunTec3);
            database.SaveChanges();

            Funcionario func4 = new Funcionario();
            func4.Nome = "Monja Coen";
            func4.Matricula = "117896";
            func4.Cargo = "DevOps";
            func4.Inicio_wa = dataHoje1.AddDays(-4);
            func4.Termino_wa = func.Inicio_wa.AddDays(17);
            func4.Gft_Id = database.Gfts.First(f => f.Id == 3);
            func4.Level = "L3";
            func4.Status = true;
            //func4.Foto = "";
            database.Funcionarios.Add(func4);
            database.SaveChanges();
            Funcionario_Tecnologia FunTec4 = new Funcionario_Tecnologia();
            FunTec4.Funcionario = database.Funcionarios.First(f => f.Id == 5);
            FunTec4.Tecnologia = database.Tecnologias.First(t => t.Id == 9);  //tecnologia python
            database.Funcionario_Tecnologias.Add(FunTec4);
            database.SaveChanges();


            return RedirectToAction("Index", "Home");
        }
    }
}