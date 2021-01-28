using System;
using System.ComponentModel.DataAnnotations;

namespace desafio_mvc.DTO
{
    public class VagaDTO
    {
        [Required]
        public int Id {get; set;}

        [Required(ErrorMessage="Data da abertura da vaga é obrigatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Abertura_vaga {get; set;}

        // [Required(ErrorMessage="Codigo da vaga é obrigatorio")]
        public string Codigo_vaga {get; set;}

        [Required(ErrorMessage="Descricao da vaga é obrigatorio")]
        public string Descricao_vaga {get; set;}

        [Required(ErrorMessage="o nome do projeto é obrigatorio")]
        public int ProjetoCad {get; set;}

        [Required(ErrorMessage="Quantidade de vaga é obrigatorio")]
        public int Qtd_vaga {get; set;}

        public int Tecnologias {get; set;}
    } 

}