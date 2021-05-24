using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.eContactClasses
{
    class contactClass
    {
        //getter and setter properties
        //acts as Data Carrier in application
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        // selecting data from database

        public DataTable Select()
        {
            //step 1 Database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                //step 2 writing sql queries
                string sql = "SELECT * FROM tbl_contact";
                //creating connection using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);


            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        //Inserting data into the database

        public bool Insert (contactClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;

            //step 1 connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //step 2 create a SQL query to insert Data
                string sql = "INSERT INTO tbl_contact(FirstName, LastName, ContactNo, Address, Gender) VALUES (@FirstName, @LastName, @ContactNo, @Address, @Gender)";

                //creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating parameter to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                // if the query runs successfully, then the value of the rows will be greater than zero else the value will be zero
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        // method to update data from the application

        public bool Update(contactClass c)
        {
            // create a default value return type and set its defaults to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try 
            {
                //sql to update database
                string sql = "UPDATE tbl_contact SET FirstName=@FirstName, LastName=LastName, ContactNo=@ContactNo, Address=@Address, Gender=@Gender WHERE ContactID = @ContactID";

                //creating sql command 
                SqlCommand cmd = new SqlCommand(sql,conn);

                //create parameter to add value
                cmd.Parameters.AddWithValue("Firstname", c.FirstName);
                cmd.Parameters.AddWithValue("LastName", c.LastName);
                cmd.Parameters.AddWithValue("ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("Address", c.Address);
                cmd.Parameters.AddWithValue("Gender", c.Gender);
                cmd.Parameters.AddWithValue("ContactID", c.ContactId);

                //open database connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                // if the query runs successfully, then the value of the rows will be greater than zero else the value will be zero
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex) { }
            finally
            {
                conn.Close();
            }


            return isSuccess;
        }


        //mrthod to delete a data from database

        public bool detele(contactClass c)
        {
            //create a default return value and set its value to false

            bool isSuccess = false;

            //create sql connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM tbl_contact WHERE ContactID= @ContactID";

                //create a sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ContactId", c.ContactId);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }



            return isSuccess;
        }
    }
}
