using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces2.Entites;

namespace Interfaces2.Serviços
{
    internal class Aluguel
    {
        public double PreçoHora { get; set; }
        public double PreçoDia { get; set; }
        private InterfaceTaxaServico Taxa;

        public Aluguel(double preçoHora, double preçoDia,InterfaceTaxaServico taxa)
        {
            PreçoHora = preçoHora;
            PreçoDia = preçoDia;
            Taxa = taxa;
        }

        public void ProcessarPagamento(Locação locação)
        {
            TimeSpan duração = locação.Fim.Subtract(locação.Inicio);

            double soma = 0.0;
            if (duração.TotalHours <= 12)
            {
                soma = PreçoHora * Math.Ceiling(duração.TotalHours);
            }
            else
            {
                soma = PreçoDia * Math.Ceiling(duração.TotalDays);
            }
            double ImpostoTaxa = Taxa.TaxaImposto(soma);

           locação.Fatura = new Fatura(ImpostoTaxa,soma);
        }
    }
}
