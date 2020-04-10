using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyConverter
{
    public partial class Form1 : Form
    {
        private double m_dollarRate = OnlineRates.GetDollar();
        private double m_euroRate = OnlineRates.GetEuro();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String moneyStr = this.textBox1.Text;
            double money = double.Parse(moneyStr);
            if (radioRuble.Checked)
            {
                double dollar = money / m_dollarRate;
                double euro = money / m_euroRate;
                string output = String.Format("В долларах: {0}\r\nВ евро: {1}", dollar, euro);
                this.result.Text = output;
                //MessageBox.Show(moneyStr);

            } else if (radioDollar.Checked)
            {
                double ruble = money * m_dollarRate;
                double euro = ruble / m_euroRate;
                string output = String.Format("В рублях: {0}\r\nВ евро: {1}", ruble, euro);
                //MessageBox.Show(moneyStr);
                this.result.Text = output;
            } else if (radioEuro.Checked)
            {
                double ruble = money * m_euroRate;
                double dollar = ruble / m_dollarRate;
                string output = String.Format("В рублях: {0}\r\nВ долларах: {1}", ruble, dollar);
                //MessageBox.Show(moneyStr);
                this.result.Text = output;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioRuble_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
