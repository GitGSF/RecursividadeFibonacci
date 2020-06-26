using System;
namespace RecursividadeFibonacci
{
    public class Fibonacci
    {
        public void SequenciaFibonacci(int numero1, int numero2, int vezes)
        {
            if(vezes > 0){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(numero1);
                SequenciaFibonacci(numero2, numero1 + numero2, vezes -1);
                Console.ResetColor();
            }
        }
    }
}