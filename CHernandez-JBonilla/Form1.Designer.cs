namespace CHernandez_JBonilla
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
            this.tcGestionBanco = new System.Windows.Forms.TabControl();
            this.tpRegBanco = new System.Windows.Forms.TabPage();
            this.dtFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.tbxNitBan = new System.Windows.Forms.TextBox();
            this.tbxNomBan = new System.Windows.Forms.TextBox();
            this.btnAgregarBanco = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.tpRegSuc = new System.Windows.Forms.TabPage();
            this.btnRegistrarSuc = new System.Windows.Forms.Button();
            this.cbxUbiSuc = new System.Windows.Forms.ComboBox();
            this.txtAniosAnt = new System.Windows.Forms.TextBox();
            this.txtNumEmp = new System.Windows.Forms.TextBox();
            this.txtNomSuc = new System.Windows.Forms.TextBox();
            this.txtCodSuc = new System.Windows.Forms.TextBox();
            this.lblAntAnios = new System.Windows.Forms.Label();
            this.lblNumEmp = new System.Windows.Forms.Label();
            this.lblUbiSuc = new System.Windows.Forms.Label();
            this.lblNomSuc = new System.Windows.Forms.Label();
            this.lblCodSuc = new System.Windows.Forms.Label();
            this.tpConsSuc = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tcGestionBanco.SuspendLayout();
            this.tpRegBanco.SuspendLayout();
            this.tpRegSuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcGestionBanco
            // 
            this.tcGestionBanco.Controls.Add(this.tpRegBanco);
            this.tcGestionBanco.Controls.Add(this.tpRegSuc);
            this.tcGestionBanco.Controls.Add(this.tpConsSuc);
            this.tcGestionBanco.Location = new System.Drawing.Point(37, 29);
            this.tcGestionBanco.Name = "tcGestionBanco";
            this.tcGestionBanco.SelectedIndex = 0;
            this.tcGestionBanco.Size = new System.Drawing.Size(661, 379);
            this.tcGestionBanco.TabIndex = 0;
            // 
            // tpRegBanco
            // 
            this.tpRegBanco.Controls.Add(this.label9);
            this.tpRegBanco.Controls.Add(this.dtFechaCreacion);
            this.tpRegBanco.Controls.Add(this.tbxNitBan);
            this.tpRegBanco.Controls.Add(this.tbxNomBan);
            this.tpRegBanco.Controls.Add(this.btnAgregarBanco);
            this.tpRegBanco.Controls.Add(this.label3);
            this.tpRegBanco.Controls.Add(this.label2);
            this.tpRegBanco.Controls.Add(this.lbl);
            this.tpRegBanco.Location = new System.Drawing.Point(4, 22);
            this.tpRegBanco.Name = "tpRegBanco";
            this.tpRegBanco.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegBanco.Size = new System.Drawing.Size(653, 353);
            this.tpRegBanco.TabIndex = 0;
            this.tpRegBanco.Text = "REGISTRAR BANCO";
            this.tpRegBanco.UseVisualStyleBackColor = true;
            // 
            // dtFechaCreacion
            // 
            this.dtFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaCreacion.Location = new System.Drawing.Point(254, 196);
            this.dtFechaCreacion.Name = "dtFechaCreacion";
            this.dtFechaCreacion.Size = new System.Drawing.Size(200, 21);
            this.dtFechaCreacion.TabIndex = 6;
            // 
            // tbxNitBan
            // 
            this.tbxNitBan.Location = new System.Drawing.Point(254, 141);
            this.tbxNitBan.Name = "tbxNitBan";
            this.tbxNitBan.Size = new System.Drawing.Size(100, 20);
            this.tbxNitBan.TabIndex = 5;
            // 
            // tbxNomBan
            // 
            this.tbxNomBan.Location = new System.Drawing.Point(254, 91);
            this.tbxNomBan.Name = "tbxNomBan";
            this.tbxNomBan.Size = new System.Drawing.Size(100, 20);
            this.tbxNomBan.TabIndex = 4;
            // 
            // btnAgregarBanco
            // 
            this.btnAgregarBanco.Location = new System.Drawing.Point(227, 266);
            this.btnAgregarBanco.Name = "btnAgregarBanco";
            this.btnAgregarBanco.Size = new System.Drawing.Size(195, 55);
            this.btnAgregarBanco.TabIndex = 3;
            this.btnAgregarBanco.Text = "REGISTRAR BANCO";
            this.btnAgregarBanco.UseVisualStyleBackColor = true;
            this.btnAgregarBanco.Click += new System.EventHandler(this.btnAgregarBanco_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA DE CREACIÓN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIT BANCO:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(93, 91);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(97, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "NOMBRE BANCO:";
            // 
            // tpRegSuc
            // 
            this.tpRegSuc.Controls.Add(this.label8);
            this.tpRegSuc.Controls.Add(this.btnRegistrarSuc);
            this.tpRegSuc.Controls.Add(this.cbxUbiSuc);
            this.tpRegSuc.Controls.Add(this.txtAniosAnt);
            this.tpRegSuc.Controls.Add(this.txtNumEmp);
            this.tpRegSuc.Controls.Add(this.txtNomSuc);
            this.tpRegSuc.Controls.Add(this.txtCodSuc);
            this.tpRegSuc.Controls.Add(this.lblAntAnios);
            this.tpRegSuc.Controls.Add(this.lblNumEmp);
            this.tpRegSuc.Controls.Add(this.lblUbiSuc);
            this.tpRegSuc.Controls.Add(this.lblNomSuc);
            this.tpRegSuc.Controls.Add(this.lblCodSuc);
            this.tpRegSuc.Location = new System.Drawing.Point(4, 22);
            this.tpRegSuc.Name = "tpRegSuc";
            this.tpRegSuc.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegSuc.Size = new System.Drawing.Size(653, 353);
            this.tpRegSuc.TabIndex = 1;
            this.tpRegSuc.Text = "REGISTRAR SUCURSAL";
            this.tpRegSuc.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarSuc
            // 
            this.btnRegistrarSuc.Location = new System.Drawing.Point(248, 293);
            this.btnRegistrarSuc.Name = "btnRegistrarSuc";
            this.btnRegistrarSuc.Size = new System.Drawing.Size(168, 46);
            this.btnRegistrarSuc.TabIndex = 10;
            this.btnRegistrarSuc.Text = "REGISTRAR SUCURSAL";
            this.btnRegistrarSuc.UseVisualStyleBackColor = true;
            // 
            // cbxUbiSuc
            // 
            this.cbxUbiSuc.FormattingEnabled = true;
            this.cbxUbiSuc.Items.AddRange(new object[] {
            "norte",
            "sur",
            "centro"});
            this.cbxUbiSuc.Location = new System.Drawing.Point(178, 225);
            this.cbxUbiSuc.Name = "cbxUbiSuc";
            this.cbxUbiSuc.Size = new System.Drawing.Size(121, 21);
            this.cbxUbiSuc.TabIndex = 9;
            // 
            // txtAniosAnt
            // 
            this.txtAniosAnt.Location = new System.Drawing.Point(80, 170);
            this.txtAniosAnt.Name = "txtAniosAnt";
            this.txtAniosAnt.Size = new System.Drawing.Size(100, 20);
            this.txtAniosAnt.TabIndex = 8;
            // 
            // txtNumEmp
            // 
            this.txtNumEmp.Location = new System.Drawing.Point(351, 170);
            this.txtNumEmp.Name = "txtNumEmp";
            this.txtNumEmp.Size = new System.Drawing.Size(100, 20);
            this.txtNumEmp.TabIndex = 7;
            // 
            // txtNomSuc
            // 
            this.txtNomSuc.Location = new System.Drawing.Point(351, 90);
            this.txtNomSuc.Name = "txtNomSuc";
            this.txtNomSuc.Size = new System.Drawing.Size(100, 20);
            this.txtNomSuc.TabIndex = 6;
            // 
            // txtCodSuc
            // 
            this.txtCodSuc.Location = new System.Drawing.Point(80, 90);
            this.txtCodSuc.Name = "txtCodSuc";
            this.txtCodSuc.Size = new System.Drawing.Size(100, 20);
            this.txtCodSuc.TabIndex = 5;
            // 
            // lblAntAnios
            // 
            this.lblAntAnios.AutoSize = true;
            this.lblAntAnios.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntAnios.Location = new System.Drawing.Point(77, 145);
            this.lblAntAnios.Name = "lblAntAnios";
            this.lblAntAnios.Size = new System.Drawing.Size(165, 15);
            this.lblAntAnios.TabIndex = 4;
            this.lblAntAnios.Text = "ANTIGUEDAD EN AÑOS:";
            // 
            // lblNumEmp
            // 
            this.lblNumEmp.AutoSize = true;
            this.lblNumEmp.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEmp.Location = new System.Drawing.Point(348, 145);
            this.lblNumEmp.Name = "lblNumEmp";
            this.lblNumEmp.Size = new System.Drawing.Size(175, 15);
            this.lblNumEmp.TabIndex = 3;
            this.lblNumEmp.Text = "NUMERO DE EMPLEADOS:";
            // 
            // lblUbiSuc
            // 
            this.lblUbiSuc.AutoSize = true;
            this.lblUbiSuc.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbiSuc.Location = new System.Drawing.Point(77, 233);
            this.lblUbiSuc.Name = "lblUbiSuc";
            this.lblUbiSuc.Size = new System.Drawing.Size(91, 15);
            this.lblUbiSuc.TabIndex = 2;
            this.lblUbiSuc.Text = "UBICACIÓN:";
            // 
            // lblNomSuc
            // 
            this.lblNomSuc.AutoSize = true;
            this.lblNomSuc.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomSuc.Location = new System.Drawing.Point(348, 60);
            this.lblNomSuc.Name = "lblNomSuc";
            this.lblNomSuc.Size = new System.Drawing.Size(144, 15);
            this.lblNomSuc.TabIndex = 1;
            this.lblNomSuc.Text = "NOMBRE SUCURSAL:";
            // 
            // lblCodSuc
            // 
            this.lblCodSuc.AutoSize = true;
            this.lblCodSuc.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodSuc.Location = new System.Drawing.Point(77, 60);
            this.lblCodSuc.Name = "lblCodSuc";
            this.lblCodSuc.Size = new System.Drawing.Size(145, 15);
            this.lblCodSuc.TabIndex = 0;
            this.lblCodSuc.Text = "CODIGO SUCURSAL:";
            // 
            // tpConsSuc
            // 
            this.tpConsSuc.Location = new System.Drawing.Point(4, 22);
            this.tpConsSuc.Name = "tpConsSuc";
            this.tpConsSuc.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsSuc.Size = new System.Drawing.Size(653, 353);
            this.tpConsSuc.TabIndex = 2;
            this.tpConsSuc.Text = "CONSULTAR SUCURSAL";
            this.tpConsSuc.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "DATOS DE LA SUCURSAL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "DATOS DEL BANCO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcGestionBanco);
            this.Name = "Form1";
            this.Text = "GESTION ADMINISTRATIVA DEL BANCO";
            this.tcGestionBanco.ResumeLayout(false);
            this.tpRegBanco.ResumeLayout(false);
            this.tpRegBanco.PerformLayout();
            this.tpRegSuc.ResumeLayout(false);
            this.tpRegSuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcGestionBanco;
        private System.Windows.Forms.TabPage tpRegBanco;
        private System.Windows.Forms.TabPage tpRegSuc;
        private System.Windows.Forms.TabPage tpConsSuc;
        private System.Windows.Forms.DateTimePicker dtFechaCreacion;
        private System.Windows.Forms.TextBox tbxNitBan;
        private System.Windows.Forms.TextBox tbxNomBan;
        private System.Windows.Forms.Button btnAgregarBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblNumEmp;
        private System.Windows.Forms.Label lblUbiSuc;
        private System.Windows.Forms.Label lblNomSuc;
        private System.Windows.Forms.Label lblCodSuc;
        private System.Windows.Forms.ComboBox cbxUbiSuc;
        private System.Windows.Forms.TextBox txtAniosAnt;
        private System.Windows.Forms.TextBox txtNumEmp;
        private System.Windows.Forms.TextBox txtNomSuc;
        private System.Windows.Forms.TextBox txtCodSuc;
        private System.Windows.Forms.Label lblAntAnios;
        private System.Windows.Forms.Button btnRegistrarSuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

