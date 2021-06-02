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
    public partial class FeeRate : Form
    {
        public FeeRate()
        {
            InitializeComponent();
        }

        private void FeeRate_Load(object sender, EventArgs e)
        {
            LoadClassandSection();
            cboFeeType.SelectedIndex = 0;
            cboFilter.SelectedIndex = 0;
            LoadFee();
        }
        BllStudentCRUD cs = new BllStudentCRUD();
        BllFee blf = new BllFee();
        public void LoadClassandSection()
        {
            DataTable dtc = cs.GetClass();
            DataRow drc = dtc.NewRow();
            drc["Class"] = "Choose Your Class";
            dtc.Rows.InsertAt(drc, 0);

            cboClass.DataSource = dtc;
            cboClass.DisplayMember = "Class";
            cboClass.ValueMember = "Classid";

            DataTable dts = cs.GetSection();
            DataRow drs = dts.NewRow();
            drs["Section"] = "Choose Your Section";
            dts.Rows.InsertAt(drs, 0);

            cboSection.DataSource = dts;
            cboSection.DisplayMember = "Section";
            cboSection.ValueMember = "Sectionid";

            DataTable dtf = blf.getFeeHead();
            DataRow drf = dtf.NewRow();
            drf["name"] = "Choose Your FeeHead";
            dtf.Rows.InsertAt(drf, 0);
            dtf.Rows.RemoveAt(7);
          
            cboFeeHead.DataSource = dtf;
            cboFeeHead.DisplayMember = "name";
            


        }
        private void LoadFee()
        {
            DataTable dt = blf.getFee();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["colSN"].Value = i + 1;
                dataGridView1.Rows[i].Cells["colClass"].Value = dt.Rows[i]["Class"].ToString();
                dataGridView1.Rows[i].Cells["colSection"].Value = dt.Rows[i]["Section"].ToString();
                dataGridView1.Rows[i].Cells["colFeeid"].Value = dt.Rows[i]["Feeid"].ToString();
                dataGridView1.Rows[i].Cells["colFeeHead"].Value = dt.Rows[i]["FeeHead"].ToString();
                dataGridView1.Rows[i].Cells["colFeeType"].Value = dt.Rows[i]["FeeType"].ToString();
                dataGridView1.Rows[i].Cells["colFeeRate"].Value = dt.Rows[i]["FeeRate"].ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0 && cboFeeHead.SelectedIndex != 0 && txtFeeRate.Text != "" && cboFeeType.SelectedIndex != 0)
            {
                blf.InsertFeeSetup(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue), cboFeeHead.Text, cboFeeType.Text, Convert.ToDecimal(txtFeeRate.Text));
                MessageBox.Show("Fee Setup done");
                cboFeeHead.SelectedIndex = 0;
                txtFeeRate.Text = "";
                LoadFee();

            }
            else
            {
                MessageBox.Show("Please Enter all the text fields for fee setup");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0 && cboFeeHead.SelectedIndex != 0 && txtFeeRate.Text != "" && cboFeeType.SelectedIndex != 0)
            {
                blf.UpdateFeeSetup(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue), cboFeeHead.Text, cboFeeType.Text, Convert.ToDecimal(txtFeeRate.Text), feeid);
                cboFeeHead.SelectedIndex = 0;
                txtFeeRate.Text = "";
                LoadFee();
                MessageBox.Show("Fee Setup Updated");
            }
        }
        int feeid = 0;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cboClass.Text = dataGridView1.CurrentRow.Cells["colClass"].Value.ToString();
            cboSection.Text = dataGridView1.CurrentRow.Cells["colSection"].Value.ToString();
            cboFeeHead.Text = dataGridView1.CurrentRow.Cells["colFeeHead"].Value.ToString();
            cboFeeType.Text = dataGridView1.CurrentRow.Cells["colFeeType"].Value.ToString();
            txtFeeRate.Text = dataGridView1.CurrentRow.Cells["colFeeRate"].Value.ToString();
            feeid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["colFeeid"].Value.ToString());
        }
    }
}
