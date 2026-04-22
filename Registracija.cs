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

namespace Projekat_2026_Stevan_Matic_A
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baza = Program.user;
            if (textBox4.Text == textBox5.Text)
            {
                SqlConnection veza = Konekcija.Connect(baza);
                string provera = "SELECT COUNT(*) FROM Korisnik WHERE email='" + textBox3.Text + "'";
                SqlCommand komanda = new SqlCommand(provera, veza);
                veza.Open();
                int ima = (int)komanda.ExecuteScalar();
                veza.Close();
                if (ima > 0)
                {
                    MessageBox.Show("Ovaj email je vec registrovan!");
                }
                else
                {
                    string naredba = "INSERT INTO korisnik VALUES('";
                    naredba += textBox1.Text + "','";
                    naredba += textBox4.Text + "','";
                    naredba += textBox3.Text + "')";
                    veza.Open();
                    SqlCommand uradi = new SqlCommand(naredba, veza);
                    uradi.ExecuteNonQuery();
                    veza.Close();
                    MessageBox.Show("Uspešno ste se registrovali!");
                    this.Hide();
                    Glavna forma = new Glavna();
                    forma.Show();

                }
            }
            else
            {
                MessageBox.Show("Ponovljena lozinka nije dobra!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.UseSystemPasswordChar = !textBox4.UseSystemPasswordChar;
            textBox5.UseSystemPasswordChar = !textBox5.UseSystemPasswordChar;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

