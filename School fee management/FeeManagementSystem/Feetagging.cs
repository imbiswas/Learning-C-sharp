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
    public partial class Feetagging : Form
    {
        public Feetagging()
        {
            InitializeComponent();
        }
        BllStudentCRUD cs = new BllStudentCRUD();
        BllFee blf = new BllFee();
        BllBillPayment blbp = new BllBillPayment();
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

            //if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
            //{
            //    DataTable dtstname = cs.GetAllStudentbyClassidandSectionid(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));

            //    DataRow drst = dtstname.NewRow();
            //    drst["StudentName"] = "Selecte All Students";
            //    dtstname.Rows.InsertAt(drst, 0);

            //    cboStudentName.DataSource = dtstname;
            //    cboStudentName.DisplayMember = "StudentName";
            //    cboStudentName.ValueMember = "Studentid";
            //}
        }
        //private void LoadDataGrid()
        //{
        //    if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
        //    {

        //        DataTable dt1 = blf.getFeeHead(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
        //        DataTable dt2 = new DataTable();
        //        for (int i = 0; i <= dt1.Rows.Count; i++)
        //        {
        //            dt2.Columns.Add();
        //        }
        //        for (int i = 0; i < dt1.Columns.Count; i++)
        //        {
        //            dt2.Rows.Add();
        //            dt2.Rows[i][0] = dt1.Columns[i].ColumnName;
        //        }
        //        for (int i = 0; i < dt1.Columns.Count; i++)
        //        {
        //            for (int j = 0; j < dt1.Rows.Count; j++)
        //            {
        //                dt2.Rows[i][j + 1] = dt1.Rows[j][i];
        //            }
        //        }

        //        DataTable dtnew = new DataTable();
        //        dtnew.Columns.Add("SN");
        //        dtnew.Columns.Add("StudentName");
        //        for (int i = 0; i < dt2.Columns.Count; i++)
        //        {
        //            dtnew.Columns.Add(dt2.Rows[0][i].ToString());
        //        }
        //        dtnew.Columns.Remove("FeeHead");
        //        if (dt1.Rows.Count > 0)
        //        {
        //            dtnew.Columns.Add("Total");
        //            dtnew.Columns.Add("PreviousDue");
        //            dtnew.Columns.Add("GrandTotal");

        //        }


        //        DataTable dt = blf.getForFeetagging(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            DataRow dr = dtnew.NewRow();
        //            dr["SN"] = i + 1;

        //            dr["StudentName"] = dt.Rows[i]["StudentName"].ToString();
        //            dtnew.Rows.Add(dr);

        //        }

        //        dataGridView1.DataSource = dtnew;
        //        dataGridView1.Columns[0].ReadOnly = true;
        //        dataGridView1.Columns[1].ReadOnly = true;
        //        if (dt1.Rows.Count > 0)
        //        {
        //            dataGridView1.Columns["Total"].ReadOnly = true;
        //            dataGridView1.Columns["PreviousDue"].ReadOnly = true;
        //            dataGridView1.Columns["GrandTotal"].ReadOnly = true;

        //        }
        //    }


        //}
        public void loadgrid()
        {
            //
            if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
            {
                DataTable dtstname = cs.GetAllStudentbyClassidandSectionid(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));

                DataRow drst = dtstname.NewRow();
                drst["StudentName"] = "All Students";
                dtstname.Rows.InsertAt(drst, 0);

                cboStudentName.DataSource = dtstname;
                cboStudentName.DisplayMember = "StudentName";
                cboStudentName.ValueMember = "Studentid";
               
                //         
                dataGridView1.Columns["colSN"].Visible = true;
                dataGridView1.Columns["colStudentName"].Visible = true;

                DataTable dt1 = blf.getFeeHead(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));

                DataTable dtstf = blf.getStudentsforfeetagging(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));


                DataTable dtnew = new DataTable();
                dtnew.Columns.Add("SN");
                dtnew.Columns.Add("Feetaggingid");
                dtnew.Columns.Add("Classid");
                dtnew.Columns.Add("Sectionid");
                dtnew.Columns.Add("Studentid");
                dtnew.Columns.Add("StudentName");

                for (int i = 0; i < dtstf.Rows.Count; i++)
                {
                    DataRow dr = dtnew.NewRow();
                    dr["SN"] = i + 1;
                    dr["Feetaggingid"] = dtstf.Rows[i]["Feetaggingid"].ToString();
                    dr["Classid"] = dtstf.Rows[i]["Classid"].ToString();
                    dr["Sectionid"] = dtstf.Rows[i]["Sectionid"].ToString();
                    dr["Studentid"] = dtstf.Rows[i]["Studentid"].ToString();
                    dr["StudentName"] = dtstf.Rows[i]["StudentName"].ToString();
                    dtnew.Rows.Add(dr);
                }

                //
               
                //
                //
                //

                      dataGridView1.Rows.Clear();
                      for (int i = 0; i < dtnew.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["colSN"].Value = i + 1;
                        dataGridView1.Rows[i].Cells["colFeetaggingid"].Value = dtnew.Rows[i]["Feetaggingid"].ToString();
                        dataGridView1.Rows[i].Cells["colClassid"].Value = dtnew.Rows[i]["Classid"].ToString();
                        dataGridView1.Rows[i].Cells["colSectionid"].Value = dtnew.Rows[i]["Sectionid"].ToString();
                        dataGridView1.Rows[i].Cells["colStudentid"].Value = dtnew.Rows[i]["Studentid"].ToString();

                        dataGridView1.Rows[i].Cells["colStudentName"].Value = dtnew.Rows[i]["StudentName"].ToString();
                     }
               


                string name = "";
               
                for(int i=0;i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Columns[i].HeaderText != "SN" && dataGridView1.Columns[i].HeaderText != "StudentName" && dataGridView1.Columns[i].HeaderText != "Total" && dataGridView1.Columns[i].HeaderText != "SystemDue" && dataGridView1.Columns[i].HeaderText != "GrandTotal" && dataGridView1.Columns[i].Name != "colFeetaggingid" && dataGridView1.Columns[i].Name != "colClassid" && dataGridView1.Columns[i].Name != "colSectionid" && dataGridView1.Columns[i].Name != "colStudentid")
                    {
                        dataGridView1.Columns.Remove(dataGridView1.Columns[i].Name);
                        i--;
                    }
                }
              
                /// adding columns in datagridview
                if (dt1.Rows.Count > 0)
                {

                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        
                        DataGridViewTextBoxColumn isEdited = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxCell txtcell = new DataGridViewTextBoxCell();
                        isEdited.CellTemplate = txtcell;
                        name = dt1.Rows[i][0].ToString();
                       
                        isEdited.Name = name;
                        isEdited.HeaderText = name;
                        isEdited.Visible = true;
                      dataGridView1.Columns.Add(isEdited);
                    }

                }

               

                dataGridView1.Columns["colGrandTotal"].DisplayIndex = dataGridView1.ColumnCount - 1;
              
                dataGridView1.Columns["colSystemDue"].DisplayIndex = dataGridView1.Columns["colGrandTotal"].DisplayIndex-1;

                dataGridView1.Columns["colTotal"].DisplayIndex = dataGridView1.Columns["colSystemDue"].DisplayIndex-1;



                if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (cboStudentName.SelectedIndex == 0)
                        {
                            DataTable dtdue2 = blc.getSystemDuebyClass(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
                        if (dtdue2.Rows.Count == 0)
                        {
                            dataGridView1.Rows[i].Cells["colSystemDue"].Value = 0;
                        }
                        else
                        {
                            //if (dtdue2.Rows[i]["Due"].ToString() == string.Empty)
                            //{
                                dataGridView1.Rows[i].Cells["colSystemDue"].Value = 0;
                            //}
                            //else
                            //{
                            //    dataGridView1.Rows[i].Cells["colSystemDue"].Value = dtdue2.Rows[i]["Due"].ToString();
                            //}
                        }

                        }
                        else
                        {
                            DataTable dtdue1 = blc.getSystemDuebyStudentid(Convert.ToInt32(cboStudentName.SelectedValue));
                            if (dtdue1.Rows[i]["Due"].ToString() == string.Empty)
                            {
                                dataGridView1.Rows[i].Cells["colSystemDue"].Value = 0;
                            }
                            else
                            {
                                dataGridView1.Rows[i].Cells["colSystemDue"].Value = dtdue1.Rows[i]["Due"].ToString();
                            }


                        }
                    }
                }

                decimal val2 = 0;
                for (int a = 0; a < dataGridView1.Rows.Count; a++)
                {
                    val2 = 0;
                    for (int b = 0; b < dataGridView1.Columns.Count; b++)
                    {
                        if (dataGridView1.Columns[b].HeaderText != "SN" && dataGridView1.Columns[b].HeaderText != "StudentName" && dataGridView1.Columns[b].HeaderText != "Total" && dataGridView1.Columns[b].HeaderText != "SystemDue" && dataGridView1.Columns[b].HeaderText != "GrandTotal" && dataGridView1.Columns[b].Name != "colFeetaggingid" && dataGridView1.Columns[b].Name != "colClassid" && dataGridView1.Columns[b].Name != "colSectionid" && dataGridView1.Columns[b].Name != "colStudentid")
                        {
                            if (dataGridView1.Rows[a].Cells[b].Value==null)
                            {
                                decimal val1 = 0;

                                val2 = val1 + val2;
                                dataGridView1.Rows[a].Cells["colTotal"].Value = val2;
                            }
                            else
                            {
                                decimal val1 = Convert.ToDecimal(dataGridView1.Rows[a].Cells[b].Value);

                                val2 = val1 + val2;
                                dataGridView1.Rows[a].Cells["colTotal"].Value = val2;
                            }
                        }

                        decimal val3 = Convert.ToDecimal(dataGridView1.Rows[a].Cells["colSystemDue"].Value.ToString());
                        dataGridView1.Rows[a].Cells["colGrandTotal"].Value = val2 + val3;
                    }

                }




                //for ( int i = 0; i < dtstf.Rows.Count; i++)
                //{
                //        dataGridView1.Rows.Add();

                //    dataGridView1.Rows[i].Cells["colSN"].Value = i + 1;
                //    dataGridView1.Rows[i].Cells["colFeetaggingid"].Value = dtstf.Rows[i]["Feetaggingid"].ToString();
                //    dataGridView1.Rows[i].Cells["colClassid"].Value = dtstf.Rows[i]["Classid"].ToString();
                //    dataGridView1.Rows[i].Cells["colSectionid"].Value = dtstf.Rows[i]["Sectionid"].ToString();
                //    dataGridView1.Rows[i].Cells["colStudentid"].Value = dtstf.Rows[i]["Studentid"].ToString();
                //    dataGridView1.Rows[i].Cells["colStudentName"].Value = dtstf.Rows[i]["StudentName"].ToString();
                //}

            }

        }
        private void Feetagging_Load(object sender, EventArgs e)
        {
            LoadClassandSection();
            //LoadDataGrid();
            dataGridView1.Columns["colStudentName"].ReadOnly = true;
            dataGridView1.Columns["colSN"].ReadOnly = true;
            dataGridView1.Columns["colTotal"].ReadOnly = true;
            dataGridView1.Columns["colSystemDue"].ReadOnly = true;
            dataGridView1.Columns["colGrandTotal"].ReadOnly = true;

            loadgrid();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataTable dt1 = blf.getFeeRate(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
           
            string name = "";
            decimal amount = 0;
            decimal val1 = 0;
            decimal val2 = 0;
            if (dt1.Rows.Count > 0)
             {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    amount = 0;
                    val1 = 0;
                    val2 = 0;
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {

                        for (int k = 0; k < dataGridView1.Columns.Count; k++)
                        {
                           
                            if (dataGridView1.Columns[k].HeaderText != "SN" && dataGridView1.Columns[k].HeaderText != "StudentName" && dataGridView1.Columns[k].HeaderText != "Total" && dataGridView1.Columns[k].HeaderText != "SystemDue" && dataGridView1.Columns[k].HeaderText != "GrandTotal" && dataGridView1.Columns[k].Name != "colFeetaggingid" && dataGridView1.Columns[k].Name != "colClassid" && dataGridView1.Columns[k].Name != "colSectionid" && dataGridView1.Columns[k].Name != "colStudentid")
                            {
                               
                                name = dt1.Rows[i][0].ToString();
                                dataGridView1.Rows[j].Cells[k].Value = name;
                                i++;
                                amount = amount + Convert.ToDecimal(dataGridView1.Rows[j].Cells[k].Value);               

                            }        
                                
                        }
                        DataTable dtbc = blbp.getBillClaimDetails(Convert.ToInt32(dataGridView1.Rows[j].Cells["colStudentid"].Value));
                        DataTable dtbd = blbp.getBillingDetails(Convert.ToInt32(dataGridView1.Rows[j].Cells["colStudentid"].Value));
                        //decimal total = 0M;
                        if (dtbd.Rows.Count == 0)
                        {
                            dataGridView1.Rows[j].Cells["colSystemDue"].Value = 0;
                        }
                        else
                        {
                            
                            val1 = val1 + Convert.ToDecimal(dtbc.Rows[i-1]["Amount"].ToString());
                           
                            val2 = val2 + Convert.ToDecimal(dtbd.Rows[i-1]["Payment"].ToString());
                        
                        }
                        dataGridView1.Rows[j].Cells["colTotal"].Value = Convert.ToString(amount);
                        dataGridView1.Rows[j].Cells["colSystemDue"].Value = Convert.ToString(val1 - val2);
                        dataGridView1.Rows[j].Cells["colGrandTotal"].Value =Convert.ToString(Convert.ToDecimal(dataGridView1.Rows[j].Cells["colTotal"].Value) + Convert.ToDecimal(dataGridView1.Rows[j].Cells["colSystemDue"].Value));
                    }

                 }

                ////////loading total systemdue and grandtotal
                //////decimal val2 = 0;
                //////for (int a = 0; a < dataGridView1.Rows.Count; a++)
                //////{
                //////    val2 = 0;
                //////    for (int b = 0; b < dataGridView1.Columns.Count; b++)
                //////    {
                //////        if (dataGridView1.Columns[b].HeaderText != "SN" && dataGridView1.Columns[b].HeaderText != "StudentName" && dataGridView1.Columns[b].HeaderText != "Total" && dataGridView1.Columns[b].HeaderText != "SystemDue" && dataGridView1.Columns[b].HeaderText != "GrandTotal" && dataGridView1.Columns[b].Name != "colFeetaggingid" && dataGridView1.Columns[b].Name != "colClassid" && dataGridView1.Columns[b].Name != "colSectionid" && dataGridView1.Columns[b].Name != "colStudentid")
                //////        {
                //////            decimal val1 = Convert.ToDecimal(dataGridView1.Rows[a].Cells[b].Value);

                //////            val2 = val1 + val2;
                //////            dataGridView1.Rows[a].Cells["colTotal"].Value = val2;
                           
                //////            if (cboStudentName.SelectedIndex != 0)
                //////            {
                //////                //DataTable dtdue1 = blc.getSystemDuebyStudentid(Convert.ToInt32(cboStudentName.SelectedValue));
                //////                //if (dtdue1.Rows.Count == 0)
                //////                //{
                //////                //    dataGridView1.Rows[a].Cells["colSystemDue"].Value = 0;
                //////                //}
                //////                //else
                //////                //{
                //////                //    if (dtdue1.Rows[a]["Due"].ToString() == string.Empty)
                //////                //    {
                //////                //        dataGridView1.Rows[a].Cells["colSystemDue"].Value = 0;
                //////                //    }
                //////                //    else
                //////                //    {
                //////                //        dataGridView1.Rows[a].Cells["colSystemDue"].Value = dtdue1.Rows[a]["Due"].ToString();
                //////                //    }
                //////                //    //if (string.IsNullOrEmpty(dtdue1.Rows[a]["Due"].ToString()) == true)
                //////                //    //{
                //////                //    //    dataGridView1.Rows[a].Cells["colSystemDue"].Value = 0;
                //////                //    //}
                //////                //    //else
                //////                //    //{
                //////                //    //    dataGridView1.Rows[a].Cells["colSystemDue"].Value = dtdue1.Rows[a]["Due"].ToString();
                //////                //    //}
                //////                //}
                                
                //////                //decimal y = Convert.ToDecimal(dataGridView1.Rows[a].Cells["colSystemDue"].Value.ToString());

                //////                //dataGridView1.Rows[a].Cells["colGrandTotal"].Value = val2 + y;
                //////            }
                //////            else
                //////            {
                //////                //DataTable dtdue1 = blc.getSystemDuebyClass(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
                //////                //if (dtdue1.Rows.Count == 0)
                //////                //{
                //////                //    dataGridView1.Rows[a].Cells["colSystemDue"].Value = 0;
                //////                //}
                //////                //else
                //////                //{
                //////                //    if (dtdue1.Rows[a]["Due"].ToString() == string.Empty)
                //////                //    {
                //////                //        dataGridView1.Rows[a].Cells["colSystemDue"].Value = 0;
                //////                //    }
                //////                //    else
                //////                //    {
                //////                //        dataGridView1.Rows[a].Cells["colSystemDue"].Value = dtdue1.Rows[a]["Due"].ToString();
                //////                //    }
                //////                //    //if (string.IsNullOrEmpty(dtdue1.Rows[a]["Due"].ToString()) == true)
                //////                //    //{
                //////                //    //    dataGridView1.Rows[a].Cells["colSystemDue"].Value = 0;
                //////                //    //}
                //////                //    //else
                //////                //    //{
                //////                //    //    dataGridView1.Rows[a].Cells["colSystemDue"].Value = dtdue1.Rows[a]["Due"].ToString();
                //////                //    //}
                //////                //}
                //////                //if (string.IsNullOrEmpty(dtdue1.Rows[a]["Due"].ToString()) == true)
                //////                //{
                //////                //    dataGridView1.Rows[a].Cells["colSystemDue"].Value = 0;
                //////                //}
                //////                //else
                //////                //{
                //////                //    dataGridView1.Rows[a].Cells["colSystemDue"].Value = dtdue1.Rows[a]["Due"].ToString();
                //////                //}
                //////                //decimal val3 = Convert.ToDecimal(dataGridView1.Rows[a].Cells["colSystemDue"].Value.ToString());
                //////                //dataGridView1.Rows[a].Cells["colGrandTotal"].Value = val2 + val3;
                //////            }
                //////            ////////////// load system due new way starts
                //////            BllBillPayment blbp = new BllBillPayment();
                //////            DataTable dtbc = blbp.getBillClaimDetails(Convert.ToInt32(cboStudentName.SelectedValue));
                //////            DataTable dtbd = blbp.getBillingDetails(Convert.ToInt32(cboStudentName.SelectedValue));
                //////            decimal amount = 0M;


                //////            if (dtbd.Rows.Count == 0)
                //////            {
                //////                dataGridView1.Rows[a].Cells["colSystemDue"].Value = Convert.ToString(Convert.ToDecimal(dtbc.Rows[a]["Amount"]));
                //////                //amount = amount + Convert.ToDecimal(dtbc.Rows[i]["Amount"].ToString());
                //////                //amount = amount + Convert.ToDecimal(dataGridView1.Rows[a].Cells["colAmount"].Value);
                //////            }
                //////            else
                //////            {
                //////                dataGridView1.Rows[a].Cells["colSystemDue"].Value = Convert.ToString(Convert.ToDecimal(dtbc.Rows[a]["Amount"]) - Convert.ToDecimal(dtbd.Rows[a]["Payment"]));
                //////                //amount = amount + Convert.ToDecimal(dtbc.Rows[i]["Amount"].ToString());
                //////                //  amount = amount + Convert.ToDecimal(dataGridView1.Rows[a].Cells["colAmount"].Value);
                //////            }


                //////            /////////load system due new way ends
                //////        }

                //////    }

                //////}
                //
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //int b = 0;
            //int k = 0;
            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //{
            //    for (int j = 0; j < dataGridView1.Rows.Count; j++)
            //    {

            //        if (dataGridView1.Columns[i].HeaderText != "SN" && dataGridView1.Columns[i].HeaderText != "StudentName" && dataGridView1.Columns[i].HeaderText != "Total" && dataGridView1.Columns[i].HeaderText != "SystemDue" && dataGridView1.Columns[i].HeaderText != "GrandTotal" && dataGridView1.Columns[i].Name != "colFeetaggingid" && dataGridView1.Columns[i].Name != "colClassid" && dataGridView1.Columns[i].Name != "colSectionid" && dataGridView1.Columns[i].Name != "colStudentid")
            //         {
            //            if (dataGridView1.Rows[j].Cells[i].Value == null)
            //            {
            //                dataGridView1.Rows[j].Cells[i].Value = k;
            //            }


            //            int a = blf.insertFeeHeadInFeetaggintable(dataGridView1.Columns[i].HeaderText.ToString(), dataGridView1.Rows[j].Cells[i].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[j].Cells["colStudentid"].Value));
            //            if (a > 0)
            //            {     
            //                b++;
            //            }
            //        }

            //    }

            //}
            //      MessageBox.Show(Convert.ToString(b));



            int b = 0;
            int k = 0;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {

                    if (dataGridView1.Columns[i].HeaderText != "SN" && dataGridView1.Columns[i].HeaderText != "StudentName"  && dataGridView1.Columns[i].HeaderText != "GrandTotal" && dataGridView1.Columns[i].Name != "colFeetaggingid" && dataGridView1.Columns[i].Name != "colClassid" && dataGridView1.Columns[i].Name != "colSectionid" && dataGridView1.Columns[i].Name != "colStudentid")
                    {
                        if (dataGridView1.Rows[j].Cells[i].Value == null)
                        {
                            dataGridView1.Rows[j].Cells[i].Value = k;
                        }


                        int a = blf.insertFeeHeadInFeetaggintable(dataGridView1.Columns[i].HeaderText.ToString(), dataGridView1.Rows[j].Cells[i].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[j].Cells["colStudentid"].Value));
                        if (a > 0)
                        {
                            b++;
                        }
                    }

                }

            }
            MessageBox.Show(Convert.ToString(b));





            //int y = 0;
            //for (int j = 0; j < dataGridView1.Rows.Count; j++)
            //{
            //   int x= blf.insertTotalInFeetaggintable(dataGridView1.Rows[j].Cells["colTotal"].ToString(), Convert.ToInt32(dataGridView1.Rows[j].Cells["colStudentid"].Value.ToString()));
            //    if (x > 0)
            //    {
            //        y++;
            //    }
            //}
            //MessageBox.Show(Convert.ToString(y));
        }

        private void cboClass_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex != 0 || cboSection.SelectedIndex != 0)
            {
                //    LoadDataGrid();
                loadgrid();
                //for (int i = 0; i < dataGridView1.Columns.Count; i++)
                //{
                //    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                //    {
                //        if (dataGridView1.Rows[j].Cells[i].Value == null)
                //        {
                //            if (dataGridView1.Columns[i].HeaderText != "SN" && dataGridView1.Columns[i].HeaderText != "StudentName" && dataGridView1.Columns[i].HeaderText != "Total" && dataGridView1.Columns[i].HeaderText != "SystemDue" && dataGridView1.Columns[i].HeaderText != "GrandTotal" && dataGridView1.Columns[i].Name != "colFeetaggingid" && dataGridView1.Columns[i].Name != "colClassid" && dataGridView1.Columns[i].Name != "colSectionid" && dataGridView1.Columns[i].Name != "colStudentid")
                //            {
                //                dataGridView1.Rows[j].Cells[i].Value = 0;
                //            }
                //        }
                //    }
                //}


            }
        }
        private void cboSection_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
            {
                //LoadDataGrid();
                loadgrid();


                //for (int i = 0; i < dataGridView1.Columns.Count; i++)
                //{
                //    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                //    {
                //        if (dataGridView1.Rows[j].Cells[i].Value == null)
                //        {
                //            if (dataGridView1.Columns[i].HeaderText != "SN" && dataGridView1.Columns[i].HeaderText != "StudentName" && dataGridView1.Columns[i].HeaderText != "Total" && dataGridView1.Columns[i].HeaderText != "SystemDue" && dataGridView1.Columns[i].HeaderText != "GrandTotal" && dataGridView1.Columns[i].Name != "colFeetaggingid" && dataGridView1.Columns[i].Name != "colClassid" && dataGridView1.Columns[i].Name != "colSectionid" && dataGridView1.Columns[i].Name != "colStudentid")
                //            {
                //                dataGridView1.Rows[j].Cells[i].Value = 0;
                //            }
                //        }
                //    }
                //}

            }
        }
        private void cboSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex != 0 && cboSection.SelectedIndex != 0)
            {
                //LoadDataGrid();
                loadgrid();


                //for (int i = 0; i < dataGridView1.Columns.Count; i++)
                //{
                //    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                //    {
                //        if (dataGridView1.Rows[j].Cells[i].Value == null)
                //        {
                //            if (dataGridView1.Columns[i].HeaderText != "SN" && dataGridView1.Columns[i].HeaderText != "StudentName" && dataGridView1.Columns[i].HeaderText != "Total" && dataGridView1.Columns[i].HeaderText != "SystemDue" && dataGridView1.Columns[i].HeaderText != "GrandTotal" && dataGridView1.Columns[i].Name != "colFeetaggingid" && dataGridView1.Columns[i].Name != "colClassid" && dataGridView1.Columns[i].Name != "colSectionid" && dataGridView1.Columns[i].Name != "colStudentid")
                //            {
                //                dataGridView1.Rows[j].Cells[i].Value = 0;
                //            }
                //        }
                //    }
                //}

            }
        }
        
       
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal val2 = 0;
            
           
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                 if (dataGridView1.Columns[i].HeaderText != "SN" && dataGridView1.Columns[i].HeaderText != "StudentName" && dataGridView1.Columns[i].HeaderText != "Total" && dataGridView1.Columns[i].HeaderText != "SystemDue" && dataGridView1.Columns[i].HeaderText != "GrandTotal" && dataGridView1.Columns[i].Name != "colFeetaggingid" && dataGridView1.Columns[i].Name != "colClassid" && dataGridView1.Columns[i].Name != "colSectionid" && dataGridView1.Columns[i].Name != "colStudentid")
                {
                   decimal  val1 = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[i].Value);
                    
                    val2 = val1 + val2;
                    dataGridView1.Rows[e.RowIndex].Cells["colTotal"].Value =  val2;
                  
                }
                //string abc = dataGridView1.Rows[e.RowIndex].Cells["colSystemDue"].Value.ToString();
                //if (abc == string.Empty)
                //{
                //    abc = "0";
                //}
                decimal val3 = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["colSystemDue"].Value.ToString());
                dataGridView1.Rows[e.RowIndex].Cells["colGrandTotal"].Value = val2 + val3;
            }

        }

        private void cboStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStudentName.SelectedIndex > 0)
            {
                dataGridView1.Rows.Clear();
                DataTable dtnew = cs.GetAllStudentbyClassidandSectionidandStudentid(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue),Convert.ToInt32(cboStudentName.SelectedValue));

                
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[0].Cells["colSN"].Value = 1;
                        dataGridView1.Rows[0].Cells["colFeetaggingid"].Value = dtnew.Rows[0]["Feetaggingid"].ToString();
                        dataGridView1.Rows[0].Cells["colClassid"].Value = dtnew.Rows[0]["Classid"].ToString();
                        dataGridView1.Rows[0].Cells["colSectionid"].Value = dtnew.Rows[0]["Sectionid"].ToString();
                        dataGridView1.Rows[0].Cells["colStudentid"].Value = dtnew.Rows[0]["Studentid"].ToString();

                        dataGridView1.Rows[0].Cells["colStudentName"].Value = dtnew.Rows[0]["StudentName"].ToString();
                   

            }
            else
            {
                loadgrid();
            }
        }




        BllClaimBill blc = new BllClaimBill();
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboStudentName.SelectedIndex == 0)
                {
                    DataTable dt1 = blc.getAllFeeTaggingDetail(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));

                    if (dt1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dt1.Columns.Count; j++)
                            {
                                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                                {
                                    if (dataGridView1.Columns[k].HeaderText == dt1.Columns[j].ColumnName)
                                    {
                                        dataGridView1.Rows[i].Cells[k].Value = dt1.Rows[i][j].ToString();
                                        dataGridView1.Rows[i].Cells["colGrandTotal"].Value = Convert.ToString(Convert.ToDecimal(dataGridView1.Rows[i].Cells["colTotal"].Value) + Convert.ToDecimal(dataGridView1.Rows[i].Cells["colSystemDue"].Value));

                                    }
                                }
                            }
                        }
                    }
                    //if (dt1.Rows.Count > 0)
                    //{
                    //    for (int i = 0; i < dt1.Rows.Count; i++)
                    //    {
                    //        for (int j = 0; j < dt1.Columns.Count; j++)
                    //        {
                    //            for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    //            {
                    //                if (dataGridView1.Columns[k].HeaderText == dt1.Columns[j].ColumnName)
                    //                {

                    //                    //dataGridView1.Rows[i].Cells[k].Value = dt1.Rows[i][j].ToString();



                    //                    //if (cboStudentName.SelectedIndex == 0)
                    //                    //{
                    //                    //    //DataTable dtdue2 = blc.getSystemDuebyClass(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue));
                    //                    //    //if (dtdue2.Rows.Count == 0)
                    //                    //    //{
                    //                    //    //    dataGridView1.Rows[i].Cells["colSystemDue"].Value = 0;
                    //                    //    //}
                    //                    //    //else
                    //                    //    //{
                    //                    //    //    //if (dtdue2.Rows[i]["Due"].ToString() == string.Empty)
                    //                    //    //    //{
                    //                    //    //    //    dataGridView1.Rows[i].Cells["colSystemDue"].Value = 0;
                    //                    //    //    //}
                    //                    //    //    //else
                    //                    //    //    //{
                    //                    //    //    //    dataGridView1.Rows[i].Cells["colSystemDue"].Value = dtdue2.Rows[i]["Due"].ToString();
                    //                    //    //    //}
                    //                    //    //    if (string.IsNullOrEmpty(dtdue2.Rows[i]["Due"].ToString())==true)
                    //                    //    //    {
                    //                    //    //        dataGridView1.Rows[i].Cells["colSystemDue"].Value = 0;
                    //                    //    //    }
                    //                    //    //    else
                    //                    //    //    {
                    //                    //    //        dataGridView1.Rows[i].Cells["colSystemDue"].Value = dtdue2.Rows[i]["Due"].ToString();
                    //                    //    //    }
                    //                    //    //}
                    //                    //}
                    //                    ////decimal val1 = Convert.ToDecimal(dataGridView1.Rows[i].Cells["colTotal"].Value.ToString());
                    //                    ////decimal val2 = Convert.ToDecimal(dataGridView1.Rows[i].Cells["colSystemDue"].Value);

                    //                    ////dataGridView1.Rows[i].Cells["colGrandTotal"].Value= val1 + val2;
                    //                }
                    //            }

                    //        }
                    //    }

                    //}
                    ////loading total systemdue and grandtotal


                    ////

                }
                else
                {
                    DataTable dt1 = blc.getAllFeeTaggingDetails(Convert.ToInt32(cboClass.SelectedValue), Convert.ToInt32(cboSection.SelectedValue), Convert.ToInt32(cboStudentName.SelectedValue));

                    if (dt1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dt1.Columns.Count; j++)
                            {
                                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                                {
                                    if (dataGridView1.Columns[k].HeaderText == dt1.Columns[j].ColumnName)
                                    {
                                        dataGridView1.Rows[i].Cells[k].Value = dt1.Rows[i][j].ToString();
                                        dataGridView1.Rows[i].Cells["colGrandTotal"].Value = Convert.ToString(Convert.ToDecimal(dataGridView1.Rows[i].Cells["colTotal"].Value) + Convert.ToDecimal(dataGridView1.Rows[i].Cells["colSystemDue"].Value));
                                    }
                                }
                            }
                        }
                    }
                    //if (dt1.Rows.Count > 0)
                    //{
                    //    for (int i = 0; i < dt1.Rows.Count; i++)
                    //    {
                    //        for (int j = 0; j < dt1.Columns.Count; j++)
                    //        {
                    //            for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    //            {
                    //                if (dataGridView1.Columns[k].HeaderText == dt1.Columns[j].ColumnName)
                    //                {

                    //                    //dataGridView1.Rows[i].Cells[k].Value = dt1.Rows[i][j].ToString();

                    //                    //if (cboStudentName.SelectedIndex != 0)
                    //                    //{
                    //                    //    //DataTable dtdue1 = blc.getSystemDuebyStudentid(Convert.ToInt32(cboStudentName.SelectedValue));
                    //                    //    //if (dtdue1.Rows.Count == 0)
                    //                    //    //{
                    //                    //    //    dataGridView1.Rows[i].Cells["colSystemDue"].Value = 0;
                    //                    //    //}
                    //                    //    //else
                    //                    //    //{
                    //                    //    //    if (dtdue1.Rows[i]["Due"].ToString() == string.Empty)
                    //                    //    //    {
                    //                    //    //        dataGridView1.Rows[i].Cells["colSystemDue"].Value = 0;
                    //                    //    //    }
                    //                    //    //    else
                    //                    //    //    {
                    //                    //    //        dataGridView1.Rows[i].Cells["colSystemDue"].Value = dtdue1.Rows[i]["Due"].ToString();
                    //                    //    //    }
                    //                    //    //}
                    //                    //    decimal val1 = Convert.ToDecimal(dt1.Rows[i]["Total"].ToString());
                    //                    //    decimal val2 = Convert.ToDecimal(dataGridView1.Rows[i].Cells["colSystemDue"].Value.ToString());

                    //                    //    dataGridView1.Rows[i].Cells["colGrandTotal"].Value = val1 + val2;
                    //                    //}
                    //                }
                    //            }

                    //        }
                    //    }

                    //}
                    ////loading total systemdue and grandtotal

                    ////

                }

            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }

        }
    }
    
}
