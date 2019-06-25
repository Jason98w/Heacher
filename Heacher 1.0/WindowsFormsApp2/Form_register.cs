using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form_register : Form
    {
        public Form_register()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;          
        }

        private void Form_register_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Student_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        Regex reg = new Regex(@"^[a-zA-Z0-9_.-]+@+(qq.com|163.com|126.com)$");

        private void Button_register_Click(object sender, EventArgs e)
        {
            if (ju.Enroll(User_name.Text, User_password.Text, Tell.Text, Email.Text, txtRePassword.Text))
            {
                MessageBox.Show("注册成功!");
                Form_Log frm = new Form_Log();
                frm.Show();
                this.Close();
            }
            else
            {
                if (User_password.Text.Length < 6)
                {
                    MessageBox.Show("密码长度小于6位", "提醒信息", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (Tell.Text.Length != 11)
                {
                    MessageBox.Show("电话号码输入错误", "提醒信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (User_password.Text != txtRePassword.Text)
                {
                    MessageBox.Show("两次密码信息不一致，请重新输入", "提醒信息", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if(!reg.IsMatch(Email.Text))
                {
                    MessageBox.Show("邮箱格式输入有误,请重新输入\n1.只允许英文字母、数字、下划线、英文句号、以及中划线组成\n" +
                                    "2.结尾是qq.com或163.com或126.com", 
                                    "提醒信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            Form_Log frm = new Form_Log();
            frm.Show();
            this.Close();
        }
        Boolean textboxHasText1 = false;
        private void User_name_Enter(object sender, EventArgs e)
        {
            if (textboxHasText1 == false)
            {
                User_name.Text = "";
                User_name.ForeColor = Color.Black;
            }
        }

        private void User_name_Leave(object sender, EventArgs e)
        {
            if (User_name.Text == "")
            {
                User_name.Text = "最大长度为20个字符";
                User_name.ForeColor = Color.SlateGray;
                textboxHasText1 = false;
            }
            else textboxHasText1 = true;
        }

        Boolean textboxHasText2 = false;
        private void User_password_Enter(object sender, EventArgs e)
        {
            if (textboxHasText2 == false)
            {
                User_password.Text = "";
                User_password.ForeColor = Color.Black;
            }
        }
        private void User_password_Leave(object sender, EventArgs e)
        {
            if (User_password.Text == "")
            {
                User_password.Text = "最大长度为20个字符";
                User_password.ForeColor = Color.SlateGray;
                textboxHasText2 = false;
            }
            else textboxHasText2 = true;
        }

        Boolean textboxHasText3 = false;
        private void Email_Enter(object sender, EventArgs e)
        {
            if (textboxHasText3 == false)
            {
                Email.Text = "";
                Email.ForeColor = Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {

            if (Email.Text == "")
            {
                Email.Text = "请填写真实邮箱";
                Email.ForeColor = Color.SlateGray;
                textboxHasText3 = false;
            }
            else textboxHasText3 = true;
        }

        Boolean textboxHasText4 = false;

        private void Tell_Enter(object sender, EventArgs e)
        {
            if (textboxHasText4 == false)
            {
                Tell.Text = "";
                Tell.ForeColor = Color.Black;
            }
        }

        private void Tell_Leave(object sender, EventArgs e)
        {
            if (Tell.Text == "")
            {
                Tell.Text = "请填写真实手机号";
                Tell.ForeColor = Color.SlateGray;
                textboxHasText4 = false;
            }
            else textboxHasText4 = true;
        }
        jwUser ju = new jwUser();

        string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";

        private void Button_verify_Click(object sender, EventArgs e)
        {
            

            if (ju.Verify(Student_name.Text, Student_id.Text, Student_password.Text))
            {
                string sql = "select * from USERS Where SNO='" + Student_id.Text + "'";
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                SqlCommand sc = new SqlCommand(sql, conn);
                SqlDataReader msDr = sc.ExecuteReader();
                if(msDr.HasRows)
                {
                    MessageBox.Show("该账号已经被注册，请重新输入！", "提醒信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    True_gray.Visible = false;
                    True_green.Visible = true;

                    User_name.Enabled = true;
                    User_password.Enabled = true;
                    Email.Enabled = true;
                    Tell.Enabled = true;
                    Button_register.Enabled = true;
                    txtRePassword.Enabled = true;

                    False_red.Visible = false;
                    False_gray.Visible = true;
                    MessageBox.Show("验证成功,请注册信息");
                }
            }
            else
            {

                True_green.Visible = false;
                True_gray.Visible = true;
                False_gray.Visible = false;
                False_red.Visible = true;
                MessageBox.Show("输入信息错误,请重新输入");

            }
        }

        private void txtRePassword_Leave(object sender, EventArgs e)
        {
            if (User_password.Text == "")
            {
                User_password.Text = "请确认密码";
                User_password.ForeColor = Color.SlateGray;
                textboxHasText2 = false;
            }
            else textboxHasText2 = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Student_password.UseSystemPasswordChar = true;
            }
            else
            {
                Student_password.UseSystemPasswordChar = false;
                Student_password.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                User_password.UseSystemPasswordChar = true;
                txtRePassword.UseSystemPasswordChar = true;
            }
            else
            {
                User_password.UseSystemPasswordChar = false;
                User_password.PasswordChar = '*';
                txtRePassword.UseSystemPasswordChar = false;
                txtRePassword.PasswordChar = '*';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
