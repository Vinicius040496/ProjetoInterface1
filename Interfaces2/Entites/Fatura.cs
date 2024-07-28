using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2.Entites
{
    internal class Fatura
    {
        public double PagamentoBase { get; set; }
        public double Taxa { get; set; }

        public Fatura(double pagamentoBase, double taxa)
        {
            PagamentoBase = pagamentoBase;
            Taxa = taxa;
        }

        public double PagamentoTotal()
        {
            return PagamentoBase + Taxa;
        }
        public override string ToString()
        {
            return "Nota pagamento: " + "\nPagamento base: " + PagamentoBase.ToString("f2", CultureInfo.InvariantCulture)
                + "\nTaxa: " + Taxa.ToString("f2", CultureInfo.InvariantCulture)
                + "\nPagamento Total: " + PagamentoTotal().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
