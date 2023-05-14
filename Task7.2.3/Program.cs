class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Метод класса BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Метод класса DerivedClass");
    }
}

class Obj
{
    public int Value;

    public static Obj operator +(Obj a, Obj b)
    {
        return new Obj
        {
            Value = a.Value + b.Value
        };
    }
    public static Obj operator -(Obj a, Obj b)
    {
        return new Obj
        {
            Value = a.Value - b.Value
        };
    }
}


class Porgram
{
    static void Main(string[] args)
    {
        DerivedClass obj = new DerivedClass();
        obj.Display();
        
        //Console.ReadKey();
    }
}
