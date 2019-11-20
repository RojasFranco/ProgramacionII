namespace CronometroForm
{
    partial class FormCronometro
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
            this.labelCronometro = new System.Windows.Forms.Label();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCronometro
            // 
            this.labelCronometro.AutoSize = true;
            this.labelCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCronometro.Location = new System.Drawing.Point(58, 47);
            this.labelCronometro.Name = "labelCronometro";
            this.labelCronometro.Size = new System.Drawing.Size(216, 42);
            this.labelCronometro.TabIndex = 0;
            this.labelCronometro.Text = "00 : 00 : 00";
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.Location = new System.Drawing.Point(12, 145);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(156, 43);
            this.buttonIniciar.TabIndex = 1;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.ButtonIniciar_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReiniciar.Location = new System.Drawing.Point(186, 145);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(156, 43);
            this.buttonReiniciar.TabIndex = 2;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.ButtonReiniciar_Click);
            // 
            // FormCronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 204);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.labelCronometro);
            this.Name = "FormCronometro";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCronometro_FormClosing);
            this.Load += new System.EventHandler(this.FormCronometro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCronometro;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonReiniciar;
    }
}

