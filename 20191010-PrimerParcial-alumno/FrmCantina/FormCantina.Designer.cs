namespace FrmCantina
{
    partial class FormCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCantina));
            this.lvlMarca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.numericUpDown1Capacidad = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTipoBotella = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.radioBtnCerveza = new System.Windows.Forms.RadioButton();
            this.radioBtnAgua = new System.Windows.Forms.RadioButton();
            this.numericUpDownContenido = new System.Windows.Forms.NumericUpDown();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.barra1 = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Capacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // lvlMarca
            // 
            this.lvlMarca.AutoSize = true;
            this.lvlMarca.Location = new System.Drawing.Point(155, 316);
            this.lvlMarca.Name = "lvlMarca";
            this.lvlMarca.Size = new System.Drawing.Size(37, 13);
            this.lvlMarca.TabIndex = 0;
            this.lvlMarca.Text = "Marca";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(158, 332);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarca.TabIndex = 1;
            // 
            // numericUpDown1Capacidad
            // 
            this.numericUpDown1Capacidad.Location = new System.Drawing.Point(111, 401);
            this.numericUpDown1Capacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1Capacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1Capacidad.Name = "numericUpDown1Capacidad";
            this.numericUpDown1Capacidad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1Capacidad.TabIndex = 2;
            this.numericUpDown1Capacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // comboBoxTipoBotella
            // 
            this.comboBoxTipoBotella.FormattingEnabled = true;
            this.comboBoxTipoBotella.Location = new System.Drawing.Point(382, 331);
            this.comboBoxTipoBotella.Name = "comboBoxTipoBotella";
            this.comboBoxTipoBotella.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoBotella.TabIndex = 3;
            this.comboBoxTipoBotella.ValueMemberChanged += new System.EventHandler(this.comboBoxTipoBotella_ValueMemberChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(429, 392);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 34);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // radioBtnCerveza
            // 
            this.radioBtnCerveza.AutoSize = true;
            this.radioBtnCerveza.Location = new System.Drawing.Point(22, 329);
            this.radioBtnCerveza.Name = "radioBtnCerveza";
            this.radioBtnCerveza.Size = new System.Drawing.Size(64, 17);
            this.radioBtnCerveza.TabIndex = 5;
            this.radioBtnCerveza.TabStop = true;
            this.radioBtnCerveza.Text = "Cerveza";
            this.radioBtnCerveza.UseVisualStyleBackColor = true;
            // 
            // radioBtnAgua
            // 
            this.radioBtnAgua.AutoSize = true;
            this.radioBtnAgua.Location = new System.Drawing.Point(22, 368);
            this.radioBtnAgua.Name = "radioBtnAgua";
            this.radioBtnAgua.Size = new System.Drawing.Size(50, 17);
            this.radioBtnAgua.TabIndex = 6;
            this.radioBtnAgua.TabStop = true;
            this.radioBtnAgua.Text = "Agua";
            this.radioBtnAgua.UseVisualStyleBackColor = true;
            // 
            // numericUpDownContenido
            // 
            this.numericUpDownContenido.Location = new System.Drawing.Point(272, 401);
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
            this.numericUpDownContenido.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownContenido.TabIndex = 7;
            this.numericUpDownContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(389, 315);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 8;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(129, 370);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 9;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(269, 372);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 10;
            this.lblContenido.Text = "Contenido";
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, 5);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(553, 298);
            this.barra1.TabIndex = 11;
            // 
            // FormCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 438);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblBotellaTipo);
            this.Controls.Add(this.numericUpDownContenido);
            this.Controls.Add(this.radioBtnAgua);
            this.Controls.Add(this.radioBtnCerveza);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.comboBoxTipoBotella);
            this.Controls.Add(this.numericUpDown1Capacidad);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.lvlMarca);
            this.Name = "FormCantina";
            this.Text = "FormCantina";
            this.Load += new System.EventHandler(this.FormCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Capacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlMarca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.NumericUpDown numericUpDown1Capacidad;
        private System.Windows.Forms.ComboBox comboBoxTipoBotella;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton radioBtnCerveza;
        private System.Windows.Forms.RadioButton radioBtnAgua;
        private System.Windows.Forms.NumericUpDown numericUpDownContenido;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
        private ControlCantina.Barra barra1;
    }
}

