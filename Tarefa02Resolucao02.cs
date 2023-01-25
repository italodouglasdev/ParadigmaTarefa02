using System;
using System.Linq;
using System.Text;


namespace ParadigmaTarefa02
{
    public class Tarefa02Resolucao02
    {
        public static void DesenharGalhos(int[] arrayEntrada)
        {

            var sbDesenho = new StringBuilder();

            var listaEntrada = arrayEntrada.ToList();

            var raiz = listaEntrada.Max();

            var indexRaiz = listaEntrada.IndexOf(raiz);

            var galhosEsquerda = listaEntrada.Take(indexRaiz).OrderByDescending(item => item).ToList();

            var galhosDireita = listaEntrada.Skip(indexRaiz + 1).OrderByDescending(item => item).ToList();

            var listaMaior = galhosEsquerda.Count;
            if (listaMaior < galhosDireita.Count)
                listaMaior = galhosDireita.Count;

            var quantidadeEspacosInicio = (listaMaior * 2);
            var quantidadeEspacosMeio = 0;

            var index = 0;
            while (index < listaMaior)
            {
                var valorEsquerda = " ";
                var barraEsquerda = " ";
                if (galhosEsquerda.Count > index)
                {
                    barraEsquerda = "/";
                    valorEsquerda = galhosEsquerda[index].ToString();
                }

                var valorDireita = " ";
                var barraDireita = " ";
                if (galhosDireita.Count > index)
                {
                    barraDireita = @"\";
                    valorDireita = galhosDireita[index].ToString();
                }

                if (index == 0)
                    sbDesenho.AppendLine(Util.DesenharEspacos(quantidadeEspacosInicio) + raiz);

                quantidadeEspacosInicio = (listaMaior * 2) - (index * 2) - 1;
                quantidadeEspacosMeio = (listaMaior * 2) - quantidadeEspacosInicio + (index * 2);

                sbDesenho.AppendLine(Util.DesenharEspacos(quantidadeEspacosInicio) + barraEsquerda + Util.DesenharEspacos(quantidadeEspacosMeio) + barraDireita);
                sbDesenho.AppendLine(Util.DesenharEspacos(quantidadeEspacosInicio - 1) + valorEsquerda + Util.DesenharEspacos(quantidadeEspacosMeio + 2) + valorDireita);


                index++;
            }

            Console.Write(sbDesenho.ToString());

        }
    }
}
