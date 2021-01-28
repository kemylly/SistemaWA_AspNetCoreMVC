using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace desafio_mvc.DTO
{
    public class FuncionarioDTO
    {
        [Required]
        public int Id {get; set;}

        [Required(ErrorMessage="O nome é obrigatorio")]
        public string Nome {get; set;}

        [Required(ErrorMessage="A matricula é obrigatorio")]
        public string Matricula {get; set;}

        [Required(ErrorMessage="O cargo é obrigatorio")]
        public string Cargo {get; set;}
        
        [Required(ErrorMessage="Inicio do periodo em  wa é obrigatorio")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Inicio_wa {get; set;}

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Termino_wa {get; set;}

        [Required(ErrorMessage="Indicacao de alguma GFT é obrigatorio")]
        public int Gft_Id {get; set;}

        public int Vaga_Id {get; set;}

        [Required(ErrorMessage="O nivel é obrigatorio")]
        public string Level {get; set;}

        public int FuncTecnologia {get; set;}

        public IFormFile Foto {get; set;}
    }
}