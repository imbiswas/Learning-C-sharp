using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeeManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StudentCRUD frm = new StudentCRUD();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FeeHead frm = new FeeHead();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FeeRate frm = new FeeRate();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Feetagging frm = new Feetagging();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ClaimBill frm = new ClaimBill();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            BillPayment frm = new BillPayment();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
