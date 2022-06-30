using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMember member = new frmMember();
            panel1.Controls.Add(member);
            member.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmOrder order=new frmOrder();
            panel1.Controls.Add(order);
            order.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            panel1.Controls.Add(product);
            product.Show();
        }
    }
}
