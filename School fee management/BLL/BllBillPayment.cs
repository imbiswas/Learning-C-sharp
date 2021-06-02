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
    public class BllBillPayment
    {
        public DataTable getStudentsForPayment(int classid, int sectionid)
        {
            string sql = "select * from tblStudent where Classid=@a and Sectionid=@b";
            SqlParameter[] param = new SqlParameter[]
        {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionid)
        };
            return DAO.GetDatatable(sql, param);


        }
        public DataTable getBillClaimDetails(int studentid)
        {
            string sql = "select  o.FeeHead, count(*) as Count, sum(o.Amount) as Amount from tblBillClaimDetails o where Studentid=@a group BY o.Feehead";
            SqlParameter[] param = new SqlParameter[]
        {
                new SqlParameter("@a",studentid)
        };
            return DAO.GetDatatable(sql, param);


        }
        public int insertinBilling(int classid, int sectionid, int studentid, decimal claimamount,decimal payment, decimal due, decimal discount,decimal advance)
        {
            string sql = "Insert into tblBilling(Classid,Sectionid,Studentid,ClaimAmount,Payment,Discount,Due,Advance) values (@a,@b,@c,@d,@e,@f,@g,@h)";
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@a", classid);
            param[1] = new SqlParameter("@b", sectionid);
            param[2] = new SqlParameter("@c", studentid);
            param[3] = new SqlParameter("@d", claimamount);
            param[4] = new SqlParameter("@e", payment);
            param[5] = new SqlParameter("@f", discount);
            param[6] = new SqlParameter("@g", due);
            param[7] = new SqlParameter("@h", advance); 
            //param[8] = new SqlParameter("@i", SqlDbType.Int);
            //param[8].Direction = ParameterDirection.Output;


            return DAO.IUD(sql, param, CommandType.Text);


        }
        public DataTable getBilling(int studentid)
        {
            string sql = "select top(1) *  from tblBilling  where Studentid=@a ORDER BY 1 DESC ";
            SqlParameter[] param = new SqlParameter[]
        {
                new SqlParameter("@a",studentid)
        };
            return DAO.GetDatatable(sql, param);


        }
        public DataTable getBillingDetails(int studentid)
        {
            string sql = "select  o.FeeHead, count(*) as Count,( sum(o.PaidAmount) + sum(o.Discount) ) as Payment from tblBillingDetails o where Studentid=@a group BY o.Feehead";
            SqlParameter[] param = new SqlParameter[]
        {
                new SqlParameter("@a",studentid)
        };
            return DAO.GetDatatable(sql, param);


        }
        public int insertinBillingDetails(int billid,int classid, int sectionid, int studentid, string billdate,string month,string feehead,decimal amount,decimal discount)
        {
            string sql = "Insert into tblBillingDetails (Billid,Classid,Sectionid,Studentid,BillDate,Month,FeeHead,PaidAmount,Discount) values (@a,@b,@c,@d,@e,@f,@g,@h,@i)";
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@a", billid);
            param[1] = new SqlParameter("@b", classid);
            param[2] = new SqlParameter("@c", sectionid);
            param[3] = new SqlParameter("@d", studentid);
            param[4] = new SqlParameter("@e", billdate);
            param[5] = new SqlParameter("@f", month);
            param[6] = new SqlParameter("@g", feehead);
            param[7] = new SqlParameter("@h", amount);
            param[8] = new SqlParameter("@i", discount);
         


            return DAO.IUD(sql, param, CommandType.Text);


        }
    }
}
