namespace pessoa.Model{
    public class Pessoa {
        //atributos
        public string nome { get; set; }
        private long cpf;
        protected DateTime dataNasc { get; set; }

        //métodos
        public void setCpf(long cpf){
            this.cpf = cpf;
        }
        public long getCpf(){
            return this.cpf;
        }
        

    }
}