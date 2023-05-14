class Helper
{
    public static void Swap(ref int num1, ref int num2)
    {
        num2 = num2 + num1;
        num1 = num2 - num1;
        num2 = num2 - num1;
    }
}

static class Obj
{
    //public string Name;
    //public string Description;

    public static string Parent;
    public static int DaysInWeek;
    public static int MaxValue;

    static Obj()
    {
        Parent = "System.Object";
        DaysInWeek = 7;
        MaxValue = 2000;
    }
}


static class IntExtensions
{
    public static int GetNegative(this int number)
    {
        return number > 0 ? -number : number;
    }
    public static int GetPositive(this int number)
    {
        return number < 0 ? -number : number;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int num1 = 3;
        int num2 = 58;

        Helper.Swap(ref num1, ref num2);

        Console.WriteLine(num1); //58
        Console.WriteLine(num2); //3


        num1 = 7;
        num2 = -13;
        int num3 = 0;

        Console.WriteLine(num1.GetNegative()); //-7
        Console.WriteLine(num1.GetPositive()); //7
        Console.WriteLine(num2.GetNegative()); //-13
        Console.WriteLine(num2.GetPositive()); //13
        Console.WriteLine(num3.GetNegative()); //0
        Console.WriteLine(num3.GetPositive()); //0
    }
}