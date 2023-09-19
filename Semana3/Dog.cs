namespace Semana3;

public class Dog : AnimalBase, IAnimal
{
    public Dog(string name) : base(name)
    {
        Noise = "Woof woof";
        Food = "Dog food";
    }
}