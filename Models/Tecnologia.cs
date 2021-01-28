using System.Collections.Generic;

namespace desafio_mvc.Models
{
    public class Tecnologia
    {
        public int Id {get; set;}
        public string Nome {get; set;} 

        //relacionameto com vaga e vaga_tecnologia
        public virtual List<Vaga_Tecnologia> VagaTecnologia {get; set;}

        //relacionamento com vaga e funcionario_tecnologia
        public virtual List<Funcionario_Tecnologia> FuncTecnologia {get; set;}
    }
}