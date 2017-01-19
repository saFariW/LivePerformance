using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformance
{
    public partial class Form1 : Form
    {
        private static Pizzaria _pizzaria;
        Klant KlantVanBon = new Klant();
        public Form1()
        {
            InitializeComponent();
            _pizzaria = new Pizzaria();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_pizzaria.Producten != null)
            {
                foreach (var product in _pizzaria.Producten)
                {
                    CBProducten.Items.Add(product);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CbCreeerBon.Checked)
            {
                try
                {
                    _pizzaria.Bestelling.PrintBon("PizzaBon.txt", KlantVanBon);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("er ging iets fout met opslaan : " + ex.Message);
                }
            }
        }

        private void CbKlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            KlantVanBon = (Klant)CbKlant.SelectedItem;
        }
    }
}
