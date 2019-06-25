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
    public partial class Form_reward_info1 : Form
    {
        private string Rid;
        private string Sno;
        //定义委托和事件
        public delegate void MyDelegate(object sender, EventArgs e);
        public event MyDelegate MyEvent;

        public Form_reward_info1(List<string> info, string Sno)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Sno = Sno;

            //数据库操作，详细信息
            string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";

            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sql = $@"SELECT * FROM REWARDS WHERE RNAME = '{info[0]}' AND RTIME = '{info[1]}' AND RLOCATION = '{info[2]}'";
            SqlCommand sc = new SqlCommand(sql, conn);

            SqlDataReader sdr = sc.ExecuteReader();        //得到数据读取器
            while (sdr.Read())                                           //读取数据
            {
                ridTextBox.Text = sdr[0].ToString();
                rnameTextBox.Text = sdr[1].ToString();
                rintroductionTextBox.Text = sdr[2].ToString();
                rtimeTextBox.Text = sdr[3].ToString();
                rlocationTextBox.Text = sdr[4].ToString();
                rpriceTextBox.Text = sdr[5].ToString();                
            }
            conn.Close();        //关闭数据库连接 
            Rid = ridTextBox.Text;
            //标识符
            conn.Open();
            sql = $@"SELECT SNAME, STEL FROM USERS WHERE SNO = (SELECT UPR.SNO FROM USERS_PUBLISH_REWARDS AS UPR WHERE RID = {this.Rid})";
            sc = new SqlCommand(sql, conn);
            sdr = sc.ExecuteReader();
            sdr.Read();
            snameTextBox.Text = sdr[0].ToString();
            stelTextBox.Text = sdr[1].ToString();
            conn.Close();
        }

        private void Accept_Click(object sender, EventArgs e)
        {

            string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";
            SqlConnection conn = new SqlConnection(connstr);
            string sql = $@"SELECT RSTATE FROM REWARDS WHERE RID = '{Rid}'";
            conn.Open();
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataReader sdr = sc.ExecuteReader();
            sdr.Read();
            string state = sdr[0].ToString();
            conn.Close();            
            if ("1" == state)
            {
                conn.Open();
                sql = $@"SELECT COUNT(*) FROM USERS_RECEIVE_REWARDS WHERE SNO = '{Sno}' AND RID = {Rid}";
                try
                {
                    sc = new SqlCommand(sql, conn);
                    sdr = sc.ExecuteReader();
                    sdr.Read();
                    int times = Convert.ToInt32(sdr[0]);
                    if (1 == times)
                        MessageBox.Show("请勿重复领取悬赏任务", "提示");
                    else
                        MessageBox.Show("悬赏任务已被他人领取", "提示");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    //标识符
                    MessageBox.Show(ex.Message + "\nHeacher恳请您反馈此问题，以便我们给您带来更好的服务");
                }                
            }
            else
            {
                //标识符
                //判断用户是否报名自己开设的课程
                sql = $@"SELECT SNO FROM USERS_PUBLISH_REWARDS WHERE RID = {Rid}";
                conn.Open();
                sc = new SqlCommand(sql, conn);
                sdr = sc.ExecuteReader();
                sdr.Read();
                string publisher = sdr[0].ToString();
                conn.Close();
                if (publisher.Trim() == Sno.Trim())
                {
                    MessageBox.Show("操作无效，不可以领取自己发布的任务", "提示");
                }
                else
                {
                    conn.Open();
                    sql = $@"INSERT USERS_RECEIVE_REWARDS VALUES ('{Sno}', {Rid}, '0')";
                    try
                    {
                        sc = new SqlCommand(sql, conn);
                        sc.ExecuteNonQuery();
                        sql = $@"UPDATE REWARDS SET RSTATE = '1' WHERE RID = {Rid}";
                        sc = new SqlCommand(sql, conn);
                        sc.ExecuteNonQuery();
                        MessageBox.Show("您已成功领取悬赏，请提前对悬赏任务做好准备！！！", "提示");
                        conn.Close();
                        //标识符
                        if (null != MyEvent)
                        {
                            MyEvent(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        //标识符
                        MessageBox.Show(ex.Message + "\nHeacher恳请您反馈此问题，以便我们给您带来更好的服务");
                    }
                }               
            }            
        }

        private void rnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
