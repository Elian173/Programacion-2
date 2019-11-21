namespace FrmCantina
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.comboBoxBotellaTipo = new System.Windows.Forms.ComboBox();
            this.numericUpDownCapacidad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownContenido = new System.Windows.Forms.NumericUpDown();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.radioButtonCerveza = new System.Windows.Forms.RadioButton();
            this.radioButtonAgua = new System.Windows.Forms.RadioButton();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.barra1 = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 408);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(408, 408);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 1;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(10, 426);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(134, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // comboBoxBotellaTipo
            // 
            this.comboBoxBotellaTipo.FormattingEnabled = true;
            this.comboBoxBotellaTipo.Location = new System.Drawing.Point(411, 424);
            this.comboBoxBotellaTipo.Name = "comboBoxBotellaTipo";
            this.comboBoxBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBotellaTipo.TabIndex = 3;
            // 
            // numericUpDownCapacidad
            // 
            this.numericUpDownCapacidad.Location = new System.Drawing.Point(166, 426);
            this.numericUpDownCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCapacidad.Name = "numericUpDownCapacidad";
            this.numericUpDownCapacidad.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownCapacidad.TabIndex = 4;
            this.numericUpDownCapacidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownContenido
            // 
            this.numericUpDownContenido.Location = new System.Drawing.Point(251, 426);
            this.numericUpDownContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownContenido.Name = "numericUpDownContenido";
            this.numericUpDownContenido.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownContenido.TabIndex = 5;
            this.numericUpDownContenido.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(163, 408);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 6;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(248, 408);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 7;
            this.lblContenido.Text = "Contenido";
            // 
            // radioButtonCerveza
            // 
            this.radioButtonCerveza.AutoSize = true;
            this.radioButtonCerveza.Location = new System.Drawing.Point(10, 447);
            this.radioButtonCerveza.Name = "radioButtonCerveza";
            this.radioButtonCerveza.Size = new System.Drawing.Size(64, 17);
            this.radioButtonCerveza.TabIndex = 8;
            this.radioButtonCerveza.TabStop = true;
            this.radioButtonCerveza.Text = "Cerveza";
            this.radioButtonCerveza.UseVisualStyleBackColor = true;
            // 
            // radioButtonAgua
            // 
            this.radioButtonAgua.AutoSize = true;
            this.radioButtonAgua.Location = new System.Drawing.Point(10, 470);
            this.radioButtonAgua.Name = "radioButtonAgua";
            this.radioButtonAgua.Size = new System.Drawing.Size(50, 17);
            this.radioButtonAgua.TabIndex = 9;
            this.radioButtonAgua.TabStop = true;
            this.radioButtonAgua.Text = "Agua";
            this.radioButtonAgua.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(411, 451);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(121, 36);
            this.buttonAgregar.TabIndex = 10;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(10, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(547, 363);
            this.barra1.TabIndex = 11;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 499);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.radioButtonAgua);
            this.Controls.Add(this.radioButtonCerveza);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.numericUpDownContenido);
            this.Controls.Add(this.numericUpDownCapacidad);
            this.Controls.Add(this.comboBoxBotellaTipo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblBotellaTipo);
            this.Controls.Add(this.lblMarca);
            this.Name = "FrmCantina";
            this.Text = "Alumno Elian Rojas 2c";
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox comboBoxBotellaTipo;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacidad;
        private System.Windows.Forms.NumericUpDown numericUpDownContenido;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.RadioButton radioButtonCerveza;
        private System.Windows.Forms.RadioButton radioButtonAgua;
        private System.Windows.Forms.Button buttonAgregar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private ControlCantina.Barra barra1;
    }
}

