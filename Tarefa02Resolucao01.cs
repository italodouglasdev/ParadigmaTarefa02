
using System;
using System.Linq;

namespace ParadigmaTarefa02
{
    public class Tarefa02Resolucao01
    {
        public static void DesenharGalhos(int[] arrayEntrada)
        {

            int raiz = arrayEntrada.Max();

            int indexRaiz = Array.FindIndex(arrayEntrada, item => item == raiz);

            int[] galhosEsquerda = arrayEntrada.Take(indexRaiz).OrderByDescending(item => item).ToArray();
            int[] galhosDireita = arrayEntrada.Skip(indexRaiz + 1).OrderByDescending(item => item).ToArray();

            int arrayMaior = galhosEsquerda.Length;
            if (arrayMaior < galhosDireita.Length)
                arrayMaior = galhosDireita.Length;

            int quantidadeEspacosInicio = (arrayMaior * 2);
            int quantidadeEspacosMeio = 0;

            Console.WriteLine($"{Util.DesenharEspacos(quantidadeEspacosInicio)}{raiz}");

            for (int index = 0; index < arrayMaior; index++)
            {

                string valorEsquerda = " ";
                string barraEsquerda = " ";
                if (galhosEsquerda.Length > index)
                {
                    barraEsquerda = "/";
                    valorEsquerda = galhosEsquerda[index].ToString();
                }

                string valorDireita = " ";
                string barraDireita = " ";
                if (galhosDireita.Length > index)
                {
                    barraDireita = @"\";
                    valorDireita = galhosDireita[index].ToString();
                }

                quantidadeEspacosInicio = (arrayMaior * 2) - (index * 2) - 1;
                quantidadeEspacosMeio = (arrayMaior * 2) - quantidadeEspacosInicio + (index * 2);

                Console.WriteLine($"{Util.DesenharEspacos(quantidadeEspacosInicio)}{barraEsquerda}{Util.DesenharEspacos(quantidadeEspacosMeio)}{barraDireita}");
                Console.WriteLine($"{Util.DesenharEspacos(quantidadeEspacosInicio - 1)}{valorEsquerda}{Util.DesenharEspacos(quantidadeEspacosMeio + 2)}{valorDireita}");

            }
        }




    }
}

