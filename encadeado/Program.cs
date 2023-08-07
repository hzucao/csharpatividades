// See https://aka.ms/new-console-template for more information
class Program{
    public static void Main(){
        Console.WriteLine("Digite a temperatura:");
        float temperatura = float.Parse(Console.ReadLine());

        if(temperatura < 35.5){
            Console.WriteLine("Hipotermia");
        }
        else if(temperatura >= 35.5 && temperatura <= 37.6){
            Console.WriteLine("Sem Febre");
        }
        else{
            Console.WriteLine("Febre");
        }
    }
}
