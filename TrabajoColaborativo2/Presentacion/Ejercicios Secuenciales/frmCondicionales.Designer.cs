namespace TrabajoColaborativo2.Presentacion.Ejercicios_Secuenciales
{
    partial class frmCondicionales
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
            this.txtTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtEntrevista = new System.Windows.Forms.TextBox();
            this.cmbEstudios = new System.Windows.Forms.ComboBox();
            this.btnComrpobar = new System.Windows.Forms.Button();
            this.grpEjercicio1 = new System.Windows.Forms.GroupBox();
            this.btnValorPago = new System.Windows.Forms.Button();
            this.txtValorapagar = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txthorastrabajadas = new System.Windows.Forms.Label();
            this.lblHorasPagar = new System.Windows.Forms.Label();
            this.grpEjercicio2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpEjercicio1.SuspendLayout();
            this.grpEjercicio2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(347, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(231, 23);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Ejercicos Condicionales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Puntaje Entrevista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nivel Educativo:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(166, 52);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(116, 27);
            this.txtEdad.TabIndex = 3;
            // 
            // txtEntrevista
            // 
            this.txtEntrevista.Location = new System.Drawing.Point(166, 138);
            this.txtEntrevista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEntrevista.Name = "txtEntrevista";
            this.txtEntrevista.Size = new System.Drawing.Size(116, 27);
            this.txtEntrevista.TabIndex = 4;
            // 
            // cmbEstudios
            // 
            this.cmbEstudios.FormattingEnabled = true;
            this.cmbEstudios.Location = new System.Drawing.Point(166, 96);
            this.cmbEstudios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEstudios.Name = "cmbEstudios";
            this.cmbEstudios.Size = new System.Drawing.Size(116, 27);
            this.cmbEstudios.TabIndex = 5;
            // 
            // btnComrpobar
            // 
            this.btnComrpobar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnComrpobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComrpobar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComrpobar.ForeColor = System.Drawing.Color.White;
            this.btnComrpobar.Location = new System.Drawing.Point(106, 225);
            this.btnComrpobar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnComrpobar.Name = "btnComrpobar";
            this.btnComrpobar.Size = new System.Drawing.Size(140, 62);
            this.btnComrpobar.TabIndex = 6;
            this.btnComrpobar.Text = "Verificar";
            this.btnComrpobar.UseVisualStyleBackColor = false;
            this.btnComrpobar.Click += new System.EventHandler(this.btnComrpobar_Click);
            // 
            // grpEjercicio1
            // 
            this.grpEjercicio1.Controls.Add(this.btnComrpobar);
            this.grpEjercicio1.Controls.Add(this.cmbEstudios);
            this.grpEjercicio1.Controls.Add(this.txtEntrevista);
            this.grpEjercicio1.Controls.Add(this.txtEdad);
            this.grpEjercicio1.Controls.Add(this.label4);
            this.grpEjercicio1.Controls.Add(this.label3);
            this.grpEjercicio1.Controls.Add(this.label2);
            this.grpEjercicio1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEjercicio1.Location = new System.Drawing.Point(47, 79);
            this.grpEjercicio1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEjercicio1.Name = "grpEjercicio1";
            this.grpEjercicio1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEjercicio1.Size = new System.Drawing.Size(335, 329);
            this.grpEjercicio1.TabIndex = 1;
            this.grpEjercicio1.TabStop = false;
            this.grpEjercicio1.Text = "Ejercicio 1";
            // 
            // btnValorPago
            // 
            this.btnValorPago.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnValorPago.FlatAppearance.BorderSize = 0;
            this.btnValorPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValorPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValorPago.ForeColor = System.Drawing.Color.White;
            this.btnValorPago.Location = new System.Drawing.Point(86, 158);
            this.btnValorPago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValorPago.Name = "btnValorPago";
            this.btnValorPago.Size = new System.Drawing.Size(167, 41);
            this.btnValorPago.TabIndex = 3;
            this.btnValorPago.Text = "Ver volor de pago ";
            this.btnValorPago.UseVisualStyleBackColor = false;
            this.btnValorPago.Click += new System.EventHandler(this.btnvalordepago_Click);
            // 
            // txtValorapagar
            // 
            this.txtValorapagar.AutoSize = true;
            this.txtValorapagar.Location = new System.Drawing.Point(25, 119);
            this.txtValorapagar.Name = "txtValorapagar";
            this.txtValorapagar.Size = new System.Drawing.Size(118, 19);
            this.txtValorapagar.TabIndex = 6;
            this.txtValorapagar.Text = "Valor a pagar";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(212, 52);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(116, 27);
            this.txtHoras.TabIndex = 2;
            // 
            // txthorastrabajadas
            // 
            this.txthorastrabajadas.AutoSize = true;
            this.txthorastrabajadas.Location = new System.Drawing.Point(6, 52);
            this.txthorastrabajadas.Name = "txthorastrabajadas";
            this.txthorastrabajadas.Size = new System.Drawing.Size(200, 19);
            this.txthorastrabajadas.TabIndex = 0;
            this.txthorastrabajadas.Text = "Ingrese horas trabajadas";
            // 
            // lblHorasPagar
            // 
            this.lblHorasPagar.AutoSize = true;
            this.lblHorasPagar.Location = new System.Drawing.Point(141, 119);
            this.lblHorasPagar.Name = "lblHorasPagar";
            this.lblHorasPagar.Size = new System.Drawing.Size(177, 19);
            this.lblHorasPagar.TabIndex = 7;
            this.lblHorasPagar.Text = "_____________________";
            // 
            // grpEjercicio2
            // 
            this.grpEjercicio2.Controls.Add(this.lblHorasPagar);
            this.grpEjercicio2.Controls.Add(this.txthorastrabajadas);
            this.grpEjercicio2.Controls.Add(this.txtHoras);
            this.grpEjercicio2.Controls.Add(this.txtValorapagar);
            this.grpEjercicio2.Controls.Add(this.btnValorPago);
            this.grpEjercicio2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEjercicio2.Location = new System.Drawing.Point(408, 79);
            this.grpEjercicio2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEjercicio2.Name = "grpEjercicio2";
            this.grpEjercicio2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEjercicio2.Size = new System.Drawing.Size(408, 226);
            this.grpEjercicio2.TabIndex = 2;
            this.grpEjercicio2.TabStop = false;
            this.grpEjercicio2.Text = "Ejercicio 2";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 27);
            this.panel1.TabIndex = 3;
            // 
            // frmCondicionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpEjercicio2);
            this.Controls.Add(this.grpEjercicio1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCondicionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCondicionales_Load);
            this.grpEjercicio1.ResumeLayout(false);
            this.grpEjercicio1.PerformLayout();
            this.grpEjercicio2.ResumeLayout(false);
            this.grpEjercicio2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtEntrevista;
        private System.Windows.Forms.ComboBox cmbEstudios;
        private System.Windows.Forms.Button btnComrpobar;
        private System.Windows.Forms.GroupBox grpEjercicio1;
        private System.Windows.Forms.Button btnValorPago;
        private System.Windows.Forms.Label txtValorapagar;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label txthorastrabajadas;
        private System.Windows.Forms.Label lblHorasPagar;
        private System.Windows.Forms.GroupBox grpEjercicio2;
        private System.Windows.Forms.Panel panel1;
    }
}