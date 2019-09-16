namespace FormularioWF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Euro = new System.Windows.Forms.Label();
            this.Dolar = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.textDolar = new System.Windows.Forms.TextBox();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.EuroA = new System.Windows.Forms.Label();
            this.DolarA = new System.Windows.Forms.Label();
            this.PesoA = new System.Windows.Forms.Label();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.textEuroAEuro = new System.Windows.Forms.TextBox();
            this.textEuroADolar = new System.Windows.Forms.TextBox();
            this.textEuroAPeso = new System.Windows.Forms.TextBox();
            this.textDolarAEuro = new System.Windows.Forms.TextBox();
            this.textDolarADolar = new System.Windows.Forms.TextBox();
            this.textDolarAPeso = new System.Windows.Forms.TextBox();
            this.textPesoAEuro = new System.Windows.Forms.TextBox();
            this.textPesoADolar = new System.Windows.Forms.TextBox();
            this.textPesoAPeso = new System.Windows.Forms.TextBox();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.imageListBtn = new System.Windows.Forms.ImageList(this.components);
            this.textCotizacionEuro = new System.Windows.Forms.TextBox();
            this.textCotizacionDolar = new System.Windows.Forms.TextBox();
            this.textCotizacionPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Euro
            // 
            this.Euro.AutoSize = true;
            this.Euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Euro.Location = new System.Drawing.Point(45, 122);
            this.Euro.Name = "Euro";
            this.Euro.Size = new System.Drawing.Size(40, 16);
            this.Euro.TabIndex = 0;
            this.Euro.Text = "Euro";
            // 
            // Dolar
            // 
            this.Dolar.AutoSize = true;
            this.Dolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dolar.Location = new System.Drawing.Point(45, 158);
            this.Dolar.Name = "Dolar";
            this.Dolar.Size = new System.Drawing.Size(46, 16);
            this.Dolar.TabIndex = 1;
            this.Dolar.Text = "Dolar";
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peso.Location = new System.Drawing.Point(45, 197);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(44, 16);
            this.Peso.TabIndex = 2;
            this.Peso.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cotizacion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(141, 118);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(86, 20);
            this.txtEuro.TabIndex = 4;
            this.txtEuro.TextChanged += new System.EventHandler(this.txtEuro_TextChanged);
            // 
            // textDolar
            // 
            this.textDolar.Location = new System.Drawing.Point(141, 154);
            this.textDolar.Name = "textDolar";
            this.textDolar.Size = new System.Drawing.Size(86, 20);
            this.textDolar.TabIndex = 5;
            // 
            // textPeso
            // 
            this.textPeso.Location = new System.Drawing.Point(141, 196);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(86, 20);
            this.textPeso.TabIndex = 6;
            // 
            // EuroA
            // 
            this.EuroA.AutoSize = true;
            this.EuroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuroA.Location = new System.Drawing.Point(473, 89);
            this.EuroA.Name = "EuroA";
            this.EuroA.Size = new System.Drawing.Size(40, 16);
            this.EuroA.TabIndex = 7;
            this.EuroA.Text = "Euro";
            this.EuroA.Click += new System.EventHandler(this.label5_Click);
            // 
            // DolarA
            // 
            this.DolarA.AutoSize = true;
            this.DolarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DolarA.Location = new System.Drawing.Point(597, 89);
            this.DolarA.Name = "DolarA";
            this.DolarA.Size = new System.Drawing.Size(46, 16);
            this.DolarA.TabIndex = 8;
            this.DolarA.Text = "Dolar";
            this.DolarA.Click += new System.EventHandler(this.label6_Click);
            // 
            // PesoA
            // 
            this.PesoA.AutoSize = true;
            this.PesoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoA.Location = new System.Drawing.Point(707, 89);
            this.PesoA.Name = "PesoA";
            this.PesoA.Size = new System.Drawing.Size(44, 16);
            this.PesoA.TabIndex = 9;
            this.PesoA.Text = "Peso";
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvertEuro.Location = new System.Drawing.Point(319, 116);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvertEuro.TabIndex = 10;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(319, 155);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 11;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.Location = new System.Drawing.Point(319, 197);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPeso.TabIndex = 12;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.btnConvertPeso_Click);
            // 
            // textEuroAEuro
            // 
            this.textEuroAEuro.Location = new System.Drawing.Point(446, 116);
            this.textEuroAEuro.Name = "textEuroAEuro";
            this.textEuroAEuro.Size = new System.Drawing.Size(100, 20);
            this.textEuroAEuro.TabIndex = 13;
            this.textEuroAEuro.TextChanged += new System.EventHandler(this.textEuroAEuro_TextChanged);
            // 
            // textEuroADolar
            // 
            this.textEuroADolar.Location = new System.Drawing.Point(572, 116);
            this.textEuroADolar.Name = "textEuroADolar";
            this.textEuroADolar.Size = new System.Drawing.Size(100, 20);
            this.textEuroADolar.TabIndex = 14;
            // 
            // textEuroAPeso
            // 
            this.textEuroAPeso.Location = new System.Drawing.Point(697, 116);
            this.textEuroAPeso.Name = "textEuroAPeso";
            this.textEuroAPeso.Size = new System.Drawing.Size(100, 20);
            this.textEuroAPeso.TabIndex = 15;
            // 
            // textDolarAEuro
            // 
            this.textDolarAEuro.Location = new System.Drawing.Point(446, 158);
            this.textDolarAEuro.Name = "textDolarAEuro";
            this.textDolarAEuro.Size = new System.Drawing.Size(100, 20);
            this.textDolarAEuro.TabIndex = 16;
            // 
            // textDolarADolar
            // 
            this.textDolarADolar.Location = new System.Drawing.Point(572, 158);
            this.textDolarADolar.Name = "textDolarADolar";
            this.textDolarADolar.Size = new System.Drawing.Size(100, 20);
            this.textDolarADolar.TabIndex = 17;
            // 
            // textDolarAPeso
            // 
            this.textDolarAPeso.Location = new System.Drawing.Point(697, 157);
            this.textDolarAPeso.Name = "textDolarAPeso";
            this.textDolarAPeso.Size = new System.Drawing.Size(100, 20);
            this.textDolarAPeso.TabIndex = 18;
            // 
            // textPesoAEuro
            // 
            this.textPesoAEuro.Location = new System.Drawing.Point(446, 200);
            this.textPesoAEuro.Name = "textPesoAEuro";
            this.textPesoAEuro.Size = new System.Drawing.Size(100, 20);
            this.textPesoAEuro.TabIndex = 19;
            // 
            // textPesoADolar
            // 
            this.textPesoADolar.Location = new System.Drawing.Point(572, 200);
            this.textPesoADolar.Name = "textPesoADolar";
            this.textPesoADolar.Size = new System.Drawing.Size(100, 20);
            this.textPesoADolar.TabIndex = 20;
            // 
            // textPesoAPeso
            // 
            this.textPesoAPeso.Location = new System.Drawing.Point(697, 200);
            this.textPesoAPeso.Name = "textPesoAPeso";
            this.textPesoAPeso.Size = new System.Drawing.Size(100, 20);
            this.textPesoAPeso.TabIndex = 21;
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageIndex = 0;
            this.btnLockCotizacion.ImageList = this.imageListBtn;
            this.btnLockCotizacion.Location = new System.Drawing.Point(319, 34);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(75, 23);
            this.btnLockCotizacion.TabIndex = 22;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // imageListBtn
            // 
            this.imageListBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBtn.ImageStream")));
            this.imageListBtn.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBtn.Images.SetKeyName(0, "lock-open-solid.png");
            this.imageListBtn.Images.SetKeyName(1, "lock-solid.png");
            // 
            // textCotizacionEuro
            // 
            this.textCotizacionEuro.Location = new System.Drawing.Point(446, 34);
            this.textCotizacionEuro.Name = "textCotizacionEuro";
            this.textCotizacionEuro.Size = new System.Drawing.Size(100, 20);
            this.textCotizacionEuro.TabIndex = 23;
            this.textCotizacionEuro.TextChanged += new System.EventHandler(this.TextCotizacionEuro_TextChanged);
            // 
            // textCotizacionDolar
            // 
            this.textCotizacionDolar.Location = new System.Drawing.Point(572, 33);
            this.textCotizacionDolar.Name = "textCotizacionDolar";
            this.textCotizacionDolar.Size = new System.Drawing.Size(100, 20);
            this.textCotizacionDolar.TabIndex = 24;
            // 
            // textCotizacionPeso
            // 
            this.textCotizacionPeso.Location = new System.Drawing.Point(697, 30);
            this.textCotizacionPeso.Name = "textCotizacionPeso";
            this.textCotizacionPeso.Size = new System.Drawing.Size(100, 20);
            this.textCotizacionPeso.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 232);
            this.Controls.Add(this.textCotizacionPeso);
            this.Controls.Add(this.textCotizacionDolar);
            this.Controls.Add(this.textCotizacionEuro);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.textPesoAPeso);
            this.Controls.Add(this.textPesoADolar);
            this.Controls.Add(this.textPesoAEuro);
            this.Controls.Add(this.textDolarAPeso);
            this.Controls.Add(this.textDolarADolar);
            this.Controls.Add(this.textDolarAEuro);
            this.Controls.Add(this.textEuroAPeso);
            this.Controls.Add(this.textEuroADolar);
            this.Controls.Add(this.textEuroAEuro);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.PesoA);
            this.Controls.Add(this.DolarA);
            this.Controls.Add(this.EuroA);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.textDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Dolar);
            this.Controls.Add(this.Euro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Euro;
        private System.Windows.Forms.Label Dolar;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox textDolar;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.Label EuroA;
        private System.Windows.Forms.Label DolarA;
        private System.Windows.Forms.Label PesoA;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.TextBox textEuroAEuro;
        private System.Windows.Forms.TextBox textEuroADolar;
        private System.Windows.Forms.TextBox textEuroAPeso;
        private System.Windows.Forms.TextBox textDolarAEuro;
        private System.Windows.Forms.TextBox textDolarADolar;
        private System.Windows.Forms.TextBox textDolarAPeso;
        private System.Windows.Forms.TextBox textPesoAEuro;
        private System.Windows.Forms.TextBox textPesoADolar;
        private System.Windows.Forms.TextBox textPesoAPeso;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.TextBox textCotizacionEuro;
        private System.Windows.Forms.TextBox textCotizacionDolar;
        private System.Windows.Forms.TextBox textCotizacionPeso;
        private System.Windows.Forms.ImageList imageListBtn;
    }
}

