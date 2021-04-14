using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txbNumbers_TextChanged(object sender, EventArgs e)
        {
            if (txbNumbers.Text != "")
            {
                btnSort.BackColor = Color.Red;
            }
            else
            {
                btnSort.BackColor = Color.DeepSkyBlue;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Numbers numbers = new Numbers();
            numbers.unorderedNumbersString = txbNumbers.Text;
            numbers.ConvertToIntArray();
            numbers.SortArray();
            numbers.ShowOrderedNumbers();
        }
    }
}
