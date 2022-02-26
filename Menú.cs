using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_Laboratorios_2._0
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void btn_labi_Click(object sender, EventArgs e)
        {
            this.Close();
            Laboratorio_Idiomas labi=new Laboratorio_Idiomas();
            labi.Show();
        }

        private void btn_labc_Click(object sender, EventArgs e)
        {
            this.Close();
            Laboratorio_Cómputo labc=new Laboratorio_Cómputo();
            labc.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
            Acceso inicio=new Acceso();
            inicio.Show();
        }
    }
}
