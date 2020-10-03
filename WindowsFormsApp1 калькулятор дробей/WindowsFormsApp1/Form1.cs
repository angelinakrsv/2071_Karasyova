using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Rational x;
        Rational y;
        public Form1()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            if (int.TryParse(chis1.Text, out int res) && int.TryParse(znam1.Text, out res))
            {
                if (int.Parse(znam1.Text) == 0)
                    MessageBox.Show(" ай яй яй");
                {
                    x = new Rational(int.Parse(chis1.Text), int.Parse(znam1.Text));
                    if (int.TryParse(chis2.Text, out res) && int.TryParse(znam2.Text, out res))
                    {
                        if (int.Parse(znam2.Text) == 0)
                            MessageBox.Show(" ай яй яй");
                        else
                        {
                            y = new Rational(int.Parse(chis2.Text), int.Parse(znam2.Text));
                            Rational sum = x.Sum(y);
                            result.Text = sum.Print();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ой ёй ёй ");
                    }
                }
            }
            else
            {
                MessageBox.Show("ой ёй ёй ");
            }
            
        }

        private void razn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(chis1.Text, out int res) && int.TryParse(znam1.Text, out res))
            {
                if (int.Parse(znam1.Text) == 0)
                    MessageBox.Show(" ай яй яй");
                {
                    x = new Rational(int.Parse(chis1.Text), int.Parse(znam1.Text));
                    if (int.TryParse(chis2.Text, out res) && int.TryParse(znam2.Text, out res))
                    {
                        if (int.Parse(znam2.Text) == 0)
                            MessageBox.Show(" ай яй яй");
                        else
                        {
                            y = new Rational(int.Parse(chis2.Text), int.Parse(znam2.Text));
                            Rational razn = x.Raznost(y);
                            result.Text = razn.Print();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ой ёй ёй ");
                    }
                }
            }
            else
            {
                MessageBox.Show("ой ёй ёй ");
            }
           
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (int.TryParse(chis1.Text, out int res) && int.TryParse(znam1.Text, out res))
            {
                if (int.Parse(znam1.Text) == 0)
                    MessageBox.Show(" ай яй яй");
                {
                    x = new Rational(int.Parse(chis1.Text), int.Parse(znam1.Text));
                    if (int.TryParse(chis2.Text, out res) && int.TryParse(znam2.Text, out res))
                    {
                        if (int.Parse(znam2.Text) == 0)
                            MessageBox.Show(" ай яй яй");
                        else
                        {
                            y = new Rational(int.Parse(chis2.Text), int.Parse(znam2.Text));
                            
                            Rational del = x.Delenie(y);
                            result.Text = del.Print();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ой ёй ёй ");
                    }
                }
            }
            else
            {
                MessageBox.Show("ой ёй ёй ");
            }
           
        }

        private void umn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(chis1.Text, out int res) && int.TryParse(znam1.Text, out res))
            {
                if (int.Parse(znam1.Text) == 0)
                    MessageBox.Show(" ай яй яй");
                {
                    x = new Rational(int.Parse(chis1.Text), int.Parse(znam1.Text));
                    if (int.TryParse(chis2.Text, out res) && int.TryParse(znam2.Text, out res))
                    {
                        if (int.Parse(znam2.Text) == 0)
                            MessageBox.Show(" ай яй яй");
                        else
                        {
                            y = new Rational(int.Parse(chis2.Text), int.Parse(znam2.Text));
                            Rational umn = x.Umnojenie(y);
                            result.Text = umn.Print();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ой ёй ёй ");
                    }
                }
            }
            else
            {
                MessageBox.Show("ой ёй ёй ");
            }
            
        }
    }
}
