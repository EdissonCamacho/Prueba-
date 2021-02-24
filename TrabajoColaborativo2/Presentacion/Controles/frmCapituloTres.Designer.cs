namespace TrabajoColaborativo2.Presentacion.Controles
{
    partial class frmCapituloTres
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapituloTres));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWebBrowser = new System.Windows.Forms.Button();
            this.grpWebBrowser = new System.Windows.Forms.GroupBox();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.Navegador = new System.Windows.Forms.WebBrowser();
            this.barraProgreso = new System.Windows.Forms.ProgressBar();
            this.pnavegador = new System.Windows.Forms.PictureBox();
            this.pPreview = new System.Windows.Forms.PictureBox();
            this.pHome = new System.Windows.Forms.PictureBox();
            this.pImprimir = new System.Windows.Forms.PictureBox();
            this.pIr = new System.Windows.Forms.PictureBox();
            this.pAtras = new System.Windows.Forms.PictureBox();
            this.pweb = new System.Windows.Forms.Panel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbOpacidad = new System.Windows.Forms.TrackBar();
            this.pAjustes = new System.Windows.Forms.PictureBox();
            this.grpAjusteImagen = new System.Windows.Forms.GroupBox();
            this.lblOpacidad = new System.Windows.Forms.Label();
            this.rdbColor2 = new System.Windows.Forms.RadioButton();
            this.rdbColor1 = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pNotaRapida = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.grpWebBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnavegador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAtras)).BeginInit();
            this.pweb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAjustes)).BeginInit();
            this.grpAjusteImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pNotaRapida)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1453, 33);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(615, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controles";
            // 
            // btnWebBrowser
            // 
            this.btnWebBrowser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnWebBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebBrowser.ForeColor = System.Drawing.Color.White;
            this.btnWebBrowser.Location = new System.Drawing.Point(600, 40);
            this.btnWebBrowser.Name = "btnWebBrowser";
            this.btnWebBrowser.Size = new System.Drawing.Size(117, 36);
            this.btnWebBrowser.TabIndex = 1;
            this.btnWebBrowser.Text = "WebBrowser";
            this.btnWebBrowser.UseVisualStyleBackColor = false;
            this.btnWebBrowser.Click += new System.EventHandler(this.btnWebBrowser_Click);
            // 
            // grpWebBrowser
            // 
            this.grpWebBrowser.BackColor = System.Drawing.Color.White;
            this.grpWebBrowser.Controls.Add(this.lblProgreso);
            this.grpWebBrowser.Controls.Add(this.Navegador);
            this.grpWebBrowser.Controls.Add(this.barraProgreso);
            this.grpWebBrowser.Controls.Add(this.pnavegador);
            this.grpWebBrowser.Controls.Add(this.pPreview);
            this.grpWebBrowser.Controls.Add(this.pHome);
            this.grpWebBrowser.Controls.Add(this.pImprimir);
            this.grpWebBrowser.Controls.Add(this.pIr);
            this.grpWebBrowser.Controls.Add(this.pAtras);
            this.grpWebBrowser.Controls.Add(this.pweb);
            this.grpWebBrowser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWebBrowser.Location = new System.Drawing.Point(148, 82);
            this.grpWebBrowser.Name = "grpWebBrowser";
            this.grpWebBrowser.Size = new System.Drawing.Size(1084, 488);
            this.grpWebBrowser.TabIndex = 8;
            this.grpWebBrowser.TabStop = false;
            this.grpWebBrowser.Text = "WebBrowser";
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(486, 33);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(32, 19);
            this.lblProgreso.TabIndex = 11;
            this.lblProgreso.Text = "0%";
            // 
            // Navegador
            // 
            this.Navegador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Navegador.Location = new System.Drawing.Point(0, 54);
            this.Navegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.Navegador.Name = "Navegador";
            this.Navegador.Size = new System.Drawing.Size(1075, 434);
            this.Navegador.TabIndex = 8;
            // 
            // barraProgreso
            // 
            this.barraProgreso.Location = new System.Drawing.Point(617, 33);
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.Size = new System.Drawing.Size(152, 23);
            this.barraProgreso.TabIndex = 9;
            // 
            // pnavegador
            // 
            this.pnavegador.Image = ((System.Drawing.Image)(resources.GetObject("pnavegador.Image")));
            this.pnavegador.Location = new System.Drawing.Point(1019, 0);
            this.pnavegador.Name = "pnavegador";
            this.pnavegador.Size = new System.Drawing.Size(59, 48);
            this.pnavegador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnavegador.TabIndex = 7;
            this.pnavegador.TabStop = false;
            // 
            // pPreview
            // 
            this.pPreview.Image = ((System.Drawing.Image)(resources.GetObject("pPreview.Image")));
            this.pPreview.Location = new System.Drawing.Point(430, 25);
            this.pPreview.Name = "pPreview";
            this.pPreview.Size = new System.Drawing.Size(33, 31);
            this.pPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pPreview.TabIndex = 5;
            this.pPreview.TabStop = false;
            this.pPreview.Click += new System.EventHandler(this.pPreview_Click);
            // 
            // pHome
            // 
            this.pHome.Image = ((System.Drawing.Image)(resources.GetObject("pHome.Image")));
            this.pHome.Location = new System.Drawing.Point(352, 25);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(33, 31);
            this.pHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHome.TabIndex = 4;
            this.pHome.TabStop = false;
            this.pHome.Click += new System.EventHandler(this.pI_Click);
            // 
            // pImprimir
            // 
            this.pImprimir.Image = ((System.Drawing.Image)(resources.GetObject("pImprimir.Image")));
            this.pImprimir.Location = new System.Drawing.Point(391, 25);
            this.pImprimir.Name = "pImprimir";
            this.pImprimir.Size = new System.Drawing.Size(33, 31);
            this.pImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImprimir.TabIndex = 3;
            this.pImprimir.TabStop = false;
            this.pImprimir.Click += new System.EventHandler(this.pImprimir_Click);
            // 
            // pIr
            // 
            this.pIr.Image = ((System.Drawing.Image)(resources.GetObject("pIr.Image")));
            this.pIr.Location = new System.Drawing.Point(313, 24);
            this.pIr.Name = "pIr";
            this.pIr.Size = new System.Drawing.Size(33, 31);
            this.pIr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pIr.TabIndex = 2;
            this.pIr.TabStop = false;
            this.pIr.Click += new System.EventHandler(this.pIr_Click);
            // 
            // pAtras
            // 
            this.pAtras.Image = ((System.Drawing.Image)(resources.GetObject("pAtras.Image")));
            this.pAtras.Location = new System.Drawing.Point(274, 24);
            this.pAtras.Name = "pAtras";
            this.pAtras.Size = new System.Drawing.Size(33, 31);
            this.pAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAtras.TabIndex = 1;
            this.pAtras.TabStop = false;
            this.pAtras.Click += new System.EventHandler(this.pAtras_Click);
            // 
            // pweb
            // 
            this.pweb.BackColor = System.Drawing.Color.DodgerBlue;
            this.pweb.Controls.Add(this.txtUrl);
            this.pweb.Controls.Add(this.lblEnter);
            this.pweb.Location = new System.Drawing.Point(3, 23);
            this.pweb.Name = "pweb";
            this.pweb.Size = new System.Drawing.Size(264, 31);
            this.pweb.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(75, 2);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(167, 27);
            this.txtUrl.TabIndex = 1;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.Color.White;
            this.lblEnter.Location = new System.Drawing.Point(5, 5);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(63, 17);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter Url:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbOpacidad
            // 
            this.tbOpacidad.Location = new System.Drawing.Point(82, 18);
            this.tbOpacidad.Name = "tbOpacidad";
            this.tbOpacidad.Size = new System.Drawing.Size(91, 45);
            this.tbOpacidad.TabIndex = 18;
            this.tbOpacidad.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pAjustes
            // 
            this.pAjustes.BackColor = System.Drawing.SystemColors.Control;
            this.pAjustes.Image = ((System.Drawing.Image)(resources.GetObject("pAjustes.Image")));
            this.pAjustes.Location = new System.Drawing.Point(1363, 57);
            this.pAjustes.Name = "pAjustes";
            this.pAjustes.Size = new System.Drawing.Size(62, 50);
            this.pAjustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAjustes.TabIndex = 19;
            this.pAjustes.TabStop = false;
            this.pAjustes.Click += new System.EventHandler(this.pAjustes_Click);
            // 
            // grpAjusteImagen
            // 
            this.grpAjusteImagen.Controls.Add(this.btnGuardar);
            this.grpAjusteImagen.Controls.Add(this.rdbColor1);
            this.grpAjusteImagen.Controls.Add(this.rdbColor2);
            this.grpAjusteImagen.Controls.Add(this.lblOpacidad);
            this.grpAjusteImagen.Controls.Add(this.tbOpacidad);
            this.grpAjusteImagen.Location = new System.Drawing.Point(1238, 118);
            this.grpAjusteImagen.Name = "grpAjusteImagen";
            this.grpAjusteImagen.Size = new System.Drawing.Size(200, 107);
            this.grpAjusteImagen.TabIndex = 20;
            this.grpAjusteImagen.TabStop = false;
            this.grpAjusteImagen.Text = "Ajustes Imagen";
            // 
            // lblOpacidad
            // 
            this.lblOpacidad.AutoSize = true;
            this.lblOpacidad.Location = new System.Drawing.Point(7, 25);
            this.lblOpacidad.Name = "lblOpacidad";
            this.lblOpacidad.Size = new System.Drawing.Size(53, 13);
            this.lblOpacidad.TabIndex = 19;
            this.lblOpacidad.Text = "Opacidad";
            // 
            // rdbColor2
            // 
            this.rdbColor2.AutoSize = true;
            this.rdbColor2.Location = new System.Drawing.Point(136, 57);
            this.rdbColor2.Name = "rdbColor2";
            this.rdbColor2.Size = new System.Drawing.Size(58, 17);
            this.rdbColor2.TabIndex = 20;
            this.rdbColor2.TabStop = true;
            this.rdbColor2.Text = "Color 2";
            this.rdbColor2.UseVisualStyleBackColor = true;
            // 
            // rdbColor1
            // 
            this.rdbColor1.AutoSize = true;
            this.rdbColor1.Location = new System.Drawing.Point(68, 57);
            this.rdbColor1.Name = "rdbColor1";
            this.rdbColor1.Size = new System.Drawing.Size(55, 17);
            this.rdbColor1.TabIndex = 21;
            this.rdbColor1.TabStop = true;
            this.rdbColor1.Text = "Color1";
            this.rdbColor1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(68, 75);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 26);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Save";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pNotaRapida
            // 
            this.pNotaRapida.BackColor = System.Drawing.SystemColors.Control;
            this.pNotaRapida.Image = ((System.Drawing.Image)(resources.GetObject("pNotaRapida.Image")));
            this.pNotaRapida.Location = new System.Drawing.Point(1285, 57);
            this.pNotaRapida.Name = "pNotaRapida";
            this.pNotaRapida.Size = new System.Drawing.Size(62, 50);
            this.pNotaRapida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pNotaRapida.TabIndex = 21;
            this.pNotaRapida.TabStop = false;
            this.pNotaRapida.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmContoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 645);
            this.Controls.Add(this.pNotaRapida);
            this.Controls.Add(this.grpAjusteImagen);
            this.Controls.Add(this.pAjustes);
            this.Controls.Add(this.grpWebBrowser);
            this.Controls.Add(this.btnWebBrowser);
            this.Controls.Add(this.panel1);
            this.Name = "frmContoles";
            this.Text = "frmContoles";
            this.Load += new System.EventHandler(this.frmContoles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpWebBrowser.ResumeLayout(false);
            this.grpWebBrowser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnavegador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAtras)).EndInit();
            this.pweb.ResumeLayout(false);
            this.pweb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAjustes)).EndInit();
            this.grpAjusteImagen.ResumeLayout(false);
            this.grpAjusteImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pNotaRapida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWebBrowser;
        private System.Windows.Forms.GroupBox grpWebBrowser;
        private System.Windows.Forms.WebBrowser Navegador;
        private System.Windows.Forms.PictureBox pnavegador;
        private System.Windows.Forms.PictureBox pPreview;
        private System.Windows.Forms.PictureBox pHome;
        private System.Windows.Forms.PictureBox pImprimir;
        private System.Windows.Forms.PictureBox pIr;
        private System.Windows.Forms.PictureBox pAtras;
        private System.Windows.Forms.Panel pweb;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.ProgressBar barraProgreso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TrackBar tbOpacidad;
        private System.Windows.Forms.PictureBox pAjustes;
        private System.Windows.Forms.GroupBox grpAjusteImagen;
        private System.Windows.Forms.Label lblOpacidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rdbColor1;
        private System.Windows.Forms.RadioButton rdbColor2;
        private System.Windows.Forms.PictureBox pNotaRapida;
    }
}