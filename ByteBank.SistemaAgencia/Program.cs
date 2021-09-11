using System;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(1234, 23412421);
            object desenvolvedor = new Desenvolvedor("45235234");

            string contaToString = conta.ToString();

            Console.WriteLine($"Resultado {conta.ToString()}");
            Console.WriteLine(conta);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "321.213.123-13";
            carlos_1.Profissao = "Designer";
            
            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "321.213.123-13";
            carlos_2.Profissao = "Designer";

            ContaCorrente conta_2 = new ContaCorrente(32433, 234242);

            if(carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São Iguais");
            }
            else
            {
                Console.WriteLine("Não são iguais");
            }

        }

        static void TestaString()
        {

            
            // "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"
            // "[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]";
            // "[0-9]{4,5}[-][0-9]{4}";
            // "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            // "[0-9]{4,5}-{0,1}[0-9]{4}";
            string  padrao = "[0-9]{4,5}-?[0-9]{4}";


            string textoDeTeste = "Meu nome é Vinicius, me ligue em 94784-4546";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();

            //Testando Starts With, Ends With and Contains;

            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));

            Console.WriteLine(urlTeste.Contains("bytebank"));
            
            Console.ReadLine(); 

            //moedaOrigem=real&moedaDestino=dolar
            //
            // ---------------------------

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&avalor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            Console.WriteLine("Valor de moedaDestino: " + extratorDeValores.GetValor("moedaDestino"));
            Console.WriteLine("Valor de moedaOrigem: " + extratorDeValores.GetValor("moedaOrigem"));
            Console.WriteLine("Valor de moedaOrigem: " + extratorDeValores.GetValor("valor"));

            Console.ReadLine();

            //Testando ToLower and ToUpper
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());

            //Testando Replace
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);


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
