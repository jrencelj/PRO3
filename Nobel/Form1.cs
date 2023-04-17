using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Reflection.Emit;

namespace Nobel
{
    public partial class Okno : Form
    {
        private const string povNiz = @"Data Source=../../../nobelDB.db; Verison=3;";
        public Okno()
        {
            InitializeComponent();
        }

        private void OknoNalozi(object sender, EventArgs e)
        {
            SQLiteConnection povezava = new SQLiteConnection(povNiz);
            povezava.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT DISTINCT subject FROM nobel", povezava);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            podrocjeComboBox.DisplayMember = "subject";
            podrocjeComboBox.DataSource = dt;
            povezava.Close();
            
        }

        private void Poisci(object sender, MouseEventArgs e)
        {
            string podrocje = podrocjeComboBox.Text.ToString();
            int leto;
            SQLiteConnection povezava = new SQLiteConnection(povNiz);
            textBox.Clear();
            string vnosLeto = letoTextBox.Text.Trim(' ');
            if (int.TryParse(vnosLeto, out leto))
            {
                povezava.Open();
                SQLiteCommand ukaz = new SQLiteCommand("SELECT * FROM nobel WHERE subject='" + podrocje + "' AND yr='" + leto + "'", povezava);
                SQLiteDataReader rez = ukaz.ExecuteReader();
                while (rez.Read())
                {
                    string vrstica = "";
                    for (int i = 0; i < rez.VisibleFieldCount; i++)
                    {
                        vrstica += rez[i].ToString() + " ";
                    }
                    textBox.Text += "* " + vrstica;
                    textBox.AppendText(Environment.NewLine);
                }
                povezava.Close();
            }
            else
            {
                MessageBox.Show("Nepravilni podatki!", "Napaka!");
                letoTextBox.Text = "";
            }

        }
    }
}
