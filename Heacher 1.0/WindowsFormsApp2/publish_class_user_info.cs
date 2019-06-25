using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class publish_class_user_info : Form
    {
        public publish_class_user_info(long cid)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //数据库操作，详细信息
            string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";

            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sql = $@"SELECT  * FROM [HEACHER].[dbo].[COURSES] where CID='{cid}'";
            SqlCommand sc1 = new SqlCommand(sql, conn);
            SqlDataReader sdr = sc1.ExecuteReader();        //得到数据读取器
            while (sdr.Read())                                           //读取数据
            {
                label_CID.Text = sdr[0].ToString();
               label_cname .Text = sdr[1].ToString();
               label_ctime.Text = sdr[2].ToString();
                label_clocation.Text = sdr[3].ToString();
                lable_cprice.Text = sdr[4].ToString();
                label_cmax_person.Text = sdr[6].ToString();
                lable_cregistered_person.Text = sdr[7].ToString();
            }
            sdr.Close();
            string sq2 = $@"SELECT [USERS].[SNO] ,[SEMAIL] ,[STEL] FROM [HEACHER].[dbo].[USERS] join USERS_APPLY_COURSES on USERS.SNO=USERS_APPLY_COURSES.SNO where USERS_APPLY_COURSES.CID='{cid}'";
            SqlCommand sc2 = new SqlCommand(sq2, conn);
            SqlDataReader sdr2 = sc2.ExecuteReader();        //得到数据读取器
            while (sdr2.Read())                                           //读取数据
            {
                    ListViewItem lv = new ListViewItem(sdr2[0].ToString());
                    lv.SubItems.Add(sdr2[2].ToString());
                    lv.SubItems.Add(sdr2[1].ToString());
                    listView1.Items.Add(lv);
            }
            sdr2.Close();
            conn.Close();        //关闭数据库连接     

        }

        
    }
}
