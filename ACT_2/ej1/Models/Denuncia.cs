using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
    public class Denuncia: Incidente
    {
        public Denuncia(Policia agente, Persona sujeto) : base(agente, sujeto)
        {

        }
        public override string VerDescripcion()
        {
            return $@"Denuncia Policial, Emitida a las {Hora}:{Minuto} 
Motivo: {Motivo}
Agente policial inteviniente: {agente.VerDatos()}
Sujeto Denunciante:{sujeto.VerDatos()}
";
        }
    }
}
