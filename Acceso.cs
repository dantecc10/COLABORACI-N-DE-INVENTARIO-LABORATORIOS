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
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario_Consultor, Usuario_Administrador, Contraseña_Consultor, Contraseña_Administrador;

            Usuario_Consultor = "CECyTE_Consulta";
            Contraseña_Consultor = "consultaLabs";

            Usuario_Administrador = "CECyTE_Administrador";
            Contraseña_Administrador = "administraLabs";

            bool adminpower;

            switch (usuariotxbx.Text)
            {
                case "CECyTE_Consulta":
                    if (contraseñatxbx.Text == Contraseña_Consultor && usuariotxbx.Text==Usuario_Consultor)
                    {
                        adminpower = false;
                        this.Hide();
                        MessageBox.Show("¡Inicio de sesión exitoso!");
                        Menú menu = new Menú();
                        menu.Show();
                    }
                    else
                    {
                        adminpower = false;
                        MessageBox.Show("Usuario o contraseña incorrectos. Asegúrese de marcar la casilla.");
                    }
                    break;
                case "CECyTE_Administrador":
                    if (contraseñatxbx.Text == Contraseña_Administrador && usuariotxbx.Text==Usuario_Administrador)
                    {
                        adminpower = true;
                        this.Hide();
                        MessageBox.Show("¡Inicio de sesión exitoso!");
                        Menú menu = new Menú();
                        menu.Show();
                    }
                    else
                    {
                        adminpower = false;
                        MessageBox.Show("Usuario o contraseña incorrectos. Asegúrese de marcar la casilla.");
                    }
                    break;
                default:
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    break;
            }

            //Inicio_Exitoso: Form1.

            //   if (contraseñatxbx.Text = Contraseña_Consultor && usuariotxbx.Text = Usuario_Consultor && CasillaNoSoyUnRobot.Checked = true)

        }

        private void Acceso_Load(object sender, EventArgs e)
        {
          
        }
    }
}