using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jsparks1730ex1b
{
    public partial class frminvoiceTotal : Form
    {
        public frminvoiceTotal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {


            txtDiscountAmount.Text =
            (Convert.ToDecimal(txtSubtotal.Text)
            * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");
            txtTotal.Text =
                (Convert.ToDecimal(txtSubtotal.Text)
            * Convert.ToDecimal(txtDiscountAmount.Text) / 100).ToString("0.00");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
