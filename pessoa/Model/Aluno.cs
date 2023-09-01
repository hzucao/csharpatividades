namespace pessoa.Model{
    public class Aluno: Pessoa
    { 
        //Atributo
        public string ra { get; set; }

        //Método
        public void setDataNasc(DateTime data){
            base.dataNasc = data;
        }
        public void imprimeDados(){
            Console.WriteLine("Nome:"+ base.nome);
            Console.WriteLine("CPF:"+ base.getCpf());
            Console.WriteLine("Data de nascimento"+ base.dataNasc);
            Console.WriteLine("RA:"+ this.ra);
        }

    }
}