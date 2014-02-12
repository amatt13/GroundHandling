using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forlæsning1
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise = Console.ReadLine();

            if (choise == "1"){
                new Program().assassignment1();
            }
            else if (choise == "2")
            {
                new Program().assassignment2();
            }
            else if (choise == "3")
            {
                new Program().assassignment3();
            }
            else if (choise == "4")
            {
                new Program().assassignment4();
            }
            else if (choise == "5")
            {
                new Program().assassignment5();
            }

            Console.ReadLine();
        }

        public void assassignment1()
        {
            Console.WriteLine("Greetings World");
        }

        public void assassignment2()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Greetings, " + name);
        }

        public void assassignment3()
        {
            double number = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine(Math.Sqrt(number));
        }

        public void assassignment4()
        {
            string[] star = {"*", "**", "***", "****", "*****"};
            int i;

            Console.WriteLine("For-loop");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(star[i]);
            }

            for (i = 5; i > 0; i--)
            {
                Console.WriteLine(star[(i-1)]);
            }

            Console.WriteLine("While-loop");
            while (i < 5)
            {
                Console.WriteLine(star[i]);
                i++;
            }

            while (i > 0)
            {
                Console.WriteLine(star[(i-1)]);
                i--;
            }
        }

        public void assassignment5()
        {
            Console.WriteLine("1");
            Console.WriteLine((300).ToString("X"));

            Console.WriteLine("2");
            decimal d = 678.5M;
            Console.WriteLine(d.ToString());

            Console.WriteLine("3");
            ulong e = 9990000000000000000;
            Console.WriteLine(e.ToString());

            Console.WriteLine("4");
            double d2 = Convert.ToDouble(d);
            Console.WriteLine(d2.ToString());

        }
    }
}
