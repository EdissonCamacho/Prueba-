namespace TrabajoColaborativo2.Presentacion.General
{
    partial class frmPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDF));
            this.btnPDF1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.verPDF = new AxAcroPDFLib.AxAcroPDF();
            this.btnPDF2 = new System.Windows.Forms.Button();
            this.btnPDF3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbExterno = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.verPDF)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPDF1
            // 
            this.btnPDF1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPDF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF1.ForeColor = System.Drawing.Color.White;
            this.btnPDF1.Location = new System.Drawing.Point(35, 42);
            this.btnPDF1.Name = "btnPDF1";
            this.btnPDF1.Size = new System.Drawing.Size(193, 33);
            this.btnPDF1.TabIndex = 1;
            this.btnPDF1.Text = "PDF_1";
            this.btnPDF1.UseVisualStyleBackColor = false;
            this.btnPDF1.Click += new System.EventHandler(this.btnPDF1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // verPDF
            // 
            this.verPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verPDF.Enabled = true;
            this.verPDF.Location = new System.Drawing.Point(0, 81);
            this.verPDF.Name = "verPDF";
            this.verPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("verPDF.OcxState")));
            this.verPDF.Size = new System.Drawing.Size(823, 430);
            this.verPDF.TabIndex = 2;
            // 
            // btnPDF2
            // 
            this.btnPDF2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPDF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF2.ForeColor = System.Drawing.Color.White;
            this.btnPDF2.Location = new System.Drawing.Point(316, 42);
            this.btnPDF2.Name = "btnPDF2";
            this.btnPDF2.Size = new System.Drawing.Size(193, 33);
            this.btnPDF2.TabIndex = 3;
            this.btnPDF2.Text = "PDF_2";
            this.btnPDF2.UseVisualStyleBackColor = false;
            this.btnPDF2.Click += new System.EventHandler(this.btnPDF2_Click);
            // 
            // btnPDF3
            // 
            this.btnPDF3.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPDF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF3.ForeColor = System.Drawing.Color.White;
            this.btnPDF3.Location = new System.Drawing.Point(595, 42);
            this.btnPDF3.Name = "btnPDF3";
            this.btnPDF3.Size = new System.Drawing.Size(193, 33);
            this.btnPDF3.TabIndex = 4;
            this.btnPDF3.Text = "PDF_3";
            this.btnPDF3.UseVisualStyleBackColor = false;
            this.btnPDF3.Click += new System.EventHandler(this.btnPDF3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(166)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.ckbExterno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 36);
            this.panel1.TabIndex = 5;
            // 
            // ckbExterno
            // 
            this.ckbExterno.AutoSize = true;
            this.ckbExterno.Checked = true;
            this.ckbExterno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbExterno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbExterno.Location = new System.Drawing.Point(3, 7);
            this.ckbExterno.Name = "ckbExterno";
            this.ckbExterno.Size = new System.Drawing.Size(152, 20);
            this.ckbExterno.TabIndex = 1;
            this.ckbExterno.Text = "Aplicacion externa";
            this.ckbExterno.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(351, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lector PDF";
            // 
            // frmPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPDF3);
            this.Controls.Add(this.btnPDF2);
            this.Controls.Add(this.verPDF);
            this.Controls.Add(this.btnPDF1);
            this.Name = "frmPDF";
            ((System.ComponentModel.ISupportInitialize)(this.verPDF)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPDF1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxAcroPDFLib.AxAcroPDF verPDF;
        private System.Windows.Forms.Button btnPDF2;
        private System.Windows.Forms.Button btnPDF3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbExterno;
    }
}