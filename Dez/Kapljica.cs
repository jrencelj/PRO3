using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dez
{
    public class Kapljica : IEquatable<Kapljica>
    {
        private int x;
        private int y;
        private bool naMestu = false;

        public Kapljica(int x, int y, bool naMestu)
        {
            this.X = x;
            this.Y = y;
            this.NaMestu = naMestu;
        }

        public int X
        { 
            get { return x; } 
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool NaMestu
        {
            get { return naMestu; }
            set { naMestu = value; }
        }

        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }
            Kapljica otherAsKacaKomponenta = other as Kapljica;
            if (otherAsKacaKomponenta == null)
            {
                return false;
            }
            else
            {
                return Equals(otherAsKacaKomponenta);
            }
        }
        public bool Equals(Kapljica other)
        {
            if (other == null)
            {
                return false;
            }
            return ((X == other.X) && (Y == other.Y) && (NaMestu == other.NaMestu));
        }

    }
}
