using Semana3;

var animals = new List<IAnimal>();
animals.Add(new Dog("Camilo"));
animals.Add(new Cat("Pantufla"));

foreach (var animal in animals)
{
    Console.WriteLine($"{animal.GetType().Name}'s name is: {animal.Name}");
    Console.WriteLine($"{animal.GetType().Name} eats {animal.Food}");
    Console.WriteLine($"{animal.GetType().Name} does: {animal.Noise}");
}