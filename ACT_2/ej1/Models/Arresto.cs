using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
    public class Arresto : Incidente
    {
        public Arresto(Persona sujeto, Policia oficial) : base(oficial, sujeto)
        {

        }
        public override string VerDescripcion()
        {
            return $@"Orden de Arresto, Emitada a las {Hora}:{Minuto} 
Motivo: {Motivo}
Sujeto a arrestar:{sujeto.VerDatos()}
Orden: Por la presente se ordena al arresto inmediato de {sujeto.VerDatos()}. El Agente {agente.VerDatos()} está autorizado a proceder con el arresto conforme a las leyes y regulaciones aplicadas
";
        }
    }
}
