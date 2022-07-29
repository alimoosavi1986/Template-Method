using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass1 client1 = new ConcreteClass1();
            client1.TemplateMethod();
            Console.WriteLine("---------------------------");
            ConcreteClass2 client2 = new ConcreteClass2();
            client2.TemplateMethod();

            Console.ReadKey();
        }
    }
}
