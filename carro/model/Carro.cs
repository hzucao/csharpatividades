//Aula 17/08/2023 Criação de classe

namespace carro.model{
    
    public class Carro{
        //Atributos
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Combustivel { get; set; }
        
        //Métodos
        public void ApresentarDoc(){
            Console.WriteLine("Placa:" + Placa);
            Console.WriteLine("Marca:" + Marca);
            Console.WriteLine("Modelo:" + Modelo);
            Console.WriteLine("Ano:" + Ano);
            Console.WriteLine("Combustivel:" + Combustivel);
        }


        //Método get set em outras linguagens
        // public string getPlaca(){
        //     return Placa;
        // }

        // public void setPlaca(string Placa){
        //     this.Placa=Placa;
        // }

    }
}