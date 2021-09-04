using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?argumentos";

            Console.WriteLine(url);
            string argumentos = url.Substring(7);
            Console.WriteLine(argumentos);

        }

        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if(timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                if(quantidadeMeses == 1)
                {
                    return " 1 mês";
                }
                return quantidadeMeses + " meses";
            }

            return timeSpan.Days + " dias";
        }
    }
}
