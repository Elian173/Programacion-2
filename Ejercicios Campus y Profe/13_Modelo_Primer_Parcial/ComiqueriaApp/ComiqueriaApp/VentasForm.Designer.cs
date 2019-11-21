namespace ComiqueriaApp
{
    partial class VentasForm
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
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelNombrePrecioFinal = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.buttonVender = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(39, 32);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(74, 13);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelNombrePrecioFinal
            // 
            this.labelNombrePrecioFinal.AutoSize = true;
            this.labelNombrePrecioFinal.Location = new System.Drawing.Point(147, 83);
            this.labelNombrePrecioFinal.Name = "labelNombrePrecioFinal";
            this.labelNombrePrecioFinal.Size = new System.Drawing.Size(65, 13);
            this.labelNombrePrecioFinal.TabIndex = 1;
            this.labelNombrePrecioFinal.Text = "Precio Final:";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(12, 81);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCantidad.TabIndex = 2;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.ValueChanged += new System.EventHandler(this.numericUpDownCantidad_ValueChanged);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(12, 65);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 3;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(230, 83);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(50, 13);
            this.labelPrecio.TabIndex = 4;
            this.labelPrecio.Text = "precioFin";
            // 
            // buttonVender
            // 
            this.buttonVender.Location = new System.Drawing.Point(15, 107);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(75, 23);
            this.buttonVender.TabIndex = 5;
            this.buttonVender.Text = "Vender";
            this.buttonVender.UseVisualStyleBackColor = true;
            this.buttonVender.Click += new System.EventHandler(this.buttonVender_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(15, 136);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 170);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonVender);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.numericUpDownCantidad);
            this.Controls.Add(this.labelNombrePrecioFinal);
            this.Controls.Add(this.labelDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.Activated += new System.EventHandler(this.VentasForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNombrePrecioFinal;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button buttonVender;
        private System.Windows.Forms.Button buttonCancelar;
    }
}