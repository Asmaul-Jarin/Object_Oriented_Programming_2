using System;
namespace Delegates
{
    //declaring a delegate
    public delegate void Calculation(int a, int b);
    class Maths
    {
        public void add(int a, int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }

        public void sub(int a, int b)
        {
            Console.WriteLine("Subtraction: " + (a - b));
        }
        public void multi(int a, int b)
        {
            Console.WriteLine("Multiplication: " + (a * b));
        }
    }

    class Program
    {
        static void SampleCalculation(Calculation del, int a, int b)
        {
            del(a, b);
        }
        static void Main(string[] args)
        {
            Maths m1 = new Maths();
            //m1.add(10, 20); 
            SampleCalculation(m1.add, 10, 10);
            SampleCalculation(m1.sub, 10, 10);
            SampleCalculation(m1.multi, 10, 10);
            Console.ReadKey();
        }
    }
}
