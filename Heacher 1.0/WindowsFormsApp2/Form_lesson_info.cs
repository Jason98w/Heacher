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
    public partial class Form_lesson_info : Form
    {
        private string Sno;
        private string Cid;
        public Form_lesson_info(List<string> info, string Sno)
        {
            this.Sno = Sno;
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //数据库操作，详细信息
            string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";

            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sql = $@"SELECT * FROM COURSES WHERE CNAME = '{info[0]}' AND CTIME = '{info[1]}' AND CLOCATION = '{info[2]}'";
            SqlCommand sc = new SqlCommand(sql, conn);

            SqlDataReader sdr = sc.ExecuteReader();        //得到数据读取器
            while (sdr.Read())                                           //读取数据
            {
                cidTextBox.Text = sdr[0].ToString();
                cnameTextBox.Text = sdr[1].ToString();
                cintroductionTextBox.Text = sdr[5].ToString();
                ctimeTextBox.Text = sdr[2].ToString();
                clocationTextBox.Text = sdr[3].ToString();
                cpriceTextBox.Text = sdr[4].ToString();
                cstateTextBox.Text = sdr[7].ToString() + "/" + sdr[6].ToString();
            }
            conn.Close();        //关闭数据库连接         
            this.Cid = cidTextBox.Text;

        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";
            SqlConnection conn = new SqlConnection(connstr);
            //读取课程的报名情况
            string sql = $@"SELECT CREGISTERED_PERSONS, CMAX_PERSONS FROM COURSES WHERE CID = '{Cid}'";
            conn.Open();
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataReader sdr = sc.ExecuteReader();
            sdr.Read();
            int registered = Convert.ToInt32(sdr[0]);
            int max = Convert.ToInt32(sdr[1]);
            conn.Close();
            //判断用户是否报名课程
            sql = $@"SELECT COUNT(*) FROM USERS_APPLY_COURSES WHERE SNO = '{Sno}' AND CID = {Cid}";
            conn.Open();
            sc = new SqlCommand(sql, conn);
            sdr = sc.ExecuteReader();
            sdr.Read();
            int times = Convert.ToInt32(sdr[0]);
            conn.Close();
            if (1 == times)
                MessageBox.Show("请勿重复报名课程", "提示");
            else
            {
                //用户没有报名课程，有以下操作
                if (registered == max)
                {
                    MessageBox.Show("课程人数已满", "提示");
                }
                else
                {

                    conn.Open();
                    sql = $@"INSERT USERS_APPLY_COURSES VALUES ('{Sno}', {Cid}, '0', '')";
                    try
                    {
                        sc = new SqlCommand(sql, conn);
                        sc.ExecuteNonQuery();
                        sql = $@"UPDATE COURSES SET CREGISTERED_PERSONS = CREGISTERED_PERSONS + 1 WHERE CID = {Cid}";
                        sc = new SqlCommand(sql, conn);
                        sc.ExecuteNonQuery();
                        MessageBox.Show("您已成功报名课程，请提前安排好时间喔！！！", "提示");
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n请向在反馈选项反馈此问题，以便我们给您带来更好的服务");
                    }
                }
            }            
        }
    }
}
