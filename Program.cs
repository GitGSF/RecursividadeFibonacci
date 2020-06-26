using System;

namespace RecursividadeFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            Console.WriteLine("20 primeiros números da sequência Fibonacci");
            fibonacci.SequenciaFibonacci(0,1,20);
            
        }
    }
}
