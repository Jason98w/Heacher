using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp2
{
    public partial class Form_user1 : Form
    {
        private string SNO;
        string connstr = @"data source=WIN-4K5HDJFV5BS\SQLEXPRESS;" +
                         "initial catalog=heacher;persist security info=true;" +
                         "user id=sa;password=1 ";
        public Form_user1(string sid)
        {
            SNO = sid;
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sql = @"Select * from users WHERE SNO='" + SNO + "'";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataReader sd = sc.ExecuteReader();
            while (sd.Read())                                           //读取数据
            {
                Student_name.Text = sd["SNAME"].ToString();
                User_password.Text = sd["SPASSWORD"].ToString();
                Student_id.Text = sd["SNO"].ToString();
                User_name.Text = sd["SNICKNAME"].ToString();
                User_score.Text = sd["SSCORE"].ToString();
                User_credit.Text = sd["SCREDIT"].ToString();
                User_email.Text = sd["SEMAIL"].ToString();
                User_tell.Text = sd["STEL"].ToString();
            }
            conn.Close();        //关闭数据库连接
        }

        

        private void Form_user_Load(object sender, EventArgs e)
        {

        }

        private void Button_publish_Click(object sender, EventArgs e)
        {
            Button_publish.BackColor = Color.CornflowerBlue;
            Button_publish.ForeColor = Color.White;
           
            Button_take.BackColor = Color.Transparent;
            Button_take.ForeColor = Color.Black;

            Button_feedback.BackColor = Color.Transparent;
            Button_feedback.ForeColor = Color.Black;
          
            Button_revise.BackColor = Color.Transparent;
            Button_revise.ForeColor = Color.Black;

            this.Panel_publish.Visible = true;
            this.Panel_infomation.Visible = false;
            this.Panel_revise.Visible = false;
            this.Panel_take.Visible = false;

        }

        private void Button_take_Click(object sender, EventArgs e)
        {
            Button_take.BackColor = Color.CornflowerBlue;
            Button_take.ForeColor = Color.White;

            Button_publish.BackColor = Color.Transparent;
            Button_publish.ForeColor = Color.Black ;

            Button_feedback.BackColor = Color.Transparent;
            Button_feedback.ForeColor = Color.Black;

            Button_revise.BackColor = Color.Transparent;
            Button_revise.ForeColor = Color.Black;

            this.Panel_publish.Visible = false ;
            this.Panel_infomation.Visible = false;
            this.Panel_revise.Visible = false;
            this.Panel_take.Visible = true ;
        }

        private void Button_revise_Click(object sender, EventArgs e)
        {
            Button_revise.BackColor = Color.CornflowerBlue;
            Button_revise.ForeColor = Color.White;

            Button_publish.BackColor = Color.Transparent;
            Button_publish.ForeColor = Color.Black;

            Button_take.BackColor = Color.Transparent;
            Button_take.ForeColor = Color.Black ;

            Button_feedback.BackColor = Color.Transparent;
            Button_feedback.ForeColor = Color.Black ;

            this.Panel_publish.Visible = false;
            this.Panel_infomation.Visible = false;
            this.Panel_revise.Visible = true ;
            this.Panel_take.Visible = false;

            //数据库操作
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sql = $@"SELECT * FROM USERS WHERE SNO = '{SNO}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            Revise_name.Text = sdr[3].ToString();
            Revise_password.Text = sdr[7].ToString();
            conn.Close();
        }

        private void Button_feedback_Click(object sender, EventArgs e)
        {
            Button_feedback.BackColor = Color.CornflowerBlue;
            Button_feedback.ForeColor = Color.White;

            Button_publish.BackColor = Color.Transparent;
            Button_publish.ForeColor = Color.Black;

            Button_take.BackColor = Color.Transparent ;
            Button_take.ForeColor = Color.Black;

            Button_revise.BackColor = Color.Transparent;
            Button_revise.ForeColor = Color.Black;

            Form_feedback frm = new Form_feedback(SNO);
            frm.Show();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void User_image_Click(object sender, EventArgs e)
        {
            this.Panel_publish.Visible = false ;
            this.Panel_infomation.Visible = true ;
            this.Panel_revise.Visible = false;
            this.Panel_take.Visible = false;
            //数据库操作
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sql = @"Select * from users WHERE SNO='" + SNO + "'";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataReader sd = sc.ExecuteReader();
            while (sd.Read())                                           //读取数据
            {
                Student_name.Text = sd["SNAME"].ToString();
                User_password.Text = sd["SPASSWORD"].ToString();
                Student_id.Text = sd["SNO"].ToString();
                User_name.Text = sd["SNICKNAME"].ToString();
                User_score.Text = sd["SSCORE"].ToString();
                User_credit.Text = sd["SCREDIT"].ToString();
                User_email.Text = sd["SEMAIL"].ToString();
                User_tell.Text = sd["STEL"].ToString();
            }
            conn.Close();        //关闭数据库连接
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("再次确认是否修改数据", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //数据库连接                
                string sql = $@"UPDATE USERS SET SPASSWORD = '{Revise_password.Text}' WHERE SNO = '{SNO}' "
                    + $@"UPDATE USERS SET SNICKNAME = '{Revise_name.Text}' WHERE SNO = '{SNO}'";
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功！！！", "提示", MessageBoxButtons.OK);
                conn.Close();
            }
        }
    }
}
