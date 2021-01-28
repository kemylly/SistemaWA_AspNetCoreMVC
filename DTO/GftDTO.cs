using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace desafio_mvc.DTO
{
    public class GftDTO
    {
        [Required]
        public int Id {get; set;}

        [Required(ErrorMessage="O CEP é obrigatorio")]
        [StringLength(9,ErrorMessage="O cep tem que ter até 8 caracteries")]
        public string Cep {get; set;}

        [Required(ErrorMessage="O nome da cidade é obrigatorio")]
        [StringLength(60,ErrorMessage="Nome muito extenso, abrevie!")]
        [MinLength(2,ErrorMessage="O nome de cidade é muito curto, não abrevie")]
        public string Cidade {get; set;}

        [Required(ErrorMessage="O endereço é obrigatorio")]
        public string Endereco {get; set;}

        [Required(ErrorMessage="O estado é obrigatorio")]
        public string Estado {get; set;}

        [Required(ErrorMessage="Nome é obrigatorio")]
        public string Nome {get; set;}

        [Required(ErrorMessage="Numero de telefone é obrigatorio")]
        [StringLength(15,ErrorMessage="Permitido ate 15 caracteries")]
        public string Telefone {get; set;}

        public IFormFile Foto {get; set;}
    }
}