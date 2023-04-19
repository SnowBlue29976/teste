using System;
using System.Collections.Generic;

public class MiniZoo

{
    private List<Animal> _animais;
    public List<Animal> Animais { get { return _animais; } }
    public MiniZoo()
    {
        _animais = new List<Animal>();
        
    }
public void AdicionarAnimal(Animal animal)
{
    _animais.Add(animal);
}

 
    
}
