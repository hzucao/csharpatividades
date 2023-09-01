namespace animal.Model{
    public class Cachorro: Animal{
        public string Nome{get; set;}

        public override void EmitirSom(){
            Console.WriteLine("AuAu");
        }

        public void ExecutarComando(string comando){
            Console.WriteLine("Eu fiz a ação de:" + comando);
        }

        public void ExecutarComando(string cmd1, string cmd2){
            Console.WriteLine("Eu fiz a ação de:" + cmd1 +  " e " + cmd2);

        }
    }
}