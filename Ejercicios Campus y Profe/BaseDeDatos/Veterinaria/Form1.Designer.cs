namespace Veterinaria
{
    partial class FormVet
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBorrarHumano = new System.Windows.Forms.Button();
            this.buttonBorrarMascota = new System.Windows.Forms.Button();
            this.buttonModificarHumano = new System.Windows.Forms.Button();
            this.buttonModificarMascota = new System.Windows.Forms.Button();
            this.listaHumanos = new System.Windows.Forms.ListBox();
            this.listaMascotas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(12, 129);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(196, 23);
            this.buttonInsertar.TabIndex = 2;
            this.buttonInsertar.Text = "Nuevo";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonBorrarHumano
            // 
            this.buttonBorrarHumano.Location = new System.Drawing.Point(12, 204);
            this.buttonBorrarHumano.Name = "buttonBorrarHumano";
            this.buttonBorrarHumano.Size = new System.Drawing.Size(196, 23);
            this.buttonBorrarHumano.TabIndex = 4;
            this.buttonBorrarHumano.Text = "Borrar Seleccionado";
            this.buttonBorrarHumano.UseVisualStyleBackColor = true;
            // 
            // buttonBorrarMascota
            // 
            this.buttonBorrarMascota.Location = new System.Drawing.Point(234, 204);
            this.buttonBorrarMascota.Name = "buttonBorrarMascota";
            this.buttonBorrarMascota.Size = new System.Drawing.Size(196, 23);
            this.buttonBorrarMascota.TabIndex = 5;
            this.buttonBorrarMascota.Text = "Borrar Seleccionado";
            this.buttonBorrarMascota.UseVisualStyleBackColor = true;
            // 
            // buttonModificarHumano
            // 
            this.buttonModificarHumano.Location = new System.Drawing.Point(12, 158);
            this.buttonModificarHumano.Name = "buttonModificarHumano";
            this.buttonModificarHumano.Size = new System.Drawing.Size(196, 23);
            this.buttonModificarHumano.TabIndex = 6;
            this.buttonModificarHumano.Text = "Modificar";
            this.buttonModificarHumano.UseVisualStyleBackColor = true;
            // 
            // buttonModificarMascota
            // 
            this.buttonModificarMascota.Location = new System.Drawing.Point(234, 158);
            this.buttonModificarMascota.Name = "buttonModificarMascota";
            this.buttonModificarMascota.Size = new System.Drawing.Size(196, 23);
            this.buttonModificarMascota.TabIndex = 7;
            this.buttonModificarMascota.Text = "Modificar";
            this.buttonModificarMascota.UseVisualStyleBackColor = true;
            // 
            // listaHumanos
            // 
            this.listaHumanos.FormattingEnabled = true;
            this.listaHumanos.Location = new System.Drawing.Point(12, 12);
            this.listaHumanos.Name = "listaHumanos";
            this.listaHumanos.Size = new System.Drawing.Size(196, 95);
            this.listaHumanos.TabIndex = 8;
            // 
            // listaMascotas
            // 
            this.listaMascotas.FormattingEnabled = true;
            this.listaMascotas.Location = new System.Drawing.Point(234, 12);
            this.listaMascotas.Name = "listaMascotas";
            this.listaMascotas.Size = new System.Drawing.Size(196, 95);
            this.listaMascotas.TabIndex = 9;
            // 
            // FormVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 239);
            this.Controls.Add(this.listaMascotas);
            this.Controls.Add(this.listaHumanos);
            this.Controls.Add(this.buttonModificarMascota);
            this.Controls.Add(this.buttonModificarHumano);
            this.Controls.Add(this.buttonBorrarMascota);
            this.Controls.Add(this.buttonBorrarHumano);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonInsertar);
            this.Name = "FormVet";
            this.Text = "Veterinaria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBorrarHumano;
        private System.Windows.Forms.Button buttonBorrarMascota;
        private System.Windows.Forms.Button buttonModificarHumano;
        private System.Windows.Forms.Button buttonModificarMascota;
        private System.Windows.Forms.ListBox listaHumanos;
        private System.Windows.Forms.ListBox listaMascotas;
    }
}

