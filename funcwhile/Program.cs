// See https://aka.ms/new-console-template for more information
class Program{
    public static void Main(){
        Console.WriteLine("Digite um numero inteiro:");
        int numero = int.Parse(Console.ReadLine());
        
        int controle = numero;

        while(controle>0){ //Estura de while, enquanto a condição do while for verdadeira o codigo do laço sera executado. Obs. ele só executa desde a primeira vez se a condição for valida.
            if(ePar(controle)){
            Console.WriteLine(controle);
            } 

            controle = controle-1;

        }

        

    }

    public static bool ePar(int num){

        if(num%2==0){
            return true;
            
        }
        else
        {
            return false;
        }

    }
    public static bool ePar(int num, int num1){
             return true;
    }

}
