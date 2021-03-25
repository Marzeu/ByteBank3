using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
           string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
           ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

           string valor = extratorDeValores.GetValor("moedaDestino");
           Console.WriteLine("Valor de moedaDestino: " + valor);
            
            

            //DateTime dataFimPagamento = new DateTime(2021, 6, 05);
            //DateTime dataCorrente = DateTime.Now;

            //TimeSpan diferença = TimeSpan.FromMinutes(60); //dataFimPagamento - dataCorrente;

            // string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferença);

            // Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
