// See https://aka.ms/new-console-template for more information
using conta.Model;
namespace conta{
    public class Program{
        public static void Main(){
            var cc = new Corrente();
            cc.NumeroConta = 1234;
            cc.Creditar(1000);
            cc.Debitar(358);
            cc.ImprimeSaldo();
        }
    }
}
