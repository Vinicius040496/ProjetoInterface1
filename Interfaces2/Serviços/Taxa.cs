using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2.Serviços
{
    internal class Taxa : InterfaceTaxaServico
    {

        public double TaxaImposto(double quantia)
        {
            if (quantia <= 100.0)
            {
                return quantia * 0.2;
            }
            else
            {
                return quantia * 0.15;
            }
        }
    }
}
