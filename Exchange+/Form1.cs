using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchange_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double dif = 0;
        
        public void button_Result_Click(object sender, EventArgs e)
        {
            try
            {
                double inner = Double.Parse(text_In.Text);
                if (combo_In.SelectedItem == "USD")
                {
                    dif = 26.8;
                }
                else if (combo_In.SelectedItem == "EUR")
                {
                    dif = 33.2;
                }
                else if (combo_In.SelectedItem == "HUF")
                {
                    dif = 0.104;
                }
                double result = inner / dif;
                text_Result.Text = Convert.ToString(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            text_In.Text = "";
            text_Result.Text = "";
        }

        public void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 ff = new Form2();
                ff.ShowDialog();
                string newcurrency = ff.text_CurrencyAdd.Text;
                dif = 1 / Double.Parse(ff.text_dif.Text);
                combo_In.Items.Add(newcurrency);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
