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
    public partial class Form_FindPas : Form
    {
        public Form_FindPas()
        {
            InitializeComponent();
        }
        jwUser ju = new jwUser();

        string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";
        private void button1_Click(object sender, EventArgs e)
        {

            if (ju.Verify(txtName.Text, txtID.Text, txtPassword.Text))
            {
                string sql = "select * from USERS Where SNO='" + txtID.Text + "'";
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                SqlCommand sc = new SqlCommand(sql, conn);
                SqlDataReader msDr = sc.ExecuteReader();
                if (msDr.HasRows)
                {
                    MessageBox.Show("验证成功,请输入新密码！", "提醒信息", MessageBoxButtons.OK);
                    txtNowpwd.Enabled = true;
                    txtReNowPwd.Enabled = true;
                }
                else
                {
                    MessageBox.Show("验证失败,该账号未被注册，请先注册！", "提醒信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            else
            {

                MessageBox.Show("输入信息错误,请重新输入");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNowpwd.Text.Length < 6)
            {
                MessageBox.Show("密码长度小于6位，请重新输入！", "提醒信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNowpwd.Text == txtReNowPwd.Text)
                {
                    string sql = "update users set spassword = '" + txtNowpwd.Text + "' where sno = '" + txtID.Text + "'";
                    SqlConnection conn = new SqlConnection(connstr);
                    conn.Open();
                    SqlCommand sc = new SqlCommand(sql, conn);
                    SqlDataReader msDr = sc.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("修改成功！");
                    this.Close();
                    Form_Log fl = new Form_Log();
                    fl.Show();
                }
                else
                {
                    MessageBox.Show("密码输入信息不一致,请重新输入！", "提醒信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Log fl = new Form_Log();
            fl.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtNowpwd.UseSystemPasswordChar = true;
                txtReNowPwd.UseSystemPasswordChar = true;
            }
            else
            {
                txtNowpwd.UseSystemPasswordChar = false;
                txtNowpwd.PasswordChar = '*';
                txtReNowPwd.UseSystemPasswordChar = false;
                txtReNowPwd.PasswordChar = '*';
            }
        }

        private void Form_FindPas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form_Log fl = new Form_Log();
            fl.Show();
        }
    }
}


