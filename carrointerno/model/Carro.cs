//Aula 17/08/2023 Criação de classe com uma classe interna.

namespace carrointerno.model{

    public class Carro{
        //Atributos
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Combustivel { get; set; }

        public class Motor{
            public void Acelerar(string combustivel){
                if(combustivel == "Gasolina"){
                    Console.WriteLine("Pior acelaração, melhor consumo");
                }
                else if(combustivel == "Alcool"){
                    Console.WriteLine("Melhor aceleração, pior consumo");
                }
                else{
                    Console.WriteLine("Esse carro só anda com Alcool ou Gasolina");
                }
            
            }
        }
        
        //Métodos
        public void ApresentarDoc(){
            Console.WriteLine("Placa:" + Placa);
            Console.WriteLine("Marca:" + Marca);
            Console.WriteLine("Modelo:" + Modelo);
            Console.WriteLine("Ano:" + Ano);
            Console.WriteLine("Combustível:" + Combustivel);
            var motor = new Motor();
            motor.Acelerar(Combustivel);
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