using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadigmaTarefa02
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayEntrada01 = new[] { 3, 2, 1, 6, 0, 5 };
            int[] arrayEntrada02 = new[] { 7, 5, 13, 9, 1, 6, 4 };

            Console.WriteLine("Array 01 | Resolução 01");
            Console.WriteLine();
            Tarefa02Resolucao01.DesenharGalhos(arrayEntrada01);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Array 02 | Resolução 01");
            Console.WriteLine();
            Tarefa02Resolucao01.DesenharGalhos(arrayEntrada02);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Array 01 | Resolução 02");
            Console.WriteLine();
            Tarefa02Resolucao02.DesenharGalhos(arrayEntrada01);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Array 02 | Resolução 02");
            Console.WriteLine();
            Tarefa02Resolucao02.DesenharGalhos(arrayEntrada02);
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();


        }
    }
}
