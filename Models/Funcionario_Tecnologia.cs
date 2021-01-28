namespace desafio_mvc.Models
{
    public class Funcionario_Tecnologia
    {
        //relacionamento entre a tabela funcionario e a tabela tecnologia
        public int Id {get; set;}
        public int FuncionarioID {get; set;}
        public virtual Funcionario Funcionario {get; set;} //fk em funcionario
        public int TecnologiaID {get; set;}
        public virtual Tecnologia Tecnologia {get; set;}  //fk em tecnologia
    }
}