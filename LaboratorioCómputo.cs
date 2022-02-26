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
    public partial class Laboratorio_Cómputo : Form
    {
        public Laboratorio_Cómputo()
        {
            InitializeComponent();
        }

        private void LaboratorioCómputo_Load(object sender, EventArgs e)
        {
            string cp_CPUsn1, cp_MTORsn1, cp_KEYBsn1, cp_MOUSEsn1; //Declaraciones equipo 1
            string cp_CPUsn2, cp_MTORsn2, cp_KEYBsn2, cp_MOUSEsn2; //Declaraciones equipo 2
            string cp_CPUsn3, cp_MTORsn3, cp_KEYBsn3, cp_MOUSEsn3; //Declaraciones equipo 3
            string cp_CPUsn4, cp_MTORsn4, cp_KEYBsn4, cp_MOUSEsn4; //Declaraciones equipo 4
            string cp_CPUsn5, cp_MTORsn5, cp_KEYBsn5, cp_MOUSEsn5; //Declaraciones equipo 5
            string cp_CPUsn6, cp_MTORsn6, cp_KEYBsn6, cp_MOUSEsn6; //Declaraciones equipo 6
            string cp_CPUsn7, cp_MTORsn7, cp_KEYBsn7, cp_MOUSEsn7; //Declaraciones equipo 7
            string cp_CPUsn8, cp_MTORsn8, cp_KEYBsn8, cp_MOUSEsn8; //Declaraciones equipo 8
            string cp_CPUsn9, cp_MTORsn9, cp_KEYBsn9, cp_MOUSEsn9; //Declaraciones equipo 9
            string cp_CPUsn10, cp_MTORsn10, cp_KEYBsn10, cp_MOUSEsn10; //Declaraciones equipo 10
            string cp_CPUsn11, cp_MTORsn11, cp_KEYBsn11, cp_MOUSEsn11; //Declaraciones equipo 11
            string cp_CPUsn12, cp_MTORsn12, cp_KEYBsn12, cp_MOUSEsn12; //Declaraciones equipo 12
            string cp_CPUsn13, cp_MTORsn13, cp_KEYBsn13, cp_MOUSEsn13; //Declaraciones equipo 13
            string cp_CPUsn14, cp_MTORsn14, cp_KEYBsn14, cp_MOUSEsn14; //Declaraciones equipo 14
            string cp_CPUsn15, cp_MTORsn15, cp_KEYBsn15, cp_MOUSEsn15; //Declaraciones equipo 15
            string cp_CPUsn16, cp_MTORsn16, cp_KEYBsn16, cp_MOUSEsn16; //Declaraciones equipo 16
            string cp_CPUsn17, cp_MTORsn17, cp_KEYBsn17, cp_MOUSEsn17; //Declaraciones equipo 17
            string cp_CPUsn18, cp_MTORsn18, cp_KEYBsn18, cp_MOUSEsn18; //Declaraciones equipo 18
            string cp_CPUsn19, cp_MTORsn19, cp_KEYBsn19, cp_MOUSEsn19; //Declaraciones equipo 19
            string cp_CPUsn20, cp_MTORsn20, cp_KEYBsn20, cp_MOUSEsn20; //Declaraciones equipo 20
            string cp_CPUsn21, cp_MTORsn21, cp_KEYBsn21, cp_MOUSEsn21; //Declaraciones equipo 21
            string cp_CPUsn22, cp_MTORsn22, cp_KEYBsn22, cp_MOUSEsn22; //Declaraciones equipo 22
            string cp_CPUsn23, cp_MTORsn23, cp_KEYBsn23, cp_MOUSEsn23; //Declaraciones equipo 23
            string cp_CPUsn24, cp_MTORsn24, cp_KEYBsn24, cp_MOUSEsn24; //Declaraciones equipo 24
            string cp_CPUsn25, cp_MTORsn25, cp_KEYBsn25, cp_MOUSEsn25; //Declaraciones equipo 25
            string cp_CPUsn26, cp_MTORsn26, cp_KEYBsn26, cp_MOUSEsn26; //Declaraciones equipo 26
            string cp_CPUsn27, cp_MTORsn27, cp_KEYBsn27, cp_MOUSEsn27; //Declaraciones equipo 27
            string cp_CPUsn28, cp_MTORsn28, cp_KEYBsn28, cp_MOUSEsn28; //Declaraciones equipo 28
            string cp_CPUsn29, cp_MTORsn29, cp_KEYBsn29, cp_MOUSEsn29; //Declaraciones equipo 29
            string cp_CPUsn30, cp_MTORsn30, cp_KEYBsn30, cp_MOUSEsn30; //Declaraciones equipo 30
            string cp_CPUsn31, cp_MTORsn31, cp_KEYBsn31, cp_MOUSEsn31; //Declaraciones equipo 31
            string cp_CPUsn32, cp_MTORsn32, cp_KEYBsn32, cp_MOUSEsn32; //Declaraciones equipo 32
            string cp_CPUsn33, cp_MTORsn33, cp_KEYBsn33, cp_MOUSEsn33; //Declaraciones equipo 33
            string cp_CPUsn34, cp_MTORsn34, cp_KEYBsn34, cp_MOUSEsn34; //Declaraciones equipo 34
            string cp_CPUsn35, cp_MTORsn35, cp_KEYBsn35, cp_MOUSEsn35; //Declaraciones equipo 35
            string cp_CPUsn36, cp_MTORsn36, cp_KEYBsn36, cp_MOUSEsn36; //Declaraciones equipo 36
            string cp_CPUsn37, cp_MTORsn37, cp_KEYBsn37, cp_MOUSEsn37; //Declaraciones equipo 37
            string cp_CPUsn38, cp_MTORsn38, cp_KEYBsn38, cp_MOUSEsn38; //Declaraciones equipo 38
            string cp_CPUsn39, cp_MTORsn39, cp_KEYBsn39, cp_MOUSEsn39; //Declaraciones equipo 39
            string cp_CPUsn40, cp_MTORsn40, cp_KEYBsn40, cp_MOUSEsn40; //Declaraciones equipo 40
            string cp_CPUsn41, cp_MTORsn41, cp_KEYBsn41, cp_MOUSEsn41; //Declaraciones equipo 41
            string cp_CPUsn42, cp_MTORsn42, cp_KEYBsn42, cp_MOUSEsn42; //Declaraciones equipo 42

            int cp_nMAQ1; //Declaración máquina 1
            int cp_nMAQ2; //Declaración máquina 2
            int cp_nMAQ3; //Declaración máquina 3
            int cp_nMAQ4; //Declaración máquina 4
            int cp_nMAQ5; //Declaración máquina 5
            int cp_nMAQ6; //Declaración máquina 6
            int cp_nMAQ7; //Declaración máquina 7
            int cp_nMAQ8; //Declaración máquina 8
            int cp_nMAQ9; //Declaración máquina 9
            int cp_nMAQ10; //Declaración máquina 10
            int cp_nMAQ11; //Declaración máquina 11
            int cp_nMAQ12; //Declaración máquina 12
            int cp_nMAQ13; //Declaración máquina 13
            int cp_nMAQ14; //Declaración máquina 14
            int cp_nMAQ15; //Declaración máquina 15
            int cp_nMAQ16; //Declaración máquina 16
            int cp_nMAQ17; //Declaración máquina 17
            int cp_nMAQ18; //Declaración máquina 18
            int cp_nMAQ19; //Declaración máquina 19
            int cp_nMAQ20; //Declaración máquina 20
            int cp_nMAQ21; //Declaración máquina 21
            int cp_nMAQ22; //Declaración máquina 22
            int cp_nMAQ23; //Declaración máquina 23
            int cp_nMAQ24; //Declaración máquina 24
            int cp_nMAQ25; //Declaración máquina 25
            int cp_nMAQ26; //Declaración máquina 26
            int cp_nMAQ27; //Declaración máquina 27
            int cp_nMAQ28; //Declaración máquina 28
            int cp_nMAQ29; //Declaración máquina 29
            int cp_nMAQ30; //Declaración máquina 30
            int cp_nMAQ31; //Declaración máquina 31
            int cp_nMAQ32; //Declaración máquina 32
            int cp_nMAQ33; //Declaración máquina 33
            int cp_nMAQ34; //Declaración máquina 34
            int cp_nMAQ35; //Declaración máquina 35
            int cp_nMAQ36; //Declaración máquina 36
            int cp_nMAQ37; //Declaración máquina 37
            int cp_nMAQ38; //Declaración máquina 38
            int cp_nMAQ39; //Declaración máquina 39
            int cp_nMAQ40; //Declaración máquina 40
            int cp_nMAQ41; //Declaración máquina 41
            int cp_nMAQ42; //Declaración máquina 42

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú menu= new Menú();
            menu.Show();
        }

        private void Validar_Click(object sender, EventArgs e)
        {

        }
        //VOIDS MOUSE HOVER
        //private void KIT1_MouseHover (object sender, EventArgs e)
        //{
        //  MessageBox.Show("Hello");
        //}
    }
}
