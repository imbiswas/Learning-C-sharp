using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace FeeManagementSystem
{
    public partial class FeeHead : Form
    {
        public FeeHead()
        {
            InitializeComponent();
        }
        BllFee blf = new BllFee();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtFeeHead.Text != "")
            {
                int i = blf.createFeeHead(txtFeeHead.Text);
                if (i < 0)
                {
                    MessageBox.Show("FeeHead Successfully Created");
                    txtFeeHead.Text = "";
                    FeeHeadLoad();

                }
            }
            else
            {
                MessageBox.Show("FeeHead is Empty");
            }
        }
        private void FeeHeadLoad()
        {
            DataTable dt = blf.getFeeHead();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["name"].ToString() != "Total")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["colSN"].Value = i + 1;
                    dataGridView1.Rows[i].Cells["colFeeHead"].Value = dt.Rows[i]["name"].ToString();
                }

            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txtNewFeeHead.Text = txtFeeHead.Text;
            txtNewFeeHead.Focus();
        }

        private void FeeHead_Load(object sender, EventArgs e)
        {
            FeeHeadLoad();
            groupBox1.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int i = blf.updateFeeHead(txtFeeHead.Text, txtNewFeeHead.Text);
            if (i < 0)
            {
                MessageBox.Show("FeeHead Update Done");
                FeeHeadLoad();
                txtFeeHead.Text = "";

            }
            groupBox1.Visible = false;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtFeeHead.Text = dataGridView1.CurrentRow.Cells["colFeeHead"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
