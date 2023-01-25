namespace ParadigmaTarefa02
{
    public class Util
    {
        public static string DesenharEspacos(int Quantidade)
        {
            var retorno = "";
            for (int index = 1; index <= Quantidade; index++)
                retorno += " ";

            return retorno;
        }
    }
}
