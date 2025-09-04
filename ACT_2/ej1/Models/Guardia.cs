using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
    internal class Guardia
    {
        public int HoraDesde { get; private set; }
        public int MinutoDesde { get; private set; }
        public int HoraHasta {  get; private set; }
        public int MinutoHasta { get; private set; }
        public int CantidadMinutos { get; private set; }
        public Policia oficialAsignado;
        public Guardia()
        {
          
        }
        public void AsignarPolicia(Policia oficial, int h, int m, int cantM)
        {
            oficialAsignado = oficial;
            HoraDesde = h;
            MinutoDesde = m;
            CantidadMinutos = cantM;
            HoraHasta = ((HoraDesde * 60 + MinutoDesde) + cantM) / 60;
            MinutoHasta = ((HoraDesde * 60 + MinutoDesde) + cantM) % 60;
        }
    }
}
