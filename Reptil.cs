public class Reptil : Animal
{
    public Reptil(string nome, int idade) : base(nome, idade) { }
    public override string EmitirSom() {
        return "Au au";
    }
}

public class cobra : Reptil
{
    public double Comprimento { get; set; }
    public cobra(string nome, int idade, double Comprimento) : base(nome, idade) { 
        this.Comprimento = Comprimento;
    }
    public override string EmitirSom() {
        return "esk esk";
    }
    
}