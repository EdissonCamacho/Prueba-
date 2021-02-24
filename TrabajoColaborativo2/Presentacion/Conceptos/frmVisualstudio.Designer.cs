namespace TrabajoColaborativo2.Presentacion.Ejercicios_Secuenciales
{
    partial class frmVisualstudio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grptabla = new System.Windows.Forms.GroupBox();
            this.rctdefi = new System.Windows.Forms.RichTextBox();
            this.btnVisual = new System.Windows.Forms.Button();
            this.lblDv = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grptabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 23);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(253, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 19);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "¿Que es Visual Studio.net ?";
            // 
            // grptabla
            // 
            this.grptabla.Controls.Add(this.lblDv);
            this.grptabla.Controls.Add(this.btnVisual);
            this.grptabla.Controls.Add(this.rctdefi);
            this.grptabla.Location = new System.Drawing.Point(12, 50);
            this.grptabla.Name = "grptabla";
            this.grptabla.Size = new System.Drawing.Size(776, 259);
            this.grptabla.TabIndex = 1;
            this.grptabla.TabStop = false;
            // 
            // rctdefi
            // 
            this.rctdefi.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.rctdefi.Location = new System.Drawing.Point(24, 21);
            this.rctdefi.Name = "rctdefi";
            this.rctdefi.ReadOnly = true;
            this.rctdefi.Size = new System.Drawing.Size(649, 186);
            this.rctdefi.TabIndex = 2;
            this.rctdefi.Text = "";
            // 
            // btnVisual
            // 
            this.btnVisual.Location = new System.Drawing.Point(279, 230);
            this.btnVisual.Name = "btnVisual";
            this.btnVisual.Size = new System.Drawing.Size(75, 23);
            this.btnVisual.TabIndex = 3;
            this.btnVisual.Text = "Visualizar ";
            this.btnVisual.UseVisualStyleBackColor = true;
            this.btnVisual.Click += new System.EventHandler(this.btnVisual_Click);
            // 
            // lblDv
            // 
            this.lblDv.AutoSize = true;
            this.lblDv.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblDv.Location = new System.Drawing.Point(31, 0);
            this.lblDv.Name = "lblDv";
            this.lblDv.Size = new System.Drawing.Size(231, 19);
            this.lblDv.TabIndex = 4;
            this.lblDv.Text = "Definicion de Visual Studio ";
            // 
            // frmVisualstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grptabla);
            this.Controls.Add(this.panel1);
            this.Name = "frmVisualstudio";
            this.Text = "frmConcepto";
            this.Load += new System.EventHandler(this.frmVisualstudio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grptabla.ResumeLayout(false);
            this.grptabla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grptabla;
        private System.Windows.Forms.Label lblDv;
        private System.Windows.Forms.Button btnVisual;
        private System.Windows.Forms.RichTextBox rctdefi;
    }
}