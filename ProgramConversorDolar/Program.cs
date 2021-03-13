using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConversorDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de dólar a ser comprada: ");
            double quantia = double.Parse(Console.ReadLine());

            double result = ConversorDeMoeda.Conversor(cotacao, quantia);

            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2"));

            Console.ReadLine();
        }
    }
}
