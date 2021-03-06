﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using CapaDatos;
namespace Lab2Vista
{
    public partial class MDINominas : Form
    {
        private int childFormNumber = 0;
        sentencia sn = new sentencia();
        string usuarioact;
        public MDINominas()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDINominas_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();

            LblUsuario.Text = login.obtenerNombreUsuario();
            usuarioact = LblUsuario.Text;
        }

        private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(LblUsuario.Text);
            seguridad.lbl_nombreUsuario.Text = LblUsuario.Text;
            seguridad.ShowDialog();
            sn.insertarBitacora(LblUsuario.Text, "Ingreso ", "Usuarios");
        }

        private void MantenimientoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MantenimientoEmpleado frm = new MantenimientoEmpleado(LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimientoPuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoPuesto frm = new MantenimientoPuesto(LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimientoConceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoConcepto frm = new MantenimientoConcepto(LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimientoDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         MantenimientoDepartamento frm = new MantenimientoDepartamento(LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void GenerarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nomina frm = new Nomina();
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
