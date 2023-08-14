// See https://aka.ms/new-console-template for more information
class Progran{
    private static void Main(){
        string[] produto = new string[4];
        float[][] qtVl = new float[4][];
        
        for(int i = 0; i < 4; i++){
            Console.WriteLine("Digite o nome do produto:");
            produto[i] = Console.ReadLine();
            qtVl[i] = new float[2];
            Console.WriteLine("Digite a Quantidade:");
            qtVl[i][0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitario:");
            qtVl[i][1] = float.Parse(Console.ReadLine());
        }

        for(int i =0; i < 4; i++){
            Console.WriteLine("Produto: "+ produto[i]+ " quantidade: "+ qtVl[i][0]+ " Vl Unitario: "+ qtVl[i][1]+ " Vl Total:" + qtVl[i][0]*qtVl[i][1]);
        }

    }
}