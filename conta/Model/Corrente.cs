namespace conta.Model{
    public class Corrente: Conta{
        //Atributos
        public long NumeroConta { get; set; }
        public double Tarifa { get; set; }

        //Métodos
        public void ImprimeSaldo(){
            Console.WriteLine("Conta: "+ NumeroConta + " saldo atual: " + base.Saldo);
        }
    }
}