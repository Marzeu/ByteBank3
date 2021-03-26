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
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(111, 111111);

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(876, 567098),
                new ContaCorrente(876, 654798));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }




            //string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            //ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            //string moedaDestino = extratorDeValores.GetValor("moedaDestino");
            //Console.WriteLine("Valor de moedaDestino: " + moedaDestino);

            //string moedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            //Console.WriteLine("Valor de moedaOrigem: " + moedaOrigem);

            //string valor = extratorDeValores.GetValor("VALOR");
            //Console.WriteLine("O Valor é: " + valor);

            //DateTime dataFimPagamento = new DateTime(2021, 6, 05);
            //DateTime dataCorrente = DateTime.Now;

            //TimeSpan diferença = TimeSpan.FromMinutes(60); //dataFimPagamento - dataCorrente;

            // string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferença);

            // Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
