using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class BllFee
    {
        public int insertintoFeetagging( int classid, int sectionid, int studentid, string studentname)
        {
            string sql = "insert into tblFeetagging ( Classid, Sectionid, Studentid,StudentName) values(@a,@b,@c,@d)";
            SqlParameter[] param = new SqlParameter[]
          {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionid),
                new SqlParameter("@c",studentid),
                new SqlParameter("@d",studentname)
              
          };
            return DAO.IUD(sql, param,System.Data.CommandType.Text);
        }
        public int createFeeHead(string feehead)
        {

                  string sql = "Alter table tblFeetagging add "+feehead+"_Fee"+" nvarchar(50)";
           
            return DAO.IUD(sql, null, System.Data.CommandType.Text);

        }
        public DataTable getFeeHead()
        {
            string sql = "SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('dbo.tblFeeTagging') and name!='Feetaggingid' and name!='StudentName' and name!='Classid' and name!='Sectionid' and name!='Studentid'";
            return DAO.GetDatatable(sql, null);

        }
        public int updateFeeHead(string feehead, string newfeehead)
        {
            string sql = "sp_rename 'tblFeetagging." + feehead + "', '" + newfeehead + "', 'COLUMN';";

            return DAO.IUD(sql, null, System.Data.CommandType.Text);

        }
        public DataTable getFee()
        {
            string sql = "SELECT tblFee.FeeHead, tblFee.FeeType, tblFee.FeeRate, tblFee.Feeid, tblClass.Class, tblSection.Section FROM tblClass INNER JOIN tblFee ON tblClass.Classid = tblFee.Classid INNER JOIN tblSection ON tblFee.Sectionid = tblSection.Sectionid";
            return DAO.GetDatatable(sql, null);

        }
        public int InsertFeeSetup(int classid, int sectionid, string feehead, string feetype, decimal feerate)
        {
            string sql = "Insert into tblFee (Classid, Sectionid, FeeHead, FeeType,FeeRate) values(@a,@b,@c,@d,@e)";
            SqlParameter[] param = new SqlParameter[]
         {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionid),
                new SqlParameter("@c",feehead),
                new SqlParameter("@d",feetype),
                 new SqlParameter("@e",feerate)
         };
            return DAO.IUD(sql, param, System.Data.CommandType.Text);
        }
        public int UpdateFeeSetup(int classid, int sectionid, string feehead, string feetype, decimal feerate, int feeid)
        {
            string sql = "Update tblFee set Classid=@a, Sectionid=@b, FeeHead=@c, FeeType=@d, FeeRate=@e where Feeid=@f";
            SqlParameter[] param = new SqlParameter[]
          {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionid),
                new SqlParameter("@c",feehead),
                new SqlParameter("@d",feetype),
                 new SqlParameter("@e",feerate),
                 new SqlParameter("@f",feeid)
          };
            return DAO.IUD(sql, param, System.Data.CommandType.Text);

        }
        public int DeleteFeeSetup(int feeid)
        {
            string sql = "Delete from tblFee where Feeid=@a";
            SqlParameter[] param = new SqlParameter[]
          {
                 new SqlParameter("@a",feeid)
          };
            return DAO.IUD(sql, param, System.Data.CommandType.Text);

        }
        public DataTable getFeeHead(int classid, int sectionid)
        {
            string sql = "SELECT FeeHead from tblFee where Classid=@a and Sectionid=@b";
            SqlParameter[] param = new SqlParameter[]
         {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionid),
         };
            return DAO.GetDatatable(sql, param);


        }
        public DataTable getFeeHeadfordatagrid()
        {
            string sql = "SELECT FeeHead from tblFee";
           
            return DAO.GetDatatable(sql, null);


        }
        public DataTable getForFeetagging(int classid, int sectionid)
        {
            string sql = "Select Feetaggingid, Classid, Sectionid,Studentid ,StudentName from tblFeetagging where Classid=@a and Sectionid=@b";
            SqlParameter[] param = new SqlParameter[]
          {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionid),
          };
            return DAO.GetDatatable(sql, param);
        }
        public DataTable getFeeRate(int classid, int sectionid)
        {
            string sql = "SELECT FeeRate from tblFee where Classid=@a and Sectionid=@b";
            SqlParameter[] param = new SqlParameter[]
         {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionid),
         };
            return DAO.GetDatatable(sql, param);
        }
        
        public int insertFeeHeadInFeetaggintable(string columnname, string value, int studentid)
        {
            string sql = "Update tblFeetagging set "+columnname+"=@b where Studentid=@c ";
            SqlParameter[] param = new SqlParameter[]
         {
               
                new SqlParameter("@b",value),
                new SqlParameter("@c",studentid)
         };
            return DAO.IUD(sql, param, System.Data.CommandType.Text);


        }
        public int insertTotalInFeetaggintable(string value, int studentid)
        {
            string sql = "Update tblFeetagging set Total=@b where Studentid=@c ";
            SqlParameter[] param = new SqlParameter[]
         {

                new SqlParameter("@b",value),
                new SqlParameter("@c",studentid)
         };
            return DAO.IUD(sql, param, System.Data.CommandType.Text);


        }
        public DataTable getStudentsforfeetagging(int classid, int sectionid)
        {
            string sql = "SELECT Feetaggingid,Classid,Sectionid,Studentid,StudentName from tblFeetagging where Classid=@a and Sectionid=@b";
            SqlParameter[] param = new SqlParameter[]
         {
                new SqlParameter("@a",classid),
                new SqlParameter("@b",sectionid),
         };
            return DAO.GetDatatable(sql, param);


        }
    }
}
