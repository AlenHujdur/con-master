using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Base
    {
        public virtual void DoSomethingVirtual()
        {
            Console.WriteLine("Base.DoSomethingVirtual");
        }

        public void DoSomethingNonVirtual()
        {
            Console.WriteLine("Base.DoSomethingNonVirtual");
        }
    }

    class Derived : Base
    {
        public override void DoSomethingVirtual()
        {
            Console.WriteLine("Derived.DoSomethingVirtual");
        }

        public new void DoSomethingNonVirtual()
        {
            Console.WriteLine("Derived.DoSomethingNonVirtual");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derived via Base reference:");

            Base b = new Derived();
            b.DoSomethingVirtual();
            b.DoSomethingNonVirtual();

            Console.WriteLine();
            Console.WriteLine("Derived via Derived reference:");

            Derived d = new Derived();
            d.DoSomethingVirtual();
            d.DoSomethingNonVirtual();

        }
    }
}
