namespace pesalupro.Model{
    public class Pessoa{
        //Atributo
        public string Nome { get; set; }
        public long Cpf{ get; set; }

        //Método
        public virtual void Apresentar(){
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);

        }
    }
}