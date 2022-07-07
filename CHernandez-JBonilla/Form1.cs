using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHernandez_JBonilla.logica;


namespace CHernandez_JBonilla
{
    public partial class Form1 : Form
    {
        Banco banco = new Banco();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarBanco_Click(object sender, EventArgs e)
        {
            int resultado;

            string nombreBanco = tbxNomBan.Text;
            int nitBanco = int.Parse(tbxNitBan.Text);
            DateTime fechaCreacionBanco = dtFechaCreacion.Value.Date;

            resultado = banco.registrarBancoBD(nitBanco, nombreBanco, fechaCreacionBanco);

            if (resultado > 0)
            {
                MessageBox.Show("Banco registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Banco no registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
