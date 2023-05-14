abstract class Engine { }
class ElectricEngine : Engine { }
class GasEngine : Engine { }
abstract class CarPart { }
class Battery : CarPart { }
class Differential : CarPart { }
class Wheel : CarPart { }

abstract class Car<TEngine> where TEngine : Engine
{
    public TEngine Engine = default(TEngine);

    public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
    {
    }
}

class ElectricCar : Car<ElectricEngine>
{
    public override void ChangePart<TPart>(TPart newPart)
    {

    }
}

class GasCar : Car<GasEngine>
{
    public override void ChangePart<TPart>(TPart newPart)
    {

    }
}


class Record<T1, T2>
{
    public T1 Id;
    public T2 Value;
    public DateTime Date;
}

class Generic<T1, T2, T3>
{
    public T1 Field; // Поле типа T1

    public T2 Property { get; set; } // Свойство типа T2

    public void Method(T3 param) // Параметр типа T3
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Generic<object, int, string> generic = new Generic<object, int, string>();
    }
}