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
        public int registrarSucursal( int v_sucursalcodigo, String v_sucursalnombre, String v_sucursalubicacion,
         int v_sucursalnumemp, int v_sucursalantiguedad, int v_banconit){

            int respuesta;

            cnn.Open();
            OracleCommand miComando = new OracleCommand("BD1B.prcregistrarpelicula", cnn);

            miComando.Parameters.Add("sucursalcodigo", OracleDbType.Int32, v_sucursalcodigo, ParameterDirection.Input);
            miComando.Parameters.Add("sucursalnombre", OracleDbType.Varchar2, 256, v_sucursalnombre).Direction = ParameterDirection.Input;
            miComando.Parameters.Add("sucursalubicacion", OracleDbType.Varchar2, 256, v_sucursalubicacion).Direction = ParameterDirection.Input;
            miComando.Parameters.Add("sucursalnumemp", OracleDbType.Int32, v_sucursalnumemp, ParameterDirection.Input);
            miComando.Parameters.Add("sucursalantiguedad", OracleDbType.Int32, v_sucursalantiguedad, ParameterDirection.Input);
            miComando.Parameters.Add("banconit", OracleDbType.Int32, v_banconit, ParameterDirection.Input);

            miComando.CommandType = CommandType.StoredProcedure;

            respuesta = miComando.ExecuteNonQuery();

            return respuesta;
        }
    }
}
