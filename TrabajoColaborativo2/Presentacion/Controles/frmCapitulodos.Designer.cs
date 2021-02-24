namespace TrabajoColaborativo2.Presentacion.Ejercicios_Secuenciales
{
    partial class frmCapitulodos
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
            this.label2 = new System.Windows.Forms.Label();
            this.mtxDato = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstvDispositivos = new System.Windows.Forms.ListView();
            this.lblLista = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstNombre = new System.Windows.Forms.ListBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblnombrest = new System.Windows.Forms.Label();
            this.lblgrado = new System.Windows.Forms.Label();
            this.lblpromed = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.treev23 = new System.Windows.Forms.TreeView();
            this.txtbox5 = new System.Windows.Forms.TextBox();
            this.txtbox6 = new System.Windows.Forms.TextBox();
            this.btnnodo2 = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btneli = new System.Windows.Forms.Button();
            this.btnNodo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 27);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(328, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Controles ";
            // 
            // mtxDato
            // 
            this.mtxDato.Location = new System.Drawing.Point(169, 76);
            this.mtxDato.Mask = "00/00/0000 00:00";
            this.mtxDato.Name = "mtxDato";
            this.mtxDato.Size = new System.Drawing.Size(133, 20);
            this.mtxDato.TabIndex = 1;
            this.mtxDato.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese la Fecha ";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(166, 99);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(10, 13);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = ":";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnMostrar.Location = new System.Drawing.Point(27, 398);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(86, 37);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar ";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstvDispositivos
            // 
            this.lstvDispositivos.Location = new System.Drawing.Point(12, 285);
            this.lstvDispositivos.Name = "lstvDispositivos";
            this.lstvDispositivos.Size = new System.Drawing.Size(269, 87);
            this.lstvDispositivos.TabIndex = 5;
            this.lstvDispositivos.UseCompatibleStateImageBehavior = false;
            this.lstvDispositivos.SelectedIndexChanged += new System.EventHandler(this.lstvDispositivos_SelectedIndexChanged);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblLista.ForeColor = System.Drawing.Color.Black;
            this.lblLista.Location = new System.Drawing.Point(7, 205);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(48, 19);
            this.lblLista.TabIndex = 6;
            this.lblLista.Text = "Lista:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(185, 73);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(112, 20);
            this.txtnombre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre y Apellido :";
            // 
            // lstNombre
            // 
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.Location = new System.Drawing.Point(16, 144);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(286, 43);
            this.lstNombre.TabIndex = 9;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(190, 203);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(70, 25);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.Location = new System.Drawing.Point(100, 203);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(76, 25);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnagregar.Location = new System.Drawing.Point(16, 203);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(70, 25);
            this.btnagregar.TabIndex = 12;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.Black;
            this.lbltitulo.Location = new System.Drawing.Point(384, 67);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(185, 19);
            this.lbltitulo.TabIndex = 13;
            this.lbltitulo.Text = "Datos del estudiante :";
            // 
            // lblnombrest
            // 
            this.lblnombrest.AutoSize = true;
            this.lblnombrest.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblnombrest.ForeColor = System.Drawing.Color.Black;
            this.lblnombrest.Location = new System.Drawing.Point(387, 93);
            this.lblnombrest.Name = "lblnombrest";
            this.lblnombrest.Size = new System.Drawing.Size(81, 19);
            this.lblnombrest.TabIndex = 14;
            this.lblnombrest.Text = "Nombre:";
            // 
            // lblgrado
            // 
            this.lblgrado.AutoSize = true;
            this.lblgrado.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblgrado.ForeColor = System.Drawing.Color.Black;
            this.lblgrado.Location = new System.Drawing.Point(387, 125);
            this.lblgrado.Name = "lblgrado";
            this.lblgrado.Size = new System.Drawing.Size(66, 19);
            this.lblgrado.TabIndex = 15;
            this.lblgrado.Text = "Grado:";
            // 
            // lblpromed
            // 
            this.lblpromed.AutoSize = true;
            this.lblpromed.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblpromed.ForeColor = System.Drawing.Color.Black;
            this.lblpromed.Location = new System.Drawing.Point(387, 144);
            this.lblpromed.Name = "lblpromed";
            this.lblpromed.Size = new System.Drawing.Size(93, 19);
            this.lblpromed.TabIndex = 16;
            this.lblpromed.Text = "Promedio:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(528, 171);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblEdad.ForeColor = System.Drawing.Color.Black;
            this.lblEdad.Location = new System.Drawing.Point(387, 168);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(56, 19);
            this.lblEdad.TabIndex = 18;
            this.lblEdad.Text = "Edad:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDown2.Location = new System.Drawing.Point(528, 147);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(528, 124);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown3.TabIndex = 20;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(489, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 21;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(465, 203);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 28);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // treev23
            // 
            this.treev23.Location = new System.Drawing.Point(30, 228);
            this.treev23.Name = "treev23";
            this.treev23.Size = new System.Drawing.Size(121, 163);
            this.treev23.TabIndex = 23;
            // 
            // txtbox5
            // 
            this.txtbox5.Location = new System.Drawing.Point(157, 228);
            this.txtbox5.Name = "txtbox5";
            this.txtbox5.Size = new System.Drawing.Size(67, 20);
            this.txtbox5.TabIndex = 24;
            // 
            // txtbox6
            // 
            this.txtbox6.Location = new System.Drawing.Point(157, 254);
            this.txtbox6.Name = "txtbox6";
            this.txtbox6.Size = new System.Drawing.Size(67, 20);
            this.txtbox6.TabIndex = 25;
            // 
            // btnnodo2
            // 
            this.btnnodo2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnnodo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnodo2.ForeColor = System.Drawing.Color.White;
            this.btnnodo2.Location = new System.Drawing.Point(230, 254);
            this.btnnodo2.Name = "btnnodo2";
            this.btnnodo2.Size = new System.Drawing.Size(93, 23);
            this.btnnodo2.TabIndex = 27;
            this.btnnodo2.Text = "Adiciona Nodo";
            this.btnnodo2.UseVisualStyleBackColor = false;
            this.btnnodo2.Click += new System.EventHandler(this.btnnodo2_Click);
            // 
            // btnb
            // 
            this.btnb.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnb.Location = new System.Drawing.Point(230, 283);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(93, 23);
            this.btnb.TabIndex = 28;
            this.btnb.Text = "Borrar";
            this.btnb.UseVisualStyleBackColor = false;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btneli
            // 
            this.btneli.BackColor = System.Drawing.Color.DodgerBlue;
            this.btneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneli.Location = new System.Drawing.Point(230, 312);
            this.btneli.Name = "btneli";
            this.btneli.Size = new System.Drawing.Size(93, 23);
            this.btneli.TabIndex = 29;
            this.btneli.Text = "Eliminar";
            this.btneli.UseVisualStyleBackColor = false;
            this.btneli.Click += new System.EventHandler(this.btneli_Click);
            // 
            // btnNodo
            // 
            this.btnNodo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodo.Location = new System.Drawing.Point(230, 225);
            this.btnNodo.Name = "btnNodo";
            this.btnNodo.Size = new System.Drawing.Size(93, 23);
            this.btnNodo.TabIndex = 26;
            this.btnNodo.Text = "Adiciona Nodo";
            this.btnNodo.UseVisualStyleBackColor = false;
            this.btnNodo.Click += new System.EventHandler(this.btnNodo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.lblLista);
            this.groupBox1.Location = new System.Drawing.Point(5, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 404);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btneli);
            this.groupBox2.Controls.Add(this.treev23);
            this.groupBox2.Controls.Add(this.btnb);
            this.groupBox2.Controls.Add(this.txtbox5);
            this.groupBox2.Controls.Add(this.btnnodo2);
            this.groupBox2.Controls.Add(this.txtbox6);
            this.groupBox2.Controls.Add(this.btnNodo);
            this.groupBox2.Location = new System.Drawing.Point(371, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 404);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // frmControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblpromed);
            this.Controls.Add(this.lblgrado);
            this.Controls.Add(this.lblnombrest);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.lstNombre);
            this.Controls.Add(this.lstvDispositivos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.mtxDato);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmControles";
            this.Text = "frmControles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtxDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListView lstvDispositivos;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstNombre;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblnombrest;
        private System.Windows.Forms.Label lblgrado;
        private System.Windows.Forms.Label lblpromed;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TreeView treev23;
        private System.Windows.Forms.TextBox txtbox5;
        private System.Windows.Forms.TextBox txtbox6;
        private System.Windows.Forms.Button btnnodo2;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btneli;
        private System.Windows.Forms.Button btnNodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}