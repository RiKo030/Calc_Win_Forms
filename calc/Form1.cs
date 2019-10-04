using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        List<string> viraz;
        string FullViraz;
        int i = 0;
        double sum = 0;
        public Form1()
        {
            InitializeComponent();
            viraz = new List<string>();
            viraz.Add(null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                viraz.Clear();
                i = 0;
                viraz.Add(null);
            }
            FullViraz = null;
            viraz[i] += "8";
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                viraz.Clear();
                i = 0;
                viraz.Add(null);
            }
            FullViraz = null;
            viraz[i] += "1";
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                viraz.Clear();
                i = 0;
                viraz.Add(null);
            }
            FullViraz = null;
            viraz[i] += "2";
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                viraz.Clear();
                i = 0;
                viraz.Add(null);
            }
            FullViraz = null;
            viraz[i] += "3";
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                viraz.Clear();
                i = 0;
                viraz.Add(null);
            }
            FullViraz = null;
            viraz[i] += "4";
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                viraz.Clear();
                i = 0;
                viraz.Add(null);
            }
            FullViraz = null;
            viraz[i] += "5";
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                viraz.Clear();
                i = 0;
                viraz.Add(null);
            }
            FullViraz = null;
            viraz[i] += "6";
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                viraz.Clear();
                i = 0;
                viraz.Add(null);
            }
            FullViraz = null;
            viraz[i] += "7";
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                viraz.Clear();
                i = 0;
                viraz.Add(null);
            }
            FullViraz = null;
            viraz[i] += "9";
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                viraz.Clear();
                i = 0;
                viraz.Add(null);
            }
            FullViraz = null;
            viraz[i] += "0";
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
        }

        private void plus_Click(object sender, EventArgs e)
        {

            FullViraz = null;
            if (viraz.Count == 1 && viraz[i] == null)
            { }
            else { 
                if (viraz[viraz.Count - 1] == null)
            {
                if (viraz[viraz.Count - 2] == "-" || viraz[viraz.Count - 2] == "+" || viraz[viraz.Count - 2] == "/" || viraz[viraz.Count - 2] == "*"|| viraz[viraz.Count - 2] == "%")
                {
                    viraz.RemoveAt(i);
                    i--;
                }
                viraz[i] = "+";
                i++;
            }
            else { 
            viraz.Add("+");
                i++;
                i++;
            }

                for (int a = 0; a < viraz.Count(); a++)
                {
                    FullViraz += viraz[a];
                }
                textBox1.Text = FullViraz;
                viraz.Add(null);
            }

        }

        private void minus_Click(object sender, EventArgs e)
        {
            FullViraz = null;
            if (viraz.Count == 1 && viraz[i] == null)
            { }
            else { 
                if (viraz[viraz.Count - 1] == null)
                {
                    if (viraz[viraz.Count - 2] == "-" || viraz[viraz.Count - 2] == "+" || viraz[viraz.Count - 2] == "/" || viraz[viraz.Count - 2] == "*" || viraz[viraz.Count - 2] == "%")
                    {
                        viraz.RemoveAt(i);
                        i--;
                    }
                    viraz[i] = "-";
                    i++;
                }
                else
                {
                    viraz.Add("-");
                    i++;
                    i++;
                }

                for (int a = 0; a < viraz.Count(); a++)
                {
                    FullViraz += viraz[a];
                }
                textBox1.Text = FullViraz;
                viraz.Add(null);
            }
        }

        private void multy_Click(object sender, EventArgs e)
        {

            FullViraz = null;
            if (viraz.Count == 1 && viraz[i] == null)
            { }
            else
            {
                if (viraz[viraz.Count - 1] == null)
                {
                    if (viraz[viraz.Count - 2] == "-" || viraz[viraz.Count - 2] == "+" || viraz[viraz.Count - 2] == "/" || viraz[viraz.Count - 2] == "*" || viraz[viraz.Count - 2] == "%")
                    {
                        viraz.RemoveAt(i);
                        i--;
                    }
                    viraz[i] = "*";
                    i++;
                }
                else
                {
                    viraz.Add("*");
                    i++;
                    i++;
                }

                for (int a = 0; a < viraz.Count(); a++)
                {
                    FullViraz += viraz[a];
                }
                textBox1.Text = FullViraz;
                viraz.Add(null);
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            FullViraz = null;
            if (viraz.Count == 1 && viraz[i] == null)
            { }
            else
            {
                if (viraz[viraz.Count - 1] == null)
                {
                    if (viraz[viraz.Count - 2] == "-" || viraz[viraz.Count - 2] == "+" || viraz[viraz.Count - 2] == "/" || viraz[viraz.Count - 2] == "*" || viraz[viraz.Count - 2] == "%")
                    {
                        viraz.RemoveAt(i);
                        i--;
                    }
                    viraz[i] = "/";
                    i++;
                }
                else
                {
                    viraz.Add("/");
                    i++;
                    i++;
                }

                for (int a = 0; a < viraz.Count(); a++)
                {
                    FullViraz += viraz[a];
                }
                textBox1.Text = FullViraz;
                viraz.Add(null);
            }
        }

        private void com_Click(object sender, EventArgs e)
        {
            if (viraz[i] == null || viraz[i] == "-" || viraz[i] == "+" || viraz[i] == "/" || viraz[i] == "*")
            {

            }
            else
            {
                FullViraz = null;
                viraz[i] += ",";
                for (int a = 0; a < viraz.Count(); a++)
                {
                    FullViraz += viraz[a];
                }
                textBox1.Text = FullViraz;
            }
        }

        private void rovno_Click(object sender, EventArgs e)
        {
            if (viraz.Count <= 1) { }
            else
            {
                if (viraz.Contains("√"))
                {
                    int index = viraz.IndexOf("√", 0);
                    double mul;
                    mul = (Math.Sqrt(Convert.ToDouble(viraz[index + 1])));
                    sum = mul;
                    viraz[index] = sum.ToString();
                    viraz.RemoveAt(index + 1);
                    i--;

                }
                if (viraz.Contains("%"))
                {
                    int index = viraz.IndexOf("%", 0);
                    double mul = Convert.ToDouble(viraz[index - 1]) % Convert.ToDouble(viraz[index + 1]);
                    sum = mul;
                    viraz[index - 1] = sum.ToString();
                    viraz.RemoveAt(index + 1);
                    i--;
                    viraz.RemoveAt(index);
                    i--;
                }
                while (viraz.Contains("*") || viraz.Contains("/"))
                {
                    if (viraz.Contains("*") && viraz.Contains("/"))
                    {
                        if (viraz.IndexOf("*", 0) < viraz.IndexOf("/", 0))
                        {
                            int index = viraz.IndexOf("*");
                            double mul = Convert.ToDouble(viraz[index - 1]) * Convert.ToDouble(viraz[index + 1]);
                            sum = mul;
                            viraz[index - 1] = sum.ToString();
                            viraz.RemoveAt(index + 1);
                            i--;
                            viraz.RemoveAt(index);
                            i--;
                        }
                        else
                        {
                            int index = viraz.IndexOf("/");
                            double mul = Convert.ToDouble(viraz[index - 1]) / Convert.ToDouble(viraz[index + 1]);
                            sum = mul;
                            viraz[index - 1] = sum.ToString();
                            viraz.RemoveAt(index + 1);
                            i--;
                            viraz.RemoveAt(index);
                            i--;
                        }
                    }
                    else if (viraz.Contains("*"))
                    {
                        int index = viraz.IndexOf("*");
                        double mul = Convert.ToDouble(viraz[index - 1]) * Convert.ToDouble(viraz[index + 1]);
                        sum = mul;
                        viraz[index - 1] = sum.ToString();
                        viraz.RemoveAt(index + 1);
                        i--;
                        viraz.RemoveAt(index);
                        i--;
                    }
                    else if (viraz.Contains("/"))
                    {
                        int index = viraz.IndexOf("/");
                        double mul = Convert.ToDouble(viraz[index - 1]) / Convert.ToDouble(viraz[index + 1]);
                        sum = mul;
                        viraz[index - 1] = sum.ToString();
                        viraz.RemoveAt(index + 1);
                        i--;
                        viraz.RemoveAt(index);
                        i--;
                    }
                }
                while (viraz.Contains("-") || viraz.Contains("+"))
                {

                    if (viraz.Contains("-") && viraz.Contains("+"))
                    {
                        if (viraz.IndexOf("-", 0) < viraz.IndexOf("+", 0))
                        {
                            int index = viraz.IndexOf("-", 0);
                            double mul = Convert.ToDouble(viraz[index - 1]) - Convert.ToDouble(viraz[index + 1]);
                            sum = mul;
                            viraz[index - 1] = sum.ToString();
                            viraz.RemoveAt(index + 1);
                            i--;
                            viraz.RemoveAt(index);
                            i--;
                        }
                        else
                        {
                            int index = viraz.IndexOf("+");
                            double mul = Convert.ToDouble(viraz[index - 1]) + Convert.ToDouble(viraz[index + 1]);
                            sum = mul;
                            viraz[index - 1] = sum.ToString();
                            viraz.RemoveAt(index + 1);
                            i--;
                            viraz.RemoveAt(index);
                            i--;
                        }
                    }
                    else if (viraz.Contains("-"))
                    {
                        int index = viraz.IndexOf("-", 0);
                        double mul = Convert.ToDouble(viraz[index - 1]) - Convert.ToDouble(viraz[index + 1]);
                        sum = mul;
                        viraz[index - 1] = sum.ToString();
                        viraz.RemoveAt(index + 1);
                        i--;
                        viraz.RemoveAt(index);
                        i--;
                    }
                    else if (viraz.Contains("+"))
                    {
                        int index = viraz.IndexOf("+");
                        double mul = Convert.ToDouble(viraz[index - 1]) + Convert.ToDouble(viraz[index + 1]);
                        sum = mul;
                        viraz[index - 1] = sum.ToString();
                        viraz.RemoveAt(index + 1);
                        i--;
                        viraz.RemoveAt(index);
                        i--;
                    }
                }

                FullViraz += "\r\n=\r\n";
                FullViraz += sum.ToString();
                textBox1.Text = FullViraz;
                FullViraz = null;
                for (int a = 0; a < viraz.Count(); a++)
                {
                    FullViraz += viraz[a];
                }
                i++;
                viraz.Add(null);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FullViraz = null;
            if (viraz.Count == 1 && viraz[i] == null)
            { }
            else
            {
                if (viraz[viraz.Count - 1] == null)
                {
                    if (viraz[viraz.Count - 2] == "-" || viraz[viraz.Count - 2] == "+" || viraz[viraz.Count - 2] == "/" || viraz[viraz.Count - 2] == "*" || viraz[viraz.Count - 2] == "%")
                    {
                        viraz.RemoveAt(i);
                        i--;
                    }
                    viraz[i] = "%";
                    i++;
                }
                else
                {
                    viraz.Add("%");
                    i++;
                    i++;
                }

                for (int a = 0; a < viraz.Count(); a++)
                {
                    FullViraz += viraz[a];
                }
                textBox1.Text = FullViraz;
                viraz.Add(null);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viraz.Clear();
            FullViraz = null;
            textBox1.Text = "";
            i = 0;
            viraz.Add(null);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (viraz[viraz.Count() - 1] != "+" || viraz[viraz.Count() - 1] != "-" || viraz[viraz.Count() - 1] != "*" || viraz[viraz.Count() - 1] != "/")
            {
                viraz[viraz.Count() - 1] = "";
                FullViraz = "";
                for (int a = 0; a < viraz.Count(); a++)
                {
                    FullViraz += viraz[a];
                }
                textBox1.Text = FullViraz;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (viraz[viraz.Count()-1]==null)
            {
                viraz.RemoveAt(viraz.Count() - 1);
                i--;
                viraz.RemoveAt(viraz.Count() - 1);
                i--;
                FullViraz = "";
                if (viraz.Count != 0) { 
                for (int a = 0; a < viraz.Count(); a++)
                {
                    FullViraz += viraz[a];
                }
                }
                textBox1.Text = FullViraz;
                viraz.Add(null);
                i++;
            }
            else
            {

            viraz.RemoveAt(i);
            i--;
            FullViraz = "";
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
            viraz.Add(null);
            i++;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FullViraz = null;
            if (viraz[i] == null)
            {
                viraz[i] = "√";
                i++;
            }
            else { 
            viraz.Add("√");
            i++;
            i++;
            }
            if (viraz.Count() < i)
            {
                i--;
            }
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
            viraz.Add(null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (viraz[viraz.Count() - 1].StartsWith("1") || viraz[viraz.Count() - 1].StartsWith("2") || viraz[viraz.Count() - 1].StartsWith("3") || viraz[viraz.Count() - 1].StartsWith("4") || viraz[viraz.Count() - 1].StartsWith("5") || viraz[viraz.Count() - 1].StartsWith("6") || viraz[viraz.Count() - 1].StartsWith("7") || viraz[viraz.Count() - 1].StartsWith("8") || viraz[viraz.Count() - 1].StartsWith("9") || viraz[viraz.Count() - 1].StartsWith("0"))
                {
                    string vir = viraz[viraz.Count() - 1];
                    string nvir = "-";
                    nvir += vir;
                    viraz[viraz.Count() - 1] = nvir;
                    FullViraz = "";
                    for (int a = 0; a < viraz.Count(); a++)
                    {
                        FullViraz += viraz[a];
                    }
                    textBox1.Text = FullViraz;
                }
                else if (viraz[viraz.Count() - 1].StartsWith("-"))
                {
                    string vir = viraz[viraz.Count() - 1];
                    vir=vir.Substring(1);
                    viraz[viraz.Count() - 1] = vir;
                    FullViraz = "";
                    for (int a = 0; a < viraz.Count(); a++)
                    {
                        FullViraz += viraz[a];
                    }
                    textBox1.Text = FullViraz;

              
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (viraz[viraz.Count - 1] == null)
            {
                viraz.RemoveAt(viraz.Count - 1);
                i--;
            }
            sum=1/Convert.ToDouble(viraz[viraz.Count() - 1]);
            FullViraz = "";
            string v="reciproc(";
            v+=viraz[viraz.Count-1];
            v+=")\r\n";
            viraz[viraz.Count-1]=v;
            viraz.Add(sum.ToString());
            for (int a = 0; a < viraz.Count(); a++)
            {
                FullViraz += viraz[a];
            }
            textBox1.Text = FullViraz;
            viraz.RemoveRange(0, viraz.Count());
            i = 0;
            viraz.Add(sum.ToString());
            viraz.Add(null);
            i++;
            
        }
    }
}
