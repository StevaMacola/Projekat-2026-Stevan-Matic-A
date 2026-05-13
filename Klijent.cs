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
            string naredba = "insert into Klijent values('";
            naredba = naredba + tBIme.Text + "','";
            naredba = naredba + tBPrezime.Text + "','";
            naredba = naredba + tBUlica.Text + "','";
            naredba = naredba + tBBroj.Text + "','";
            naredba = naredba + tBOpstina.Text + "','";
            naredba = naredba + tBGrad.Text + "','";
            naredba = naredba + tBMobilni.Text + "')";
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Klijent", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            br_sloga = tabela.Rows.Count - 1;
            prikazi();
        }
        private void bPromeni_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE Klijent SET ";
            naredba += "Ime='" + tBIme.Text + "',";
            naredba += "Prezime='" + tBPrezime.Text + "',";
            naredba += "Ulica='" + tBUlica.Text + "',";
            naredba += "Broj='" + tBBroj.Text + "',";
            naredba += "Opšitna='" + tBOpstina.Text + "',";
            naredba += "Grad='" + tBGrad.Text + "',";
            naredba += "Mobilni='" + tBMobilni.Text + "'";
            naredba += "WHERE klijent_ID = " + tBId.Text;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Klijent", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            prikazi();
        }
        private void bIzbrisi_Click(object sender, EventArgs e)
        {
           
                if (br_sloga == tabela.Rows.Count - 1)
                {
                    br_sloga--;
                }
                string naredba = "DELETE FROM Klijent WHERE id=" + tBId.Text;
                SqlConnection veza = Konekcija.Connect();
                SqlCommand komanda = new SqlCommand(naredba, veza);
                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.GetType().ToString());
                }
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Klijent", veza);
                tabela = new DataTable();
                da.Fill(tabela);
                prikazi();
            }
        private void Klijent_Load(object sender, EventArgs e)
        {
            br_sloga = 0;
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Klijent", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            prikazi();
        }

        private void bSledeci_Click(object sender, EventArgs e)
        {
            br_sloga++;
            prikazi();
        }

        private void bProsli_Click(object sender, EventArgs e)
        {
            br_sloga--;
            prikazi();
        }

       
    }
}
