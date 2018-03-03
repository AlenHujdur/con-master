using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

    class Proces
    {
        public string OSVersion { get; set; }
        public string MachineName { get; set; }

        List<ICollection<string>> GetProcesses() { 
        Lazy<ICollection<string>> processes = 
            new Lazy<ICollection<string>>(
            ()=>
            {
                List<string> processNames = new List<string>();
                foreach(var p in Process.GetProcesses())
                {
                    processNames.Add(p.ProcessName);
                }
                return processNames;
            }
         );
            return null;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Bazna i derivatna + virtual */
            //Console.WriteLine("Derived via Base reference:");

            //Base b = new Derived();
            //b.DoSomethingVirtual();
            //b.DoSomethingNonVirtual();

            //Console.WriteLine();
            //Console.WriteLine("Derived via Derived reference:");

            //Derived d = new Derived();
            //d.DoSomethingVirtual();
            //d.DoSomethingNonVirtual();

            /*Malo Linq*/
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine("Prosjek: " + list.Average().ToString());

            string path = @"C:\";
            foreach (string f in Directory.EnumerateDirectories(path))
            { Console.WriteLine(f); }


        }
    }
}
