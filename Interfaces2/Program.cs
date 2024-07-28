using Interfaces2.Entites;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces2.Serviços;

namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com dados da locação: ");
                Console.WriteLine();
                Console.Write("Modelo carro: ");
                string modelo = Console.ReadLine();
                Console.Write("Horario de retira: ");
                DateTime inicio = DateTime.ParseExact(Console.ReadLine(), ("dd/MM/yyyy HH:mm"), CultureInfo.InvariantCulture);
                Console.Write("Horario de entrega: ");
                DateTime fim = DateTime.ParseExact(Console.ReadLine(), ("dd/MM/yyyy HH:mm"), CultureInfo.InvariantCulture);

                Locação locação = new Locação(inicio, fim, new Veiculo(modelo));

                Console.Write("Entre com valor hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entre com valor diaria: ");
                double valorDiaria = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Aluguel aluguel = new Aluguel(valorHora, valorDiaria, new Taxa());

                aluguel.ProcessarPagamento(locação);

                Console.WriteLine(locação.Fatura);
                Console.ReadLine();
            }
            catch (EntitesException e)
            {
                Console.WriteLine(e.Message);
            }
          
        }
    }
}
