using System;
using System.Linq;
using System.Collections.Generic;

namespace desafio_mvc.Models
{
    public class Vaga
    {
        public int Id {get; set;}
        public DateTime Abertura_vaga {get; set;}
        //DateTime dt = DateTime.Now;
        public string Codigo_vaga {get; set;}
        public string Descricao_vaga {get; set;}
        public Projeto ProjetoCad {get; set;}
        public int Qtd_vaga {get; set;}
        public bool Status {get; set;}
        //relacionamento com as tecnologias
        public virtual List<Vaga_Tecnologia> Tecnologias {get; set;}

        // public static implicit operator Vaga(int v)
        // {
        //     throw new NotImplementedException();
        // }
    }
}