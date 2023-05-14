using FirstApp;
using System;

namespace FirstApp
{
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager : Employee
    {
        public string ProjectName;
    }

    class Developer : Employee
    {
        private string ProgrammingLanguage;
    }

    class Eatablethings
    {
        public string Name;
    }

    class Fruit : Eatablethings
    {
        public int Sugar;
    }

    class Vegatable : Eatablethings
    {
        public double Сarbohydrate;
    }
}


class BaseClass
{
    public virtual int Counter { get; set; }
}

class DerivedClass : BaseClass
{
    private int counter;
    public override int Counter
    {
        get
        {
            return counter;
        }
        set
        {
            if (value >= 0)
            {
                counter = value;
            }
        }
    }
}

class MainClass
{
    static string Main(string[] args)
    {
        Fruit Apple = new Fruit();
        Fruit Banana = new Fruit();
        Fruit Pear = new Fruit();
        Vegatable Potato = new Vegatable();
        Vegatable Carrot = new Vegatable();

        return "Приветствую";
    }
}