namespace FrmMostrar
{
    partial class FrmFacturacion
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
            this.labelFacturacion = new System.Windows.Forms.Label();
            this.textoFacturacion = new System.Windows.Forms.RichTextBox();
            this.textoMasInformacion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFacturacion
            // 
            this.labelFacturacion.AutoSize = true;
            this.labelFacturacion.Location = new System.Drawing.Point(12, 9);
            this.labelFacturacion.Name = "labelFacturacion";
            this.labelFacturacion.Size = new System.Drawing.Size(33, 13);
            this.labelFacturacion.TabIndex = 1;
            this.labelFacturacion.Text = "woop";
            // 
            // textoFacturacion
            // 
            this.textoFacturacion.Location = new System.Drawing.Point(12, 34);
            this.textoFacturacion.Name = "textoFacturacion";
            this.textoFacturacion.ReadOnly = true;
            this.textoFacturacion.Size = new System.Drawing.Size(190, 20);
            this.textoFacturacion.TabIndex = 2;
            this.textoFacturacion.Text = "";
            // 
            // textoMasInformacion
            // 
            this.textoMasInformacion.Location = new System.Drawing.Point(12, 85);
            this.textoMasInformacion.Name = "textoMasInformacion";
            this.textoMasInformacion.ReadOnly = true;
            this.textoMasInformacion.Size = new System.Drawing.Size(190, 123);
            this.textoMasInformacion.TabIndex = 3;
            this.textoMasInformacion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro total de Llamadas:";
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoMasInformacion);
            this.Controls.Add(this.textoFacturacion);
            this.Controls.Add(this.labelFacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facturacion";
            this.Activated += new System.EventHandler(this.FrmFacturacion_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFacturacion;
        private System.Windows.Forms.RichTextBox textoFacturacion;
        private System.Windows.Forms.RichTextBox textoMasInformacion;
        private System.Windows.Forms.Label label1;
    }
}