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
    public partial class Form_feedback : Form
    {
        string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";

        string sno;
        public Form_feedback(string sno)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.sno = sno;
        }

        private void Question_suggestion_Click(object sender, EventArgs e)
        {
            Question_suggestion.BackColor = Color.Transparent;
            Question_suggestion.ForeColor = Color.White;
            Function_feedback.BackColor = Color.Transparent ;
            Function_feedback.ForeColor = Color.Gray ;
        }

        private void Function_feedback_Click(object sender, EventArgs e)
        {
            Function_feedback.BackColor = Color.Transparent;
            Function_feedback.ForeColor = Color.White;
            Question_suggestion.BackColor = Color.Transparent ;
            Question_suggestion.ForeColor = Color.Gray ;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Messagebox.Text.Length != 0)
            {
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                string time = System.DateTime.Now.ToShortTimeString();
                long Cid = Convert.ToInt64((Convert.ToInt64(long.Parse(sno) % 1000000)).ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString());

                string sql = "INSERT INTO [HEACHER].[dbo].[SUGGESTIONS] ([SUID] ,[SUTIME],[SUDETAILS],[SNO])" +
                    " VALUES(" + Cid.ToString() + ",'" + time + "','" + Messagebox.Text + "'," + sno + ")";
                SqlCommand sc = new SqlCommand(sql, conn);
                if (1 == sc.ExecuteNonQuery())
                {
                    MessageBox.Show("成功反馈信息");
                }
                else
                    MessageBox.Show("反馈信息失败!");
            }
            else
            {
                MessageBox.Show("请输入您的反馈建议!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
