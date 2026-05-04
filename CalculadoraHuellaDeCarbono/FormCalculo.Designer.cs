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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblNivel = new Label();
            SuspendLayout();
            // 
            // txtElectricidad
            // 
            txtElectricidad.Location = new Point(253, 81);
            txtElectricidad.Name = "txtElectricidad";
            txtElectricidad.Size = new Size(100, 25);
            txtElectricidad.TabIndex = 0;
            // 
            // txtTransporte
            // 
            txtTransporte.Location = new Point(253, 129);
            txtTransporte.Name = "txtTransporte";
            txtTransporte.Size = new Size(100, 25);
            txtTransporte.TabIndex = 1;
            // 
            // txtGas
            // 
            txtGas.Location = new Point(253, 173);
            txtGas.Name = "txtGas";
            txtGas.Size = new Size(100, 25);
            txtGas.TabIndex = 2;
            // 
            // txtResiduos
            // 
            txtResiduos.Location = new Point(253, 219);
            txtResiduos.Name = "txtResiduos";
            txtResiduos.Size = new Size(100, 25);
            txtResiduos.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 9.980198F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(319, 321);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 34);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(542, 116);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 17);
            lblResultado.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 84);
            label1.Name = "label1";
            label1.Size = new Size(193, 17);
            label1.TabIndex = 6;
            label1.Text = "Consumo de electricidad (kWh):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 129);
            label2.Name = "label2";
            label2.Size = new Size(150, 17);
            label2.TabIndex = 6;
            label2.Text = "Distancia recorrida (km):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 176);
            label3.Name = "label3";
            label3.Size = new Size(138, 17);
            label3.TabIndex = 6;
            label3.Text = "Consumo de gas (m³):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 222);
            label4.Name = "label4";
            label4.Size = new Size(157, 17);
            label4.TabIndex = 6;
            label4.Text = "Residuos generados (kg):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.1188116F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(589, 63);
            label5.Name = "label5";
            label5.Size = new Size(135, 23);
            label5.TabIndex = 5;
            label5.Text = "¡Tus resultados!";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Location = new Point(542, 173);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(0, 17);
            lblNivel.TabIndex = 5;
            // 
            // FormCalculo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(lblNivel);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblNivel;
    }
}