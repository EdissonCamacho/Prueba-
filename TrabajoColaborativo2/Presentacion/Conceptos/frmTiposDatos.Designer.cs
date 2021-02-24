namespace TrabajoColaborativo2.Presentacion.Conceptos
{
    partial class frmTiposDatos
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpexplicacion = new System.Windows.Forms.GroupBox();
            this.lblExplicacion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbdatatype = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rango = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grpexplicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbdatatype)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 39);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(371, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tipos de datos C#.net ";
            // 
            // grpexplicacion
            // 
            this.grpexplicacion.Controls.Add(this.button1);
            this.grpexplicacion.Controls.Add(this.lblExplicacion);
            this.grpexplicacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpexplicacion.Location = new System.Drawing.Point(91, 61);
            this.grpexplicacion.Name = "grpexplicacion";
            this.grpexplicacion.Size = new System.Drawing.Size(788, 106);
            this.grpexplicacion.TabIndex = 1;
            this.grpexplicacion.TabStop = false;
            this.grpexplicacion.Text = "¿Que es un tipo de Dato?";
            // 
            // lblExplicacion
            // 
            this.lblExplicacion.AutoSize = true;
            this.lblExplicacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacion.Location = new System.Drawing.Point(20, 32);
            this.lblExplicacion.Name = "lblExplicacion";
            this.lblExplicacion.Size = new System.Drawing.Size(0, 16);
            this.lblExplicacion.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(667, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok, Entendido";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbdatatype
            // 
            this.tbdatatype.AllowUserToAddRows = false;
            this.tbdatatype.AllowUserToDeleteRows = false;
            this.tbdatatype.BackgroundColor = System.Drawing.Color.White;
            this.tbdatatype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbdatatype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Tamaño,
            this.Rango});
            this.tbdatatype.Location = new System.Drawing.Point(269, 167);
            this.tbdatatype.Name = "tbdatatype";
            this.tbdatatype.ReadOnly = true;
            this.tbdatatype.Size = new System.Drawing.Size(375, 271);
            this.tbdatatype.TabIndex = 2;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo Dato";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Tamaño
            // 
            this.Tamaño.HeaderText = "Tamaño";
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.ReadOnly = true;
            // 
            // Rango
            // 
            this.Rango.HeaderText = "Rango de Valores";
            this.Rango.Name = "Rango";
            this.Rango.ReadOnly = true;
            this.Rango.Width = 120;
            // 
            // frmTiposDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.tbdatatype);
            this.Controls.Add(this.grpexplicacion);
            this.Controls.Add(this.panel1);
            this.Name = "frmTiposDatos";
            this.Text = "frmTiposDatos";
            this.Load += new System.EventHandler(this.frmTiposDatos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpexplicacion.ResumeLayout(false);
            this.grpexplicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbdatatype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpexplicacion;
        private System.Windows.Forms.Label lblExplicacion;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView tbdatatype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rango;
    }
}