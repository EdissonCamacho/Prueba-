namespace TrabajoColaborativo2.Presentacion.Controles
{
    partial class frmCapituloCuatro
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BrowserDialog = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtGuardar = new System.Windows.Forms.TextBox();
            this.txtAbrir = new System.Windows.Forms.TextBox();
            this.ColorDialog = new System.Windows.Forms.TabPage();
            this.btnFuente = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.BrowserDialog.SuspendLayout();
            this.ColorDialog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BrowserDialog);
            this.tabControl1.Controls.Add(this.ColorDialog);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // BrowserDialog
            // 
            this.BrowserDialog.Controls.Add(this.btnBuscar);
            this.BrowserDialog.Controls.Add(this.btnGuardar);
            this.BrowserDialog.Controls.Add(this.btnAbrir);
            this.BrowserDialog.Controls.Add(this.label3);
            this.BrowserDialog.Controls.Add(this.label2);
            this.BrowserDialog.Controls.Add(this.label1);
            this.BrowserDialog.Controls.Add(this.txtBuscar);
            this.BrowserDialog.Controls.Add(this.txtGuardar);
            this.BrowserDialog.Controls.Add(this.txtAbrir);
            this.BrowserDialog.Location = new System.Drawing.Point(4, 28);
            this.BrowserDialog.Name = "BrowserDialog";
            this.BrowserDialog.Padding = new System.Windows.Forms.Padding(3);
            this.BrowserDialog.Size = new System.Drawing.Size(562, 340);
            this.BrowserDialog.TabIndex = 0;
            this.BrowserDialog.Text = "BrowserDialog";
            this.BrowserDialog.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(406, 204);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(406, 142);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 30);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(406, 89);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(93, 30);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ruta Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta Guardar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta Abrir:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(151, 207);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(234, 27);
            this.txtBuscar.TabIndex = 2;
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(151, 145);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(234, 27);
            this.txtGuardar.TabIndex = 1;
            // 
            // txtAbrir
            // 
            this.txtAbrir.Location = new System.Drawing.Point(151, 92);
            this.txtAbrir.Name = "txtAbrir";
            this.txtAbrir.Size = new System.Drawing.Size(234, 27);
            this.txtAbrir.TabIndex = 0;
            // 
            // ColorDialog
            // 
            this.ColorDialog.Controls.Add(this.btnFuente);
            this.ColorDialog.Controls.Add(this.btnColor);
            this.ColorDialog.Controls.Add(this.rtbTexto);
            this.ColorDialog.Location = new System.Drawing.Point(4, 28);
            this.ColorDialog.Name = "ColorDialog";
            this.ColorDialog.Padding = new System.Windows.Forms.Padding(3);
            this.ColorDialog.Size = new System.Drawing.Size(562, 340);
            this.ColorDialog.TabIndex = 1;
            this.ColorDialog.Text = "Texto";
            this.ColorDialog.UseVisualStyleBackColor = true;
            // 
            // btnFuente
            // 
            this.btnFuente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuente.ForeColor = System.Drawing.Color.White;
            this.btnFuente.Location = new System.Drawing.Point(332, 24);
            this.btnFuente.Name = "btnFuente";
            this.btnFuente.Size = new System.Drawing.Size(161, 36);
            this.btnFuente.TabIndex = 2;
            this.btnFuente.Text = "Cambiar Fuente";
            this.btnFuente.UseVisualStyleBackColor = false;
            this.btnFuente.Click += new System.EventHandler(this.btnFuente_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Location = new System.Drawing.Point(47, 24);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(163, 36);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Cambiar Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(6, 66);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(542, 268);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(166)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 42);
            this.panel1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(118, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Capitulo 4 TabControl - ColorDialog  ";
            // 
            // frmCapituloCuatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCapituloCuatro";
            this.tabControl1.ResumeLayout(false);
            this.BrowserDialog.ResumeLayout(false);
            this.BrowserDialog.PerformLayout();
            this.ColorDialog.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BrowserDialog;
        private System.Windows.Forms.TabPage ColorDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnFuente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtGuardar;
        private System.Windows.Forms.TextBox txtAbrir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}