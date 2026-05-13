using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projekat_2026_Stevan_Matic_A
{
    public partial class Termini : Form
    {
        public Termini()
        {
            InitializeComponent();
        }

        private void Termini_Load(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BAZA", veza);
            DataTable raspodela = new DataTable();
            da.Fill(raspodela);
            da = new SqlDataAdapter("SELECT * FROM BAZA", veza);
            DataTable sk_godina = new DataTable();
            da.Fill(sk_godina);
            cBDatum.DataSource = sk_godina;
            cBDatum.ValueMember = "id";
            cBDatum.DisplayMember = "datum_pocetka";
            cBDatum.SelectedValue = raspodela.Rows[0]["baza_ID"].ToString();
        }
    }
}
