namespace FrmMostrar
{
    partial class FrmGenerarLlamada
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
            this.textoNumeroDestino = new System.Windows.Forms.RichTextBox();
            this.comboBoxFranjas = new System.Windows.Forms.ComboBox();
            this.botonLlamar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.textoNumeroOrigen = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNumeral = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonAsterisco = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoNumeroDestino
            // 
            this.textoNumeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNumeroDestino.Location = new System.Drawing.Point(12, 12);
            this.textoNumeroDestino.Multiline = false;
            this.textoNumeroDestino.Name = "textoNumeroDestino";
            this.textoNumeroDestino.ReadOnly = true;
            this.textoNumeroDestino.Size = new System.Drawing.Size(217, 39);
            this.textoNumeroDestino.TabIndex = 0;
            this.textoNumeroDestino.Text = "Nro destino";
            this.textoNumeroDestino.TextChanged += new System.EventHandler(this.textoNumeroDestino_TextChanged);
            // 
            // comboBoxFranjas
            // 
            this.comboBoxFranjas.Enabled = false;
            this.comboBoxFranjas.FormattingEnabled = true;
            this.comboBoxFranjas.Location = new System.Drawing.Point(15, 221);
            this.comboBoxFranjas.Name = "comboBoxFranjas";
            this.comboBoxFranjas.Size = new System.Drawing.Size(214, 21);
            this.comboBoxFranjas.TabIndex = 2;
            // 
            // botonLlamar
            // 
            this.botonLlamar.Location = new System.Drawing.Point(132, 83);
            this.botonLlamar.Name = "botonLlamar";
            this.botonLlamar.Size = new System.Drawing.Size(102, 26);
            this.botonLlamar.TabIndex = 3;
            this.botonLlamar.Text = "Llamar";
            this.botonLlamar.UseVisualStyleBackColor = true;
            this.botonLlamar.Click += new System.EventHandler(this.botonLlamar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(132, 115);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(102, 26);
            this.botonLimpiar.TabIndex = 4;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.BotonLimpiar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(134, 175);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(102, 26);
            this.botonSalir.TabIndex = 5;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // textoNumeroOrigen
            // 
            this.textoNumeroOrigen.Location = new System.Drawing.Point(134, 146);
            this.textoNumeroOrigen.Name = "textoNumeroOrigen";
            this.textoNumeroOrigen.Size = new System.Drawing.Size(100, 22);
            this.textoNumeroOrigen.TabIndex = 6;
            this.textoNumeroOrigen.Text = "Nro Origen";
            this.textoNumeroOrigen.Click += new System.EventHandler(this.TextoNumeroOrigen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNumeral);
            this.groupBox1.Controls.Add(this.button0);
            this.groupBox1.Controls.Add(this.buttonAsterisco);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 158);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // buttonNumeral
            // 
            this.buttonNumeral.Location = new System.Drawing.Point(74, 115);
            this.buttonNumeral.Name = "buttonNumeral";
            this.buttonNumeral.Size = new System.Drawing.Size(28, 23);
            this.buttonNumeral.TabIndex = 14;
            this.buttonNumeral.Text = "#";
            this.buttonNumeral.UseVisualStyleBackColor = true;
            this.buttonNumeral.Click += new System.EventHandler(this.ButtonNumeral_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(40, 115);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(28, 23);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // buttonAsterisco
            // 
            this.buttonAsterisco.Location = new System.Drawing.Point(6, 115);
            this.buttonAsterisco.Name = "buttonAsterisco";
            this.buttonAsterisco.Size = new System.Drawing.Size(28, 23);
            this.buttonAsterisco.TabIndex = 12;
            this.buttonAsterisco.Text = "*";
            this.buttonAsterisco.UseVisualStyleBackColor = true;
            this.buttonAsterisco.Click += new System.EventHandler(this.ButtonAsterisco_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(74, 87);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(28, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(40, 87);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(74, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(40, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmGenerarLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 254);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textoNumeroOrigen);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonLlamar);
            this.Controls.Add(this.comboBoxFranjas);
            this.Controls.Add(this.textoNumeroDestino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGenerarLlamada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmGenerarLlamada";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textoNumeroDestino;
        private System.Windows.Forms.ComboBox comboBoxFranjas;
        private System.Windows.Forms.Button botonLlamar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.RichTextBox textoNumeroOrigen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNumeral;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonAsterisco;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}