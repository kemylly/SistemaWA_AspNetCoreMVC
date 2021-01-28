using System;
using System.ComponentModel.DataAnnotations;

namespace desafio_mvc.DTO
{
    public class TecnologiaDTO
    {
        [Required]
        public int Id {get; set;}
        [Required(ErrorMessage="Nome é obrigatorio")]
        public string Nome {get; set;} 
    }
}