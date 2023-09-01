namespace pesalupro.Model{
    public class Aluno: Pessoa{
        public long Ra{get; set;}

        public override void Apresentar(){
            base.Apresentar();
            Console.WriteLine("R.A.: "+this.Ra);
            
        }

    }
}