using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_calculator_uk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Gross_TextChanged(object sender, EventArgs e)
        {
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int period_helper = 12;

            if (Per.Text == "Per year")
            {
                period_helper = 1;
                   
            }
            try
            {
                if (double.Parse(Gross.Text) < 0)
                {
                    MessageBox.Show("File for bankruptcy!");
                }
                else
                {
                    var tax_obj = new tax(double.Parse(Gross.Text), period_helper);
                    Gross.Text = tax_obj.Gross.ToString();
                    Net.Text = tax_obj.net_amount.ToString();
                    Tax.Text = tax_obj.tax_amount.ToString();
                    Percentage.Text = tax_obj.percentage.ToString();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please type in a valid income amount");
            }
            
            
        }

        private void Per_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Per.SelectedIndex = 1;
            Gross.Text = "0";

        }
    }
}
