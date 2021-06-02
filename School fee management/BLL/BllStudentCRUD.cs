using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class BllStudentCRUD
    {
        public DataTable GetClass()
        {
            string sql = "select * from tblClass";
            return DAO.GetDatatable(sql, null);
        }
        public DataTable GetSection()
        {
          string sql = "select * from tblSection";
            return DAO.GetDatatable(sql, null);
        }
        public int InsertStudent(string StudentName, string Address,string Guardian, string Contact, int Classid, int Sectionid)
        {
            string sql = "sp_insertstudent";
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@studentname", StudentName);
            param[1] = new SqlParameter("@address", Address);
            param[2] = new SqlParameter("@guardian", Guardian);
            param[3] = new SqlParameter("@contact", Contact);
            param[4] = new SqlParameter("@classid", Classid);
            param[5] = new SqlParameter("@sectionid", Sectionid);

            param[6] = new SqlParameter("@studentid", SqlDbType.Int);
            param[6].Direction = ParameterDirection.Output;





            return DAO.IUD(sql, param,CommandType.StoredProcedure);
        }
        public DataTable GetAllStudent()
        {
            SqlConnection conn = new SqlConnection("Data Source=IUCS\\SQLEXPRESS;Initial Catalog=BIAttendance;Integrated Security=True;Pooling=False");
            string sql = "SELECT tblClass.Class, tblSection.Section, tblStudent.Studentid, tblStudent.StudentName,tblStudent.Guardian, tblStudent.Address, tblStudent.Contact FROM tblClass INNER JOIN tblStudent ON tblClass.Classid = tblStudent.Classid INNER JOIN tblSection ON tblStudent.Sectionid = tblSection.Sectionid";
            return DAO.GetDatatable(sql, null);
        }
        public DataTable GetAllStudentbyStudentid(int studentid)
        {
            string sql = "SELECT * from tblStudent where Studentid=@a";
            SqlParameter[] param = new SqlParameter[]
           {
               new SqlParameter("@a",studentid)
           };
            return DAO.GetDatatable(sql, param);
        }
        public DataTable GetAllStudentbyClassidandSectionid(int classid,int sectionid)
        {
            string sql = "SELECT * from tblStudent where Classid=@a and Sectionid=@b";
            SqlParameter[] param = new SqlParameter[]
           {
               new SqlParameter("@a",classid),
               new SqlParameter("@b",sectionid)
           };
            return DAO.GetDatatable(sql, param);
        }
        public DataTable GetAllStudentbyClassidandSectionidandStudentid(int classid, int sectionid,int studentid)
        {
            string sql = "SELECT * from tblFeetagging where Classid=@a and Sectionid=@b and Studentid=@c";
            SqlParameter[] param = new SqlParameter[]
           {
               new SqlParameter("@a",classid),
               new SqlParameter("@b",sectionid),
               new SqlParameter("@c",studentid)
           };
            return DAO.GetDatatable(sql, param);
        }
        public DataTable GetStudentbyClassidandSectionidandStudentid(int classid, int sectionid)
        {
            string sql = "SELECT * from tblFeetagging where Classid=@a and Sectionid=@b ";
            SqlParameter[] param = new SqlParameter[]
           {
               new SqlParameter("@a",classid),
               new SqlParameter("@b",sectionid)
           };
            return DAO.GetDatatable(sql, param);
        }
        public int UpdateStudent(int Studentid, string StudentName, string Address,string Guardian, string Contact, int Classid, int Sectionid)
        {
            string sql = "Update tblStudent set StudentName=@a,Address=@b,Guardian=@c,Contact=@d,Classid=@e,Sectionid=@f where Studentid=@g";
            SqlParameter[] param = new SqlParameter[]
             {
                new SqlParameter("@a",StudentName),
                new SqlParameter("@b",Address),
                new SqlParameter("@c",Guardian),
                new SqlParameter("@d",Contact),
                new SqlParameter("@e",Classid),
                new SqlParameter("@f",Sectionid),
                new SqlParameter("@g",Studentid)
             };
            return DAO.IUD(sql, param,CommandType.Text);
        }
        public int UpdateStudentatfeetagging(int Studentid, string StudentName, int Classid, int Sectionid)
        {
            string sql = "Update tblFeetagging set StudentName=@a,Classid=@b,Sectionid=@c where Studentid=@d";
            SqlParameter[] param = new SqlParameter[]
             {
                new SqlParameter("@a",StudentName),
                new SqlParameter("@b",Classid),
                new SqlParameter("@c",Sectionid),
                new SqlParameter("@d",Studentid)
             };
            return DAO.IUD(sql, param, CommandType.Text);
        }
        public int DeleteStudent(int Studentid)
        {
            string sql = "delete from tblStudent where Studentid=@a";
            SqlParameter[] param = new SqlParameter[]
            {
               
                new SqlParameter("@a",Studentid)
            };
            return DAO.IUD(sql, param,CommandType.Text);
        }
    }
}
