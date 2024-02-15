using System.Diagnostics;
using System.Runtime.CompilerServices;
using static Calculate.Program;
namespace Calculate
{
    public class Program
    {
        //public delegate int DelegateCalculate(int x, int y);

        //public delegate TResult GenericDelegate<T1, T2, TResult>(T1 x, T2 y);
        

        public static void Main(string[] args) 
        {
            

            Console.WriteLine("Sonlarni kiriting: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int c;

            Console.WriteLine();

            do
            {
                Menu();
                c = Convert.ToInt32(Console.ReadLine());

                switch (c)

                {
                    case 1:
                        Func<int, int, int> delegateCalculate1 = (a, b) => a + b;
                        Console.WriteLine(delegateCalculate1(a, b));
                        break;
                    case 2:
                        Func<int, int, int> delegateCalculate2 = (a, b) => a - b;
                        Console.WriteLine(delegateCalculate2(a, b));
                        break;
                    case 3:
                        Func<int, int, int> delegateCalculate3 = (a, b) => a * b ;
                        Console.WriteLine(delegateCalculate3(a, b));
                        break;
                    case 4:
                        Func<int, int, int> delegateCalculate4 = (a, b) => a / b; 
                        Console.WriteLine(delegateCalculate4(a, b));
                        break;
                    case 5:
                        Func<int, int, int> delegateCalculate5 = (a, b) => a % b;
                        Console.WriteLine(delegateCalculate5(a, b));
                        break;
                    default:

                        break;

                }
            }
            while (c != 6);

        }

        public static void Menu()
        {
            Console.WriteLine("1.Qoshish");
            Console.WriteLine("2.Ayirish");
            Console.WriteLine("3.Kopaytirish");
            Console.WriteLine("4.Bo'lish");
            Console.WriteLine("5.Qoldiqli bo'lish");
            Console.WriteLine("6.Dasturdan chiqish");


        }


        public static int Qoshish1(int a, int b)
        {
            return a + b;
        }

        public static int Qoshish(int a, int b) => a + b;

        public static int Ayirish1(int a, int b)
        {
            return a - b;
        }
        public static int Ayirish(int a, int b) => a - b;
        
        public static int Kopaytirish1(int a, int b)
        {
            return a * b;
        }
        public static int Kopaytirish(int a, int b) => a * b;
        
        public static int Bolish1(int a, int b)
        {
            return a / b;
        }
        public static int Bolish(int a, int b) => a / b;
        public static int QoldiqliBolish1(int a, int b)
        {
            return a % b;
        }
        public static int QoldiqliBolish(int a, int b) => a % b;


    }
}

