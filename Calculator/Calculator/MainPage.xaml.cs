using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Check_Button(object sender, EventArgs e)
        {
            try
            {


                var per = sender as Xamarin.Forms.Button;
                switch (per.Text)
                {
                    case "C":
                        textBox.Text = String.Empty;
                        break;
                    case ",":
                        textBox.Text += ",";
                        break;
                    case "/":
                        textBox.Text += "/";
                        break;
                    case "*":
                        textBox.Text += "*";
                        break;
                    case "-":
                        textBox.Text += "-";
                        break;
                    case "+":
                        textBox.Text += "+";
                        break;
                    case "9":
                        textBox.Text += "9";
                        break;
                    case "8":
                        textBox.Text += "8";
                        break;
                    case "7":
                        textBox.Text += "7";
                        break;
                    case "6":
                        textBox.Text += "6";
                        break;
                    case "5":
                        textBox.Text += "5";
                        break;
                    case "4":
                        textBox.Text += "4";
                        break;
                    case "3":
                        textBox.Text += "3";
                        break;
                    case "2":
                        textBox.Text += "2";
                        break;
                    case "1":
                        textBox.Text += "1";
                        break;
                    case "0":
                        textBox.Text += "0";
                        break;
                    case "000":
                        textBox.Text += "000";
                        break;
                    case "=":
                        var sum = new System.Data.DataTable().Compute(textBox.Text, "");
                        textBox.Text = sum.ToString();
                        break;
                }
                
            }
                catch {
                    }
            
        }
    }
}
