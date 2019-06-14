using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibreriaBD
{
    public class Biblioteca
    {
        public static DataSet Herramientas(string cmd)
        {
            SqlConnection conectar = new SqlConnection(@"Data Source=GO070135\SQLEXPRESS;Initial Catalog=tienda;Integrated Security=True");
            conectar.Open();

            DataSet dll = new DataSet();
            SqlDataAdapter dll_adapter = new SqlDataAdapter(cmd,conectar);

            dll_adapter.Fill(dll);

            conectar.Close();

            return dll;
        }
    }
}
