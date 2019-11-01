namespace Ejercicio56
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripInformacion = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusInformacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBoxTexto = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStripInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuArchivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuArchivo
            // 
            this.toolStripMenuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuAbrir,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.toolStripMenuArchivo.Name = "toolStripMenuArchivo";
            this.toolStripMenuArchivo.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuArchivo.Text = "Archivo";
            // 
            // abrirToolStripMenuAbrir
            // 
            this.abrirToolStripMenuAbrir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirToolStripMenuAbrir.Name = "abrirToolStripMenuAbrir";
            this.abrirToolStripMenuAbrir.Size = new System.Drawing.Size(286, 22);
            this.abrirToolStripMenuAbrir.Text = "Abrir                                      Ctrl+A";
            this.abrirToolStripMenuAbrir.Click += new System.EventHandler(this.abrirToolStripMenuAbrir_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.guardarToolStripMenuItem.Text = "Guardar                                 Ctrl+S";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...                   Ctrl+Mayus+S";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // statusStripInformacion
            // 
            this.statusStripInformacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusInformacion});
            this.statusStripInformacion.Location = new System.Drawing.Point(0, 182);
            this.statusStripInformacion.Name = "statusStripInformacion";
            this.statusStripInformacion.Size = new System.Drawing.Size(463, 22);
            this.statusStripInformacion.TabIndex = 1;
            this.statusStripInformacion.Text = "statusStrip1";
            // 
            // toolStripStatusInformacion
            // 
            this.toolStripStatusInformacion.Name = "toolStripStatusInformacion";
            this.toolStripStatusInformacion.Size = new System.Drawing.Size(0, 17);
            // 
            // richTextBoxTexto
            // 
            this.richTextBoxTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTexto.Location = new System.Drawing.Point(0, 24);
            this.richTextBoxTexto.Name = "richTextBoxTexto";
            this.richTextBoxTexto.Size = new System.Drawing.Size(463, 158);
            this.richTextBoxTexto.TabIndex = 2;
            this.richTextBoxTexto.Text = "";
            this.richTextBoxTexto.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 204);
            this.Controls.Add(this.richTextBoxTexto);
            this.Controls.Add(this.statusStripInformacion);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripInformacion.ResumeLayout(false);
            this.statusStripInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuArchivo;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuAbrir;
        private System.Windows.Forms.StatusStrip statusStripInformacion;
        private System.Windows.Forms.RichTextBox richTextBoxTexto;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusInformacion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

