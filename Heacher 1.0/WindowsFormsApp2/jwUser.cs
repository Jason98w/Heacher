using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    class jwUser
    {

        string jwId;
        string jwName;
        string nickname;
        string nowPassword;
        string telephone;
        string emailNum;

        string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";
        public bool Verify(string jwName, string jwId, string jwPassword )
        {


            string sql = "select * from DEAN Where SNO='" + jwId + "' AND DPASSWORD='" + jwPassword + "' AND SNAME='" + jwName + "'";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataReader msDr = sc.ExecuteReader();
           
            if (msDr.Read())
            {
                this.jwId = jwId;
                this.jwName = jwName;
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool Enroll(string nickname, string nowPassword, string telephone, string emailNum, string nowRePassword)
        {
            Regex reg = new Regex(@"^[a-zA-Z0-9_.-]+@+(qq.com|163.com|126.com)$");

            if (nowPassword.Length < 6)
            {
                return false;
            }
            else if (telephone.Length != 11)
            {
                return false;
            }
            else if(nowPassword != nowRePassword)
            {
                return false;
            }
            else if(!reg.IsMatch(emailNum) )
            {
                return false;
            }
            else
            {
                string sql = @"INSERT INTO [HEACHER].[dbo].[USERS]
           ([SNO]
           ,[SNAME]
           ,[SEMAIL]
           ,[SNICKNAME]
           ,[SSCORE]
           ,[SCREDIT]
           ,[STEL]
           ,[SPASSWORD])
     VALUES
           ('" + jwId + "','" + jwName + "','" + emailNum + "','" + nickname + "'," + 0 + "," + 100 +
              ",'" + telephone + "','" + nowPassword + "')";
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                SqlCommand sc = new SqlCommand(sql, conn);
                SqlDataReader msDr = sc.ExecuteReader();
                if (1 == msDr.FieldCount)
                {

                    conn.Close();
                }
                conn.Close();
            }
            return true;
        }
    }
}
