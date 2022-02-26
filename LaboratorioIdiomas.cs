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

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú menu = new Menú();
            menu.Show();
        }

        private void KIT1_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ1; nsCPUtxbx.Text = global.id_CPUsn1; nsKEYBtxbx.Text = global.id_KEYBsn1; nsMOUSEtxbx.Text = global.id_MOUSEsn1; nsMTORtxbx.Text = global.id_MTORsn1; nsSillatxbx.Text = global.id_SILLAsn1; }
        private void KIT2_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ2; nsCPUtxbx.Text = global.id_CPUsn2; nsKEYBtxbx.Text = global.id_KEYBsn2; nsMOUSEtxbx.Text = global.id_MOUSEsn2; nsMTORtxbx.Text = global.id_MTORsn2; nsSillatxbx.Text = global.id_SILLAsn2; }
        private void KIT3_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ3; nsCPUtxbx.Text = global.id_CPUsn3; nsKEYBtxbx.Text = global.id_KEYBsn3; nsMOUSEtxbx.Text = global.id_MOUSEsn3; nsMTORtxbx.Text = global.id_MTORsn3; nsSillatxbx.Text = global.id_SILLAsn3; }
        private void KIT4_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ4; nsCPUtxbx.Text = global.id_CPUsn4; nsKEYBtxbx.Text = global.id_KEYBsn4; nsMOUSEtxbx.Text = global.id_MOUSEsn4; nsMTORtxbx.Text = global.id_MTORsn4; nsSillatxbx.Text = global.id_SILLAsn4; }
        private void KIT5_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ5; nsCPUtxbx.Text = global.id_CPUsn5; nsKEYBtxbx.Text = global.id_KEYBsn5; nsMOUSEtxbx.Text = global.id_MOUSEsn5; nsMTORtxbx.Text = global.id_MTORsn5; nsSillatxbx.Text = global.id_SILLAsn5; }
        private void KIT6_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ6; nsCPUtxbx.Text = global.id_CPUsn6; nsKEYBtxbx.Text = global.id_KEYBsn6; nsMOUSEtxbx.Text = global.id_MOUSEsn6; nsMTORtxbx.Text = global.id_MTORsn6; nsSillatxbx.Text = global.id_SILLAsn6; }
        private void KIT7_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ7; nsCPUtxbx.Text = global.id_CPUsn7; nsKEYBtxbx.Text = global.id_KEYBsn7; nsMOUSEtxbx.Text = global.id_MOUSEsn7; nsMTORtxbx.Text = global.id_MTORsn7; nsSillatxbx.Text = global.id_SILLAsn7; }
        private void KIT8_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ8; nsCPUtxbx.Text = global.id_CPUsn8; nsKEYBtxbx.Text = global.id_KEYBsn8; nsMOUSEtxbx.Text = global.id_MOUSEsn8; nsMTORtxbx.Text = global.id_MTORsn8; nsSillatxbx.Text = global.id_SILLAsn8; }
        private void KIT9_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ9; nsCPUtxbx.Text = global.id_CPUsn9; nsKEYBtxbx.Text = global.id_KEYBsn9; nsMOUSEtxbx.Text = global.id_MOUSEsn9; nsMTORtxbx.Text = global.id_MTORsn9; nsSillatxbx.Text = global.id_SILLAsn9; }
        private void KIT10_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ10; nsCPUtxbx.Text = global.id_CPUsn10; nsKEYBtxbx.Text = global.id_KEYBsn10; nsMOUSEtxbx.Text = global.id_MOUSEsn10; nsMTORtxbx.Text = global.id_MTORsn10; nsSillatxbx.Text = global.id_SILLAsn10; }
        private void KIT11_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ11; nsCPUtxbx.Text = global.id_CPUsn11; nsKEYBtxbx.Text = global.id_KEYBsn11; nsMOUSEtxbx.Text = global.id_MOUSEsn11; nsMTORtxbx.Text = global.id_MTORsn11; nsSillatxbx.Text = global.id_SILLAsn11; }
        private void KIT12_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ12; nsCPUtxbx.Text = global.id_CPUsn12; nsKEYBtxbx.Text = global.id_KEYBsn12; nsMOUSEtxbx.Text = global.id_MOUSEsn12; nsMTORtxbx.Text = global.id_MTORsn12; nsSillatxbx.Text = global.id_SILLAsn12; }
        private void KIT13_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ13; nsCPUtxbx.Text = global.id_CPUsn13; nsKEYBtxbx.Text = global.id_KEYBsn13; nsMOUSEtxbx.Text = global.id_MOUSEsn13; nsMTORtxbx.Text = global.id_MTORsn13; nsSillatxbx.Text = global.id_SILLAsn13; }
        private void KIT14_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ14; nsCPUtxbx.Text = global.id_CPUsn14; nsKEYBtxbx.Text = global.id_KEYBsn14; nsMOUSEtxbx.Text = global.id_MOUSEsn14; nsMTORtxbx.Text = global.id_MTORsn14; nsSillatxbx.Text = global.id_SILLAsn14; }
        private void KIT15_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ15; nsCPUtxbx.Text = global.id_CPUsn15; nsKEYBtxbx.Text = global.id_KEYBsn15; nsMOUSEtxbx.Text = global.id_MOUSEsn15; nsMTORtxbx.Text = global.id_MTORsn15; nsSillatxbx.Text = global.id_SILLAsn15; }
        private void KIT16_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ16; nsCPUtxbx.Text = global.id_CPUsn16; nsKEYBtxbx.Text = global.id_KEYBsn16; nsMOUSEtxbx.Text = global.id_MOUSEsn16; nsMTORtxbx.Text = global.id_MTORsn16; nsSillatxbx.Text = global.id_SILLAsn16; }
        private void KIT17_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ17; nsCPUtxbx.Text = global.id_CPUsn17; nsKEYBtxbx.Text = global.id_KEYBsn17; nsMOUSEtxbx.Text = global.id_MOUSEsn17; nsMTORtxbx.Text = global.id_MTORsn17; nsSillatxbx.Text = global.id_SILLAsn17; }
        private void KIT18_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ18; nsCPUtxbx.Text = global.id_CPUsn18; nsKEYBtxbx.Text = global.id_KEYBsn18; nsMOUSEtxbx.Text = global.id_MOUSEsn18; nsMTORtxbx.Text = global.id_MTORsn18; nsSillatxbx.Text = global.id_SILLAsn18; }
        private void KIT19_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ19; nsCPUtxbx.Text = global.id_CPUsn19; nsKEYBtxbx.Text = global.id_KEYBsn19; nsMOUSEtxbx.Text = global.id_MOUSEsn19; nsMTORtxbx.Text = global.id_MTORsn19; nsSillatxbx.Text = global.id_SILLAsn19; }
        private void KIT20_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ20; nsCPUtxbx.Text = global.id_CPUsn20; nsKEYBtxbx.Text = global.id_KEYBsn20; nsMOUSEtxbx.Text = global.id_MOUSEsn20; nsMTORtxbx.Text = global.id_MTORsn20; nsSillatxbx.Text = global.id_SILLAsn20; }
        private void KIT21_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ21; nsCPUtxbx.Text = global.id_CPUsn21; nsKEYBtxbx.Text = global.id_KEYBsn21; nsMOUSEtxbx.Text = global.id_MOUSEsn21; nsMTORtxbx.Text = global.id_MTORsn21; nsSillatxbx.Text = global.id_SILLAsn21; }
        private void KIT22_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ22; nsCPUtxbx.Text = global.id_CPUsn22; nsKEYBtxbx.Text = global.id_KEYBsn22; nsMOUSEtxbx.Text = global.id_MOUSEsn22; nsMTORtxbx.Text = global.id_MTORsn22; nsSillatxbx.Text = global.id_SILLAsn22; }
        private void KIT23_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ23; nsCPUtxbx.Text = global.id_CPUsn23; nsKEYBtxbx.Text = global.id_KEYBsn23; nsMOUSEtxbx.Text = global.id_MOUSEsn23; nsMTORtxbx.Text = global.id_MTORsn23; nsSillatxbx.Text = global.id_SILLAsn23; }
        private void KIT24_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ24; nsCPUtxbx.Text = global.id_CPUsn24; nsKEYBtxbx.Text = global.id_KEYBsn24; nsMOUSEtxbx.Text = global.id_MOUSEsn24; nsMTORtxbx.Text = global.id_MTORsn24; nsSillatxbx.Text = global.id_SILLAsn24; }
        private void KIT25_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ25; nsCPUtxbx.Text = global.id_CPUsn25; nsKEYBtxbx.Text = global.id_KEYBsn25; nsMOUSEtxbx.Text = global.id_MOUSEsn25; nsMTORtxbx.Text = global.id_MTORsn25; nsSillatxbx.Text = global.id_SILLAsn25; }
        private void KIT26_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ26; nsCPUtxbx.Text = global.id_CPUsn26; nsKEYBtxbx.Text = global.id_KEYBsn26; nsMOUSEtxbx.Text = global.id_MOUSEsn26; nsMTORtxbx.Text = global.id_MTORsn26; nsSillatxbx.Text = global.id_SILLAsn26; }
        private void KIT27_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ27; nsCPUtxbx.Text = global.id_CPUsn27; nsKEYBtxbx.Text = global.id_KEYBsn27; nsMOUSEtxbx.Text = global.id_MOUSEsn27; nsMTORtxbx.Text = global.id_MTORsn27; nsSillatxbx.Text = global.id_SILLAsn27; }
        private void KIT28_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ28; nsCPUtxbx.Text = global.id_CPUsn28; nsKEYBtxbx.Text = global.id_KEYBsn28; nsMOUSEtxbx.Text = global.id_MOUSEsn28; nsMTORtxbx.Text = global.id_MTORsn28; nsSillatxbx.Text = global.id_SILLAsn28; }
        private void KIT29_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ29; nsCPUtxbx.Text = global.id_CPUsn29; nsKEYBtxbx.Text = global.id_KEYBsn29; nsMOUSEtxbx.Text = global.id_MOUSEsn29; nsMTORtxbx.Text = global.id_MTORsn29; nsSillatxbx.Text = global.id_SILLAsn29; }
        private void KIT30_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ30; nsCPUtxbx.Text = global.id_CPUsn30; nsKEYBtxbx.Text = global.id_KEYBsn30; nsMOUSEtxbx.Text = global.id_MOUSEsn30; nsMTORtxbx.Text = global.id_MTORsn30; nsSillatxbx.Text = global.id_SILLAsn30; }
        private void KIT31_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ31; nsCPUtxbx.Text = global.id_CPUsn31; nsKEYBtxbx.Text = global.id_KEYBsn31; nsMOUSEtxbx.Text = global.id_MOUSEsn31; nsMTORtxbx.Text = global.id_MTORsn31; nsSillatxbx.Text = global.id_SILLAsn31; }
        private void KIT32_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ32; nsCPUtxbx.Text = global.id_CPUsn32; nsKEYBtxbx.Text = global.id_KEYBsn32; nsMOUSEtxbx.Text = global.id_MOUSEsn32; nsMTORtxbx.Text = global.id_MTORsn32; nsSillatxbx.Text = global.id_SILLAsn32; }
        private void KIT33_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ33; nsCPUtxbx.Text = global.id_CPUsn33; nsKEYBtxbx.Text = global.id_KEYBsn33; nsMOUSEtxbx.Text = global.id_MOUSEsn33; nsMTORtxbx.Text = global.id_MTORsn33; nsSillatxbx.Text = global.id_SILLAsn33; }
        private void KIT34_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ34; nsCPUtxbx.Text = global.id_CPUsn34; nsKEYBtxbx.Text = global.id_KEYBsn34; nsMOUSEtxbx.Text = global.id_MOUSEsn34; nsMTORtxbx.Text = global.id_MTORsn34; nsSillatxbx.Text = global.id_SILLAsn34; }
        private void KIT35_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ35; nsCPUtxbx.Text = global.id_CPUsn35; nsKEYBtxbx.Text = global.id_KEYBsn35; nsMOUSEtxbx.Text = global.id_MOUSEsn35; nsMTORtxbx.Text = global.id_MTORsn35; nsSillatxbx.Text = global.id_SILLAsn35; }
        private void KIT36_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ36; nsCPUtxbx.Text = global.id_CPUsn36; nsKEYBtxbx.Text = global.id_KEYBsn36; nsMOUSEtxbx.Text = global.id_MOUSEsn36; nsMTORtxbx.Text = global.id_MTORsn36; nsSillatxbx.Text = global.id_SILLAsn36; }
        private void KIT37_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ37; nsCPUtxbx.Text = global.id_CPUsn37; nsKEYBtxbx.Text = global.id_KEYBsn37; nsMOUSEtxbx.Text = global.id_MOUSEsn37; nsMTORtxbx.Text = global.id_MTORsn37; nsSillatxbx.Text = global.id_SILLAsn37; }
        private void KIT38_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ38; nsCPUtxbx.Text = global.id_CPUsn38; nsKEYBtxbx.Text = global.id_KEYBsn38; nsMOUSEtxbx.Text = global.id_MOUSEsn38; nsMTORtxbx.Text = global.id_MTORsn38; nsSillatxbx.Text = global.id_SILLAsn38; }
        private void KIT39_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ39; nsCPUtxbx.Text = global.id_CPUsn39; nsKEYBtxbx.Text = global.id_KEYBsn39; nsMOUSEtxbx.Text = global.id_MOUSEsn39; nsMTORtxbx.Text = global.id_MTORsn39; nsSillatxbx.Text = global.id_SILLAsn39; }
        private void KIT40_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ40; nsCPUtxbx.Text = global.id_CPUsn40; nsKEYBtxbx.Text = global.id_KEYBsn40; nsMOUSEtxbx.Text = global.id_MOUSEsn40; nsMTORtxbx.Text = global.id_MTORsn40; nsSillatxbx.Text = global.id_SILLAsn40; }
        private void KIT41_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ41; nsCPUtxbx.Text = global.id_CPUsn41; nsKEYBtxbx.Text = global.id_KEYBsn41; nsMOUSEtxbx.Text = global.id_MOUSEsn41; nsMTORtxbx.Text = global.id_MTORsn41; nsSillatxbx.Text = global.id_SILLAsn41; }
        private void KIT42_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ42; nsCPUtxbx.Text = global.id_CPUsn42; nsKEYBtxbx.Text = global.id_KEYBsn42; nsMOUSEtxbx.Text = global.id_MOUSEsn42; nsMTORtxbx.Text = global.id_MTORsn42; nsSillatxbx.Text = global.id_SILLAsn42; }
        private void KIT43_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ43; nsCPUtxbx.Text = global.id_CPUsn43; nsKEYBtxbx.Text = global.id_KEYBsn43; nsMOUSEtxbx.Text = global.id_MOUSEsn43; nsMTORtxbx.Text = global.id_MTORsn43; nsSillatxbx.Text = global.id_SILLAsn43; }
        private void KIT44_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ44; nsCPUtxbx.Text = global.id_CPUsn44; nsKEYBtxbx.Text = global.id_KEYBsn44; nsMOUSEtxbx.Text = global.id_MOUSEsn44; nsMTORtxbx.Text = global.id_MTORsn44; nsSillatxbx.Text = global.id_SILLAsn44; }
        private void KIT45_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ45; nsCPUtxbx.Text = global.id_CPUsn45; nsKEYBtxbx.Text = global.id_KEYBsn45; nsMOUSEtxbx.Text = global.id_MOUSEsn45; nsMTORtxbx.Text = global.id_MTORsn45; nsSillatxbx.Text = global.id_SILLAsn45; }
        private void KIT46_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ46; nsCPUtxbx.Text = global.id_CPUsn46; nsKEYBtxbx.Text = global.id_KEYBsn46; nsMOUSEtxbx.Text = global.id_MOUSEsn46; nsMTORtxbx.Text = global.id_MTORsn46; nsSillatxbx.Text = global.id_SILLAsn46; }
        private void KIT47_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ47; nsCPUtxbx.Text = global.id_CPUsn47; nsKEYBtxbx.Text = global.id_KEYBsn47; nsMOUSEtxbx.Text = global.id_MOUSEsn47; nsMTORtxbx.Text = global.id_MTORsn47; nsSillatxbx.Text = global.id_SILLAsn47; }
        private void KIT48_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ48; nsCPUtxbx.Text = global.id_CPUsn48; nsKEYBtxbx.Text = global.id_KEYBsn48; nsMOUSEtxbx.Text = global.id_MOUSEsn48; nsMTORtxbx.Text = global.id_MTORsn48; nsSillatxbx.Text = global.id_SILLAsn48; }
        private void KIT49_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ49; nsCPUtxbx.Text = global.id_CPUsn49; nsKEYBtxbx.Text = global.id_KEYBsn49; nsMOUSEtxbx.Text = global.id_MOUSEsn49; nsMTORtxbx.Text = global.id_MTORsn49; nsSillatxbx.Text = global.id_SILLAsn49; }
        private void KIT50_Click(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ50; nsCPUtxbx.Text = global.id_CPUsn50; nsKEYBtxbx.Text = global.id_KEYBsn50; nsMOUSEtxbx.Text = global.id_MOUSEsn50; nsMTORtxbx.Text = global.id_MTORsn50; nsSillatxbx.Text = global.id_SILLAsn50; }



        public static class global
        {
            public static string id_CPUsn1, id_MTORsn1, id_KEYBsn1, id_MOUSEsn1, id_SILLAsn1; //Declaraciones equipo 1
            public static string id_CPUsn2, id_MTORsn2, id_KEYBsn2, id_MOUSEsn2, id_SILLAsn2; //Declaraciones equipo 2
            public static string id_CPUsn3, id_MTORsn3, id_KEYBsn3, id_MOUSEsn3, id_SILLAsn3; //Declaraciones equipo 3
            public static string id_CPUsn4, id_MTORsn4, id_KEYBsn4, id_MOUSEsn4, id_SILLAsn4; //Declaraciones equipo 4
            public static string id_CPUsn5, id_MTORsn5, id_KEYBsn5, id_MOUSEsn5, id_SILLAsn5; //Declaraciones equipo 5
            public static string id_CPUsn6, id_MTORsn6, id_KEYBsn6, id_MOUSEsn6, id_SILLAsn6; //Declaraciones equipo 6
            public static string id_CPUsn7, id_MTORsn7, id_KEYBsn7, id_MOUSEsn7, id_SILLAsn7; //Declaraciones equipo 7
            public static string id_CPUsn8, id_MTORsn8, id_KEYBsn8, id_MOUSEsn8, id_SILLAsn8; //Declaraciones equipo 8
            public static string id_CPUsn9, id_MTORsn9, id_KEYBsn9, id_MOUSEsn9, id_SILLAsn9; //Declaraciones equipo 9
            public static string id_CPUsn10, id_MTORsn10, id_KEYBsn10, id_MOUSEsn10, id_SILLAsn10; //Declaraciones equipo 10
            public static string id_CPUsn11, id_MTORsn11, id_KEYBsn11, id_MOUSEsn11, id_SILLAsn11; //Declaraciones equipo 11
            public static string id_CPUsn12, id_MTORsn12, id_KEYBsn12, id_MOUSEsn12, id_SILLAsn12; //Declaraciones equipo 12
            public static string id_CPUsn13, id_MTORsn13, id_KEYBsn13, id_MOUSEsn13, id_SILLAsn13; //Declaraciones equipo 13
            public static string id_CPUsn14, id_MTORsn14, id_KEYBsn14, id_MOUSEsn14, id_SILLAsn14; //Declaraciones equipo 14
            public static string id_CPUsn15, id_MTORsn15, id_KEYBsn15, id_MOUSEsn15, id_SILLAsn15; //Declaraciones equipo 15
            public static string id_CPUsn16, id_MTORsn16, id_KEYBsn16, id_MOUSEsn16, id_SILLAsn16; //Declaraciones equipo 16
            public static string id_CPUsn17, id_MTORsn17, id_KEYBsn17, id_MOUSEsn17, id_SILLAsn17; //Declaraciones equipo 17
            public static string id_CPUsn18, id_MTORsn18, id_KEYBsn18, id_MOUSEsn18, id_SILLAsn18; //Declaraciones equipo 18
            public static string id_CPUsn19, id_MTORsn19, id_KEYBsn19, id_MOUSEsn19, id_SILLAsn19; //Declaraciones equipo 19
            public static string id_CPUsn20, id_MTORsn20, id_KEYBsn20, id_MOUSEsn20, id_SILLAsn20; //Declaraciones equipo 20
            public static string id_CPUsn21, id_MTORsn21, id_KEYBsn21, id_MOUSEsn21, id_SILLAsn21; //Declaraciones equipo 21
            public static string id_CPUsn22, id_MTORsn22, id_KEYBsn22, id_MOUSEsn22, id_SILLAsn22; //Declaraciones equipo 22
            public static string id_CPUsn23, id_MTORsn23, id_KEYBsn23, id_MOUSEsn23, id_SILLAsn23; //Declaraciones equipo 23
            public static string id_CPUsn24, id_MTORsn24, id_KEYBsn24, id_MOUSEsn24, id_SILLAsn24; //Declaraciones equipo 24
            public static string id_CPUsn25, id_MTORsn25, id_KEYBsn25, id_MOUSEsn25, id_SILLAsn25; //Declaraciones equipo 25
            public static string id_CPUsn26, id_MTORsn26, id_KEYBsn26, id_MOUSEsn26, id_SILLAsn26; //Declaraciones equipo 26
            public static string id_CPUsn27, id_MTORsn27, id_KEYBsn27, id_MOUSEsn27, id_SILLAsn27; //Declaraciones equipo 27
            public static string id_CPUsn28, id_MTORsn28, id_KEYBsn28, id_MOUSEsn28, id_SILLAsn28; //Declaraciones equipo 28
            public static string id_CPUsn29, id_MTORsn29, id_KEYBsn29, id_MOUSEsn29, id_SILLAsn29; //Declaraciones equipo 29
            public static string id_CPUsn30, id_MTORsn30, id_KEYBsn30, id_MOUSEsn30, id_SILLAsn30; //Declaraciones equipo 30
            public static string id_CPUsn31, id_MTORsn31, id_KEYBsn31, id_MOUSEsn31, id_SILLAsn31; //Declaraciones equipo 31
            public static string id_CPUsn32, id_MTORsn32, id_KEYBsn32, id_MOUSEsn32, id_SILLAsn32; //Declaraciones equipo 32
            public static string id_CPUsn33, id_MTORsn33, id_KEYBsn33, id_MOUSEsn33, id_SILLAsn33; //Declaraciones equipo 33
            public static string id_CPUsn34, id_MTORsn34, id_KEYBsn34, id_MOUSEsn34, id_SILLAsn34; //Declaraciones equipo 34
            public static string id_CPUsn35, id_MTORsn35, id_KEYBsn35, id_MOUSEsn35, id_SILLAsn35; //Declaraciones equipo 35
            public static string id_CPUsn36, id_MTORsn36, id_KEYBsn36, id_MOUSEsn36, id_SILLAsn36; //Declaraciones equipo 36
            public static string id_CPUsn37, id_MTORsn37, id_KEYBsn37, id_MOUSEsn37, id_SILLAsn37; //Declaraciones equipo 37
            public static string id_CPUsn38, id_MTORsn38, id_KEYBsn38, id_MOUSEsn38, id_SILLAsn38; //Declaraciones equipo 38
            public static string id_CPUsn39, id_MTORsn39, id_KEYBsn39, id_MOUSEsn39, id_SILLAsn39; //Declaraciones equipo 39
            public static string id_CPUsn40, id_MTORsn40, id_KEYBsn40, id_MOUSEsn40, id_SILLAsn40; //Declaraciones equipo 40
            public static string id_CPUsn41, id_MTORsn41, id_KEYBsn41, id_MOUSEsn41, id_SILLAsn41; //Declaraciones equipo 41
            public static string id_CPUsn42, id_MTORsn42, id_KEYBsn42, id_MOUSEsn42, id_SILLAsn42; //Declaraciones equipo 42
            public static string id_CPUsn43, id_MTORsn43, id_KEYBsn43, id_MOUSEsn43, id_SILLAsn43; //Declaraciones equipo 43
            public static string id_CPUsn44, id_MTORsn44, id_KEYBsn44, id_MOUSEsn44, id_SILLAsn44; //Declaraciones equipo 44
            public static string id_CPUsn45, id_MTORsn45, id_KEYBsn45, id_MOUSEsn45, id_SILLAsn45; //Declaraciones equipo 45
            public static string id_CPUsn46, id_MTORsn46, id_KEYBsn46, id_MOUSEsn46, id_SILLAsn46; //Declaraciones equipo 46
            public static string id_CPUsn47, id_MTORsn47, id_KEYBsn47, id_MOUSEsn47, id_SILLAsn47; //Declaraciones equipo 47
            public static string id_CPUsn48, id_MTORsn48, id_KEYBsn48, id_MOUSEsn48, id_SILLAsn48; //Declaraciones equipo 48
            public static string id_CPUsn49, id_MTORsn49, id_KEYBsn49, id_MOUSEsn49, id_SILLAsn49; //Declaraciones equipo 49
            public static string id_CPUsn50, id_MTORsn50, id_KEYBsn50, id_MOUSEsn50, id_SILLAsn50; //Declaraciones equipo 50
                                                                                                   //Declaraciones equipo 50

            public static string id_nMAQ1; //Declaración máquina 1
            public static string id_nMAQ2; //Declaración máquina 2
            public static string id_nMAQ3; //Declaración máquina 3
            public static string id_nMAQ4; //Declaración máquina 4
            public static string id_nMAQ5; //Declaración máquina 5
            public static string id_nMAQ6; //Declaración máquina 6
            public static string id_nMAQ7; //Declaración máquina 7
            public static string id_nMAQ8; //Declaración máquina 8
            public static string id_nMAQ9; //Declaración máquina 9
            public static string id_nMAQ10; //Declaración máquina 10
            public static string id_nMAQ11; //Declaración máquina 11
            public static string id_nMAQ12; //Declaración máquina 12
            public static string id_nMAQ13; //Declaración máquina 13
            public static string id_nMAQ14; //Declaración máquina 14
            public static string id_nMAQ15; //Declaración máquina 15
            public static string id_nMAQ16; //Declaración máquina 16
            public static string id_nMAQ17; //Declaración máquina 17
            public static string id_nMAQ18; //Declaración máquina 18
            public static string id_nMAQ19; //Declaración máquina 19
            public static string id_nMAQ20; //Declaración máquina 20
            public static string id_nMAQ21; //Declaración máquina 21
            public static string id_nMAQ22; //Declaración máquina 22
            public static string id_nMAQ23; //Declaración máquina 23
            public static string id_nMAQ24; //Declaración máquina 24
            public static string id_nMAQ25; //Declaración máquina 25
            public static string id_nMAQ26; //Declaración máquina 26
            public static string id_nMAQ27; //Declaración máquina 27
            public static string id_nMAQ28; //Declaración máquina 28
            public static string id_nMAQ29; //Declaración máquina 29
            public static string id_nMAQ30; //Declaración máquina 30
            public static string id_nMAQ31; //Declaración máquina 31
            public static string id_nMAQ32; //Declaración máquina 32
            public static string id_nMAQ33; //Declaración máquina 33
            public static string id_nMAQ34; //Declaración máquina 34
            public static string id_nMAQ35; //Declaración máquina 35
            public static string id_nMAQ36; //Declaración máquina 36
            public static string id_nMAQ37; //Declaración máquina 37
            public static string id_nMAQ38; //Declaración máquina 38
            public static string id_nMAQ39; //Declaración máquina 39
            public static string id_nMAQ40; //Declaración máquina 40
            public static string id_nMAQ41; //Declaración máquina 41
            public static string id_nMAQ42; //Declaración máquina 42
            public static string id_nMAQ43; //Declaración máquina 43
            public static string id_nMAQ44; //Declaración máquina 44
            public static string id_nMAQ45; //Declaración máquina 45
            public static string id_nMAQ46; //Declaración máquina 46
            public static string id_nMAQ47; //Declaración máquina 47
            public static string id_nMAQ48; //Declaración máquina 48
            public static string id_nMAQ49; //Declaración máquina 49
            public static string id_nMAQ50; //Declaración máquina 50
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void KIT1_MouseHover(object sender, EventArgs e)
        //{
          //  nmaqtxbx.Text = global.id_nMAQ1;
            //nsCPUtxbx.Text = global.id_CPUsn1;
           // nsKEYBtxbx.Text = global.id_KEYBsn1;
         //   nsMOUSEtxbx.Text = global.id_MOUSEsn1;
           // nsMTORtxbx.Text = global.id_MTORsn1;
            //nsSillatxbx.Text=global.id_SILLAsn1;
        //}
        private void KIT1_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ1; nsCPUtxbx.Text = global.id_CPUsn1; nsKEYBtxbx.Text = global.id_KEYBsn1; nsMOUSEtxbx.Text = global.id_MOUSEsn1; nsMTORtxbx.Text = global.id_MTORsn1; nsSillatxbx.Text = global.id_SILLAsn1; }
        private void KIT2_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ2; nsCPUtxbx.Text = global.id_CPUsn2; nsKEYBtxbx.Text = global.id_KEYBsn2; nsMOUSEtxbx.Text = global.id_MOUSEsn2; nsMTORtxbx.Text = global.id_MTORsn2; nsSillatxbx.Text = global.id_SILLAsn2; }
        private void KIT3_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ3; nsCPUtxbx.Text = global.id_CPUsn3; nsKEYBtxbx.Text = global.id_KEYBsn3; nsMOUSEtxbx.Text = global.id_MOUSEsn3; nsMTORtxbx.Text = global.id_MTORsn3; nsSillatxbx.Text = global.id_SILLAsn3; }
        private void KIT4_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ4; nsCPUtxbx.Text = global.id_CPUsn4; nsKEYBtxbx.Text = global.id_KEYBsn4; nsMOUSEtxbx.Text = global.id_MOUSEsn4; nsMTORtxbx.Text = global.id_MTORsn4; nsSillatxbx.Text = global.id_SILLAsn4; }
        private void KIT5_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ5; nsCPUtxbx.Text = global.id_CPUsn5; nsKEYBtxbx.Text = global.id_KEYBsn5; nsMOUSEtxbx.Text = global.id_MOUSEsn5; nsMTORtxbx.Text = global.id_MTORsn5; nsSillatxbx.Text = global.id_SILLAsn5; }
        private void KIT6_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ6; nsCPUtxbx.Text = global.id_CPUsn6; nsKEYBtxbx.Text = global.id_KEYBsn6; nsMOUSEtxbx.Text = global.id_MOUSEsn6; nsMTORtxbx.Text = global.id_MTORsn6; nsSillatxbx.Text = global.id_SILLAsn6; }
        private void KIT7_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ7; nsCPUtxbx.Text = global.id_CPUsn7; nsKEYBtxbx.Text = global.id_KEYBsn7; nsMOUSEtxbx.Text = global.id_MOUSEsn7; nsMTORtxbx.Text = global.id_MTORsn7; nsSillatxbx.Text = global.id_SILLAsn7; }
        private void KIT8_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ8; nsCPUtxbx.Text = global.id_CPUsn8; nsKEYBtxbx.Text = global.id_KEYBsn8; nsMOUSEtxbx.Text = global.id_MOUSEsn8; nsMTORtxbx.Text = global.id_MTORsn8; nsSillatxbx.Text = global.id_SILLAsn8; }
        private void KIT9_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ9; nsCPUtxbx.Text = global.id_CPUsn9; nsKEYBtxbx.Text = global.id_KEYBsn9; nsMOUSEtxbx.Text = global.id_MOUSEsn9; nsMTORtxbx.Text = global.id_MTORsn9; nsSillatxbx.Text = global.id_SILLAsn9; }
        private void KIT10_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ10; nsCPUtxbx.Text = global.id_CPUsn10; nsKEYBtxbx.Text = global.id_KEYBsn10; nsMOUSEtxbx.Text = global.id_MOUSEsn10; nsMTORtxbx.Text = global.id_MTORsn10; nsSillatxbx.Text = global.id_SILLAsn10; }
        private void KIT11_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ11; nsCPUtxbx.Text = global.id_CPUsn11; nsKEYBtxbx.Text = global.id_KEYBsn11; nsMOUSEtxbx.Text = global.id_MOUSEsn11; nsMTORtxbx.Text = global.id_MTORsn11; nsSillatxbx.Text = global.id_SILLAsn11; }
        private void KIT12_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ12; nsCPUtxbx.Text = global.id_CPUsn12; nsKEYBtxbx.Text = global.id_KEYBsn12; nsMOUSEtxbx.Text = global.id_MOUSEsn12; nsMTORtxbx.Text = global.id_MTORsn12; nsSillatxbx.Text = global.id_SILLAsn12; }
        private void KIT13_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ13; nsCPUtxbx.Text = global.id_CPUsn13; nsKEYBtxbx.Text = global.id_KEYBsn13; nsMOUSEtxbx.Text = global.id_MOUSEsn13; nsMTORtxbx.Text = global.id_MTORsn13; nsSillatxbx.Text = global.id_SILLAsn13; }
        private void KIT14_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ14; nsCPUtxbx.Text = global.id_CPUsn14; nsKEYBtxbx.Text = global.id_KEYBsn14; nsMOUSEtxbx.Text = global.id_MOUSEsn14; nsMTORtxbx.Text = global.id_MTORsn14; nsSillatxbx.Text = global.id_SILLAsn14; }
        private void KIT15_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ15; nsCPUtxbx.Text = global.id_CPUsn15; nsKEYBtxbx.Text = global.id_KEYBsn15; nsMOUSEtxbx.Text = global.id_MOUSEsn15; nsMTORtxbx.Text = global.id_MTORsn15; nsSillatxbx.Text = global.id_SILLAsn15; }
        private void KIT16_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ16; nsCPUtxbx.Text = global.id_CPUsn16; nsKEYBtxbx.Text = global.id_KEYBsn16; nsMOUSEtxbx.Text = global.id_MOUSEsn16; nsMTORtxbx.Text = global.id_MTORsn16; nsSillatxbx.Text = global.id_SILLAsn16; }
        private void KIT17_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ17; nsCPUtxbx.Text = global.id_CPUsn17; nsKEYBtxbx.Text = global.id_KEYBsn17; nsMOUSEtxbx.Text = global.id_MOUSEsn17; nsMTORtxbx.Text = global.id_MTORsn17; nsSillatxbx.Text = global.id_SILLAsn17; }
        private void KIT18_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ18; nsCPUtxbx.Text = global.id_CPUsn18; nsKEYBtxbx.Text = global.id_KEYBsn18; nsMOUSEtxbx.Text = global.id_MOUSEsn18; nsMTORtxbx.Text = global.id_MTORsn18; nsSillatxbx.Text = global.id_SILLAsn18; }
        private void KIT19_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ19; nsCPUtxbx.Text = global.id_CPUsn19; nsKEYBtxbx.Text = global.id_KEYBsn19; nsMOUSEtxbx.Text = global.id_MOUSEsn19; nsMTORtxbx.Text = global.id_MTORsn19; nsSillatxbx.Text = global.id_SILLAsn19; }
        private void KIT20_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ20; nsCPUtxbx.Text = global.id_CPUsn20; nsKEYBtxbx.Text = global.id_KEYBsn20; nsMOUSEtxbx.Text = global.id_MOUSEsn20; nsMTORtxbx.Text = global.id_MTORsn20; nsSillatxbx.Text = global.id_SILLAsn20; }
        private void KIT21_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ21; nsCPUtxbx.Text = global.id_CPUsn21; nsKEYBtxbx.Text = global.id_KEYBsn21; nsMOUSEtxbx.Text = global.id_MOUSEsn21; nsMTORtxbx.Text = global.id_MTORsn21; nsSillatxbx.Text = global.id_SILLAsn21; }
        private void KIT22_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ22; nsCPUtxbx.Text = global.id_CPUsn22; nsKEYBtxbx.Text = global.id_KEYBsn22; nsMOUSEtxbx.Text = global.id_MOUSEsn22; nsMTORtxbx.Text = global.id_MTORsn22; nsSillatxbx.Text = global.id_SILLAsn22; }
        private void KIT23_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ23; nsCPUtxbx.Text = global.id_CPUsn23; nsKEYBtxbx.Text = global.id_KEYBsn23; nsMOUSEtxbx.Text = global.id_MOUSEsn23; nsMTORtxbx.Text = global.id_MTORsn23; nsSillatxbx.Text = global.id_SILLAsn23; }
        private void KIT24_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ24; nsCPUtxbx.Text = global.id_CPUsn24; nsKEYBtxbx.Text = global.id_KEYBsn24; nsMOUSEtxbx.Text = global.id_MOUSEsn24; nsMTORtxbx.Text = global.id_MTORsn24; nsSillatxbx.Text = global.id_SILLAsn24; }
        private void KIT25_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ25; nsCPUtxbx.Text = global.id_CPUsn25; nsKEYBtxbx.Text = global.id_KEYBsn25; nsMOUSEtxbx.Text = global.id_MOUSEsn25; nsMTORtxbx.Text = global.id_MTORsn25; nsSillatxbx.Text = global.id_SILLAsn25; }
        private void KIT26_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ26; nsCPUtxbx.Text = global.id_CPUsn26; nsKEYBtxbx.Text = global.id_KEYBsn26; nsMOUSEtxbx.Text = global.id_MOUSEsn26; nsMTORtxbx.Text = global.id_MTORsn26; nsSillatxbx.Text = global.id_SILLAsn26; }
        private void KIT27_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ27; nsCPUtxbx.Text = global.id_CPUsn27; nsKEYBtxbx.Text = global.id_KEYBsn27; nsMOUSEtxbx.Text = global.id_MOUSEsn27; nsMTORtxbx.Text = global.id_MTORsn27; nsSillatxbx.Text = global.id_SILLAsn27; }
        private void KIT28_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ28; nsCPUtxbx.Text = global.id_CPUsn28; nsKEYBtxbx.Text = global.id_KEYBsn28; nsMOUSEtxbx.Text = global.id_MOUSEsn28; nsMTORtxbx.Text = global.id_MTORsn28; nsSillatxbx.Text = global.id_SILLAsn28; }
        private void KIT29_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ29; nsCPUtxbx.Text = global.id_CPUsn29; nsKEYBtxbx.Text = global.id_KEYBsn29; nsMOUSEtxbx.Text = global.id_MOUSEsn29; nsMTORtxbx.Text = global.id_MTORsn29; nsSillatxbx.Text = global.id_SILLAsn29; }
        private void KIT30_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ30; nsCPUtxbx.Text = global.id_CPUsn30; nsKEYBtxbx.Text = global.id_KEYBsn30; nsMOUSEtxbx.Text = global.id_MOUSEsn30; nsMTORtxbx.Text = global.id_MTORsn30; nsSillatxbx.Text = global.id_SILLAsn30; }
        private void KIT31_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ31; nsCPUtxbx.Text = global.id_CPUsn31; nsKEYBtxbx.Text = global.id_KEYBsn31; nsMOUSEtxbx.Text = global.id_MOUSEsn31; nsMTORtxbx.Text = global.id_MTORsn31; nsSillatxbx.Text = global.id_SILLAsn31; }
        private void KIT32_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ32; nsCPUtxbx.Text = global.id_CPUsn32; nsKEYBtxbx.Text = global.id_KEYBsn32; nsMOUSEtxbx.Text = global.id_MOUSEsn32; nsMTORtxbx.Text = global.id_MTORsn32; nsSillatxbx.Text = global.id_SILLAsn32; }
        private void KIT33_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ33; nsCPUtxbx.Text = global.id_CPUsn33; nsKEYBtxbx.Text = global.id_KEYBsn33; nsMOUSEtxbx.Text = global.id_MOUSEsn33; nsMTORtxbx.Text = global.id_MTORsn33; nsSillatxbx.Text = global.id_SILLAsn33; }
        private void KIT34_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ34; nsCPUtxbx.Text = global.id_CPUsn34; nsKEYBtxbx.Text = global.id_KEYBsn34; nsMOUSEtxbx.Text = global.id_MOUSEsn34; nsMTORtxbx.Text = global.id_MTORsn34; nsSillatxbx.Text = global.id_SILLAsn34; }
        private void KIT35_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ35; nsCPUtxbx.Text = global.id_CPUsn35; nsKEYBtxbx.Text = global.id_KEYBsn35; nsMOUSEtxbx.Text = global.id_MOUSEsn35; nsMTORtxbx.Text = global.id_MTORsn35; nsSillatxbx.Text = global.id_SILLAsn35; }
        private void KIT36_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ36; nsCPUtxbx.Text = global.id_CPUsn36; nsKEYBtxbx.Text = global.id_KEYBsn36; nsMOUSEtxbx.Text = global.id_MOUSEsn36; nsMTORtxbx.Text = global.id_MTORsn36; nsSillatxbx.Text = global.id_SILLAsn36; }
        private void KIT37_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ37; nsCPUtxbx.Text = global.id_CPUsn37; nsKEYBtxbx.Text = global.id_KEYBsn37; nsMOUSEtxbx.Text = global.id_MOUSEsn37; nsMTORtxbx.Text = global.id_MTORsn37; nsSillatxbx.Text = global.id_SILLAsn37; }
        private void KIT38_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ38; nsCPUtxbx.Text = global.id_CPUsn38; nsKEYBtxbx.Text = global.id_KEYBsn38; nsMOUSEtxbx.Text = global.id_MOUSEsn38; nsMTORtxbx.Text = global.id_MTORsn38; nsSillatxbx.Text = global.id_SILLAsn38; }
        private void KIT39_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ39; nsCPUtxbx.Text = global.id_CPUsn39; nsKEYBtxbx.Text = global.id_KEYBsn39; nsMOUSEtxbx.Text = global.id_MOUSEsn39; nsMTORtxbx.Text = global.id_MTORsn39; nsSillatxbx.Text = global.id_SILLAsn39; }
        private void KIT40_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ40; nsCPUtxbx.Text = global.id_CPUsn40; nsKEYBtxbx.Text = global.id_KEYBsn40; nsMOUSEtxbx.Text = global.id_MOUSEsn40; nsMTORtxbx.Text = global.id_MTORsn40; nsSillatxbx.Text = global.id_SILLAsn40; }
        private void KIT41_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ41; nsCPUtxbx.Text = global.id_CPUsn41; nsKEYBtxbx.Text = global.id_KEYBsn41; nsMOUSEtxbx.Text = global.id_MOUSEsn41; nsMTORtxbx.Text = global.id_MTORsn41; nsSillatxbx.Text = global.id_SILLAsn41; }
        private void KIT42_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ42; nsCPUtxbx.Text = global.id_CPUsn42; nsKEYBtxbx.Text = global.id_KEYBsn42; nsMOUSEtxbx.Text = global.id_MOUSEsn42; nsMTORtxbx.Text = global.id_MTORsn42; nsSillatxbx.Text = global.id_SILLAsn42; }
        private void KIT43_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ43; nsCPUtxbx.Text = global.id_CPUsn43; nsKEYBtxbx.Text = global.id_KEYBsn43; nsMOUSEtxbx.Text = global.id_MOUSEsn43; nsMTORtxbx.Text = global.id_MTORsn43; nsSillatxbx.Text = global.id_SILLAsn43; }
        private void KIT44_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ44; nsCPUtxbx.Text = global.id_CPUsn44; nsKEYBtxbx.Text = global.id_KEYBsn44; nsMOUSEtxbx.Text = global.id_MOUSEsn44; nsMTORtxbx.Text = global.id_MTORsn44; nsSillatxbx.Text = global.id_SILLAsn44; }
        private void KIT45_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ45; nsCPUtxbx.Text = global.id_CPUsn45; nsKEYBtxbx.Text = global.id_KEYBsn45; nsMOUSEtxbx.Text = global.id_MOUSEsn45; nsMTORtxbx.Text = global.id_MTORsn45; nsSillatxbx.Text = global.id_SILLAsn45; }
        private void KIT46_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ46; nsCPUtxbx.Text = global.id_CPUsn46; nsKEYBtxbx.Text = global.id_KEYBsn46; nsMOUSEtxbx.Text = global.id_MOUSEsn46; nsMTORtxbx.Text = global.id_MTORsn46; nsSillatxbx.Text = global.id_SILLAsn46; }
        private void KIT47_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ47; nsCPUtxbx.Text = global.id_CPUsn47; nsKEYBtxbx.Text = global.id_KEYBsn47; nsMOUSEtxbx.Text = global.id_MOUSEsn47; nsMTORtxbx.Text = global.id_MTORsn47; nsSillatxbx.Text = global.id_SILLAsn47; }
        private void KIT48_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ48; nsCPUtxbx.Text = global.id_CPUsn48; nsKEYBtxbx.Text = global.id_KEYBsn48; nsMOUSEtxbx.Text = global.id_MOUSEsn48; nsMTORtxbx.Text = global.id_MTORsn48; nsSillatxbx.Text = global.id_SILLAsn48; }
        private void KIT49_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ49; nsCPUtxbx.Text = global.id_CPUsn49; nsKEYBtxbx.Text = global.id_KEYBsn49; nsMOUSEtxbx.Text = global.id_MOUSEsn49; nsMTORtxbx.Text = global.id_MTORsn49; nsSillatxbx.Text = global.id_SILLAsn49; }
        private void KIT50_MouseHover(object sender, EventArgs e) { nmaqtxbx.Text = global.id_nMAQ50; nsCPUtxbx.Text = global.id_CPUsn50; nsKEYBtxbx.Text = global.id_KEYBsn50; nsMOUSEtxbx.Text = global.id_MOUSEsn50; nsMTORtxbx.Text = global.id_MTORsn50; nsSillatxbx.Text = global.id_SILLAsn50; }

        private void KIT1_Click_1(object sender, EventArgs e)
        {
         //   nmaqtxbx= PRIMERA_PRUEBA_HOPEDataSet.IDIOMAS1DataTable.GetDataTableSchema()


        }

        private void Laboratorio_Idiomas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pRIMERA_PRUEBA_HOPEDataSet.IDIOMAS1' Puede moverla o quitarla según sea necesario.
            this.iDIOMAS1TableAdapter.Fill(this.pRIMERA_PRUEBA_HOPEDataSet.IDIOMAS1);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
