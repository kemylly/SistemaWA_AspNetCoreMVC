using System;
using System.ComponentModel.DataAnnotations;

namespace desafio_mvc.DTO
{
    public class ProjetoDTO
    {
        [Required]
        public int Id {get; set;}
        [Required(ErrorMessage="O nome é obrigatorio /n")]
        public string Nome {get; set;}
    }
}