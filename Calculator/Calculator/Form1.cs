using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double bellek = 0;
        double bellek2 = 0;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonClick(object sender, EventArgs args)
        {
            Button button = sender as Button;

            if (button != null)
            {
                switch (button.Text)
                {
                    case "+" :
                        if (Sonuc.Text != "")
                        {
                            bellek = Convert.ToDouble(Sonuc.Text);
                            Sonuc.Text = "";
                        }
                        islem = "+";
                        break;

                    case "-":
                        if (Sonuc.Text != "")
                        {
                            bellek = Convert.ToDouble(Sonuc.Text);
                            Sonuc.Text = "";
                        }
                        islem = "-";
                        break;

                    case "x":
                        if (Sonuc.Text != "")
                        {
                            bellek = Convert.ToDouble(Sonuc.Text);
                            Sonuc.Text = "";
                        }
                        islem = "x";
                        break;

                    case "/":
                        if (Sonuc.Text != "")
                        {
                            bellek = Convert.ToDouble(Sonuc.Text);
                            Sonuc.Text = "";
                        }
                        islem = "/";
                        break;

                    case "=":
                        if (islem == "+") Sonuc.Text = (bellek + bellek2).ToString();
                        if (islem == "-") Sonuc.Text = (bellek - bellek2).ToString();
                        if (islem == "/") Sonuc.Text = (bellek / bellek2).ToString();
                        if (islem == "x") Sonuc.Text = (bellek * bellek2).ToString();
                        bellek = 0;
                        bellek2 = 0;
                        islem = null;
                        break;

                    case "Temizle":
                        Sonuc.Text = "";
                        bellek = 0;
                        bellek2 = 0;
                        islem = null;
                        break;

                    case "K":
                        Sonuc.Text = Math.Sqrt(Convert.ToDouble(Sonuc.Text)).ToString();
                        bellek = 0;
                        bellek2 = 0;
                        islem = null;
                        break;

                    default:
                        Sonuc.Text += button.Text;
                        if (islem == null) bellek = Convert.ToDouble(Sonuc.Text);
                        else bellek2 = Convert.ToDouble(Sonuc.Text);
                        break;
                }
            }
        }
    }
}
