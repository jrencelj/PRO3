using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dez
{
    public partial class Okno : Form
    {
        private List<Kapljica> padajoceKapljice = new List<Kapljica>();
        private List<Kapljica> kapljiceNaDnu = new List<Kapljica>();
        Random random = new Random();
        public Okno()
        {
            InitializeComponent();
        }

        private void UstvariKapljico()
        {
            Kapljica kapljica1 = new Kapljica(random.Next(pictureBox.Width), 0, false);
            padajoceKapljice.Add(kapljica1);
        }
        private void Osvezi(object sender, EventArgs e)
        {
            foreach (Kapljica kapljica in padajoceKapljice)
            {
                if (!kapljica.NaMestu)
                {
                    if (kapljica.Y + 1 > pictureBox.Height)
                    {
                        kapljica.NaMestu = true;
                    }
                    else if (padajoceKapljice.Contains(new Kapljica(kapljica.X, kapljica.Y + 1, true)))
                    {
                        kapljica.NaMestu = true;
                    }
                    else
                    {
                        kapljica.Y += 1;
                    }
                }
            }
            UstvariKapljico();
            pictureBox.Refresh();
        }

        private void Zacni(object sender, EventArgs e)
        {
            casovnik.Start();
        }

        private void Narisi(object sender, PaintEventArgs e)
        {
            Graphics platno = e.Graphics;
            foreach (Kapljica kapljica in padajoceKapljice)
            {
                platno.DrawEllipse(new Pen(Color.Blue, 1), new Rectangle(kapljica.X, kapljica.Y, 1, 1));
            }
        }
    }
}
