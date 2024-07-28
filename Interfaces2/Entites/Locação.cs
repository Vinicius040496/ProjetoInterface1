using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2.Entites
{
    internal class Locação
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Modelo { get; set; }
        public Fatura Fatura { get; set; }

        public Locação(DateTime inicio, DateTime fim, Veiculo modelo)
        {
            Inicio = inicio;
            Fim = fim;
            Modelo = modelo;
        }
    }

}
