using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
    abstract public class Incidente
    {
        public string Motivo { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public Policia agente { get; private set; }
        public Persona sujeto { get; private set; }
        
        public Incidente(Policia oficial, Persona sujeto)
        {
            this.agente = oficial;
            this.sujeto = sujeto;
        }
        public abstract string VerDescripcion();

    }
}
