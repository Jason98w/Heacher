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
    public partial class publish_reward_user_info : Form
    {
        public publish_reward_user_info(long rid)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //数据库操作，详细信息
            string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";

            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sql = $@"SELECT  * FROM [HEACHER].[dbo].[REWARDS]  where RID='{rid}'";
            SqlCommand sc1 = new SqlCommand(sql, conn);
            SqlDataReader sdr = sc1.ExecuteReader();        //得到数据读取器
            while (sdr.Read())                                           //读取数据
            {
                label_RID.Text = sdr[0].ToString();
                label_Rname.Text = sdr[1].ToString();
                label_Rtime.Text = sdr[3].ToString();
                label_Rlocation.Text = sdr[4].ToString();
                lable_Rprice.Text = sdr[5].ToString();
                label_RSTATE.Text = sdr[6].ToString();
            }
            sdr.Close();
            string sq2 = $@"SELECT [USERS].[SNO] ,[SEMAIL] ,[STEL] FROM [HEACHER].[dbo].[USERS] join USERS_RECEIVE_REWARDS on USERS.SNO= USERS_RECEIVE_REWARDS.SNO where  USERS_RECEIVE_REWARDS.RID='{rid}'
";
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
        private void publish_class_user_info_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
