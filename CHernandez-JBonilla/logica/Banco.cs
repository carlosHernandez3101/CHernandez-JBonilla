using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace CHernandez_JBonilla.logica
{
    class Banco
    {
        OracleConnection cnn = new OracleConnection("Data Source = localhost; User ID = BD1B; Password = admin;");
        public int registrarBancoBD(int v_bancoNit, string v_bancoNombre, DateTime v_bancoFechaCreacion)

        {
            int resultado = 0;
            //abrimos conexion
            try
            {
                cnn.Open();
                //creo un objeto de tipo Comando
                OracleCommand miComando = new OracleCommand("BD1B.prcRegistrarBanco", cnn);
                miComando.Parameters.Add("(v_bancoNit ", OracleDbType.Int64, v_bancoNit, ParameterDirection.Input);
                miComando.Parameters.Add("v_bancoNombre ", OracleDbType.Varchar2, 40, v_bancoNombre, ParameterDirection.Input);
                miComando.Parameters.Add("v_bancoFechaCreacion ", OracleDbType.Varchar2, 256, v_bancoFechaCreacion, ParameterDirection.Input);
                miComando.CommandType = CommandType.StoredProcedure;

                resultado = miComando.ExecuteNonQuery(); // insert, update or delete.

                cnn.Close();
                return resultado;
            }
            catch (Exception)
            {
                MessageBox.Show("Banco no registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

    }
}
