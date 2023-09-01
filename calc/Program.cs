// See https://aka.ms/new-console-template for more information
using calc.Model;

namespace calc{
    public class Program{
        public static void Main(){
            var calculadoraNormal = new CalculadoraNormal();
            calculadoraNormal.Multiplicacao(2,5);

            var calculadoraCientifica = new CalculadoraCientifica();
            calculadoraCientifica.Potencia(10,3);
        }
    }
}
