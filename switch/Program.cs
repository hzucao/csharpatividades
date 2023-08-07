// See https://aka.ms/new-console-template for more information
using System;

class Program{
    public static void Main(){
        Console.WriteLine("Digite um numero de 1 à 7:");
        int dia = int.Parse(Console.ReadLine());
        
        if(dia == 1){
            Console.WriteLine("Domingo");
        }
        else if(dia == 2){
            Console.WriteLine("Segunda");
        }
        else if(dia == 3){
            Console.WriteLine("Terça");
        }
        else if(dia == 4){
            Console.WriteLine("Quarta");
        }
        else if(dia == 5){
            Console.WriteLine("Quinta");
        }
        else if(dia == 6){
            Console.WriteLine("Sexta");
        }
        else if(dia ==7){
            Console.WriteLine("Sabado");
        }
        else{
            Console.WriteLine("Numero invalido. Pense um pouco");
        }

        switch(dia){
            case 1: Console.WriteLine("Domingo"); break;
            case 2: Console.WriteLine("Segunda"); break;
            case 3: Console.WriteLine("Terça"); break;
            case 4: Console.WriteLine("Quarta"); break;
            case 5: Console.WriteLine("Quinta"); break;
            case 6: Console.WriteLine("Sexta"); break;
            case 7: Console.WriteLine("Sabado"); break;
            default: Console.WriteLine("Numero Invalido. Pense um pouco"); break;
        }

    }
}
