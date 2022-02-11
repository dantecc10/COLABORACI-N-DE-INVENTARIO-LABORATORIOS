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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario_Consultor, Usuario_Administrador, Contraseña_Consultor, Contraseña_Administrador;

            Usuario_Consultor = "CECyTE_Consulta";
            Contraseña_Consultor = "consultaLabs";

            Usuario_Administrador = "CECyTE_Administra";
            Contraseña_Administrador = "administraLabs";

            bool adminpower;

            switch (usuariotxbx.Text)
            {
                case "CECyTE_Consulta":
                    if (contraseñatxbx.Text == "consultaLabs")
                    {
                        adminpower = false;
                    //    goto Inicio_Exitoso;
                    }
                    else
                    {
                        adminpower = false;
                        MessageBox.Show("Usuario o contraseña incorrectos. Asegúrese de marcar la casilla.");
                    }
                    break;
                case "CECyTE_Administrador":
                    if (contraseñatxbx.Text == "administraLabs")
                    {
                        adminpower = true;
                    //    goto Inicio_Exitoso;
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
            //     MessageBox.Show("Ha iniciado sesión...");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
