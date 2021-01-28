using System;
using System.Collections.Generic;

namespace desafio_mvc.Models
{
    public class Funcionario
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Matricula {get; set;}
        public string Cargo {get; set;}
        public DateTime Inicio_wa {get; set;}
        public DateTime Termino_wa {get; set;}
        public Gft Gft_Id {get; set;}
        public Vaga Vaga_Id {get; set;}
        public bool Status {get; set;}
        public string Level {get; set;}
        public string Foto {get; set;}

        //relacionamento com as tecnologias
        public virtual List<Funcionario_Tecnologia> FuncTecnologia {get; set;}

        // public static implicit operator Funcionario(int v)
        // {
        //     throw new NotImplementedException();
        // }
        //public ICollection<Funcionario_Tecnologia> FuncTecnologia {get; set;}
    }
}