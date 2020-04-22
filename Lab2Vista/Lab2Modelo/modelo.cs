using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Lab2Controlador;
using System.Data.Odbc;

namespace Lab2Modelo
{
    public class modelo
    {
        sentencias  sn = new sentencias();



        public string idmax(string tabla, string dato)
        {



            string idmax = sn.obteneridmax(tabla, dato);
            if (idmax == "")
            {

                idmax = "1";
            }

            return idmax;
        }
        public void insertar(string sql)
        {

            sn.insertar(sql);

        }
    }
}
