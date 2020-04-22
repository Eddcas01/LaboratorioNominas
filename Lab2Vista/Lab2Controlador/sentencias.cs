using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Lab2Controlador
{
    public class sentencias
    {

        conexion con = new conexion();
        public string obteneridmax(string tabla, string dato)// metodo  que obtinene el contenio de una tabla
        {
            string id = "";
            string sql = "SELECT MAX(" + dato + "+1) FROM " + tabla + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcCommand command = new OdbcCommand(sql, con.Conexion());
            OdbcDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                id = reader.GetValue(0).ToString();
            }
            return id;
        }

        public void insertar(string sql)
        {



            OdbcCommand consulta = new OdbcCommand(sql, con.Conexion());
            consulta.ExecuteNonQuery();




        }



    }


}
