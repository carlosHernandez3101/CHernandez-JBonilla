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
            this.tpRegSuc = new System.Windows.Forms.TabPage();
            this.tpConsSuc = new System.Windows.Forms.TabPage();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarBanco = new System.Windows.Forms.Button();
            this.tbxNomBan = new System.Windows.Forms.TextBox();
            this.tbxNitBan = new System.Windows.Forms.TextBox();
            this.dtFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.tcGestionBanco.SuspendLayout();
            this.tpRegBanco.SuspendLayout();
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
            // tpRegSuc
            // 
            this.tpRegSuc.Location = new System.Drawing.Point(4, 22);
            this.tpRegSuc.Name = "tpRegSuc";
            this.tpRegSuc.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegSuc.Size = new System.Drawing.Size(653, 353);
            this.tpRegSuc.TabIndex = 1;
            this.tpRegSuc.Text = "REGISTRAR SUCURSAL";
            this.tpRegSuc.UseVisualStyleBackColor = true;
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
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(78, 57);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(97, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "NOMBRE BANCO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIT BANCO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA DE CREACIÓN:";
            // 
            // btnAgregarBanco
            // 
            this.btnAgregarBanco.Location = new System.Drawing.Point(227, 266);
            this.btnAgregarBanco.Name = "btnAgregarBanco";
            this.btnAgregarBanco.Size = new System.Drawing.Size(195, 55);
            this.btnAgregarBanco.TabIndex = 3;
            this.btnAgregarBanco.Text = "REGISTRAR BANCO";
            this.btnAgregarBanco.UseVisualStyleBackColor = true;
            // 
            // tbxNomBan
            // 
            this.tbxNomBan.Location = new System.Drawing.Point(239, 57);
            this.tbxNomBan.Name = "tbxNomBan";
            this.tbxNomBan.Size = new System.Drawing.Size(100, 20);
            this.tbxNomBan.TabIndex = 4;
            // 
            // tbxNitBan
            // 
            this.tbxNitBan.Location = new System.Drawing.Point(239, 107);
            this.tbxNitBan.Name = "tbxNitBan";
            this.tbxNitBan.Size = new System.Drawing.Size(100, 20);
            this.tbxNitBan.TabIndex = 5;
            // 
            // dtFechaCreacion
            // 
            this.dtFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaCreacion.Location = new System.Drawing.Point(239, 162);
            this.dtFechaCreacion.Name = "dtFechaCreacion";
            this.dtFechaCreacion.Size = new System.Drawing.Size(200, 21);
            this.dtFechaCreacion.TabIndex = 6;
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
    }
}

