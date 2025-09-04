using ej1.Models;

namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Comisaria comisaria = new Comisaria();
        FormVerIncidentes modalIncidentes;
        private void btnCrearComisaria_Click(object sender, EventArgs e)
        {
            Comisaria comisaria = new Comisaria();
        }

        private void btnListarIncidente_Click(object sender, EventArgs e)
        {
            modalIncidentes = new FormVerIncidentes();
            for (int i = 0; i < comisaria.CantidadIncidentes; i++) 
            {   
                Incidente incidente = comisaria.VerIncidente(i);
                modalIncidentes.lsbIncidentes.Items.Add($"--------{i}-------");
                modalIncidentes.lsbIncidentes.Items.Add(incidente.VerDescripcion());
                
            }
            modalIncidentes.ShowDialog();

        }

        private void btnAsignacionGuardia_Click(object sender, EventArgs e)
        {
            Guardia guardia = new Guardia();
            int nroGuardia = Convert.ToInt32(nudGuardia.Value);
            Policia agenteAsignado = comisaria.VerAgente(nroGuardia);
            if (agenteAsignado != null)
            {
                int hDesde = Convert.ToInt32(nudHora.Value);
                int mDesde = Convert.ToInt32(nudMinuto.Value);
                int cantM = Convert.ToInt32(nudDuracionM.Value);
                comisaria.AsignarGuardia(agenteAsignado.NumeroPlaca, hDesde, mDesde, cantM, agenteAsignado);
                MessageBox.Show($"Guardia asignado: {agenteAsignado.Nombre}" +
                    $"DNI {agenteAsignado.DNI} - N° Placa {agenteAsignado.NumeroPlaca}" +
                    $"Desde las {hDesde}:{mDesde} hasta las {guardia.HoraHasta}:{guardia.MinutoHasta}");
            }
            else { MessageBox.Show("Agente inexistente"); }
        }

        private void btnAsignarAgente_Click(object sender, EventArgs e)
        {
            int placaAgente = Convert.ToInt32(cbPlaca.Text);
            int dniAgente = Convert.ToInt32(tbDNIAgente.Text);
            string nombreAgente = tbNombreAgente.Text;
            Policia agente = new Policia(dniAgente, nombreAgente, placaAgente);
            if (comisaria.AsignarPolicia(agente) == false)
            {
                MessageBox.Show("Máximo de agentes asignados.");
            }
            else
            {
                btnAsignarAgente.Text = $"Asignar Agente ({comisaria.ContAgentes}))";
            }
        }

        private void btnRegistrarIncidente_Click(object sender, EventArgs e)
        {
            int tipoIncidente; if(cbTipoIncidente.Text == "Denuncia") { tipoIncidente = 1; } else { tipoIncidente = 2; }
            int hora = Convert.ToInt32(nudHoraIncidente.Value);
            int minuto = Convert.ToInt32(nudMinutoIncidente.Value);
            string motivo = tbMotivo.Text;
            string nombrePersona = tbPersona.Text; int dniPersona = Convert.ToInt32(tbDNI.Text); Persona persona = new Persona(dniPersona, nombrePersona);
            Policia agente = comisaria.VerAgente(Convert.ToInt32(cbPlaca.Text));if (agente == null) { MessageBox.Show("Agente inexistente"); }
            else
            { comisaria.RegistrarIncidente(agente, persona, motivo, hora, minuto, tipoIncidente); }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {   
            Close();
        }
    }
}
