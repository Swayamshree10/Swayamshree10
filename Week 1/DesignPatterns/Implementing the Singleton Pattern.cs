using System;
class Singleton
{
    private static Singleton instance;

    private Singleton()
    {
        Console.WriteLine("Singleton object created.");
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void Display()
    {
        Console.WriteLine("Hello from Singleton class!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Singleton obj1 = Singleton.GetInstance();
        Singleton obj2 = Singleton.GetInstance();

        obj1.Display();

        if (obj1 == obj2)
        {
            Console.WriteLine("Both objects are the same instance.");
        }
        else
        {
            Console.WriteLine("Objects are different.");
        }
    }
}