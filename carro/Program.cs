// See https://aka.ms/new-console-template for more information
//aula 17/08/2023 intanciando objeto de uma classe,
using carro.model;

namespace carro{
    public class Program{
        public static void Main(){
            var carro = new Carro();
            carro.Placa = "XXX1234";
            carro.Marca = "BMW";
            carro.Modelo = "X5";
            carro.Ano = 2023;
            carro.Combustivel = "Gasolina";

            carro.ApresentarDoc();
        }
    }
}

