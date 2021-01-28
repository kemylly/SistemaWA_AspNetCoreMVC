
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace desafio_mvc.Models
{
    public class Gft
    {
        public int Id {get; set;}

        public string Cep {get; set;}

        public string Cidade {get; set;}

        public string Endereco {get; set;}

        public string Estado {get; set;}

        public string Nome {get; set;}

        public string Telefone {get; set;}

        public string Foto {get; set;}

        public bool Status {get; set;}
    }
}