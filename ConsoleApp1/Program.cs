using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

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
        public Proces()
        {
            this.MachineName = Environment.MachineName;
            this.OSVersion = Environment.OSVersion.ToString();
        }
        public Lazy<ICollection<string>> GetProcesses()
        {
            Lazy<ICollection<string>> processes =
               new Lazy<ICollection<string>>(
               () =>
               {
                   List<string> processNames = new List<string>();
                   foreach (var p in Process.GetProcesses())
                   {
                       processNames.Add(p.ProcessName);
                   }
                   return processNames;
               }
            );
            PrintSystemInfo(processes, true);
            Console.ReadKey();
            return null;
        }

        public void PrintSystemInfo(Lazy<ICollection<string>> processNames, bool showProcesses)
        {
            Console.WriteLine("MachineName: {0}", Environment.MachineName);
            Console.WriteLine("OS version: {0}", Environment.OSVersion);
            Console.WriteLine("DBG: Is process list created? {0}", processNames.IsValueCreated);
            if (showProcesses)
            {
                Console.WriteLine("Processes:");
                foreach(string p in processNames.Value)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine("DBG: Is process list created? {0}", processNames.IsValueCreated);
            }
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
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //console.writeline("prosjek: " + list.average().tostring());

            /*Citanje direktorija: */
            //string path = @"C:\";
            //foreach (string f in Directory.EnumerateDirectories(path))
            //{ Console.WriteLine(f); }

            /*Procesi i info o OS:*/
            //Proces p = new Proces();
            //p.GetProcesses();
            //p.PrintSystemInfo(p.GetProcesses(), true);
            /*Brojevi*/
            BigInteger x = 3;
            Console.WriteLine(x.IsEven.ToString());
            /*Culturel Info*/
            //Console.WriteLine(number.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
