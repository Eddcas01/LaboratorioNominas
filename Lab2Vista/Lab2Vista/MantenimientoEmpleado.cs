using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Vista
{
    public partial class MantenimientoEmpleado : Form
    {
        string usuario = "";
        public MantenimientoEmpleado(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "cod_ empleado", "Nombre empleado", "Cod_Puesto", "codigo depto","Sueldo", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            Color Hotel = Color.FromArgb(253, 254, 254);
            navegador1.asignarColorFondo(Hotel);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1");
            navegador1.asignarComboConTabla("puesto", "nombre_puesto", 1);
            navegador1.asignarComboConTabla("departamento", "nombre_departamento", 1);
            navegador1.asignarTabla("empleado");
            navegador1.asignarNombreForm("");

        }

        private void Navegador1_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
