using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class Conexion
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-E0OV10B;Initial Catalog=CRUDFULL;Integrated Security=True");

        public SqlConnection AbriConexion()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public SqlConnection CerrarConexion()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
    }
}
