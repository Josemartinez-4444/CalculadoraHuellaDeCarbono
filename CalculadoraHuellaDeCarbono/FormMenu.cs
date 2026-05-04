using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraHuellaDeCarbono
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            FormCalculo f = new FormCalculo();
            f.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial f = new FormHistorial();
            f.Show();
        }
    }
}