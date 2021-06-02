using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllClaimBill
    {
        public DataTable getMonths()
        {
            string sql = "SELECT * from tblMonth";    
            return DAO.GetDatatable(sql, null);
        }
        public DataTable getTaggedAmount(int studentid)
        {
            string sql = "select Total from tblFeetagging where Studentid=@a";
            SqlParameter[] param = new SqlParameter[]
         {
                new SqlParameter("@a",studentid)
         };
            return DAO.GetDatatable(sql, param);


        }
        public DataTable getAllFeeTaggingDetail(int classid,int sectionnid)
        {
            string sql = "select * from tblFeetagging where Classid=@a and Sectionid=@b ";
            SqlParameter[] param = new SqlParameter[]
        {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionnid)
        };
            return DAO.GetDatatable(sql, param);


        }
        public DataTable getAllFeeTaggingDetails(int classid, int sectionnid, int studentid)
        {
            string sql = "select * from tblFeetagging where Classid=@a and Sectionid=@b and Studentid=@c";
            SqlParameter[] param = new SqlParameter[]
        {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionnid),
                new SqlParameter("@c",studentid)
        };
            return DAO.GetDatatable(sql, param);


        }
        public DataTable getFeeHeadandFeeid(int classid, int sectionid)
        {
            string sql = "SELECT Feeid,FeeHead from tblFee where Classid=@a and Sectionid=@b";
            SqlParameter[] param = new SqlParameter[]
         {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionid),
         };
            return DAO.GetDatatable(sql, param);


        }
        public DataTable getSystemDuebyClass(int classid, int sectionid)
        {
            string sql = "SELECT Due from tblBilling where Classid=@a and Sectionid=@b";
            SqlParameter[] param = new SqlParameter[]
         {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionid),
         };
            return DAO.GetDatatable(sql, param);


        }
        public DataTable getSystemDuebyStudentid(int studentid)
        {
            string sql = "SELECT Due from tblBilling where Studentid=@a ";
            SqlParameter[] param = new SqlParameter[]
         {
                new SqlParameter("@a",studentid)
         };
            return DAO.GetDatatable(sql, param);


        }

        public int insertinBillClaim(int classid,int sectionid,int studentid,int monthid,decimal claimamount, string claimdate,string claimmonth,decimal previousdue)
        {
            string sql = "sp_InsertBillClaim";
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@classid", classid);
            param[1] = new SqlParameter("@sectionid", sectionid);
            param[2] = new SqlParameter("@studentid",studentid);
            param[3] = new SqlParameter("@monthid", monthid);
            param[4] = new SqlParameter("@claimamount", claimamount);
            param[5] = new SqlParameter("@claimdate", claimdate);
            param[6] = new SqlParameter("@claimmonth", claimmonth);
            param[7] = new SqlParameter("@previousdue", previousdue);
           

            return DAO.IUD(sql, param, CommandType.StoredProcedure);


        }
        public DataTable getClamidStudentidfromtblBillClaim()
        {
            string sql = "select top(1) *  from tblBillClaim  ORDER BY 1 DESC ";
         //   SqlParameter[] param = new SqlParameter[]
         //{
         //       new SqlParameter("@a",studentid)
         //};
            return DAO.GetDatatable(sql,null);


        }
        public int insertinBillClaimDetails(int claimid, int studentid,string feehead, decimal amount)
        {
            string sql = "insert into tblBillClaimDetails(Claimid,Studentid,FeeHead,Amount) values(@a,@b,@c,@d)";
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@a", claimid);
            param[1] = new SqlParameter("@b", studentid);
            param[2] = new SqlParameter("@c", feehead);
            param[3] = new SqlParameter("@d", amount);
            return DAO.IUD(sql, param, CommandType.Text);


        }
        public DataTable getBillClaimAllStudents(int classid, int sectionnid,string claimmonth ,int monthid)
        {
            string sql = "select * from tblBillClaim where Classid=@a and Sectionid=@b and ClaimMonth=@c and Monthid<=@d";
            SqlParameter[] param = new SqlParameter[]
        {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionnid),
                new SqlParameter("@c",claimmonth),
                new SqlParameter("@d",monthid)
        };
            return DAO.GetDatatable(sql, param);


        }
        public DataTable getBillClaimbyStudentid(int studentid, string claimmonth, int monthid)
        {
            string sql = "select * from tblBillClaim where Studentid=@a and ClaimMonth=@b and Monthid<=@c";
            SqlParameter[] param = new SqlParameter[]
        {
                new SqlParameter("@a",studentid),
                new SqlParameter("@b",claimmonth),
                new SqlParameter("@c",monthid)
        };
            return DAO.GetDatatable(sql, param);


        }
        public DataTable getMonthid()
        {
            string sql = "select Monthid from tblBillClaim ";
        //    SqlParameter[] param = new SqlParameter[]
        //{
        //        new SqlParameter("@a",studentid),
        //        new SqlParameter("@b",claimmonth),
        //        new SqlParameter("@c",monthid)
        //};
            return DAO.GetDatatable(sql, null);


        }
        public DataTable getBillClaimlist(int classid,int sectionid)
        {
            string sql = " select* from view_listofBillClaim where Classid=@a and Sectionid=@b";
            SqlParameter[] param = new SqlParameter[]
        {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionid)
        };
            return DAO.GetDatatable(sql, param);


        }
        public DataTable getBillClaimlistbyStudentid(int studentid)
        {
            string sql = " select* from view_listofBillClaim where Studentid=@a";
            SqlParameter[] param = new SqlParameter[]
        {
                new SqlParameter("@a",studentid)
        };
            return DAO.GetDatatable(sql, param);


        }
        public DataTable getBillClaimlistbyClaimMonth(string claimmonth)
        {
            string sql = " select* from view_listofBillClaim where ClaimMonth=@a";
            SqlParameter[] param = new SqlParameter[]
        {
                new SqlParameter("@a",claimmonth)
        };
            return DAO.GetDatatable(sql, param);


        }

    }
}
