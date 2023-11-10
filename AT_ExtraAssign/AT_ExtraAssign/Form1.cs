using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT_ExtraAssign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Calcultion Init()//khoi tao gia tri a va b tu textbox
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            Calcultion c = new Calcultion(a, b);
            return c;
        }
        private void button1_Click(object sender, EventArgs e)//Cong
        {
           txtKQ.Text = Init().Execute("+").ToString();
        }

        private void btTru_Click(object sender, EventArgs e)//Tru
        {
            txtKQ.Text = Init().Execute("-").ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)//Nhan
        {
            txtKQ.Text = Init().Execute("*").ToString();
        }

        private void btChia_Click(object sender, EventArgs e)//Chia
        {
            txtKQ.Text = Init().Execute("/").ToString();
        }
    }
}
