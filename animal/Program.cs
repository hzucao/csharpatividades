// See https://aka.ms/new-console-template for more information
using animal.Model;
namespace animal{
    public class Program{
        public static void Main(){
          var dog = new Cachorro();
          dog.EmitirSom();
          dog.ExecutarComando("Sentar");
          dog.ExecutarComando("Sentar", "Dar a pata");
          
        }
    }
}
