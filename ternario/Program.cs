// See https://aka.ms/new-console-template for more information
class Progam{
    public static void Main(){
        Console.WriteLine("Digite o primeiro numero:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero:");
        int num2 = int.Parse(Console.ReadLine());
        //Metedo tradicional
        if(num1 == num2){
            Console.WriteLine("Iguais");
        }
        else{
            Console.WriteLine("Diferentes");
        }

        //Com operador ternario

        string retorno = (num1 == num2) ? "Iguais tenario" : "Diferente ternario";
        Console.WriteLine(retorno);
    }
}
