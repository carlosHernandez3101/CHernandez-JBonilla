using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;


namespace CHernandez_JBonilla.persistencia
{
    class SucursalBD
    {
        OracleConnection cnn = new OracleConnection("Data Source = localhost; User ID = BD1B; Password = admin;");
        public int registrarSucursal( int v_sucursalcodigo, string v_sucursalnombre, string v_sucursalubicacion,
         int v_sucursalnumemp, int v_sucursalantiguedad, int v_banconit){

            int respuesta;

            cnn.Open();
            OracleCommand miComando = new OracleCommand("BD1B.prcregistrarpelicula", cnn);

            miComando.Parameters.Add("(v_sucursalCodigo ", OracleDbType.Int64, v_sucursalcodigo, ParameterDirection.Input);
            miComando.Parameters.Add("v_sucursalNombre ", OracleDbType.Varchar2, 60, v_sucursalnombre, ParameterDirection.Input);
            miComando.Parameters.Add("v_sucursalUbicacion ", OracleDbType.Varchar2, 20, v_sucursalubicacion, ParameterDirection.Input);
            miComando.Parameters.Add("(v_sucursalNumEmp ", OracleDbType.Int64, v_sucursalnumemp, ParameterDirection.Input);
            miComando.Parameters.Add("(v_sucursalAntiguedad ", OracleDbType.Int64, v_sucursalantiguedad, ParameterDirection.Input);
            miComando.Parameters.Add("(v_bancoNit ", OracleDbType.Int64, v_banconit, ParameterDirection.Input);

            miComando.CommandType = CommandType.StoredProcedure;
            respuesta = miComando.ExecuteNonQuery();
            cnn.Close();

            return respuesta;
        }

        public DataSet consultarSucursalesBD(int v_bancoNit, string v_sucursalUbicacion)
        {
            //int resultado;
            //abrimos conexion
            cnn.Open();
            //creo un objeto de tipo Comando
            OracleCommand miComando = new OracleCommand("bd1a.prcConsultarSucursales", cnn);

            miComando.Parameters.Add("(v_bancoNit ", OracleDbType.Int64, v_bancoNit, ParameterDirection.Input);
            miComando.Parameters.Add("v_sucursalUbicacion ", OracleDbType.Varchar2, 20, v_sucursalUbicacion, ParameterDirection.Input);
            miComando.Parameters.Add("cur_sucursales ", OracleDbType.RefCursor, ParameterDirection.Output);

            miComando.CommandType = CommandType.StoredProcedure;

            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "Sucursales");

            cnn.Close();

            return ds;
        }
    }
}
