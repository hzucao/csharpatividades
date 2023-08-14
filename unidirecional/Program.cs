// See https://aka.ms/new-console-template for more information
class Program{
    public static void Main(){
       
       int[] numeros;
       numeros = new int[3] {1,2,3};

       int[] numeros2 = new int[3];

       numeros2[0] = 4;
       numeros2[1] = 5;
       numeros2[2] = 6;

       for(int i =0; i<3; i++){
        Console.WriteLine("Valor do indice " +i + ":" +numeros[i]);
       }

       foreach(int n in numeros){
        Console.WriteLine(n);
       }

    }
}