// See https://aka.ms/new-console-template for more information
class Program{
    public static void Main(){
        string[,] semestres;
        semestres = new string[2,6]  { 
               {"Janeiro", "Fevereiro", "Março",    "Abril",   "Maio",     "Junho"},
               {"Julho",   "Agosto",    "Setembro", "Outubro", "Novembro", "Dezembro"}
        };

        foreach(string s in semestres){
            Console.WriteLine(s);
        }
    }
}
