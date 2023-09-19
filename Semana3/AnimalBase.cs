namespace Semana3;

public abstract class AnimalBase
{
    protected AnimalBase(string name)
    {
        Name = name;
    }

    public string Noise { get; protected set; } = "";

    public string Food { get; protected set; } = "";

    public string Name { get; private set; }
}