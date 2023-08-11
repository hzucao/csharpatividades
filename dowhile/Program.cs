// See https://aka.ms/new-console-template for more information
class Progam{

    public static void Main(){
        bool controle = false;

        do{ // executa uma vez e depois entra no processo de validação do enquanto
            Console.WriteLine("Digite um numero");
            int numero = int.Parse(Console.ReadLine());
            //chamada do metodo multiplicaDez dentro do WriteLine com a passagem da variavel numero como argumento.
            Console.WriteLine(MultiplicaDez(numero));
            Console.WriteLine("Deseja Multiplar outro numero? S-Sim N-Não");
            string simNao = Console.ReadLine();

            if(simNao == "S" || simNao == "s"){
                controle = true;
            }
            else{
                controle = false;
            }
        }while(controle); // controle do loop, "enquanto" a validação do while for verdade o loop vai continuar acontecendo.

    }

    public static int MultiplicaDez(int num ) //assinatura do metodo num é um parametro
    {
        return num*10; //metodo com retorno ja fazendo o calculo
    }
}
