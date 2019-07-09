using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_calculator_uk
{
    class tax
    {
        public double Gross { get; set; }
        public double tax_amount { get; set; }
        public double net_amount { get; set; }
        public int percentage { get; set; }
        public int Period { get; set; }

        public tax(double gross,int period)
        {
            this.Gross = gross;
            this.Period = period;
            Calculate_tax();
        }



        private void Calculate_tax()
        {
            if (Period == 12)
            {
                Gross = Gross * 12;
            }
            if (Gross<= 11850)
            {
                percentage = 0;
            }
            else if (Gross > 11850 && Gross < 46350)
            {
                percentage = 20;
            }
            else if (Gross > 46350 && Gross <= 150000)
            {
                percentage = 40;
            }
            else if (Gross > 150000)
            {
                percentage = 45;
            }

            if (Period == 12)
            {
               tax_amount = ((Gross * percentage) / 100) / 12;
                Gross = Gross / 12;
            }
            else
            {
                tax_amount = ((Gross * percentage) / 100);
            }
            net_amount = Gross - tax_amount;
        }
    }
}
