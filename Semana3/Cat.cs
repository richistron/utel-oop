namespace Semana3;

public class Cat : AnimalBase, IAnimal
{
    public Cat(string name) : base(name)
    {
        Noise = "Meow";
        Food = "Cat food";
    }
}