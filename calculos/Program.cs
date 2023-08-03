// See https://aka.ms/new-console-template for more information
public class Program{

    public static void Main(){

        Console.WriteLine("Digite um aluno");
        string aluno = Console.ReadLine();
        Console.WriteLine("Digite nota1");
        float nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite nota2");
        float nota2 = float.Parse(Console.ReadLine());

        float media = (nota1+nota2)/2;
        
        Console.WriteLine("Aluno "+ aluno+ "tem a media:" + media);


    }

}
