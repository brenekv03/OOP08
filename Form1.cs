using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zbozi zbozi = new Zbozi("Mliko", 20, DateTime.Parse("01-05-2022"), 1);
            MessageBox.Show( zbozi.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt("Klobna", 25, DateTime.Parse("01-05-2022"), 1, true);
            MessageBox.Show( produkt.ToString());
        }
    }
}
