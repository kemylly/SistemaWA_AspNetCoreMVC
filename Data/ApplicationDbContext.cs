using System;
using System.Collections.Generic;
using System.Text;
//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using desafio_mvc.Models;
using System.Threading.Tasks;

namespace desafio_mvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Gft> Gfts {get; set;}
        public DbSet<Projeto> Projetos {get; set;}
        public DbSet<Tecnologia> Tecnologias {get; set;}
        public DbSet<Vaga> Vagas {get; set;}
        public DbSet<Funcionario> Funcionarios {get; set;}
        public DbSet<Vaga_Tecnologia> Vaga_Tecnologias {get; set;}
        public DbSet<Funcionario_Tecnologia> Funcionario_Tecnologias {get; set;}
        public DbSet<Alocar> Alocars {get; set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
