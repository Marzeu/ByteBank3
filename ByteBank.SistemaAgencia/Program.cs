using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 3, 25);
            DateTime dataCorrente = DateTime.Now;

            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente);


            Console.ReadLine();
        }
    }
}
