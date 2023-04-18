using Npgsql;
using System.Data;

namespace Nobel
{
    public partial class Okno : Form
    {
        private const string povNiz = @"Server= baza.fmf.uni-lj.si; 
        User Id= student11;
        Password= student;
        Database= nobel2012;";

        public Okno()
        {
            InitializeComponent();
        }

        private void Poisci(object sender, MouseEventArgs e)
        {
            string podrocje = podrocjeComboBox.Text.ToString();
            int leto;
            NpgsqlConnection povezava = new NpgsqlConnection(povNiz);
            textBox.Clear();
            string vnosLeto = letoTextBox.Text.Trim(' ');
            if (int.TryParse(vnosLeto, out leto))
            {
                povezava.Open();
                NpgsqlCommand ukaz = new NpgsqlCommand("SELECT * FROM nobel WHERE subject='" + podrocje + "' AND yr='" + leto + "'", povezava);
                NpgsqlDataReader rez = ukaz.ExecuteReader();
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

        private void OknoNalozi(object sender, EventArgs e)
        {
            NpgsqlConnection povezava = new NpgsqlConnection(povNiz);
            povezava.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT DISTINCT subject FROM nobel", povezava);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            podrocjeComboBox.DisplayMember = "subject";
            podrocjeComboBox.DataSource = dt;
            povezava.Close();
        }
    }
}