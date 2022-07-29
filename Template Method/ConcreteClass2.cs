using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine(" ---> CocreteClass2.RequiredOperation1() Run....");

        }
        protected override void RequiredOperation2()
        {
            Console.WriteLine(" ---> CocreteClass2.RequiredOperation2() Run....");
        }
    }
}
