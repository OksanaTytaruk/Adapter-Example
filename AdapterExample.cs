using System;

// Цільовий інтерфейс (Target)
public interface ITarget
{
    string GetRequest();
}

// Адаптуємий клас (Adaptee)
public class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Специфічний запит";
    }
}

// Адаптер (Adapter)
public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public string GetRequest()
    {
        return $"Адаптований запит: {_adaptee.GetSpecificRequest()}";
    }
}

// Клієнтський код
class Program
{
    static void Main(string[] args)
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);

        Console.WriteLine("Клієнт отримав: " + target.GetRequest());
    }
}
