namespace conta.Model{
    public abstract class Conta{
        //Atributo
          protected double Saldo {get; set;}

        //Métodos
        public void Creditar(double valor){
            Saldo = Saldo + valor;
        }

        public void Debitar(double valor){
            Saldo = Saldo - valor;
        }
    }
}