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
    public partial class Form_Log : Form
    {
        public Form_Log()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }


        string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";
        private void button1_Click(object sender, EventArgs e)
        {
            Form_register frm = new Form_register();
            frm.ShowDialog();
           // this.Hide();
        }

       

        private void Button_log_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection(connstr);
            string sql = "select * from users Where SNO='" + User_id.Text + "' AND SPASSWORD='" + User_password.Text + "'";
            SqlCommand com = new SqlCommand(sql, con);

            con.Open();
            SqlCommand sc = new SqlCommand(sql, con);
            SqlDataReader msDr = sc.ExecuteReader();


            if (msDr.Read())
            {
                Form_hall frm = new Form_hall(User_id.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("学号或密码错误", "提醒信息", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        int i = 0;
        private void Form_Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (i == 0)
            {
                DialogResult result = MessageBox.Show("是否确定退出？", "提示消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                if (result == DialogResult.Yes)
                {
                    i = 1;
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            if(i==1)
            {
                Dispose();
                System.Environment.Exit(0);
            }
        }



        private void Form_Log_Load(object sender, EventArgs e)
        {

        }

        private void Show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_password.Checked)
            {
                User_password.UseSystemPasswordChar = true;
            }
            else
            {
                User_password.UseSystemPasswordChar = false;
                User_password.PasswordChar = '*';
            }
        }

        private void btnFindPas_Click(object sender, EventArgs e)
        {
            Form_FindPas ff = new Form_FindPas();
            ff.ShowDialog();
            this.Hide();
        }
    }
}
