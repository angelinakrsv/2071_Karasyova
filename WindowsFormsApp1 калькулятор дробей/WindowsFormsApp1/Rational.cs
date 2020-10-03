using System.Drawing.Printing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Rational
    {

        int chislitel;
        int znamenatel;
        
        public Rational(int c, int z)
        {
            this.chislitel = c;
            this.znamenatel = z;
            Sokr();
           
        }

        private void Sokr() 
        {
            int a = chislitel;
            int b = znamenatel;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }

            chislitel /= a;
            znamenatel /= b;
        }

        public string Print() 
        {
            return chislitel + "/" + znamenatel;
        }

        public Rational Sum(Rational other)
        {
            Rational d1 = this;
            Rational d2 = other;
            int chis, znam;
            znam = d1.znamenatel * d2.znamenatel;
            chis = d1.chislitel * d2.znamenatel + d1.znamenatel * d2.chislitel;
            return new Rational(chis, znam);

        }

        public Rational Raznost(Rational other)
        {
            Rational d1 = this;
            Rational d2 = other;
            int chis, znam;
            znam = d1.znamenatel * d2.znamenatel;
            chis = d1.chislitel * d2.znamenatel - d1.znamenatel * d2.chislitel;
            return new Rational(chis, znam);

        }

        public Rational Umnojenie(Rational other)
        {
            Rational d1 = this;
            Rational d2 = other;
            int chis, znam;
            znam = d1.znamenatel * d2.znamenatel;
            chis = d1.chislitel * d2.chislitel;
            return new Rational(chis, znam);

        }

        public Rational Delenie(Rational other)
        {
            Rational d1 = this;
            Rational d2 = other;
            int chis, znam;
            znam = d1.znamenatel * d2.chislitel;
            chis = d1.chislitel * d2.znamenatel;
            return new Rational(chis, znam);

        }
        
        
       









    }
}