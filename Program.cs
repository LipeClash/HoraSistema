using System;
using Figgle;

namespace auladepc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data e a Hora atual do sistema.");
            DateTime HoradoSistema = DateTime.Now;
            Console.WriteLine($"Neste momento são exatamente {HoradoSistema}");

        }
    }
}
