using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsApp
{
    public abstract class AbstractClass
    {
        public abstract void Method();
    }

    public class ConcreteClass: AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Реализация метода Method()");
        }
    }
}