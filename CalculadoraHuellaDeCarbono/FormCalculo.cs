using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculadoraHuellaDeCarbono

    {
    public partial class FormCalculo : Form
    { // <--- Agrega esta línea y esta llave
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double electricidad = Convert.ToDouble(txtElectricidad.Text);
            double transporte = Convert.ToDouble(txtTransporte.Text);
            double gas = Convert.ToDouble(txtGas.Text);
            double residuos = Convert.ToDouble(txtResiduos.Text);

            double huella =
                (electricidad * 0.5) +
                (transporte * 0.2) +
                (gas * 0.3) +
                (residuos * 0.1);

            lblResultado.Text = "Huella: " + huella;

            // Guardar en memoria (temporal)
            Datos.lista.Add(huella);
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                // Importante: revisa que tus cuadros de texto se llamen así en las Propiedades
                double electricidad = Convert.ToDouble(txtElectricidad.Text);
                double transporte = Convert.ToDouble(txtTransporte.Text);
                double gas = Convert.ToDouble(txtGas.Text);
                double residuos = Convert.ToDouble(txtResiduos.Text);

                double huella = (electricidad * 0.5) + (transporte * 0.2) + (gas * 0.3) + (residuos * 0.1);

                // Cambia lblResultado por el nombre que tenga tu etiqueta de respuesta
                lblResultado.Text = "Tu huella es: " + huella.ToString("N2");

                Datos.lista.Add(huella);
            }
            catch
            {
                MessageBox.Show("Escribe números válidos en todos los campos");
            }
        }
    }
    }
