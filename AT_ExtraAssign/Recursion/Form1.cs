using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursion
{
    public partial class Recursion : Form
    {
        public Recursion()
        {
            InitializeComponent();
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtx.Text);
            int n = int.Parse(txtn.Text);
            txtKQ.Text = RecursionCalculation.Power(x, n).ToString();
        }
    }
}
