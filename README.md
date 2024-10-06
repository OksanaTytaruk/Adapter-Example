# Adapter Example

Цей репозиторій містить приклад патерну проектування "Адаптер".

## Патерн Адаптер (Adapter)

Патерн "Адаптер" дозволяє об'єктам з несумісними інтерфейсами працювати разом. Він обгортає адаптований клас у клас з інтерфейсом, сумісним з цільовим класом.

### Приклад коду:

```csharp
// Цільовий інтерфейс
public interface ITarget
{
    string GetRequest();
}

// Адаптуємий клас
public class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Специфічний запит";
    }
}

// Адаптер
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
