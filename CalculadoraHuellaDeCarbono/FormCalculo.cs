using System;
using System.Windows.Forms;

namespace CalculadoraHuellaDeCarbono
{
    public partial class FormCalculo : Form
    {
        public FormCalculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                double electricidad = Convert.ToDouble(txtElectricidad.Text);
                double transporte = Convert.ToDouble(txtTransporte.Text);
                double gas = Convert.ToDouble(txtGas.Text);
                double residuos = Convert.ToDouble(txtResiduos.Text);

                double huella =
                    (electricidad * 0.42) +
                    (transporte * 0.21) +
                    (gas * 2.0) +
                    (residuos * 0.45);

                string nivel;

                if (huella < 100)
                    nivel = "Baja";
                else if (huella < 300)
                    nivel = "Media";
                else
                    nivel = "Alta";

                lblResultado.Text = $"Huella total: {huella:N2} kg CO₂";
                lblNivel.Text = $"Nivel de impacto: {nivel}";

                Datos.lista.Add(huella);
            }
            catch
            {
                MessageBox.Show("Ingresa números válidos");
            }
        }
    }
}