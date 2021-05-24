using Econtact.eContactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econtact
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }

        contactClass c = new contactClass();
        private void Econtact_Load(object sender, EventArgs e)
        {
            //load data in table
            DataTable dt = c.Select();
            dataGridViewContactList.DataSource = dt;
        }
        //method to clear vields
        public void Clear()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxContactNo.Text = "";
            textBoxAddress.Text = "";
            comboBoxGender.Text = "";
            textBoxContactId.Text = "";
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //get the value from the input fields
            c.FirstName = textBoxFirstName.Text;
            c.LastName = textBoxLastName.Text;
            c.ContactNo = textBoxContactNo.Text;
            c.Address = textBoxAddress.Text;
            c.Gender = comboBoxGender.Text;


            //inserting data into database 
            bool success = c.Insert(c);
            if (success == true)
            {
                //successfully inserted
                MessageBox.Show("New contact successfully inserted!!!");
                //call the clear method here
                Clear();

            }
            else
            {
                MessageBox.Show("Faild to add new contact.");
            }

            //load data in table
            DataTable dt = c.Select();
            dataGridViewContactList.DataSource = dt;
        }

      

       

        

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //get the data from text boxes
            c.ContactId = int.Parse(textBoxContactId.Text);
            c.FirstName = textBoxFirstName.Text;
            c.LastName = textBoxLastName.Text;
            c.ContactNo = textBoxContactNo.Text;
            c.Address = textBoxAddress.Text;
            c.Gender = comboBoxGender.Text;

            //update the data in database
            bool success = c.Update(c);
            if (success = true)
            {
                //update successfully
                MessageBox.Show("Contact has been successfully updated!!!");
                //load data in table
                DataTable dt = c.Select();
                dataGridViewContactList.DataSource = dt;
                Clear();

            }
            else
            {
                MessageBox.Show("Failed to update contact!!");
            }
            
        }

        private void dataGridViewContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from the drid view and load it to the text boxes
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            textBoxContactId.Text = dataGridViewContactList.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridViewContactList.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewContactList.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxContactNo.Text = dataGridViewContactList.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridViewContactList.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxGender.Text = dataGridViewContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //call clear method here
            Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //get data from the text box
            c.ContactId = Convert.ToInt32(textBoxContactId.Text);
            bool success = c.detele(c);
            if (success = true)
            {
                MessageBox.Show("The data has been suvvessfully deleted.");
                Clear();
                //load data in table
                DataTable dt = c.Select();
                dataGridViewContactList.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //get the value from textbox
            string keyword = textBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword+"%' OR LastName LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword+"%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewContactList.DataSource = dt;
        }
    }
}
