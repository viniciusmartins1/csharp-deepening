using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //moedaOrigem=real&moedaDestino=dolar
            //
            // ---------------------------


            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&avalor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            Console.WriteLine("Valor de moedaDestino: " + extratorDeValores.GetValor("moedaDestino"));
            Console.WriteLine("Valor de moedaOrigem: " + extratorDeValores.GetValor("moedaOrigem"));
            Console.WriteLine("Valor de moedaOrigem: " + extratorDeValores.GetValor("valor"));

            Console.ReadLine();


            // Testando o metodo remove
            string testeRemocao = "primeiraparte&parteParRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            
            Console.ReadLine();

            // <nome>=<valor>

            string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            

        }
    }
}
