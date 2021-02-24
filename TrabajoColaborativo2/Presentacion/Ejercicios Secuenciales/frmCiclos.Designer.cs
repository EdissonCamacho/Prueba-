namespace TrabajoColaborativo2.Presentacion.Ejercicios_Secuenciales
{
    partial class frmCiclos
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSumando = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.numero1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbutton2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtlimite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResultado1 = new System.Windows.Forms.Button();
            this.txtnu = new System.Windows.Forms.Label();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 43);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(416, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ciclos";
            // 
            // txtnum1
            // 
            this.txtnum1.AutoSize = true;
            this.txtnum1.BackColor = System.Drawing.Color.Transparent;
            this.txtnum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtnum1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtnum1.Location = new System.Drawing.Point(3, 68);
            this.txtnum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(428, 21);
            this.txtnum1.TabIndex = 1;
            this.txtnum1.Text = "calcular la sumatoria de los numeros de 1 hasta N:";
            this.txtnum1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.btnSumando);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.numero1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(418, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejercicio 1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Sumatoria";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(163, 228);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(154, 28);
            this.txtTotal.TabIndex = 7;
            // 
            // btnSumando
            // 
            this.btnSumando.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSumando.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumando.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSumando.ForeColor = System.Drawing.Color.White;
            this.btnSumando.Location = new System.Drawing.Point(98, 134);
            this.btnSumando.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSumando.Name = "btnSumando";
            this.btnSumando.Size = new System.Drawing.Size(171, 57);
            this.btnSumando.TabIndex = 6;
            this.btnSumando.Text = "Sumatoria";
            this.btnSumando.UseVisualStyleBackColor = false;
            this.btnSumando.Click += new System.EventHandler(this.btnSumando_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(200, 56);
            this.txtN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(86, 28);
            this.txtN.TabIndex = 1;
            // 
            // numero1
            // 
            this.numero1.AutoSize = true;
            this.numero1.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Bold);
            this.numero1.Location = new System.Drawing.Point(10, 65);
            this.numero1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(148, 19);
            this.numero1.TabIndex = 0;
            this.numero1.Text = "Digite el numero:";
            this.numero1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbutton2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(457, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 325);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ejercicio 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Calcular e Imprimir ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 3;
            // 
            // txtbutton2
            // 
            this.txtbutton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtbutton2.ForeColor = System.Drawing.Color.White;
            this.txtbutton2.Location = new System.Drawing.Point(138, 144);
            this.txtbutton2.Name = "txtbutton2";
            this.txtbutton2.Size = new System.Drawing.Size(155, 34);
            this.txtbutton2.TabIndex = 2;
            this.txtbutton2.Text = "Operacion";
            this.txtbutton2.UseVisualStyleBackColor = false;
            this.txtbutton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtlimite);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnResultado1);
            this.groupBox3.Controls.Add(this.txtnu);
            this.groupBox3.Controls.Add(this.txtNumero3);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(27, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 271);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ejercicio 3";
            // 
            // txtlimite
            // 
            this.txtlimite.Location = new System.Drawing.Point(322, 40);
            this.txtlimite.Name = "txtlimite";
            this.txtlimite.Size = new System.Drawing.Size(68, 28);
            this.txtlimite.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Limite";
            // 
            // btnResultado1
            // 
            this.btnResultado1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnResultado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado1.ForeColor = System.Drawing.Color.White;
            this.btnResultado1.Location = new System.Drawing.Point(170, 101);
            this.btnResultado1.Name = "btnResultado1";
            this.btnResultado1.Size = new System.Drawing.Size(170, 62);
            this.btnResultado1.TabIndex = 2;
            this.btnResultado1.Text = "Multiplicacion";
            this.btnResultado1.UseVisualStyleBackColor = false;
            this.btnResultado1.Click += new System.EventHandler(this.btnResultado1_Click);
            // 
            // txtnu
            // 
            this.txtnu.AutoSize = true;
            this.txtnu.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtnu.Location = new System.Drawing.Point(2, 40);
            this.txtnu.Name = "txtnu";
            this.txtnu.Size = new System.Drawing.Size(153, 19);
            this.txtnu.TabIndex = 1;
            this.txtnu.Text = "Digite un numero:";
            // 
            // txtNumero3
            // 
            this.txtNumero3.Location = new System.Drawing.Point(161, 40);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(66, 28);
            this.txtNumero3.TabIndex = 0;
            // 
            // frmCiclos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCiclos";
            this.Load += new System.EventHandler(this.frmCiclos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtnum1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label numero1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnSumando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button txtbutton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnResultado1;
        private System.Windows.Forms.Label txtnu;
        private System.Windows.Forms.TextBox txtNumero3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlimite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}