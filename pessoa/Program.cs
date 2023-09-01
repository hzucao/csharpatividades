// See https://aka.ms/new-console-template for more information
using pessoa.Model;
namespace pessoa{
    public class Program{
        public static void Main(){
            //instacia da classe em um objeto
            var aluno = new Aluno();
            aluno.nome = "Heitor";
            aluno.setCpf(12345678910);
            DateTime datanasc = new DateTime(2023, 8, 15);
            aluno.setDataNasc(datanasc);
            aluno.ra = "SN12345";
            aluno.imprimeDados();
            //com classe normal consiguimos criar uma instacia de objeto para classe pai;
            var pessoa = new Pessoa();
            
        }
    }
}
