using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2Modelo;

namespace Lab2Vista
{
    public partial class Nomina : Form
    {
        modelo mo = new modelo();
        public Nomina()
        {
            InitializeComponent();
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Dtp_fechalim.Format = DateTimePickerFormat.Custom;
            Dtp_fechalim.CustomFormat = "yyyy-MM-dd";
            Lbl_date.Text = fecha;
            grb_detalle.Enabled = false;
            cmb_emp.llenarse("empleado", "codigo_empleado", "nombre_empleado");
            cmb_concepto.llenarse("concepto", "codigo_concepto", "nombre_concepto");
            cod.Text = mo.idmax("nominae","codigo_nomina");
            

        }

        private void Btn_orden_Click(object sender, EventArgs e)
        {
            grb_detalle.Enabled = true;
            Gb_encab.Enabled = false;

            string fecha1 = DateTime.Now.ToString("yyyy-MM-dd");
            string fecha2 = Dtp_fechalim.Text;

            string id = cod.Text;

            string cadena = "INSERT INTO nominae (codigo_nomina, fecha_inicial_nomina, fecha_final_nomina, estado) VALUES("+id+",'" + fecha1 + "','" + fecha2 + "',1);";
            mo.insertar(cadena);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string codi = cod.Text;
            string codemp = cmb_emp.obtenerP();
            string condcon = cmb_concepto.obtenerP();
            string valnom = txtvalorconcepto.Text;

            dgb_nomina.Rows.Add(codi, codemp, condcon,valnom);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (dgb_nomina.SelectedRows.Count == 1)
            {


               dgb_nomina.Rows.RemoveAt(dgb_nomina.CurrentRow.Index);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string idmax = cod.Text;
          
            foreach (DataGridViewRow row in dgb_nomina.Rows)
            {
                string cadena = "INSERT INTO nominad (codigo_nomina, codigo_empleado, codigo_concepto, valor_nominaD, estado) VALUES (" + idmax + ",'" + row.Cells[1].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "' , "+ row.Cells[3].Value.ToString() + " , 1);";
                mo.insertar(cadena);
            }

            MessageBox.Show("Orden Generada");
            this.Close();
        }
    }
}
