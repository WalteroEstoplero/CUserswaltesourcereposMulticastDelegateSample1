using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegateSample1
{
    public delegate void MyDelegate();

    class StaticMethods
    {
        public static void DoSomething()
        {
            Console.WriteLine("In der Methode 'DoSomething'");
        }
        public static void DoSomethingMore()
        {
            Console.WriteLine("In der Methode 'DoSomethingmore'");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            MyDelegate del = (MyDelegate)Delegate.Combine(new MyDelegate(StaticMethods.DoSomething),
                new MyDelegate(StaticMethods.DoSomethingMore));

            // Multicast-Delegaten ausführen
            del();


            Console.ReadLine();
        }


    }
}
