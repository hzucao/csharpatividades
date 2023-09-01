// See https://aka.ms/new-console-template for more information
using pesalupro.Model;
namespace pesalupro{
    public class Program{
        public static void Main(){
            var aluno = new Aluno();
            aluno.Nome = "Heitor";
            aluno.Cpf = 12345678910;
            aluno.Ra = 1234;
            
            aluno.Apresentar();
        }
    }

}
