namespace desafio_mvc.Models
{
    public class Vaga_Tecnologia
    {
        //relacionamento entre a tabela vaga e a tabela tecnologia
        public int Id {get; set;}
        public int VagaID {get; set;}
        public virtual Vaga Vaga {get; set;}  //fk de vaga
        public int TecnologiaID {get;set;}
        public virtual Tecnologia Tecnologia {get; set;}  //fk de tecnologia
    }
}