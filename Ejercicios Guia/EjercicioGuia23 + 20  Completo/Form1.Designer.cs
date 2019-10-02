
using Moneda;
using System;

namespace Ejercicio23_Forms_
{
    partial class Ventana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.DolarButton = new System.Windows.Forms.Button();
            this.LockButton = new System.Windows.Forms.Button();
            this.DolarInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DolarXDolarOutputTextBox = new System.Windows.Forms.TextBox();
            this.DolarXPesoOutputBox = new System.Windows.Forms.TextBox();
            this.CotizacionDolarInputTextBox = new System.Windows.Forms.TextBox();
            this.CotizacionPesoInputTextBox = new System.Windows.Forms.TextBox();
            this.PesoInputTextBox = new System.Windows.Forms.TextBox();
            this.PesoButton = new System.Windows.Forms.Button();
            this.PesoXDolarOutputTextBox = new System.Windows.Forms.TextBox();
            this.PesoXPesoOutputTextBox = new System.Windows.Forms.TextBox();
            this.CotizacionEuroInputTextBox1 = new System.Windows.Forms.TextBox();
            this.EuroInputTextBox = new System.Windows.Forms.TextBox();
            this.EuroButton = new System.Windows.Forms.Button();
            this.EuroXDolarTextBox = new System.Windows.Forms.TextBox();
            this.EuroXEuroTextBox = new System.Windows.Forms.TextBox();
            this.EuroXPesoTextBox = new System.Windows.Forms.TextBox();
            this.PesoXEuroTextBox = new System.Windows.Forms.TextBox();
            this.DolarXEuroTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DolarButton
            // 
            this.DolarButton.Location = new System.Drawing.Point(194, 112);
            this.DolarButton.Name = "DolarButton";
            this.DolarButton.Size = new System.Drawing.Size(75, 23);
            this.DolarButton.TabIndex = 0;
            this.DolarButton.Text = "->";
            this.DolarButton.UseVisualStyleBackColor = true;
            this.DolarButton.Click += new System.EventHandler(this.DolarButton_Click);
            // 
            // LockButton
            // 
            this.LockButton.Location = new System.Drawing.Point(113, 22);
            this.LockButton.Name = "LockButton";
            this.LockButton.Size = new System.Drawing.Size(75, 23);
            this.LockButton.TabIndex = 3;
            this.LockButton.Text = "LOCK";
            this.LockButton.UseVisualStyleBackColor = true;
            this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
            // 
            // DolarInputTextBox
            // 
            this.DolarInputTextBox.Location = new System.Drawing.Point(88, 115);
            this.DolarInputTextBox.Name = "DolarInputTextBox";
            this.DolarInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.DolarInputTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "EURO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DOLAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "PESOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "COTIZACION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "EURO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "DOLAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "PESOS";
            // 
            // DolarXDolarOutputTextBox
            // 
            this.DolarXDolarOutputTextBox.Location = new System.Drawing.Point(414, 114);
            this.DolarXDolarOutputTextBox.Name = "DolarXDolarOutputTextBox";
            this.DolarXDolarOutputTextBox.Size = new System.Drawing.Size(100, 20);
            this.DolarXDolarOutputTextBox.TabIndex = 20;
            // 
            // DolarXPesoOutputBox
            // 
            this.DolarXPesoOutputBox.Location = new System.Drawing.Point(534, 114);
            this.DolarXPesoOutputBox.Name = "DolarXPesoOutputBox";
            this.DolarXPesoOutputBox.Size = new System.Drawing.Size(100, 20);
            this.DolarXPesoOutputBox.TabIndex = 21;
            // 
            // CotizacionDolarInputTextBox
            // 
            this.CotizacionDolarInputTextBox.Enabled = false;
            this.CotizacionDolarInputTextBox.Location = new System.Drawing.Point(414, 25);
            this.CotizacionDolarInputTextBox.Name = "CotizacionDolarInputTextBox";
            this.CotizacionDolarInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.CotizacionDolarInputTextBox.TabIndex = 27;
            this.CotizacionDolarInputTextBox.Text = "1";
            // 
            // CotizacionPesoInputTextBox
            // 
            this.CotizacionPesoInputTextBox.Location = new System.Drawing.Point(534, 25);
            this.CotizacionPesoInputTextBox.Name = "CotizacionPesoInputTextBox";
            this.CotizacionPesoInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.CotizacionPesoInputTextBox.TabIndex = 28;
            this.CotizacionPesoInputTextBox.Text = "0";
            this.CotizacionPesoInputTextBox.Leave += new System.EventHandler(this.CotizacionPesoInputTextBox_Leave);
            // 
            // PesoInputTextBox
            // 
            this.PesoInputTextBox.Location = new System.Drawing.Point(88, 148);
            this.PesoInputTextBox.Name = "PesoInputTextBox";
            this.PesoInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.PesoInputTextBox.TabIndex = 29;
            // 
            // PesoButton
            // 
            this.PesoButton.Location = new System.Drawing.Point(194, 146);
            this.PesoButton.Name = "PesoButton";
            this.PesoButton.Size = new System.Drawing.Size(75, 23);
            this.PesoButton.TabIndex = 30;
            this.PesoButton.Text = "->";
            this.PesoButton.UseVisualStyleBackColor = true;
            this.PesoButton.Click += new System.EventHandler(this.PesoButton_Click);
            // 
            // PesoXDolarOutputTextBox
            // 
            this.PesoXDolarOutputTextBox.Location = new System.Drawing.Point(414, 149);
            this.PesoXDolarOutputTextBox.Name = "PesoXDolarOutputTextBox";
            this.PesoXDolarOutputTextBox.Size = new System.Drawing.Size(100, 20);
            this.PesoXDolarOutputTextBox.TabIndex = 31;
            // 
            // PesoXPesoOutputTextBox
            // 
            this.PesoXPesoOutputTextBox.Location = new System.Drawing.Point(534, 148);
            this.PesoXPesoOutputTextBox.Name = "PesoXPesoOutputTextBox";
            this.PesoXPesoOutputTextBox.Size = new System.Drawing.Size(100, 20);
            this.PesoXPesoOutputTextBox.TabIndex = 32;
            // 
            // CotizacionEuroInputTextBox1
            // 
            this.CotizacionEuroInputTextBox1.Location = new System.Drawing.Point(298, 25);
            this.CotizacionEuroInputTextBox1.Name = "CotizacionEuroInputTextBox1";
            this.CotizacionEuroInputTextBox1.Size = new System.Drawing.Size(100, 20);
            this.CotizacionEuroInputTextBox1.TabIndex = 33;
            this.CotizacionEuroInputTextBox1.Text = "0";
            this.CotizacionEuroInputTextBox1.Leave += new System.EventHandler(this.CotizacionEuroInputTextBox1_Leave);
            // 
            // EuroInputTextBox
            // 
            this.EuroInputTextBox.Location = new System.Drawing.Point(88, 74);
            this.EuroInputTextBox.Name = "EuroInputTextBox";
            this.EuroInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.EuroInputTextBox.TabIndex = 34;
            // 
            // EuroButton
            // 
            this.EuroButton.Location = new System.Drawing.Point(194, 74);
            this.EuroButton.Name = "EuroButton";
            this.EuroButton.Size = new System.Drawing.Size(75, 23);
            this.EuroButton.TabIndex = 35;
            this.EuroButton.Text = "->";
            this.EuroButton.UseVisualStyleBackColor = true;
            this.EuroButton.Click += new System.EventHandler(this.EuroButton_Click);
            // 
            // EuroXDolarTextBox
            // 
            this.EuroXDolarTextBox.Location = new System.Drawing.Point(414, 74);
            this.EuroXDolarTextBox.Name = "EuroXDolarTextBox";
            this.EuroXDolarTextBox.Size = new System.Drawing.Size(100, 20);
            this.EuroXDolarTextBox.TabIndex = 36;
            // 
            // EuroXEuroTextBox
            // 
            this.EuroXEuroTextBox.Location = new System.Drawing.Point(298, 74);
            this.EuroXEuroTextBox.Name = "EuroXEuroTextBox";
            this.EuroXEuroTextBox.Size = new System.Drawing.Size(100, 20);
            this.EuroXEuroTextBox.TabIndex = 37;
            // 
            // EuroXPesoTextBox
            // 
            this.EuroXPesoTextBox.Location = new System.Drawing.Point(535, 74);
            this.EuroXPesoTextBox.Name = "EuroXPesoTextBox";
            this.EuroXPesoTextBox.Size = new System.Drawing.Size(100, 20);
            this.EuroXPesoTextBox.TabIndex = 38;
            // 
            // PesoXEuroTextBox
            // 
            this.PesoXEuroTextBox.Location = new System.Drawing.Point(298, 148);
            this.PesoXEuroTextBox.Name = "PesoXEuroTextBox";
            this.PesoXEuroTextBox.Size = new System.Drawing.Size(100, 20);
            this.PesoXEuroTextBox.TabIndex = 39;
            // 
            // DolarXEuroTextBox
            // 
            this.DolarXEuroTextBox.Location = new System.Drawing.Point(298, 114);
            this.DolarXEuroTextBox.Name = "DolarXEuroTextBox";
            this.DolarXEuroTextBox.Size = new System.Drawing.Size(100, 20);
            this.DolarXEuroTextBox.TabIndex = 40;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 207);
            this.Controls.Add(this.DolarXEuroTextBox);
            this.Controls.Add(this.PesoXEuroTextBox);
            this.Controls.Add(this.EuroXPesoTextBox);
            this.Controls.Add(this.EuroXEuroTextBox);
            this.Controls.Add(this.EuroXDolarTextBox);
            this.Controls.Add(this.EuroButton);
            this.Controls.Add(this.EuroInputTextBox);
            this.Controls.Add(this.CotizacionEuroInputTextBox1);
            this.Controls.Add(this.PesoXPesoOutputTextBox);
            this.Controls.Add(this.PesoXDolarOutputTextBox);
            this.Controls.Add(this.PesoButton);
            this.Controls.Add(this.PesoInputTextBox);
            this.Controls.Add(this.CotizacionPesoInputTextBox);
            this.Controls.Add(this.CotizacionDolarInputTextBox);
            this.Controls.Add(this.DolarXPesoOutputBox);
            this.Controls.Add(this.DolarXDolarOutputTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DolarInputTextBox);
            this.Controls.Add(this.LockButton);
            this.Controls.Add(this.DolarButton);
            this.Name = "Ventana";
            this.Text = "VentanaTexto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DolarButton;
        private System.Windows.Forms.Button LockButton;
        private System.Windows.Forms.TextBox DolarInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DolarXDolarOutputTextBox;
        private System.Windows.Forms.TextBox DolarXPesoOutputBox;
        private System.Windows.Forms.TextBox CotizacionDolarInputTextBox;
        private System.Windows.Forms.TextBox CotizacionPesoInputTextBox;
        private System.Windows.Forms.TextBox PesoInputTextBox;
        private System.Windows.Forms.Button PesoButton;
        private System.Windows.Forms.TextBox PesoXDolarOutputTextBox;
        private System.Windows.Forms.TextBox PesoXPesoOutputTextBox;
        private System.Windows.Forms.TextBox CotizacionEuroInputTextBox1;
        private System.Windows.Forms.TextBox EuroInputTextBox;
        private System.Windows.Forms.Button EuroButton;
        private System.Windows.Forms.TextBox EuroXDolarTextBox;
        private System.Windows.Forms.TextBox EuroXEuroTextBox;
        private System.Windows.Forms.TextBox EuroXPesoTextBox;
        private System.Windows.Forms.TextBox PesoXEuroTextBox;
        private System.Windows.Forms.TextBox DolarXEuroTextBox;
    }
}

