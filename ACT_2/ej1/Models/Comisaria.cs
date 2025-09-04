using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
    internal class Comisaria
    {
        public int CantidadIncidentes { get; private set; }
        Guardia[] guardias;
        public int ContGuardias { get; private set; }
        Policia[] agentes;
        public int ContAgentes { get; private set; }
        List<Incidente> incidentes;
        public Comisaria()
        {
            CantidadIncidentes = 0;
            guardias = new Guardia[2];
            ContGuardias = 0;
            agentes = new Policia[2];
            ContAgentes = 0;
            incidentes = new List<Incidente>();
        }
        public bool AsignarPolicia(Policia oficial)
        {
            if (ContAgentes < 2)
            {
                agentes[ContAgentes] = oficial;
                ContAgentes++;
                return true;
            }
            else { return false; }
        }
        public Policia VerAgente(int numeroPlaca)
        {
            Policia agente = null;
            for(int i = 0; i < ContAgentes; i++)
            {
                if (agentes[i].NumeroPlaca == numeroPlaca)
                {
                    agente = agentes[i];
                }
            }
            return agente;
        }
        public void AsignarGuardia(int numero, int h1, int m1, int tiempoMinutos, Policia agente)
        {
            Guardia guardia = new Guardia();
            guardia.AsignarPolicia(agente, h1, m1, tiempoMinutos);
            guardias[ContGuardias] = guardia;
            ContGuardias++;
        }
        public void RegistrarIncidente(Policia agente, Persona sujeto, string motivo, int h, int m, int tipoIncidente)
        {
            Incidente incidente = null;
            if (tipoIncidente == 1)
            {
                incidente = new Denuncia(agente, sujeto);
            }
            else if (tipoIncidente == 2)
            {
                incidente = new Arresto(sujeto, agente);
            }
            incidente.Motivo = motivo;
            incidente.Hora = h;
            incidente.Minuto = m;
            incidentes.Add(incidente);
            CantidadIncidentes++;
        }
        public Incidente VerIncidente(int idx)
        {
            return incidentes[idx];
        }
    }
}
