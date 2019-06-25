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
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form_user : Form
    {
        private string SNO;
        private string pwd;
        string imgNumber = "1";
        //记录该登录用户的学号
        long sno;
        public Form_user(string sid)
        {
            SNO = sid;
            sno = long.Parse(sid);
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            //默认不显示密码
            checkboxShowPaw.Checked = false;



            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sql = @"Select * from users WHERE SNO='" + SNO + "'";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataReader sd = sc.ExecuteReader();



            while (sd.Read())                                           //读取数据
            {
                Student_name.Text = sd["SNAME"].ToString();
                pwd = sd["SPASSWORD"].ToString();
                User_password.Text = "******";
                Student_id.Text = sd["SNO"].ToString();
                User_name.Text = sd["SNICKNAME"].ToString();
                User_score.Text = sd["SSCORE"].ToString();
                User_credit.Text = sd["SCREDIT"].ToString();
                User_email.Text = sd["SEMAIL"].ToString();
                User_tell.Text = sd["STEL"].ToString();
                imgNumber = sd["SIMAGENUMBER"].ToString();

            }
            conn.Close();        //关闭数据库连接

            conn.Open();

            string sql1 = @"Select * from image where number='" + imgNumber + "'";
            sc = new SqlCommand(sql1, conn);
            sd = sc.ExecuteReader();
            sd.Read();
            byte[] b = (byte[])sd["IMAGES"];
            if (b.Length > 0)
            {
                MemoryStream stream = new MemoryStream(b);
                //tream.Write(b, 0, b.Length);
                //MessageBox.Show(stream.Length.ToString());

                //Bitmap bmpt = new Bitmap(stream);
                pic_Head.SizeMode = PictureBoxSizeMode.Zoom;
                pic_Head.Image = Image.FromStream(stream);
                User_image.SizeMode = PictureBoxSizeMode.Zoom;
                User_image.Image = Image.FromStream(stream);
                //ImageListViewItem lvi = new ImageListViewItem();
                //lvi.Text = "DEMO";
                //lvi.ThumbnailImage = bmpt;//设置显示 image   报错
                //imageListView1.Items.Add(lvi);
                stream.Close();
            }
        }

        private void Form_user_Load(object sender, EventArgs e)
        {

        }

        private void Button_revise_Click(object sender, EventArgs e)
        {
            Button_revise.BackColor = Color.CornflowerBlue;
            Button_revise.ForeColor = Color.White;

            Button_publish.BackColor = Color.Transparent;
            Button_publish.ForeColor = Color.Black;

            Button_take.BackColor = Color.Transparent;
            Button_take.ForeColor = Color.Black;

            Button_feedback.BackColor = Color.Transparent;
            Button_feedback.ForeColor = Color.Black;

            this.Panel_publish.Visible = false;
            this.Panel_infomation.Visible = false;
            this.Panel_revise.Visible = true;
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

            Button_take.BackColor = Color.Transparent;
            Button_take.ForeColor = Color.Black;

            Button_revise.BackColor = Color.Transparent;
            Button_revise.ForeColor = Color.Black;

            Form_feedback frm = new Form_feedback(SNO);
            frm.ShowDialog();


        }

        private void User_image_Click(object sender, EventArgs e)
        {
            this.Panel_publish.Visible = false;
            this.Panel_infomation.Visible = true;
            this.Panel_revise.Visible = false;
            this.Panel_take.Visible = false;
            this.Panel_publish.Visible = false;
            this.Panel_infomation.Visible = true;
            this.Panel_revise.Visible = false;
            this.Panel_take.Visible = false;

            //默认不显示密码
            checkboxShowPaw.Checked = false;
            //数据库操作
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sql = @"Select * from users WHERE SNO='" + SNO + "'";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataReader sd = sc.ExecuteReader();
            while (sd.Read())                                           //读取数据
            {
                Student_name.Text = sd["SNAME"].ToString();
                User_password.Text = "******";
                Student_id.Text = sd["SNO"].ToString();
                User_name.Text = sd["SNICKNAME"].ToString();
                User_score.Text = sd["SSCORE"].ToString();
                User_credit.Text = sd["SCREDIT"].ToString();
                User_email.Text = sd["SEMAIL"].ToString();
                User_tell.Text = sd["STEL"].ToString();
            }
            conn.Close();        //关闭数据库连接
        }


        //2019.6.7修改以下代码

        //利用连接字符串连接数据库
        static string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";
        SqlConnection conn = new SqlConnection(connstr);

        //判断数据库的连接是否已打开
        public bool is_open_conn()
        {
            if (conn.State == ConnectionState.Open)
            {
                return true;
            }
            else return false;
        }


        //初始化四个列表，用来存储该登录用户的发布课程id，发布悬赏id，报名课程id，接单悬赏id
        List<long> stu_publish_course_id = new List<long>();
        List<long> stu_publish_reward_id = new List<long>();
        List<long> stu_apply_course_id = new List<long>();
        List<long> stu_recieve_reward_id = new List<long>();

        //使用listview控件展示该用户发布的课程或悬赏
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

            //展示该用户发布的课程或悬赏
            show_publish();

        }
        //publish具体展示过程
        private void show_publish()
        {
            //打开数据库
            if (is_open_conn() == true)
            {
                conn.Close();
                conn.Open();
            }
            else conn.Open();

            //清空记录
            stu_apply_course_id.Clear();
            stu_publish_course_id.Clear();
            stu_publish_reward_id.Clear();
            stu_recieve_reward_id.Clear();
            try
            { //清空展示发布的课程的控件中的展示内容
                listview_publish_course.Items.Clear();

                //从数据库中选择出该用户所开设的课程id存入对应列表，以及显示课程名称。
                string sql = @"SELECT COURSES.CID, [CNAME] FROM [HEACHER].[dbo].[COURSES] join USERS_ESTABLISH_COURSES on USERS_ESTABLISH_COURSES.CID=COURSES.CID where USERS_ESTABLISH_COURSES.SNO='" + sno + "'";
                SqlCommand sc = new SqlCommand(sql, conn);
                SqlDataReader reader = sc.ExecuteReader();
                ListViewItem lv1 = new ListViewItem("已发布课程：");
                listview_publish_course.Items.Add(lv1);
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader[1].ToString());

                    //在控件中显示课程名称
                    listview_publish_course.Items.Add(lv);

                    //将该用户发布的课程id存入对应id列表中
                    stu_publish_course_id.Add(Convert.ToInt64(reader[0]));
                }
                reader.Close();

                //清空展示发布的悬赏的控件中的展示内容
                listView_publish_reward.Items.Clear();

                //从数据库中选择出该用户发布的悬赏id存入对应列表，以及显示悬赏名称。
                string sq2 = @"SELECT REWARDS.RID ,RNAME FROM [HEACHER].[dbo].[REWARDS] join USERS_PUBLISH_REWARDS on REWARDS.RID=USERS_PUBLISH_REWARDS.RID where USERS_PUBLISH_REWARDS.SNO='" + sno + "'";
                SqlCommand sc2 = new SqlCommand(sq2, conn);
                SqlDataReader reader2 = sc2.ExecuteReader();
                ListViewItem lv2 = new ListViewItem("已发布悬赏：");
                listView_publish_reward.Items.Add(lv2);
                while (reader2.Read())
                {
                    ListViewItem lv = new ListViewItem(reader2[1].ToString());

                    //在控件中显示悬赏名称
                    listView_publish_reward.Items.Add(lv);

                    //将该用户发布的悬赏id存入对应id列表中
                    stu_publish_reward_id.Add(Convert.ToInt64(reader2[0]));
                }
                reader2.Close();

                //关闭数据库的连接
                conn.Close();
            }

            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show("publish具体展示过程出错，出错内容：" + e.Message);
            }
        }

        //使用listview展示该用户报名的课程或接单的悬赏
        private void Button_take_Click(object sender, EventArgs e)
        {
            Button_take.BackColor = Color.CornflowerBlue;
            Button_take.ForeColor = Color.White;

            Button_publish.BackColor = Color.Transparent;
            Button_publish.ForeColor = Color.Black;

            Button_feedback.BackColor = Color.Transparent;
            Button_feedback.ForeColor = Color.Black;

            Button_revise.BackColor = Color.Transparent;
            Button_revise.ForeColor = Color.Black;

            this.Panel_publish.Visible = false;
            this.Panel_infomation.Visible = false;
            this.Panel_revise.Visible = false;
            this.Panel_take.Visible = true;

            //展示该用户报名的课程或者接单的悬赏
            show_take();

        }
        //take具体展示过程
        private void show_take()
        {
            //打开数据库
            if (is_open_conn() == true)
            {
                conn.Close();
                conn.Open();
            }
            else conn.Open();
            //清空记录
            stu_apply_course_id.Clear();
            stu_publish_course_id.Clear();
            stu_publish_reward_id.Clear();
            stu_recieve_reward_id.Clear();
            try
            {
                //清空展示报名课程的控件的展示内容
                ListView_take_course.Items.Clear();

                //从数据库中选择该用户所报名的课程id存入对应列表，以及展示报名的课程名称
                string sql = @"SELECT COURSES.CID, CNAME  FROM [HEACHER].[dbo].[COURSES] join USERS_APPLY_COURSES on COURSES.CID=USERS_APPLY_COURSES.CID where USERS_APPLY_COURSES.SNO='" + sno + "'";
                SqlCommand sc = new SqlCommand(sql, conn);
                SqlDataReader reader = sc.ExecuteReader();
                ListViewItem lv1 = new ListViewItem("已报名课程：");
                ListView_take_course.Items.Add(lv1);
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader[1].ToString());

                    //展示已报名的课程名称
                    ListView_take_course.Items.Add(lv);

                    //将已报名的课程id存入对应列表
                    stu_apply_course_id.Add(Convert.ToInt64(reader[0]));
                }
                reader.Close();

                //清空展示已接单悬赏的控件的展示内容
                listView_take_reward.Items.Clear();

                //从数据库中选择该用户已接单悬赏的id存入对应列表，以及展示已接单悬赏名称
                string sq2 = @"SELECT [REWARDS].RID, [RNAME] FROM [HEACHER].[dbo].[REWARDS] join USERS_RECEIVE_REWARDS on REWARDS.RID=USERS_RECEIVE_REWARDS.RID where USERS_RECEIVE_REWARDS.SNO='" + sno + "'";
                SqlCommand sc2 = new SqlCommand(sq2, conn);
                SqlDataReader reader2 = sc2.ExecuteReader();
                ListViewItem lv2 = new ListViewItem("已接单悬赏：");
                listView_take_reward.Items.Add(lv2);
                while (reader2.Read())
                {
                    ListViewItem lv = new ListViewItem(reader2[1].ToString());

                    //展示已接单悬赏名称
                    listView_take_reward.Items.Add(lv);

                    //将该用户的已接单悬赏id存入对应列表
                    stu_recieve_reward_id.Add(Convert.ToInt64(reader2[0]));
                }
                reader2.Close();

                //关闭数据库
                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show("take具体展示过程出错，出错内容：" + e.Message);
            }
        }

        //取消已发布课程或悬赏
        private void Publish_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                //在展示已发布课程控件中循环，找到用户选择的课程
                foreach (ListViewItem lv in listview_publish_course.SelectedItems)
                {
                    //从已发布课程id列表中按照顺序找到对应id
                    for (int i = 1; i <= stu_publish_course_id.Count; i++)
                    {
                        if (i == lv.Index)
                        {
                            //打开数据库
                            if (is_open_conn() == true)
                            {
                                conn.Close();
                                conn.Open();
                            }
                            else conn.Open();

                            //选择出发布的课程的对应时间，并判断是否在这个时间的三天前取消
                            string sql = @"SELECT[CTIME] FROM [HEACHER].[dbo].[COURSES] where CID='" + stu_publish_course_id[i - 1] + "'";
                            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);


                            //关闭数据库
                            conn.Close();
                            foreach (DataRow dr in dt.Rows)
                            {
                                DialogResult result = MessageBox.Show("是否确定取消？", "提示消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    DateTime dateTime = Convert.ToDateTime(dr[0]);
                                    if (dateTime < DateTime.Now)
                                    {
                                        MessageBox.Show("由你开设的该门课程已失效，将自动取消");
                                        cancel_course_publish(stu_publish_course_id[i - 1]);
                                    }
                                    else if (dateTime >= DateTime.Now.AddDays(+3))
                                    {
                                        MessageBox.Show("由你开设的该门课程可正常取消开设");
                                        cancel_course_publish(stu_publish_course_id[i - 1]);

                                    }
                                    else
                                    {
                                        MessageBox.Show("未在开始前三天内取消，扣除10信誉度");
                                        cancel_course_publish(stu_publish_course_id[i - 1]);
                                        xinyu(-10, sno);
                                    }
                                }

                            }
                            dt.Clear();

                        }
                    }
                    //重新展示发布课程或者悬赏控件的内容
                    show_publish();
                }

                //清除发布课程显示控件上的选择状态
                listview_publish_course.SelectedItems.Clear();

                //在展示已发布课程控件中循环，找到用户选择的悬赏
                foreach (ListViewItem lv in listView_publish_reward.SelectedItems)
                {
                    //从已发布悬赏id列表中按照顺序找到对应id
                    for (int i = 1; i <= stu_publish_reward_id.Count; i++)
                    {
                        if (i == lv.Index)
                        {
                            //打开数据库
                            conn.Open();

                            //选择出该悬赏的时间，并判断是否是在三天前内取消
                            string sql = @"SELECT[RTIME] FROM [HEACHER].[dbo].[REWARDS] where RID='" + stu_publish_reward_id[i - 1] + "'";
                            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);


                            //关闭数据库
                            conn.Close();
                            foreach (DataRow dr in dt.Rows)
                            {
                                DialogResult result = MessageBox.Show("是否确定取消？", "提示消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    DateTime dateTime = Convert.ToDateTime(dr[0]);
                                    if (dateTime < DateTime.Now)
                                    {
                                        MessageBox.Show("由你发布的该悬赏已失效，将自动取消");
                                        cancel_reward_publish(stu_publish_reward_id[i - 1]);
                                    }
                                    else if (dateTime >= DateTime.Now.AddDays(+3))
                                    {
                                        MessageBox.Show("由你发布的该悬赏可正常取消发布");
                                        cancel_reward_publish(stu_publish_reward_id[i - 1]);
                                    }
                                    else
                                    {
                                        MessageBox.Show("未在开始前三天内取消，扣除10信誉度");
                                        cancel_reward_publish(stu_publish_reward_id[i - 1]);
                                        xinyu(-10, sno);
                                    }
                                }
                            }
                            dt.Clear();

                        }
                    }
                    //重新显示已发布课程和悬赏控件内容
                    show_publish();
                }
                //取消已发布悬赏控件的选择状态
                listView_publish_reward.SelectedItems.Clear();
            }
            //处理异常
            catch (Exception d)
            {
                MessageBox.Show("取消已发布课程或悬赏过程出错，出错内容：" + d.Message);
            }
        }
        //传入已发布课程id进行取消
        private void cancel_course_publish(long cid)
        {
            //打开数据库
            if (is_open_conn() == true)
            {
                conn.Close();
                conn.Open();
            }
            else conn.Open();
            try
            {
                //从开设课程表中删除记录
                string sql = @"DELETE FROM [HEACHER].[dbo].[USERS_ESTABLISH_COURSES] WHERE CID='" + cid + "' and SNO='" + sno + "'";
                SqlCommand sda = new SqlCommand(sql, conn);
                int y = sda.ExecuteNonQuery();
                //从报名课程表中删除报名了该课程的记录
                string sq2 = @"DELETE FROM [HEACHER].[dbo].[USERS_APPLY_COURSES] WHERE CID='" + cid + "'";
                SqlCommand sd = new SqlCommand(sq2, conn);
                int x = sd.ExecuteNonQuery();
                //从课程表中删除课程记录
                string sq3 = @"DELETE FROM [HEACHER].[dbo].[COURSES] WHERE CID='" + cid + "'";
                SqlCommand s = new SqlCommand(sq3, conn);
                int z = s.ExecuteNonQuery();
                if (y == 0 || x == 0 || z == 0)
                {
                    MessageBox.Show("无人报名该课程或者无该课程记录，取消成功");
                }
                else MessageBox.Show("取消成功");
                //关闭数据库
                conn.Close();
            }

            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show("传入已发布课程id进行取消过程出错，出错内容：" + e.Message);
            }
        }
        //传入已发布悬赏id进行取消
        private void cancel_reward_publish(long rid)
        {
            //打开数据库
            if (is_open_conn() == true)
            {
                conn.Close();
                conn.Open();
            }
            else conn.Open();
            try
            {//删除已发布悬赏表中的记录
                string sql = @"DELETE FROM [HEACHER].[dbo].USERS_PUBLISH_REWARDS  WHERE RID='" + rid + "' and SNO='" + sno + "'";
                SqlCommand sda = new SqlCommand(sql, conn);
                int y = sda.ExecuteNonQuery();
                //将接单了该悬赏的接单记录删除
                string sq2 = @"DELETE FROM [HEACHER].[dbo].[USERS_RECEIVE_REWARDS] WHERE RID='" + rid + "'";
                SqlCommand sd = new SqlCommand(sq2, conn);
                int x = sd.ExecuteNonQuery();
                //将该悬赏记录删除
                string sq3 = @"DELETE FROM [HEACHER].[dbo].[REWARDS] WHERE RID='" + rid + "'";
                SqlCommand s = new SqlCommand(sq3, conn);
                int z = s.ExecuteNonQuery();
                if (y == 0 || x == 0 || z == 0)
                {
                    MessageBox.Show("无人接单该悬赏，或无悬赏记录，取消成功");
                }
                else MessageBox.Show("取消成功");
                //关闭数据库
                conn.Close();
            }

            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show("传入已发布悬赏id进行取消过程出错，出错内容：" + e.Message);
            }
        }

        //取消已报名课程或者已接单悬赏
        private void Take_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                //先在已报名课程中循环，找到用户选择的课程
                foreach (ListViewItem lv in ListView_take_course.SelectedItems)
                {
                    //根据顺序到对应列表中索引出课程编号
                    for (int i = 1; i <= stu_apply_course_id.Count; i++)
                    {
                        if (i == lv.Index)
                        {
                            //打开数据库
                            if (is_open_conn() == true)
                            {
                                conn.Close();
                                conn.Open();
                            }
                            else conn.Open();

                            //从数据库中选择出该课程的开设时间并判断是否在合理时间内取消。
                            string sql = @"SELECT[CTIME] FROM [HEACHER].[dbo].[COURSES] where CID='" + stu_apply_course_id[i - 1] + "'";
                            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);


                            //关闭数据库
                            conn.Close();
                            foreach (DataRow dr in dt.Rows)
                            {
                                DialogResult result = MessageBox.Show("是否确定取消？", "提示消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    DateTime dateTime = Convert.ToDateTime(dr[0]);
                                    if (dateTime < DateTime.Now)
                                    {
                                        MessageBox.Show("你报名的该课程已失效，将自动取消");
                                        cancel_course_take(stu_apply_course_id[i - 1]);

                                    }
                                    else if (dateTime >= DateTime.Now.AddDays(+3))
                                    {
                                        MessageBox.Show("你报名的该课程可正常取消报名");
                                        cancel_course_take(stu_apply_course_id[i - 1]);
                                    }
                                    else
                                    {
                                        MessageBox.Show("未在开始前三天内取消，扣除10信誉度");
                                        cancel_course_take(stu_apply_course_id[i - 1]);
                                        xinyu(-10, sno);
                                    }
                                }
                            }
                            dt.Clear();
                        }
                    }
                    //重新展示已报名课程和已接单悬赏内容
                    show_take();
                }

                //清除已报名课程显示控件的选择状态。
                ListView_take_course.SelectedItems.Clear();

                //先在已接单悬赏中循环，找到用户选择的悬赏
                foreach (ListViewItem lv in listView_take_reward.SelectedItems)
                {
                    //根据顺序到对应列表中索引出悬赏编号
                    for (int i = 1; i <= stu_recieve_reward_id.Count; i++)
                    {
                        if (i == lv.Index)
                        {
                            //打开数据库
                            if (is_open_conn() == true)
                            {
                                conn.Close();
                                conn.Open();
                            }
                            else conn.Open();

                            //从数据库中选择出该悬赏的开始时间并判断是否在合理时间内取消。
                            string sql = @"SELECT[RTIME] FROM [HEACHER].[dbo].[REWARDS] where RID='" + stu_recieve_reward_id[i - 1] + "'";
                            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            //关闭数据库
                            conn.Close();
                            foreach (DataRow dr in dt.Rows)
                            {
                                DialogResult result = MessageBox.Show("是否确定取消？", "提示消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    DateTime dateTime = Convert.ToDateTime(dr[0]);
                                    if (dateTime < DateTime.Now)
                                    {
                                        MessageBox.Show("由你接单的该悬赏已失效");

                                    }
                                    else if (dateTime >= DateTime.Now.AddDays(+3))
                                    {
                                        MessageBox.Show("由你接单的该悬赏可正常取消接单");
                                        cancel_reward_take(stu_recieve_reward_id[i - 1]);
                                    }
                                    else
                                    {
                                        MessageBox.Show("未在开始前三天内取消，扣除10信誉度");
                                        cancel_reward_take(stu_recieve_reward_id[i - 1]);
                                        xinyu(-10, sno);
                                    }
                                }
                            }
                            dt.Clear();

                        }
                    }
                    //重新展示已报名课程和已接单悬赏控件内容
                    show_take();
                }

                //清除已接单悬赏控件内的选择状态
                listView_take_reward.SelectedItems.Clear();
            }

            //显示异常情况详细内容
            catch (Exception d)
            {
                MessageBox.Show("取消已报名课程或者已接单悬赏过程出错，出错内容：" + d.Message);
            }
        }
        //传入已报名课程id进行取消
        private void cancel_course_take(long cid)
        {
            //打开数据库
            if (is_open_conn() == true)
            {
                conn.Close();
                conn.Open();
            }
            else conn.Open();

            try
            {//将该课程的报名人数减少1
                string sql = @"UPDATE [HEACHER].[dbo].[COURSES] SET [CREGISTERED_PERSONS] -=1 WHERE CID='" + cid + "'";
                SqlCommand sda = new SqlCommand(sql, conn);
                int y = sda.ExecuteNonQuery();

                //将报名课程表中该用户的报名记录删除
                string sq2 = @"DELETE FROM [HEACHER].[dbo].USERS_APPLY_COURSES  WHERE CID='" + cid + "' and SNO='" + sno + "'";
                SqlCommand sd = new SqlCommand(sq2, conn);

                int x = sd.ExecuteNonQuery();
                if (y == 0 || x == 0)
                {
                    MessageBox.Show("未报名该课程或者该课程已被取消或不存在，取消成功");
                }
                else MessageBox.Show("取消成功");

                //关闭数据库
                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show("传入已报名课程id进行取消过程出错，出错内容：" + e.Message);
            }
        }
        //传入已接单悬赏id进行取消
        private void cancel_reward_take(long rid)
        {
            //打开数据库
            if (is_open_conn() == true)
            {
                conn.Close();
                conn.Open();
            }
            else conn.Open();

            try
            {
                // 将该悬赏的接单状态变为0
                string sql = @"UPDATE [HEACHER].[dbo].[REWARDS] SET [RSTATE] =0 WHERE RID='" + rid + "'";
                SqlCommand sda = new SqlCommand(sql, conn);
                int y = sda.ExecuteNonQuery();

                //在接单悬赏表中该用户的接单记录删除
                string sq2 = @"DELETE FROM [HEACHER].[dbo].USERS_RECEIVE_REWARDS  WHERE RID='" + rid + "' and SNO='" + sno + "'";
                SqlCommand sd = new SqlCommand(sq2, conn);
                int x = sd.ExecuteNonQuery();

                if (y == 0 || x == 0)
                {
                    MessageBox.Show("未接单该悬赏或者该悬赏已被取消或不存在，取消成功");
                }
                else MessageBox.Show("取消成功");

                //关闭数据库
                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show("传入已接单悬赏id进行取消过程出错，出错内容：" + e.Message);
            }
        }




        //结束已报名课程和已接单悬赏
        private void Take_finish_Click(object sender, EventArgs e)
        {
            if (Take_assess.Text == "")
            {
                MessageBox.Show("请先填写评价等级");
            }
            else
            {
                try
                {
                    //先在已报名课程中循环，找到用户选择的课程
                    foreach (ListViewItem lv in ListView_take_course.SelectedItems)
                    {
                        //根据顺序到对应列表中索引出课程编号
                        for (int i = 1; i <= stu_apply_course_id.Count; i++)
                        {
                            if (i == lv.Index)
                            {
                                //打开数据库
                                if (is_open_conn() == true)
                                {
                                    conn.Close();
                                    conn.Open();
                                }
                                else conn.Open();

                                //从数据库中选择出该课程的开设时间并判断是否在合理时间内结束。
                                string sql = @"SELECT [CTIME] FROM [HEACHER].[dbo].[COURSES] where CID='" + stu_apply_course_id[i - 1] + "'";
                                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                                DataTable dt = new DataTable();
                                sda.Fill(dt);

                                //关闭数据库
                                conn.Close();
                                foreach (DataRow dr in dt.Rows)
                                {
                                    DialogResult result = MessageBox.Show("是否确定结束？", "提示消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (result == DialogResult.Yes)
                                    {
                                        DateTime dateTime = Convert.ToDateTime(dr[0]);
                                        if (dateTime > DateTime.Now)
                                        {
                                            MessageBox.Show("你报名的该课程尚未开始，无法结束，如需取消请选择取消按钮");

                                        }
                                        else if (dateTime <= DateTime.Now)
                                        {
                                            MessageBox.Show("你报名的该课程可正常结束");
                                            done_course_take(stu_apply_course_id[i - 1]);
                                        }
                                    }
                                }
                                dt.Clear();
                            }
                        }
                        //重新展示已报名课程和已接单悬赏内容
                        show_take();
                    }

                    //清除已报名课程显示控件的选择状态。
                    ListView_take_course.SelectedItems.Clear();

                    //先在已接单悬赏中循环，找到用户选择的悬赏
                    foreach (ListViewItem lv in listView_take_reward.SelectedItems)
                    {
                        //根据顺序到对应列表中索引出悬赏编号
                        for (int i = 1; i <= stu_recieve_reward_id.Count; i++)
                        {
                            if (i == lv.Index)
                            {
                                //打开数据库
                                if (is_open_conn() == true)
                                {
                                    conn.Close();
                                    conn.Open();
                                }
                                else conn.Open();

                                //从数据库中选择出该悬赏的开始时间并判断是否在合理时间内结束。
                                string sql = @"SELECT [RTIME] FROM [HEACHER].[dbo].[REWARDS] where RID='" + stu_recieve_reward_id[i - 1] + "'";
                                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                                DataTable dt = new DataTable();
                                sda.Fill(dt);

                                //关闭数据库
                                conn.Close();
                                foreach (DataRow dr in dt.Rows)
                                {
                                    DialogResult result = MessageBox.Show("是否确定结束？", "提示消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (result == DialogResult.Yes)
                                    {
                                        DateTime dateTime = Convert.ToDateTime(dr[0]);
                                        if (dateTime > DateTime.Now)
                                        {
                                            MessageBox.Show("由你接单的该悬赏尚未开始，无法结束，如需取消请选择取消按钮");
                                        }
                                        else if (dateTime < DateTime.Now)
                                        {
                                            MessageBox.Show("由你接单的该悬赏可正常结束");
                                            done_reward_take(stu_recieve_reward_id[i - 1]);
                                        }
                                    }
                                }
                                dt.Clear();

                            }
                        }
                        //重新展示已报名课程和已接单悬赏控件内容
                        show_take();
                    }

                    //清除已接单悬赏控件内的选择状态
                    listView_take_reward.SelectedItems.Clear();
                }

                //显示异常情况详细内容
                catch (Exception d)
                {
                    MessageBox.Show("结束已报名课程和已接单悬赏过程出错，出错内容：" + d.Message);
                }
            }
        }
        //传入已报名课程id进行结束
        private void done_course_take(long cid)
        {
            //打开数据库
            if (is_open_conn() == true)
            {
                conn.Close();
                conn.Open();
            }
            else conn.Open();

            try
            {//将该用户报名该课程的记录状态设置为1
                string sql = @"UPDATE [HEACHER].[dbo].[USERS_APPLY_COURSES] SET [UAC_STATE] = 1 WHERE USERS_APPLY_COURSES.SNO='" + sno + "' and USERS_APPLY_COURSES.CID='" + cid + "'";
                SqlCommand sda = new SqlCommand(sql, conn);
                int y = sda.ExecuteNonQuery();



                //查找这门课的积分价格并记录下来
                double price = jifen_course_check(cid);

                //查找开设这门课的学生
                long s = course_publish_sno(cid);

                //为开设这门课程的学生修改信誉值（用评价值来修改）
                xinyu(Convert.ToInt32(Take_assess.ToString()), s);

                //为两端的学生修改积分
                jifen(price, s);
                jifen(-price, sno);

                //关闭数据库
                conn.Close();
                //判断是否已完全结束，并做出提示,若已完全结束，则可以利用取消代码做处理
                if (bool_cid(cid))
                {
                    cancel_course_publish(cid);
                    cancel_course_take(cid);
                }

            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show("传入已报名课程id进行结束过程出错，出错内容：" + e.Message);
            }
        }
        //传入已接单悬赏id进行结束
        private void done_reward_take(long rid)
        {
            //打开数据库
            if (is_open_conn() == true)
            {
                conn.Close();
                conn.Open();
            }
            else conn.Open();

            try
            {
                //将该用户接单该悬赏的记录状态设置为1
                string sql = @"UPDATE [HEACHER].[dbo].[USERS_RECEIVE_REWARDS] SET [URR_STATE] = 1 WHERE [USERS_RECEIVE_REWARDS].SNO='" + sno + "' and [USERS_RECEIVE_REWARDS].RID='" + rid + "'";
                SqlCommand sda = new SqlCommand(sql, conn);
                sda.Dispose();

                //查找这个悬赏的积分价格并记录下来
                double price = jifen_reward_check(rid);

                //查找发布这个悬赏的学生
                long s = reward_publish_sno(rid);

                //为发布这门悬赏的学生修改信誉值（用评价值来修改）
                xinyu(Convert.ToInt32(Take_assess.Text.ToString()), s);

                //为两端的学生修改积分
                jifen(-price, s);
                jifen(price, sno);


                //关闭数据库
                conn.Close();

                //判断是否已完全结束，并做出提示,若已完全结束，则可以利用取消代码做处理
                bool i = bool_rid(rid);
                if (i)
                {
                    cancel_reward_publish(rid);
                    cancel_reward_take(rid);
                }


            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show("传入已接单悬赏id进行结束过程出错，出错内容：" + e.Message);
            }
        }


        //结束已发布课程或者已发布悬赏
        private void Publish_finish_Click(object sender, EventArgs e)
        {
            if (Publish_score.Text == "")
            {
                MessageBox.Show("请先填写评价等级");
            }
            else
            {
                try
                {
                    //在展示已发布课程控件中循环，找到用户选择的课程
                    foreach (ListViewItem lv in listview_publish_course.SelectedItems)
                    {
                        //从已发布课程id列表中按照顺序找到对应id
                        for (int i = 1; i <= stu_publish_course_id.Count; i++)
                        {
                            if (i == lv.Index)
                            {
                                //打开数据库
                                if (is_open_conn() == true)
                                {
                                    conn.Close();
                                    conn.Open();
                                }
                                else conn.Open();

                                //选择出发布的课程的对应时间，并判断是否在合理时间内结束
                                string sql = @"SELECT[CTIME] FROM [HEACHER].[dbo].[COURSES] where CID='" + stu_publish_course_id[i - 1] + "'";
                                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                                DataTable dt = new DataTable();
                                sda.Fill(dt);

                                //关闭数据库
                                conn.Close();
                                foreach (DataRow dr in dt.Rows)
                                {
                                    DialogResult result = MessageBox.Show("是否确定结束？", "提示消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (result == DialogResult.Yes)
                                    {
                                        DateTime dateTime = Convert.ToDateTime(dr[0]);
                                        if (dateTime > DateTime.Now)
                                        {
                                            MessageBox.Show("由你开设的课程尚未开始，无法结束，如需取消请选择取消按钮");
                                        }
                                        else if (dateTime < DateTime.Now)
                                        {
                                            MessageBox.Show("由你开设的课程可正常结束");
                                            done_course_publish(stu_publish_course_id[i - 1]);
                                        }
                                    }

                                }
                                dt.Clear();

                            }
                        }
                        //重新展示发布课程或者悬赏控件的内容
                        show_publish();
                    }

                    //清除发布课程显示控件上的选择状态
                    listview_publish_course.SelectedItems.Clear();

                    //在展示已发布课程控件中循环，找到用户选择的悬赏
                    foreach (ListViewItem lv in listView_publish_reward.SelectedItems)
                    {
                        //从已发布悬赏id列表中按照顺序找到对应id
                        for (int i = 1; i <= stu_publish_reward_id.Count; i++)
                        {
                            if (i == lv.Index)
                            {
                                //打开数据库
                                if (is_open_conn() == true)
                                {
                                    conn.Close();
                                    conn.Open();
                                }
                                else conn.Open();

                                //选择出该悬赏的时间，并判断是否是在三天前内取消
                                string sql = @"SELECT[RTIME] FROM [HEACHER].[dbo].[REWARDS] where RID='" + stu_publish_reward_id[i - 1] + "'";
                                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                                DataTable dt = new DataTable();
                                sda.Fill(dt);

                                //关闭数据库
                                conn.Close();
                                foreach (DataRow dr in dt.Rows)
                                {
                                    DialogResult result = MessageBox.Show("是否确定结束？", "提示消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (result == DialogResult.Yes)
                                    {
                                        DateTime dateTime = Convert.ToDateTime(dr[0]);
                                        if (dateTime > DateTime.Now)
                                        {
                                            MessageBox.Show("由你发布的悬赏尚未开始，无法结束，如需取消请选择取消按钮");
                                        }
                                        else if (dateTime < DateTime.Now)
                                        {
                                            MessageBox.Show("由你发布悬赏可正常结束");
                                            done_reward_publish(stu_publish_reward_id[i - 1]);
                                        }
                                    }
                                }
                                dt.Clear();
                            }
                        }
                        //重新显示已发布课程和悬赏控件内容
                        show_publish();
                    }
                    //取消已发布悬赏控件的选择状态
                    listView_publish_reward.SelectedItems.Clear();
                }
                //处理异常
                catch (Exception d)
                {
                    MessageBox.Show("结束已发布课程或者已发布悬赏过程出错，出错内容：" + d.Message);
                }
            }
        }
        //传入已发布课程id进行结束
        private void done_course_publish(long cid)
        {
            //打开数据库
            if (is_open_conn() == true)
            {
                conn.Close();
                conn.Open();
            }
            else conn.Open();

            try
            {
                //将该用户发布该课程的记录状态设置为1
                string sql = @"UPDATE [HEACHER].[dbo].[USERS_ESTABLISH_COURSES] SET [UEC_STATE] =1  WHERE [USERS_ESTABLISH_COURSES].SNO='" + sno + "' and [USERS_ESTABLISH_COURSES].CID='" + cid + "'";
                SqlCommand sda = new SqlCommand(sql, conn);

                //为报名该课程的学生修改信誉值（用评价值来修改）
                string sq = @"SELECT users.[SNO] FROM [HEACHER].[dbo].[USERS_APPLY_COURSES] joIn USERS on [USERS_APPLY_COURSES] .SNO=USERs.SNO where [USERS_APPLY_COURSES].CID='" + cid + "'";
                SqlDataAdapter sd = new SqlDataAdapter(sq, conn);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                sda.Dispose();
                foreach (DataRow dr in dt.Rows)
                {
                    xinyu(Convert.ToInt32(Publish_score.Text.ToString()), Convert.ToInt64(dr[0].ToString()));
                }

                //关闭数据库
                conn.Close();

                //判断是否已完全结束，并做出提示,若已完全结束，则可以利用取消代码做处理
                if (bool_cid(cid))
                {
                    cancel_course_publish(cid);
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("传入已发布悬赏id进行结束过程出错，出错内容：" + e.Message);
                conn.Close();
            }
        }
        //传入已发布悬赏id进行结束
        private void done_reward_publish(long rid)
        {
            //打开数据库
            if (is_open_conn() == true)
            {
                conn.Close();
                conn.Open();
            }
            else conn.Open();
            try
            {
                //将该用户发布该悬赏的记录状态设置为1
                string sql = @"UPDATE [HEACHER].[dbo].[USERS_PUBLISH_REWARDS] SET [UPR_STATE] =1  WHERE [USERS_PUBLISH_REWARDS].SNO='" + sno + "' and [USERS_PUBLISH_REWARDS].RID='" + rid + "'";
                SqlCommand sda = new SqlCommand(sql, conn);
                int y = sda.ExecuteNonQuery();

                //为接单该悬赏的学生修改信誉值（用评价值来修改）
                string sq = @"SELECT users.[SNO] FROM [HEACHER].[dbo].[USERS_RECEIVE_REWARDS] joIn USERS on USERS_RECEIVE_REWARDS .SNO=USERs.SNO where USERS_RECEIVE_REWARDS.RID='" + rid + "'";
                SqlDataAdapter sd = new SqlDataAdapter(sq, conn);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                sda.Dispose();
                foreach (DataRow dr in dt.Rows)
                {
                    xinyu(Convert.ToInt32(Publish_score.Text.ToString()), Convert.ToInt64(dr[0].ToString()));
                }
                //关闭数据库
                conn.Close();
                //判断是否已完全结束，并做出提示,若已完全结束，则可以利用取消代码做处理
                if (bool_rid(rid))
                {
                    cancel_reward_publish(rid);
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("传入已发布悬赏id进行结束过程出错，出错内容：" + e.Message);
                conn.Close();
            }
        }



        //将sno1用户的信誉值做相应的加减
        private void xinyu(int x, long sno1)
        {
            //打开数据库
            if (is_open_conn() == false)
            {
                conn.Open();
            }
            try
            {
                string sql = @"UPDATE [HEACHER].[dbo].[USERS]  SET [SCREDIT] +=" + x + " WHERE SNO='" + sno1 + "';";
                SqlCommand sda = new SqlCommand(sql, conn);
                int y = sda.ExecuteNonQuery();
                if (y == 0)
                {
                    MessageBox.Show("信誉值修改失败");
                }
                else MessageBox.Show("已修改信誉值");

            }
            catch (Exception e)
            {
                MessageBox.Show("信誉值修改过程出错,出错内容：" + e.Message);
            }
        }

        //将sno1用户的积分值做相应的加减
        private void jifen(double x, long sno1)
        {
            //打开数据库
            if (is_open_conn() == false)
            {
                conn.Open();
            }
            try
            {
                string sql = @"UPDATE [HEACHER].[dbo].[USERS]  SET [SSCORE] +=" + x + " WHERE SNO='" + sno1 + "';";
                SqlCommand sda = new SqlCommand(sql, conn);
                int y = sda.ExecuteNonQuery();
                if (y == 0)
                {
                    MessageBox.Show("积分值修改失败");
                }
                else MessageBox.Show("已修改积分值");
            }
            catch (Exception e)
            {
                MessageBox.Show("积分值修改过程出错,出错内容：" + e.Message);
            }
        }

        //查找对应课程的积分值并返回
        private double jifen_course_check(long cid)
        {
            //打开数据库
            if (is_open_conn() == false)
            {
                conn.Open();
            }
            string sql = @"SELECT [CPRICE] FROM [HEACHER].[dbo].[COURSES] where COURSES.CID='" + cid + "'";
            SqlCommand sda = new SqlCommand(sql, conn);
            SqlDataReader reader = sda.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string s = reader[0].ToString();
                    reader.Close();
                    return Convert.ToDouble(s);
                }
                reader.Close();

                return 0;
            }
            catch (Exception e)
            {
                reader.Close();
                MessageBox.Show("查找对应课程的积分值过程出错，出错内容：" + e.Message);
                return 0;
            }
        }
        //查找对应悬赏的积分值并返回
        private double jifen_reward_check(long rid)
        {
            //打开数据库
            if (is_open_conn() == false)
            {
                conn.Open();
            }
            string sql = @"SELECT [RPRICE] FROM [HEACHER].[dbo].[REWARDS] where REWARDS.RID='" + rid + "'";
            SqlCommand sda = new SqlCommand(sql, conn);
            SqlDataReader reader = sda.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    string s = reader[0].ToString();
                    reader.Close();
                    return Convert.ToDouble(s);
                }

                reader.Close();
                return 0;
            }
            catch (Exception e)
            {
                reader.Close();
                MessageBox.Show("查找对应悬赏的积分值过程出错,出错内容：" + e.Message);
                return 0;
            }
        }

        //查找对应课程的开课学号
        private long course_publish_sno(long cid)
        {
            //打开数据库
            if (is_open_conn() == false)
            {
                conn.Open();
            }
            string sql = @"SELECT [SNO] FROM [HEACHER].[dbo].[USERS_ESTABLISH_COURSES] where USERS_ESTABLISH_COURSES.CID='" + cid + "'";
            SqlCommand sda = new SqlCommand(sql, conn);
            SqlDataReader reader = sda.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string s = reader[0].ToString();
                    reader.Close();
                    return Convert.ToInt64(s);
                }
                reader.Close();
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("查找对应课程的开课学号过程出错,出错内容：" + e.Message);
                reader.Close();
                return 0;
            }
        }
        //查找对应悬赏的发布学号
        private long reward_publish_sno(long rid)
        {
            //打开数据库
            if (is_open_conn() == false)
            {
                conn.Open();
            }
            string sql = @"SELECT [SNO] FROM [HEACHER].[dbo].[USERS_PUBLISH_REWARDS] where [USERS_PUBLISH_REWARDS].RID='" + rid + "'";
            SqlCommand sda = new SqlCommand(sql, conn);
            SqlDataReader reader = sda.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string s = reader[0].ToString();
                    reader.Close();
                    return Convert.ToInt64(s);

                }

                reader.Close();
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("查找对应悬赏的发布学号过程出错,出错内容：" + e.Message);
                reader.Close();
                return 0;
            }
        }

        //判断课程是否完全结束
        private bool bool_cid(long cid)
        {
            //打开数据库
            if (is_open_conn() == false)
            {
                conn.Open();
            }
            try
            {
                string sql = @"SELECT [UEC_STATE] FROM [HEACHER].[dbo].[USERS_ESTABLISH_COURSES] where USERS_ESTABLISH_COURSES.CID='" + cid + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Dispose();
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr[0].ToString()) == 1)
                    {
                        string sq2 = @"SELECT [UAC_STATE] FROM [HEACHER].[dbo].[USERS_APPLY_COURSES] where USERS_APPLY_COURSES.CID='" + cid + "'";
                        SqlDataAdapter sd = new SqlDataAdapter(sq2, conn);
                        DataTable d = new DataTable();
                        sd.Fill(d);
                        sd.Dispose();
                        foreach (DataRow ds in dt.Rows)
                        {
                            if (Convert.ToInt32(ds[0].ToString()) == 1)
                            {
                                continue;
                            }
                            else
                            {
                                MessageBox.Show("课程未完全结束，在双方均作出评价以后，课程将自动结束，您的评价已记录");
                                return false;
                            }
                        }
                        d.Clear();
                        d.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("课程未完全结束，在双方均作出评价以后，课程将自动结束，您的评价已记录");
                        return false;
                    }
                    return true;
                }
                dt.Clear();
                dt.Dispose();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("判断课程是否完全结束过程出错,出错内容：" + e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        //判断悬赏是否完全结束
        private bool bool_rid(long rid)
        {
            //打开数据库
            if (is_open_conn() == false)
            {
                conn.Open();
            }
            try
            {
                string sql = @"SELECT [UPR_STATE] FROM [HEACHER].[dbo].[USERS_PUBLISH_REWARDS] where[USERS_PUBLISH_REWARDS].RID='" + rid + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Dispose();
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr[0].ToString()) == 1)
                    {
                        string sq2 = @"SELECT [URR_STATE] FROM [HEACHER].[dbo].[USERS_RECEIVE_REWARDS] where [USERS_RECEIVE_REWARDS].RID='" + rid + "'";
                        SqlDataAdapter sd = new SqlDataAdapter(sq2, conn);
                        DataTable d = new DataTable();
                        sd.Fill(d);
                        sd.Dispose();
                        foreach (DataRow ds in dt.Rows)
                        {
                            if (Convert.ToInt32(ds[0].ToString()) == 1)
                            {
                                continue;
                            }
                            else
                            {
                                MessageBox.Show("悬赏未完全结束，在双方均作出评价以后，悬赏将自动结束，您的评价已记录");
                                return false;
                            }
                        }
                        d.Clear();
                        d.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("悬赏未完全结束，在双方均作出评价以后，悬赏将自动结束，您的评价已记录");
                        return false;
                    }
                    return true;
                }
                dt.Clear();
                dt.Dispose();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("判断悬赏是否完全结束过程出错,出错内容：" + e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void checkboxShowPaw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPaw.Checked == true)
                User_password.Text = pwd;
            else
                User_password.Text = "******";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("再次确认是否修改数据", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
        //2019.6.12添加该函数
        private void listview_publish_course_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string course_number = "";
            List<string> info = new List<string>();
            try
            {
                foreach (ListViewItem lv in listview_publish_course.SelectedItems)
                {
                    //从已发布课程id列表中按照顺序找到对应id
                    for (int i = 1; i <= stu_publish_course_id.Count; i++)
                    {
                        if (i == lv.Index)
                        {
                            course_number = stu_publish_course_id[i - 1].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            publish_class_user_info publish_Class_User_Info = new publish_class_user_info(Convert.ToInt64(course_number.ToString()));
            publish_Class_User_Info.Show();
        }
        //2019.6.12添加该函数
        private void listView_publish_reward_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string rid_number = "";
            List<string> info = new List<string>();
            try
            {
                foreach (ListViewItem lv in listView_publish_reward.SelectedItems)
                {
                    //从已发布悬赏id列表中按照顺序找到对应id
                    for (int i = 1; i <= stu_publish_reward_id.Count; i++)
                    {
                        if (i == lv.Index)
                        {
                            rid_number = stu_publish_reward_id[i - 1].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            publish_reward_user_info publish_Reward_User_Info = new publish_reward_user_info(Convert.ToInt64(rid_number.ToString()));
            publish_Reward_User_Info.Show();
        }
        //2019.6.12添加该函数
        private void ListView_take_course_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string course_number = "";
            List<string> info = new List<string>();
            try
            {
                foreach (ListViewItem lv in ListView_take_course.SelectedItems)
                {
                    //从已发布课程id列表中按照顺序找到对应id
                    for (int i = 1; i <= stu_apply_course_id.Count; i++)
                    {
                        if (i == lv.Index)
                        {
                            course_number = stu_apply_course_id[i - 1].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            regist_class_use_info regist_Class_Use_Info = new regist_class_use_info(Convert.ToInt32(course_number.ToString()));
            regist_Class_Use_Info.Show();
            ;
        }
        //2019.6.12添加该函数
        private void listView_take_reward_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string rid_number = "";
            List<string> info = new List<string>();
            try
            {
                foreach (ListViewItem lv in listView_take_reward.SelectedItems)
                {
                    //从已发布悬赏id列表中按照顺序找到对应id
                    for (int i = 1; i <= stu_recieve_reward_id.Count; i++)
                    {
                        if (i == lv.Index)
                        {
                            rid_number = stu_recieve_reward_id[i - 1].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            recieve_reward_user_info recieve_Reward_User_Info = new recieve_reward_user_info(Convert.ToInt64(rid_number.ToString()));
            recieve_Reward_User_Info.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgNumber = comboBox1.SelectedItem.ToString();

            SqlConnection conn = new SqlConnection(connstr);
            string sql = @"update users set simagenumber=" + int.Parse(imgNumber) + "where sno ='" + SNO + "'";
            string sql1 = @"Select * from image where number='" + imgNumber + "'";
            conn.Open();

            SqlCommand sc1 = new SqlCommand(sql, conn);
            SqlDataReader sd1 = sc1.ExecuteReader();
            conn.Close();
            conn.Open();
            SqlCommand sc = new SqlCommand(sql1, conn);
            SqlDataReader sd = sc.ExecuteReader();
            sd.Read();
            byte[] b = (byte[])sd["IMAGES"];
            if (b.Length > 0)
            {
                MemoryStream stream = new MemoryStream(b);
                //tream.Write(b, 0, b.Length);
                //MessageBox.Show(stream.Length.ToString());

                //Bitmap bmpt = new Bitmap(stream);
                pic_Head.SizeMode = PictureBoxSizeMode.Zoom;
                pic_Head.Image = Image.FromStream(stream);
                User_image.SizeMode = PictureBoxSizeMode.Zoom;
                User_image.Image = Image.FromStream(stream);
                //ImageListViewItem lvi = new ImageListViewItem();
                //lvi.Text = "DEMO";
                //lvi.ThumbnailImage = bmpt;//设置显示 image   报错
                //imageListView1.Items.Add(lvi);
                stream.Close();
            }

        }

        private void Student_id_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        for (int i = 0; i < 9; i++)
        //        {
        //            string connString = connstr;
        //            SqlConnection connection = new SqlConnection(connString);//创建connection对象


        //            string sql = "update Image set images =  (@blobdata) where number='" + (i + 1).ToString() + "'";
        //            SqlCommand command = new SqlCommand(sql, connection);
        //            //图片路径
        //            string picturePath = @"C:\Users\Administrator.WIN-4K5HDJFV5BS\Desktop\新建文件夹\" + (i + 1).ToString() + ".png"; //注意，这里需要指定保存图片的绝对路径和图片?

        //            //文件的名称，每次必须更换图片的名称，这里很为不便
        //            //创建FileStream对象
        //            FileStream fs = new FileStream(picturePath, FileMode.Open, FileAccess.Read);
        //            //声明Byte数组
        //            Byte[] mybyte = new byte[fs.Length];
        //            //读取数据
        //            fs.Read(mybyte, 0, mybyte.Length);
        //            fs.Close();
        //            //转换成二进制数据，并保存到数据库
        //            SqlParameter prm = new SqlParameter
        //          ("@blobdata", SqlDbType.VarBinary, mybyte.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mybyte);
        //            command.Parameters.Add(prm);
        //            //打开数据库连接
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //            connection.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
