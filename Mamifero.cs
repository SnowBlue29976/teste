public class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) { 
    }
    public override string EmitirSom() {
        return "Au au";
    }
}
    
   public class Leão : Mamifero
    {
        public int TamanhoDoGrupo { get; set;} 
        public Leão(string nome, int idade,int TamanhoDoGrupo) : base(nome, idade) {    
        
        this.TamanhoDoGrupo = TamanhoDoGrupo; 
    }
        public override string EmitirSom() {
            return "errrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr";
        }
    }
    