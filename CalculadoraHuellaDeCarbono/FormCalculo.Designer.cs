using System;
using System.Drawing;
using System.Windows.Forms; 

namespace CalculadoraHuellaDeCarbono
{
    partial class FormCalculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtElectricidad = new TextBox();
            txtTransporte = new TextBox();
            txtGas = new TextBox();
            txtResiduos = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtElectricidad
            // 
            txtElectricidad.Location = new Point(83, 74);
            txtElectricidad.Name = "txtElectricidad";
            txtElectricidad.Size = new Size(100, 23);
            txtElectricidad.TabIndex = 0;
            txtElectricidad.Text = "txtElectricidad";
            // 
            // txtTransporte
            // 
            txtTransporte.Location = new Point(83, 103);
            txtTransporte.Name = "txtTransporte";
            txtTransporte.Size = new Size(100, 23);
            txtTransporte.TabIndex = 1;
            txtTransporte.Text = "txtTransporte";
            // 
            // txtGas
            // 
            txtGas.Location = new Point(83, 132);
            txtGas.Name = "txtGas";
            txtGas.Size = new Size(100, 23);
            txtGas.TabIndex = 2;
            txtGas.Text = "txtGas";
            // 
            // txtResiduos
            // 
            txtResiduos.Location = new Point(83, 161);
            txtResiduos.Name = "txtResiduos";
            txtResiduos.Size = new Size(100, 23);
            txtResiduos.TabIndex = 3;
            txtResiduos.Text = "txtResiduos";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(83, 216);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 30);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "btnCalcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(102, 273);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "lblResultado";
            // 
            // FormCalculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtResiduos);
            Controls.Add(txtGas);
            Controls.Add(txtTransporte);
            Controls.Add(txtElectricidad);
            Name = "FormCalculo";
            Text = "FormCalculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtElectricidad;
        private TextBox txtTransporte;
        private TextBox txtGas;
        private TextBox txtResiduos;
        private Button btnCalcular;
        private Label lblResultado;
    }
}