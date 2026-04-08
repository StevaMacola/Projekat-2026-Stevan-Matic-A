using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projekat_2026_Stevan_Matic_A
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Stevan Matic 
            // drugi red
            comboBox1.SelectedItem = "skola";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == "" || txtSifra.Text == "")
            {
                MessageBox.Show("Morate uneti podatke u oba polja!!!");
            }
            else
            {
                string lokacija = comboBox1.SelectedItem.ToString();
                SqlConnection veza = Konekcija.Connect(lokacija);
                DataTable podaci = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM korisnik WHERE ime ="+"'"+txtIme.Text+"'", veza);
                adapter.Fill(podaci);
                int count = podaci.Rows.Count;
                if (count == 0)
                {
                    MessageBox.Show("Dato ime je nevažece!");
                }
                else
                {
                    /*razliciti nacini za poredjenje
                    string prvi = podaci.Rows[0]["pass"].ToString();
                    string drugi = txtSifra.Text;
                    bool isti = prvi.Equals(drugi);
                    bool jednaki = String.Equals(prvi, drugi);
                    int poredak = String.Compare(prvi, drugi);
                    */

                    if (podaci.Rows[0]["pass"].ToString()==txtSifra.Text)
                    {
                        MessageBox.Show("Uspesno ste se ulogovali!!!!");
                        this.Hide();
                        Glavna forma = new Glavna();
                        forma.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sifra je netacnaaa!");
                    }
                }
            }
        }

        private void txtSifra_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.user = comboBox1.SelectedItem.ToString();
            Registracija nova = new Registracija();
            nova.ShowDialog();

        }
    }
}
