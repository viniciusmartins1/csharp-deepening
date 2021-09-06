using System;
namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private string _argumentos { get;}
        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {
            
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("O argumento url não pode ser nulo ou vazio",nameof(url));
            }

            URL = url;

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

        }

        //moedaOrigem=real&moedaDestino=dolar
        public string GetValor(string nomeParamentro)
        {
            string termo = nomeParamentro + "=";
            int indiceTermo = _argumentos.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');


            if(indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);

            //return "";
        }
    }
}