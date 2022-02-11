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
    public partial class Laboratorio_Idiomas : Form
    {
        public Laboratorio_Idiomas()
        {
            InitializeComponent();
        }

        private void LaboratorioIdiomas_Load(object sender, EventArgs e)
        {
            string id_CPUsn1, id_MTORsn1, id_KEYBsn1, id_MOUSEsn1; //Declaraciones equipo 1
            string id_CPUsn2, id_MTORsn2, id_KEYBsn2, id_MOUSEsn2; //Declaraciones equipo 2
            string id_CPUsn3, id_MTORsn3, id_KEYBsn3, id_MOUSEsn3; //Declaraciones equipo 3
            string id_CPUsn4, id_MTORsn4, id_KEYBsn4, id_MOUSEsn4; //Declaraciones equipo 4
            string id_CPUsn5, id_MTORsn5, id_KEYBsn5, id_MOUSEsn5; //Declaraciones equipo 5
            string id_CPUsn6, id_MTORsn6, id_KEYBsn6, id_MOUSEsn6; //Declaraciones equipo 6
            string id_CPUsn7, id_MTORsn7, id_KEYBsn7, id_MOUSEsn7; //Declaraciones equipo 7
            string id_CPUsn8, id_MTORsn8, id_KEYBsn8, id_MOUSEsn8; //Declaraciones equipo 8
            string id_CPUsn9, id_MTORsn9, id_KEYBsn9, id_MOUSEsn9; //Declaraciones equipo 9
            string id_CPUsn10, id_MTORsn10, id_KEYBsn10, id_MOUSEsn10; //Declaraciones equipo 10
            string id_CPUsn11, id_MTORsn11, id_KEYBsn11, id_MOUSEsn11; //Declaraciones equipo 11
            string id_CPUsn12, id_MTORsn12, id_KEYBsn12, id_MOUSEsn12; //Declaraciones equipo 12
            string id_CPUsn13, id_MTORsn13, id_KEYBsn13, id_MOUSEsn13; //Declaraciones equipo 13
            string id_CPUsn14, id_MTORsn14, id_KEYBsn14, id_MOUSEsn14; //Declaraciones equipo 14
            string id_CPUsn15, id_MTORsn15, id_KEYBsn15, id_MOUSEsn15; //Declaraciones equipo 15
            string id_CPUsn16, id_MTORsn16, id_KEYBsn16, id_MOUSEsn16; //Declaraciones equipo 16
            string id_CPUsn17, id_MTORsn17, id_KEYBsn17, id_MOUSEsn17; //Declaraciones equipo 17
            string id_CPUsn18, id_MTORsn18, id_KEYBsn18, id_MOUSEsn18; //Declaraciones equipo 18
            string id_CPUsn19, id_MTORsn19, id_KEYBsn19, id_MOUSEsn19; //Declaraciones equipo 19
            string id_CPUsn20, id_MTORsn20, id_KEYBsn20, id_MOUSEsn20; //Declaraciones equipo 20
            string id_CPUsn21, id_MTORsn21, id_KEYBsn21, id_MOUSEsn21; //Declaraciones equipo 21
            string id_CPUsn22, id_MTORsn22, id_KEYBsn22, id_MOUSEsn22; //Declaraciones equipo 22
            string id_CPUsn23, id_MTORsn23, id_KEYBsn23, id_MOUSEsn23; //Declaraciones equipo 23
            string id_CPUsn24, id_MTORsn24, id_KEYBsn24, id_MOUSEsn24; //Declaraciones equipo 24
            string id_CPUsn25, id_MTORsn25, id_KEYBsn25, id_MOUSEsn25; //Declaraciones equipo 25
            string id_CPUsn26, id_MTORsn26, id_KEYBsn26, id_MOUSEsn26; //Declaraciones equipo 26
            string id_CPUsn27, id_MTORsn27, id_KEYBsn27, id_MOUSEsn27; //Declaraciones equipo 27
            string id_CPUsn28, id_MTORsn28, id_KEYBsn28, id_MOUSEsn28; //Declaraciones equipo 28
            string id_CPUsn29, id_MTORsn29, id_KEYBsn29, id_MOUSEsn29; //Declaraciones equipo 29
            string id_CPUsn30, id_MTORsn30, id_KEYBsn30, id_MOUSEsn30; //Declaraciones equipo 30
            string id_CPUsn31, id_MTORsn31, id_KEYBsn31, id_MOUSEsn31; //Declaraciones equipo 31
            string id_CPUsn32, id_MTORsn32, id_KEYBsn32, id_MOUSEsn32; //Declaraciones equipo 32
            string id_CPUsn33, id_MTORsn33, id_KEYBsn33, id_MOUSEsn33; //Declaraciones equipo 33
            string id_CPUsn34, id_MTORsn34, id_KEYBsn34, id_MOUSEsn34; //Declaraciones equipo 34
            string id_CPUsn35, id_MTORsn35, id_KEYBsn35, id_MOUSEsn35; //Declaraciones equipo 35
            string id_CPUsn36, id_MTORsn36, id_KEYBsn36, id_MOUSEsn36; //Declaraciones equipo 36
            string id_CPUsn37, id_MTORsn37, id_KEYBsn37, id_MOUSEsn37; //Declaraciones equipo 37
            string id_CPUsn38, id_MTORsn38, id_KEYBsn38, id_MOUSEsn38; //Declaraciones equipo 38
            string id_CPUsn39, id_MTORsn39, id_KEYBsn39, id_MOUSEsn39; //Declaraciones equipo 39
            string id_CPUsn40, id_MTORsn40, id_KEYBsn40, id_MOUSEsn40; //Declaraciones equipo 40
            string id_CPUsn41, id_MTORsn41, id_KEYBsn41, id_MOUSEsn41; //Declaraciones equipo 41
            string id_CPUsn42, id_MTORsn42, id_KEYBsn42, id_MOUSEsn42; //Declaraciones equipo 42
            string id_CPUsn43, id_MTORsn43, id_KEYBsn43, id_MOUSEsn43; //Declaraciones equipo 43
            string id_CPUsn44, id_MTORsn44, id_KEYBsn44, id_MOUSEsn44; //Declaraciones equipo 44
            string id_CPUsn45, id_MTORsn45, id_KEYBsn45, id_MOUSEsn45; //Declaraciones equipo 45
            string id_CPUsn46, id_MTORsn46, id_KEYBsn46, id_MOUSEsn46; //Declaraciones equipo 46
            string id_CPUsn47, id_MTORsn47, id_KEYBsn47, id_MOUSEsn47; //Declaraciones equipo 47
            string id_CPUsn48, id_MTORsn48, id_KEYBsn48, id_MOUSEsn48; //Declaraciones equipo 48
            string id_CPUsn49, id_MTORsn49, id_KEYBsn49, id_MOUSEsn49; //Declaraciones equipo 49
            string id_CPUsn50, id_MTORsn50, id_KEYBsn50, id_MOUSEsn50; //Declaraciones equipo 50

            int id_nMAQ1; //Declaración máquina 1
            int id_nMAQ2; //Declaración máquina 2
            int id_nMAQ3; //Declaración máquina 3
            int id_nMAQ4; //Declaración máquina 4
            int id_nMAQ5; //Declaración máquina 5
            int id_nMAQ6; //Declaración máquina 6
            int id_nMAQ7; //Declaración máquina 7
            int id_nMAQ8; //Declaración máquina 8
            int id_nMAQ9; //Declaración máquina 9
            int id_nMAQ10; //Declaración máquina 10
            int id_nMAQ11; //Declaración máquina 11
            int id_nMAQ12; //Declaración máquina 12
            int id_nMAQ13; //Declaración máquina 13
            int id_nMAQ14; //Declaración máquina 14
            int id_nMAQ15; //Declaración máquina 15
            int id_nMAQ16; //Declaración máquina 16
            int id_nMAQ17; //Declaración máquina 17
            int id_nMAQ18; //Declaración máquina 18
            int id_nMAQ19; //Declaración máquina 19
            int id_nMAQ20; //Declaración máquina 20
            int id_nMAQ21; //Declaración máquina 21
            int id_nMAQ22; //Declaración máquina 22
            int id_nMAQ23; //Declaración máquina 23
            int id_nMAQ24; //Declaración máquina 24
            int id_nMAQ25; //Declaración máquina 25
            int id_nMAQ26; //Declaración máquina 26
            int id_nMAQ27; //Declaración máquina 27
            int id_nMAQ28; //Declaración máquina 28
            int id_nMAQ29; //Declaración máquina 29
            int id_nMAQ30; //Declaración máquina 30
            int id_nMAQ31; //Declaración máquina 31
            int id_nMAQ32; //Declaración máquina 32
            int id_nMAQ33; //Declaración máquina 33
            int id_nMAQ34; //Declaración máquina 34
            int id_nMAQ35; //Declaración máquina 35
            int id_nMAQ36; //Declaración máquina 36
            int id_nMAQ37; //Declaración máquina 37
            int id_nMAQ38; //Declaración máquina 38
            int id_nMAQ39; //Declaración máquina 39
            int id_nMAQ40; //Declaración máquina 40
            int id_nMAQ41; //Declaración máquina 41
            int id_nMAQ42; //Declaración máquina 42
            int id_nMAQ43; //Declaración máquina 43
            int id_nMAQ44; //Declaración máquina 44
            int id_nMAQ45; //Declaración máquina 45
            int id_nMAQ46; //Declaración máquina 46
            int id_nMAQ47; //Declaración máquina 47
            int id_nMAQ48; //Declaración máquina 48
            int id_nMAQ49; //Declaración máquina 49
            int id_nMAQ50; //Declaración máquina 50

        }
    }
}
