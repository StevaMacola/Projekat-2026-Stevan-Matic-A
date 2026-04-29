using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Projekat_2026_Stevan_Matic_A
{
    public partial class Klijent : Form
    {
        int br_sloga;
        DataTable tabela;
        public Klijent()
        {
            InitializeComponent();
        }
        public void prikazi()
        {
            if (tabela.Rows.Count == 0)
            {   tBId.Text = "";
                tBIme.Text = "";
                tBPrezime.Text = "";
                tBUlica.Text = "";
                tBBroj.Text = "";
                tBOpstina.Text = "";
                tBGrad.Text = "";              
                tBMobilni.Text = "";
                tBDatum.Text = "";
            }
            else
            {
                tBId.Text = tabela.Rows[br_sloga][0].ToString();
                tBIme.Text = tabela.Rows[br_sloga][1].ToString();
                tBPrezime.Text = tabela.Rows[br_sloga][2].ToString();
                tBUlica.Text = tabela.Rows[br_sloga][3].ToString();
                tBBroj.Text = tabela.Rows[br_sloga][4].ToString();
                tBOpstina.Text = tabela.Rows[br_sloga][5].ToString();
                tBGrad.Text = tabela.Rows[br_sloga][6].ToString();
                tBMobilni.Text = tabela.Rows[br_sloga][7].ToString();
                tBDatum.Text = tabela.Rows[br_sloga][8].ToString();
            }
            if (br_sloga == tabela.Rows.Count - 1)
                bSledeci.Enabled = false;
            else bSledeci.Enabled = true;
            if (br_sloga == 0)
                bProsli.Enabled = false;
            else bProsli.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bDodaj_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE osoba SET ";
            naredba += "klijent_ID='" + tBIme.Text + "',";
            naredba += "Ime='" + tBIme.Text + "',";
            naredba += "Prezime='" + tBPrezime.Text + "',";
            naredba += "Ulica='" + tBUlica.Text + "',";
            naredba += "Broj='" + tBBroj.Text + "',";
            naredba += "Opština='" + tBOpstina.Text + "',";
            naredba += "Grad='" + tBGrad.Text + "',";
            naredba += "Mobilni='" + tBMobilni.Text + "',";
            naredba += "datum_upisa='" + tBDatum.Text + "'";
            naredba += "WHERE id = " + tBId.Text;
            string lokacija = cBserver.SelectedItem.ToString();
            SqlConnection veza = Konekcija.Connect(lokacija);
            SqlCommand komanda = new SqlCommand(naredba, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            prikazi();
        }

        private void Klijent_Load(object sender, EventArgs e)
        {
            cBserver.SelectedItem = "skola";
        }
    }
}
