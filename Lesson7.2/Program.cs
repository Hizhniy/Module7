//Создайте схему классов A, B, C, D и E таким образом, чтобы B наследовался от A, С от A, D от B и E от C. А также:

//Добавьте в класс A виртуальный метод Display (void тип, без параметров), который будет выводить в консоль "A".
//В классе B скройте этот метод и сделайте так, чтобы в консоль выводилось "B".
//Для класса C переопределите метод Display, чтобы в консоли было "C".
//Для D снова скройте метод.
////В классе E также скройте метод.

using System.Net.WebSockets;

class A
{
    public virtual void Display()
    {
        Console.WriteLine("A");
    }
}
class B : A
{
    public new void Display()
    {
        Console.WriteLine("B");
    }
}
class C : A
{
    public override void Display()
    {
        Console.WriteLine("C");
    }
}
class D : B
{
    public new void Display()
    {
        Console.WriteLine("D");
    }
}
class E : C
{
    public new void Display()
    {
        Console.WriteLine("E");
    }
}


// Класс для объекта “Книга”
class Book
{
    public string Name;
    public string Author;
}

// Класс для объекта “Коллекция книг”
class BookCollection
{
    // Закрытое поле, хранящее книги в виде массива
    private Book[] collection;

    // Конструктор с добавлением массива книг
    public BookCollection(Book[] collection)
    {
        this.collection = collection;
    }

    // Индексатор по массиву
    public Book this[int index]
    {
        get
        {
            // Проверяем, чтобы индекс был в диапазоне для массива
            if (index >= 0 && index < collection.Length)
            {
                return collection[index];
            }
            else
            {
                return null;
            }
        }

        private set
        {
            // Проверяем, чтобы индекс был в диапазоне для массива
            if (index >= 0 && index < collection.Length)
            {
                collection[index] = value;
            }
        }
    }

    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }

    }
}

class Program
{
    static void Main(string[] args)
    {
        D d = new D();
        E e = new E();

        d.Display();
        ((A)e).Display();
        ((B)d).Display();
        ((A)d).Display();
    }
}