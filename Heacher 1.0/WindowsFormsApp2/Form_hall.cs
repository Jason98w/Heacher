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
    public partial class Form_hall : Form
    {
        private string Sno;
        bool isLesson = false;
        bool isReward = false;
        //标识符        
        public static int price_sign = 0;//多次点击排序出现变化的标志
        public static int state_sign = 0;


        string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";

        public Form_hall(string sno)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Sno = sno;
            this.sno = long.Parse(sno);
         //   pictureBox1.BackColor.;
            chushihua(sno);
        }
        //2019.6.12修改该函数
        private void chushihua(string sno)
        {
            //clear all the items
            Reward_year.Items.Clear();
            Reward_month.Items.Clear();
            Reward_day.Items.Clear();
            Reward_hour.Items.Clear();
            Reward_min.Items.Clear();
            Lesson_year.Items.Clear();
            Lesson_month.Items.Clear();
            Lesson_day.Items.Clear();
            Lesson_hour.Items.Clear();
            Lesson_min.Items.Clear();

            //把所有控件设置为只能选择下拉框值，无法自己手动输入值
            Reward_year.DropDownStyle = ComboBoxStyle.DropDownList;
            Reward_month.DropDownStyle = ComboBoxStyle.DropDownList;
            Reward_day.DropDownStyle = ComboBoxStyle.DropDownList;
            Reward_hour.DropDownStyle = ComboBoxStyle.DropDownList;
            Reward_min.DropDownStyle = ComboBoxStyle.DropDownList;
            Lesson_year.DropDownStyle = ComboBoxStyle.DropDownList;
            Lesson_month.DropDownStyle = ComboBoxStyle.DropDownList;
            Lesson_day.DropDownStyle = ComboBoxStyle.DropDownList;
            Lesson_hour.DropDownStyle = ComboBoxStyle.DropDownList;
            Lesson_month.DropDownStyle = ComboBoxStyle.DropDownList;
            Lesson_min.DropDownStyle = ComboBoxStyle.DropDownList;

            //存储该学生的入学年份，毕业年份，以及当前时间
            int first = int.Parse(sno.Substring(0, 4));
            int last = first + 4;
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;

            //对年份combobox进行初始化数据
            for (int i = year; i <= last; i++)
            {
                Reward_year.Items.Add(i);
                Lesson_year.Items.Add(i);
            }
            Reward_year.Text = year.ToString();
            Lesson_year.Text = year.ToString();

            //对月份combobox进行初始化数据
            for (int i = 1; i <= 12; i++)
            {
                Reward_month.Items.Add(i);
                Lesson_month.Items.Add(i);
            }
            Reward_month.Text = month.ToString();
            Lesson_month.Text = month.ToString();

            //对日combobox进行初始化数据
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                for (int i = 1; i <= 31; i++)
                {
                    Reward_day.Items.Add(i);
                    Lesson_day.Items.Add(i);
                }
            }
            else if (month == 2)
            {
                if (IsLearYear(year))
                {
                    for (int i = 1; i <= 29; i++)
                    {
                        Reward_day.Items.Add(i);
                        Lesson_day.Items.Add(i);
                    }
                }
                else
                {
                    for (int i = 1; i <= 28; i++)
                    {
                        Reward_day.Items.Add(i);
                        Lesson_day.Items.Add(i);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 30; i++)
                {
                    Reward_day.Items.Add(i);
                    Lesson_day.Items.Add(i);
                }
            }
            Reward_day.Text = day.ToString();
            Lesson_day.Text = day.ToString();

            //对时combobox进行初始化数据
            for (int i = 7; i <= 22; i++)
            {
                Reward_hour.Items.Add(i);
                Lesson_hour.Items.Add(i);
            }
            Reward_hour.Text = hour.ToString();
            Lesson_hour.Text = hour.ToString();

            //对分combobox进行初始化数据
            for (int i = 0; i < 60; i++)
            {
                Reward_min.Items.Add(i);
                Lesson_min.Items.Add(i);
            }
            Reward_min.Text = min.ToString();
            Lesson_min.Text = min.ToString();
        }
        //2019.6.12修改该函数
        private void Reward_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] mouth = new int[] { 1, 3, 5, 7, 8, 10, 12 };
            int day = 0;
            if (mouth.Contains(int.Parse(Reward_month.SelectedItem.ToString())))
            {
                day = 31;
            }
            else if (int.Parse(Reward_month.SelectedItem.ToString()) == 2)
            {
                if (IsLearYear(int.Parse(Reward_year.SelectedItem.ToString())))
                {
                    day = 29;
                }
                else
                    day = 28;
            }
            else
                day = 30;
            Reward_day.Items.Clear();
            for (int i = 1; i <= day; i++)
            {
                Reward_day.Items.Add(i);
            }
        }
        //2019.6.12修改该函数
        private void Lesson_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] mouth = new int[] { 1, 3, 5, 7, 8, 10, 12 };
            int day = 0;
            if (mouth.Contains(int.Parse(Lesson_month.SelectedItem.ToString())))
            {
                day = 31;

            }
            else if (int.Parse(Lesson_month.Text.ToString()) == 2)
            {
                if (IsLearYear(int.Parse(Lesson_year.SelectedItem.ToString())))
                {
                    day = 29;
                }
                else
                    day = 28;
            }
            else
                day = 30;
            Lesson_day.Items.Clear();
            for (int i = 1; i <= day; i++)
            {
                Lesson_day.Items.Add(i);
            }
        }
        //2019.6.12添加该函数
        private void Lesson_year_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Lesson_year.SelectedItem.ToString() == DateTime.Now.Year.ToString())
                Lesson_month.Text = "1";
        }
        //2019.6.12添加该函数
        private void Reward_year_SelectedValueChanged(object sender, EventArgs e)
        {
            Reward_month.Text = "1";
        }

        private bool IsLearYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;
            return false;
        }



        private void Search_Click(object sender, EventArgs e)
        {
            ListView_homepage.Visible = false;
            ListView_reward.Visible = true;
            ListView_lesson.Visible = false;
            string text = Searchbox.Text;//存储搜索框中的内容
            if (isLesson)
            {
                ListView_reward.Visible = false;
                ListView_lesson.Visible = true;
                ListView_lesson.Items.Clear();
                //数据处理操作---课程
                SqlConnection conn1 = new SqlConnection(connstr);
                conn1.Open();
                string sql = @"SELECT * FROM C_INFO WHERE 课程名称 LIKE '%[" + text + @"]%' UNION " +
                @"SELECT * FROM C_INFO WHERE 开课人 LIKE '%[" + text + @"]%' UNION " +
                //@"SELECT * FROM C_INFO WHERE 价格 LIKE '%[" + text + @"]%' UNION " +
                //@"SELECT * FROM C_INFO WHERE 时间 LIKE '%[" + text + @"]%' UNION " +
                @"SELECT * FROM C_INFO WHERE 地点 LIKE '%[" + text + @"]%'";
                SqlCommand sc1 = new SqlCommand(sql, conn1);
                SqlDataReader sdr1 = sc1.ExecuteReader();        //得到数据读取器
                while (sdr1.Read())                                           //读取数据
                {
                    ListViewItem lv = new ListViewItem(sdr1[0].ToString());

                    lv.SubItems.Add(sdr1[1].ToString());
                    lv.SubItems.Add(sdr1[3].ToString());
                    lv.SubItems.Add(sdr1[4].ToString());
                    lv.SubItems.Add(sdr1[2].ToString());
                    lv.SubItems.Add(sdr1[5].ToString() + "/" + sdr1[6].ToString());
                    ListView_lesson.Items.Add(lv);
                }
                conn1.Close();        //关闭数据库连接
            }
            else if (isReward)
            {
                ListView_lesson.Visible = false;
                ListView_reward.Visible = true;
                ListView_reward.Items.Clear();
                //数据处理操作---课程
                SqlConnection conn2 = new SqlConnection(connstr);
                conn2.Open();
                string sql = @"SELECT * FROM R_INFO WHERE 悬赏名称 LIKE '%[" + text + @"]%' UNION " +
                 @"SELECT * FROM R_INFO WHERE 发布人 LIKE '%[" + text + @"]%' UNION " +
                 //@"SELECT * FROM R_INFO WHERE 价格 LIKE '%[" + text + @"]%' UNION " +
                 //@"SELECT * FROM R_INFO WHERE 时间 LIKE '%[" + text + @"]%' UNION " +
                 @"SELECT * FROM R_INFO WHERE 地点 LIKE '%[" + text + @"]%'";
                SqlCommand sc2 = new SqlCommand(sql, conn2);
                SqlDataReader sdr2 = sc2.ExecuteReader();        //得到数据读取器
                while (sdr2.Read())                                           //读取数据
                {
                    ListViewItem lv = new ListViewItem(sdr2[0].ToString());

                    lv.SubItems.Add(sdr2[1].ToString());
                    lv.SubItems.Add(sdr2[3].ToString());
                    lv.SubItems.Add(sdr2[4].ToString());
                    lv.SubItems.Add(sdr2[2].ToString());
                    ListView_reward.Items.Add(lv);
                }
                conn2.Close();        //关闭数据库连接
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_feedback frm = new Form_feedback(Sno);
            frm.ShowDialog();
        }

        private void Form_hall_Load(object sender, EventArgs e)
        {
            this.ListView_homepage.Visible = false;
            this.ListView_reward.Visible = true;
            this.ListView_lesson.Visible = false;
            this.Panel_publish_lesson.Visible = false;
            this.Panel_publish_reward.Visible = false;
            ListView_reward.Items.Clear();

            Reward.BackColor = Color.CornflowerBlue;
            Reward.ForeColor = Color.White;
            Lesson.BackColor = Color.Transparent;
            Lesson.ForeColor = Color.Black;
            Publish_reward.BackColor = Color.Transparent;
            Publish_reward.ForeColor = Color.Black;
            Publish_lesson.BackColor = Color.Transparent;
            Publish_lesson.ForeColor = Color.Black;
            isReward = true;
            isLesson = false;
            #region 悬赏信息展示数据库处理
            //数据处理操作---课程
            SqlConnection conn2 = new SqlConnection(connstr);
            conn2.Open();
            string sql2 = @"SELECT * FROM R_INFO";
            SqlCommand sc2 = new SqlCommand(sql2, conn2);
            SqlDataReader sdr2 = sc2.ExecuteReader();        //得到数据读取器
            while (sdr2.Read())                                           //读取数据
            {
                ListViewItem lv = new ListViewItem(sdr2[0].ToString());

                lv.SubItems.Add(sdr2[1].ToString());
                lv.SubItems.Add(sdr2[3].ToString());
                lv.SubItems.Add(sdr2[4].ToString());
                lv.SubItems.Add(sdr2[2].ToString());
                //标识符
                lv.SubItems.Add(sdr2[5].ToString() + "/1");
              
                ListView_reward.Items.Add(lv);
            }
            conn2.Close();        //关闭数据库连接
            #endregion
        }

        private void User_image_Click(object sender, EventArgs e)
        {
            Form_user frm = new Form_user(Sno);
            //数据库操作 

            frm.ShowDialog();

        }

        private void Reward_Click(object sender, EventArgs e)
        {
            //标识符
            this.Searchbox.Visible = true;
            this.Search.Visible = true;

            this.ListView_homepage.Visible = false;
            this.ListView_reward.Visible = true;
            this.ListView_lesson.Visible = false;
            this.Panel_publish_lesson.Visible = false;
            this.Panel_publish_reward.Visible = false;
            //  this.Panel_rewards.BringToFront();

            //Reward.BackColor = Color.CornflowerBlue;
            //Reward.ForeColor = Color.White;
            //Lesson.BackColor = Color.Transparent;
            //Lesson.ForeColor = Color.Black;
            //Publish_reward.BackColor = Color.Transparent;
            //Publish_reward.ForeColor = Color.Black;
            //Publish_lesson.BackColor = Color.Transparent;
            //Publish_lesson.ForeColor = Color.Black;

            Reward.BackColor = Color.LightGray;
            Reward.ForeColor = Color.CornflowerBlue;
            Lesson.BackColor = Color.Transparent;
            Lesson.ForeColor = Color.Black;
            Publish_reward.BackColor = Color.Transparent;
            Publish_reward.ForeColor = Color.Black;
            Publish_lesson.BackColor = Color.Transparent;
            Publish_lesson.ForeColor = Color.Black;


            ListView_reward.Items.Clear();
            #region 悬赏信息展示数据库处理
            //数据处理操作---课程
            SqlConnection conn2 = new SqlConnection(connstr);
            conn2.Open();
            string sql2 = @"SELECT * FROM R_INFO";
            SqlCommand sc2 = new SqlCommand(sql2, conn2);
            SqlDataReader sdr2 = sc2.ExecuteReader();        //得到数据读取器
            while (sdr2.Read())                                           //读取数据
            {
                ListViewItem lv = new ListViewItem(sdr2[0].ToString());

                lv.SubItems.Add(sdr2[1].ToString());
                lv.SubItems.Add(sdr2[3].ToString());
                lv.SubItems.Add(sdr2[4].ToString());
                lv.SubItems.Add(sdr2[2].ToString());
                //标识符
                lv.SubItems.Add(sdr2[5].ToString() + "/1");

                ListView_reward.Items.Add(lv);
            }
            conn2.Close();        //关闭数据库连接
            #endregion

            isReward = true;
            isLesson = false;

            //标识符
            state_sign = 0;
            price_sign = 0;
        }

        private void Lesson_Click(object sender, EventArgs e)
        {
            //标识符
            this.Searchbox.Visible = true;
            this.Search.Visible = true;

            this.ListView_homepage.Visible = false;
            this.ListView_reward.Visible = false;
            this.ListView_lesson.Visible = true;
            this.Panel_publish_lesson.Visible = false;
            this.Panel_publish_reward.Visible = false;
            this.ListView_lesson.BringToFront();

            Lesson.BackColor = Color.LightGray;
            Lesson.ForeColor = Color.CornflowerBlue;
            Reward.BackColor = Color.Transparent;
            Reward.ForeColor = Color.Black;
            Publish_reward.BackColor = Color.Transparent;
            Publish_reward.ForeColor = Color.Black;
            Publish_lesson.BackColor = Color.Transparent;
            Publish_lesson.ForeColor = Color.Black;

            isReward = false;
            isLesson = true;

            ListView_lesson.Items.Clear();
            #region 课程信息展示数据库处理
            //数据处理操作---课程
            SqlConnection conn1 = new SqlConnection(connstr);
            conn1.Open();
            string sql1 = @"SELECT * FROM C_INFO";
            SqlCommand sc1 = new SqlCommand(sql1, conn1);
            SqlDataReader sdr1 = sc1.ExecuteReader();        //得到数据读取器
            while (sdr1.Read())                                           //读取数据
            {
                ListViewItem lv = new ListViewItem(sdr1[0].ToString());

                lv.SubItems.Add(sdr1[1].ToString());
                lv.SubItems.Add(sdr1[3].ToString());
                lv.SubItems.Add(sdr1[4].ToString());
                lv.SubItems.Add(sdr1[2].ToString());
                lv.SubItems.Add(sdr1[5].ToString() + "/" + sdr1[6].ToString());
                ListView_lesson.Items.Add(lv);
            }
            conn1.Close();        //关闭数据库连接
            #endregion

            //标识符
            state_sign = 0;
            price_sign = 0;
        }

        private void Publish_reward_Click(object sender, EventArgs e)
        {
            //标识符
            this.Searchbox.Visible = false;
            this.Search.Visible = false;

            this.ListView_homepage.Visible = false;
            this.ListView_reward.Visible = false;
            this.ListView_lesson.Visible = false;
            this.Panel_publish_lesson.Visible = false;
            this.Panel_publish_reward.Visible = true;
            this.Panel_publish_reward.BringToFront();

            Publish_reward.BackColor = Color.LightGray;
            Publish_reward.ForeColor = Color.CornflowerBlue;
            Lesson.BackColor = Color.Transparent;
            Lesson.ForeColor = Color.Black;
            Reward.BackColor = Color.Transparent;
            Reward.ForeColor = Color.Black;
            Publish_lesson.BackColor = Color.Transparent;
            Publish_lesson.ForeColor = Color.Black;

        }

        private void Publish_lesson_Click(object sender, EventArgs e)
        {
            this.ListView_homepage.Visible = false;
            this.ListView_reward.Visible = false;
            this.ListView_lesson.Visible = false;
            this.Panel_publish_lesson.Visible = true;
            this.Panel_publish_reward.Visible = false;
            this.Panel_publish_lesson.BringToFront();

            Publish_lesson.BackColor = Color.LightGray;
            Publish_lesson.ForeColor = Color.CornflowerBlue;
            Publish_reward.BackColor = Color.Transparent;
            Publish_reward.ForeColor = Color.Black;
            Reward.BackColor = Color.Transparent;
            Reward.ForeColor = Color.Black;
            Lesson.BackColor = Color.Transparent;
            Lesson.ForeColor = Color.Black;

        }





        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            //    int ms = e.NewValue - e.OldValue;
            //    Panel_publish_reward.Height = Panel_publish_reward.Height - ms;
            //
        }

        private void Form_hall_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("是否确认退出?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                Dispose();
                System.Environment.Exit(0);
            }
            if (result.Equals(DialogResult.No))
            {
                e.Cancel = true;
            }



        }
        Boolean textboxHasText1 = false;
        private void Searchbox_Enter(object sender, EventArgs e)
        {
            if (textboxHasText1 == false)
            {
                Searchbox.Text = "";
                Searchbox.ForeColor = Color.Black;
            }
        }

        private void Searchbox_Leave(object sender, EventArgs e)
        {
            if (Searchbox.Text == "")
            {
                Searchbox.Text = "输入关键字查询";
                Searchbox.ForeColor = Color.SlateGray;
                textboxHasText1 = false;
            }
            else textboxHasText1 = true;
        }



        private void Form_hall_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Application.Exit();
        }

        private void ListView_lesson_DoubleClick(object sender, EventArgs e)
        {
            //存储被选中的那一行的所有信息
            List<string> info = new List<string>();
            try
            {
                info.Add(ListView_lesson.SelectedItems[0].SubItems[0].Text.ToString());
                info.Add(ListView_lesson.SelectedItems[0].SubItems[2].Text.ToString());
                info.Add(ListView_lesson.SelectedItems[0].SubItems[3].Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Form_lesson_info1 fi = new Form_lesson_info1(info, Sno);
            fi.Show();
            //标识符            
            fi.MyEvent += new Form_lesson_info1.MyDelegate(Lesson_Click);

        }

        private void ListView_lesson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView_reward_DoubleClick(object sender, EventArgs e)
        {
            //存储被选中的那一行的所有信息
            List<string> info = new List<string>();
            try
            {
                info.Add(ListView_reward.SelectedItems[0].SubItems[0].Text.ToString());
                info.Add(ListView_reward.SelectedItems[0].SubItems[2].Text.ToString());
                info.Add(ListView_reward.SelectedItems[0].SubItems[3].Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Form_reward_info1 fi = new Form_reward_info1(info, Sno);
            fi.Show();
            //标识符
            fi.MyEvent += new Form_reward_info1.MyDelegate(Reward_Click);
        }
        //利用连接字符串连接数据库
        //static string connstr = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HEACHER;Data Source=DESKTOP-C8J3AGD\SQLEXPRESS";
        //该用户的学号
        long sno;
        //2019.6.7修改以下代码
        public void Button_pub_les_Click(object sender, EventArgs e)
        {

            if ((Lesson_name.Text.ToString() == "") || (Lesson_year.Text.ToString() == "") || (Lesson_month.Text.ToString() == "") || (Lesson_day.Text.ToString() == "") || (Lesson_hour.Text.ToString() == "") || (Lesson_min.Text.ToString() == "") || (Lesson_place.Text.ToString() == "") || (Lesson_price.Text.ToString() == "") || (Introduction.Text.ToString() == "") || (Lesson_people.Text.ToString() == "") || Convert.ToDouble(Lesson_price.Text.ToString()) <= 0 || Convert.ToDouble(Lesson_people.Text.ToString()) <= 0)
            {
                MessageBox.Show("填写内容不能为空，字数不可超出规定范围，价格或人数不能为非正数");
            }
            else
            {
                try
                {
                    //用到学号
                    Courses courses = new Courses(sno, Lesson_name.Text.ToString(), Convert.ToInt32(Lesson_year.Text.ToString()), Convert.ToInt32(Lesson_month.Text.ToString()), Convert.ToInt32(Lesson_day.Text.ToString()), Convert.ToInt32(Lesson_hour.Text.ToString()), Convert.ToInt32(Lesson_min.Text.ToString()), Lesson_place.Text.ToString(), Convert.ToDouble(Lesson_price.Text.ToString()), Introduction.Text.ToString(), Convert.ToInt32(Lesson_people.Text.ToString()));
                    //用到学号
                    bool i = courses.Establish_Class(sno);
                    if (i == true)
                    {
                        MessageBox.Show("发布成功");
                        Lesson_name.Text = "";
                        Lesson_year.Text = "";
                        Lesson_month.Text = "";
                        Lesson_day.Text = "";
                        Lesson_hour.Text = "";
                        Lesson_min.Text = "";
                        Lesson_place.Text = "";
                        Lesson_price.Text = "";
                        Introduction.Text = "";
                        Lesson_people.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("发布失败");
                    }
                }
                catch
                {
                    MessageBox.Show("请按格式填写");
                }

            }
        }

        public void Button_pub_rew_Click(object sender, EventArgs e)
        {
            if ((Reward_name.Text.ToString() == "") | (Reward_year.Text.ToString() == "") | (Reward_month.Text.ToString() == "") | (Reward_day.Text.ToString() == "") | (Reward_hour.Text.ToString() == "") | (Reward_min.Text.ToString() == "") | (Reward_place.Text.ToString() == "") | (Reward_price.Text.ToString() == "") | (Requirement.Text.ToString() == "") || Convert.ToDouble(Reward_price.Text.ToString()) <= 0)
            {
                MessageBox.Show("请将内容填写完整,字数不可超出规定范围，报酬不能为负数");
            }
            else
            {
                try
                {
                    Rewards rewards = new Rewards(sno, Reward_name.Text.ToString(), Convert.ToInt32(Reward_year.Text.ToString()), Convert.ToInt32(Reward_month.Text.ToString()), Convert.ToInt32(Reward_day.Text.ToString()), Convert.ToInt32(Reward_hour.Text.ToString()), Convert.ToInt32(Reward_min.Text.ToString()), Reward_place.Text.ToString(), Convert.ToDouble(Reward_price.Text.ToString()), Requirement.Text.ToString());

                    bool j = rewards.Publish_Reward(sno);

                    if (j == true)
                    {

                        MessageBox.Show("发布成功");
                        Reward_name.Text = "";
                        Reward_year.Text = "";
                        Reward_month.Text = "";
                        Reward_day.Text = "";
                        Reward_hour.Text = "";
                        Reward_min.Text = "";
                        Reward_place.Text = "";
                        Reward_price.Text = "";
                        Requirement.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("发布失败");
                    }
                }
                catch
                {
                    MessageBox.Show("请按格式填写");
                }
            }
        }

        //2019.6.12修改以下代码
        public class Courses
        {
            public long Cid = 0;
            public string CName, Clocation, Cdetailed_Introduction;
            public DateTime date;
            public double Cprice = 0;
            public int Max_Persons = 0;
            public int Registered_Persons = 0;

            string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";

            //利用构造函数初始化课程信息
            public Courses(long sno, string cname, int year, int month, int day, int hour, int minute, string clocation, double cprice, string cdetailed_Introduction, int max_persons)
            {

                Cid = Convert.ToInt64((Convert.ToInt32(sno % 1000000)).ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString());
                this.CName = cname;
                this.date = new DateTime(year, month, day, hour, minute, 0);
                this.Clocation = clocation;
                this.Cprice = cprice;
                this.Cdetailed_Introduction = cdetailed_Introduction;
                this.Max_Persons = max_persons;

            }
            //将课程信息存入数据库
            public bool Establish_Class(long Sno)
            {

                if (this.date < DateTime.Now.AddMinutes(15))
                {
                    MessageBox.Show("设置的开始时间无效，请重新设置(请将发布时间调整为十五分钟以后)");
                }
                else
                {
                    try
                    {
                        string sq2 = "insert into COURSES(CID,CNAME,CTIME,CLOCATION,CPRICE,CDETAILED_INTRODUCTION,CMAX_PERSONS) values(" + this.Cid + ",'" + this.CName + "','" + this.date + "','" + this.Clocation + "'," + this.Cprice + ",'" + this.Cdetailed_Introduction + "'," + this.Max_Persons + ")";
                        string sql = "insert into USERS_ESTABLISH_COURSES(SNO,CID) values(" + Sno + "," + this.Cid + ")";
                        SqlConnection oledb = new SqlConnection(connstr);
                        oledb.Open();
                        SqlCommand oleDbCommand1 = new SqlCommand(sq2, oledb);
                        SqlCommand oleDbCommand2 = new SqlCommand(sql, oledb);

                        int i = oleDbCommand1.ExecuteNonQuery();
                        int j = oleDbCommand2.ExecuteNonQuery();

                        if (i == 1 && j == 1)
                        {
                            return true;
                        }
                        oledb.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return false;
                    }
                }
                return false;
            }
        }
        //2019.6.12修改以下代码
        public class Rewards
        {
            public long Rid = 0;
            public string Rname, Rlocation, Rrequire;
            public DateTime Rtime;
            public double Rprice = 0;
            public char Rstate = '0';

            string connstr = @"data source=132.232.156.108;" +
                        "initial catalog=heacher;persist security info=true;" +
                        "user id=sa;password=qq1234@ ";

            //利用构造函数初始化
            public Rewards(long sno, string rname, int year, int month, int day, int hour, int minute, string rlocation, double rprice, string rrequire)
            {
                Rid = Convert.ToInt64((Convert.ToInt64(sno % 1000000)).ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString());
                this.Rname = rname;
                this.Rtime = new DateTime(year, month, day, hour, minute, 0);
                this.Rlocation = rlocation;
                this.Rprice = rprice;
                this.Rrequire = rrequire;
            }
            //将数据存入数据库
            public bool Publish_Reward(long Sno)
            {
                if (this.Rtime < DateTime.Now.AddMinutes(15))
                {
                    MessageBox.Show("设置的开始时间无效，请重新设置(请将发布时间调整为十五分钟以后)");
                }
                else
                {
                    try
                    {
                        string sq2 = "insert into REWARDS (RID ,RNAME ,RTIME,RLOCATION,RPRICE,RREQUIRE) values(" + this.Rid + ",'" + this.Rname + "','" + this.Rtime + "','" + this.Rlocation + "'," + this.Rprice + ",'" + this.Rrequire + "')";
                        string sql = "insert into USERS_PUBLISH_REWARDS(SNO,RID) values(" + Sno + "," + this.Rid + ")";
                        SqlConnection oledb = new SqlConnection(connstr);
                        oledb.Open();
                        SqlCommand oleDbCommand1 = new SqlCommand(sq2, oledb);
                        SqlCommand oleDbCommand2 = new SqlCommand(sql, oledb);

                        int i = oleDbCommand1.ExecuteNonQuery();
                        int j = oleDbCommand2.ExecuteNonQuery();

                        if (i == 1 && j == 1)
                        {
                            return true;
                        }
                        oledb.Close();
                    }
                    catch
                    {
                        return false;
                    }
                }
                return false;
            }
        }
        //标识符
        //此处更改需要对在ListView控件中增加该事件
        private void ListView_reward_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 4 when price_sign % 3 == 0:
                    #region 悬赏信息排序处理---赏金升序
                    ListView_reward.Items.Clear();
                    //数据处理操作---课程
                    SqlConnection conn1 = new SqlConnection(connstr);
                    conn1.Open();
                    string sql1 = @"SELECT * FROM R_INFO ORDER BY 价格 ASC";
                    SqlCommand sc1 = new SqlCommand(sql1, conn1);
                    SqlDataReader sdr1 = sc1.ExecuteReader();        //得到数据读取器
                    while (sdr1.Read())                                           //读取数据
                    {
                        ListViewItem lv = new ListViewItem(sdr1[0].ToString());

                        lv.SubItems.Add(sdr1[1].ToString());
                        lv.SubItems.Add(sdr1[3].ToString());
                        lv.SubItems.Add(sdr1[4].ToString());
                        lv.SubItems.Add(sdr1[2].ToString());
                        //标识符            
                        lv.SubItems.Add(sdr1[5].ToString() + "/1");
                        ListView_reward.Items.Add(lv);
                    }
                    conn1.Close();        //关闭数据库连接
                    #endregion
                    price_sign++;
                    break;
                case 4 when price_sign % 3 == 1:
                    #region 悬赏信息排序处理---赏金降序
                    ListView_reward.Items.Clear();
                    //数据处理操作---课程
                    SqlConnection conn2 = new SqlConnection(connstr);
                    conn2.Open();
                    string sql2 = @"SELECT * FROM R_INFO ORDER BY 价格 DESC";
                    SqlCommand sc2 = new SqlCommand(sql2, conn2);
                    SqlDataReader sdr2 = sc2.ExecuteReader();        //得到数据读取器
                    while (sdr2.Read())                                           //读取数据
                    {
                        ListViewItem lv = new ListViewItem(sdr2[0].ToString());

                        lv.SubItems.Add(sdr2[1].ToString());
                        lv.SubItems.Add(sdr2[3].ToString());
                        lv.SubItems.Add(sdr2[4].ToString());
                        lv.SubItems.Add(sdr2[2].ToString());
                        //标识符
                        lv.SubItems.Add(sdr2[5].ToString() + "/1");
                        ListView_reward.Items.Add(lv);
                    }
                    conn2.Close();        //关闭数据库连接
                    #endregion
                    price_sign++;
                    break;
                case 4 when price_sign % 3 == 2:
                    #region 悬赏信息排序处理---赏金最初始状态
                    ListView_reward.Items.Clear();
                    //数据处理操作---课程
                    SqlConnection conn3 = new SqlConnection(connstr);
                    conn3.Open();
                    string sql3 = @"SELECT * FROM R_INFO";
                    SqlCommand sc3 = new SqlCommand(sql3, conn3);
                    SqlDataReader sdr3 = sc3.ExecuteReader();        //得到数据读取器
                    while (sdr3.Read())                                           //读取数据
                    {
                        ListViewItem lv = new ListViewItem(sdr3[0].ToString());

                        lv.SubItems.Add(sdr3[1].ToString());
                        lv.SubItems.Add(sdr3[3].ToString());
                        lv.SubItems.Add(sdr3[4].ToString());
                        lv.SubItems.Add(sdr3[2].ToString());
                        //标识符
                        lv.SubItems.Add(sdr3[5].ToString() + "/1");
                        ListView_reward.Items.Add(lv);
                    }
                    conn3.Close();        //关闭数据库连接
                    #endregion
                    price_sign++;
                    break;
                case 5 when state_sign % 3 == 0:
                    #region 悬赏信息排序处理---状态升序
                    ListView_reward.Items.Clear();
                    //数据处理操作---课程
                    SqlConnection conn4 = new SqlConnection(connstr);
                    conn4.Open();
                    string sql4 = @"SELECT * FROM R_INFO ORDER BY 状态 ASC";
                    SqlCommand sc4 = new SqlCommand(sql4, conn4);
                    SqlDataReader sdr4 = sc4.ExecuteReader();        //得到数据读取器
                    while (sdr4.Read())                                           //读取数据
                    {
                        ListViewItem lv = new ListViewItem(sdr4[0].ToString());

                        lv.SubItems.Add(sdr4[1].ToString());
                        lv.SubItems.Add(sdr4[3].ToString());
                        lv.SubItems.Add(sdr4[4].ToString());
                        lv.SubItems.Add(sdr4[2].ToString());
                        //标识符
                        lv.SubItems.Add(sdr4[5].ToString() + "/1");
                        ListView_reward.Items.Add(lv);
                    }
                    conn4.Close();        //关闭数据库连接
                    #endregion
                    state_sign++;
                    break;
                case 5 when state_sign % 3 == 1:
                    #region 悬赏信息排序处理---状态降序
                    ListView_reward.Items.Clear();
                    //数据处理操作---课程
                    SqlConnection conn5 = new SqlConnection(connstr);
                    conn5.Open();
                    string sql5 = @"SELECT * FROM R_INFO ORDER BY 状态 DESC";
                    SqlCommand sc5 = new SqlCommand(sql5, conn5);
                    SqlDataReader sdr5 = sc5.ExecuteReader();        //得到数据读取器
                    while (sdr5.Read())                                           //读取数据
                    {
                        ListViewItem lv = new ListViewItem(sdr5[0].ToString());

                        lv.SubItems.Add(sdr5[1].ToString());
                        lv.SubItems.Add(sdr5[3].ToString());
                        lv.SubItems.Add(sdr5[4].ToString());
                        lv.SubItems.Add(sdr5[2].ToString());
                        //标识符
                        lv.SubItems.Add(sdr5[5].ToString() + "/1");
                        ListView_reward.Items.Add(lv);
                    }
                    conn5.Close();        //关闭数据库连接
                    #endregion
                    state_sign++;
                    break;
                case 5 when state_sign % 3 == 2:
                    #region 悬赏信息排序处理---状态升序
                    ListView_reward.Items.Clear();
                    //数据处理操作---课程
                    SqlConnection conn6 = new SqlConnection(connstr);
                    conn6.Open();
                    string sql6 = @"SELECT * FROM R_INFO";
                    SqlCommand sc6 = new SqlCommand(sql6, conn6);
                    SqlDataReader sdr6 = sc6.ExecuteReader();        //得到数据读取器
                    while (sdr6.Read())                                           //读取数据
                    {
                        ListViewItem lv = new ListViewItem(sdr6[0].ToString());

                        lv.SubItems.Add(sdr6[1].ToString());
                        lv.SubItems.Add(sdr6[3].ToString());
                        lv.SubItems.Add(sdr6[4].ToString());
                        lv.SubItems.Add(sdr6[2].ToString());
                        //标识符
                        lv.SubItems.Add(sdr6[5].ToString() + "/1");
                        ListView_reward.Items.Add(lv);
                    }
                    conn6.Close();        //关闭数据库连接
                    #endregion
                    state_sign++;
                    break;
            }
        }
        //标识符
        private void ListView_lesson_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 4 when price_sign % 3 == 0:
                    #region 课程信息展示---金额升序
                    ListView_lesson.Items.Clear();
                    //数据处理操作---课程
                    SqlConnection conn1 = new SqlConnection(connstr);
                    conn1.Open();
                    string sql1 = @"SELECT * FROM C_INFO ORDER BY 价格 ASC";
                    SqlCommand sc1 = new SqlCommand(sql1, conn1);
                    SqlDataReader sdr1 = sc1.ExecuteReader();        //得到数据读取器
                    while (sdr1.Read())                                           //读取数据
                    {
                        ListViewItem lv = new ListViewItem(sdr1[0].ToString());

                        lv.SubItems.Add(sdr1[1].ToString());
                        lv.SubItems.Add(sdr1[3].ToString());
                        lv.SubItems.Add(sdr1[4].ToString());
                        lv.SubItems.Add(sdr1[2].ToString());
                        lv.SubItems.Add(sdr1[5].ToString() + "/" + sdr1[6].ToString());
                        ListView_lesson.Items.Add(lv);
                    }
                    conn1.Close();        //关闭数据库连接
                    #endregion
                    price_sign++;
                    break;
                case 4 when price_sign % 3 == 1:
                    #region 课程信息展示---金额降序
                    ListView_lesson.Items.Clear();
                    //数据处理操作---课程
                    SqlConnection conn2 = new SqlConnection(connstr);
                    conn2.Open();
                    string sql2 = @"SELECT * FROM C_INFO ORDER BY 价格 DESC";
                    SqlCommand sc2 = new SqlCommand(sql2, conn2);
                    SqlDataReader sdr2 = sc2.ExecuteReader();        //得到数据读取器
                    while (sdr2.Read())                                           //读取数据
                    {
                        ListViewItem lv = new ListViewItem(sdr2[0].ToString());

                        lv.SubItems.Add(sdr2[1].ToString());
                        lv.SubItems.Add(sdr2[3].ToString());
                        lv.SubItems.Add(sdr2[4].ToString());
                        lv.SubItems.Add(sdr2[2].ToString());
                        lv.SubItems.Add(sdr2[5].ToString() + "/" + sdr2[6].ToString());
                        ListView_lesson.Items.Add(lv);
                    }
                    conn2.Close();        //关闭数据库连接
                    #endregion
                    price_sign++;
                    break;
                case 4 when price_sign % 3 == 2:
                    #region 课程信息展示---金额初态
                    ListView_lesson.Items.Clear();
                    //数据处理操作---课程
                    SqlConnection conn3 = new SqlConnection(connstr);
                    conn3.Open();
                    string sql3 = @"SELECT * FROM C_INFO";
                    SqlCommand sc3 = new SqlCommand(sql3, conn3);
                    SqlDataReader sdr3 = sc3.ExecuteReader();        //得到数据读取器
                    while (sdr3.Read())                                           //读取数据
                    {
                        ListViewItem lv = new ListViewItem(sdr3[0].ToString());

                        lv.SubItems.Add(sdr3[1].ToString());
                        lv.SubItems.Add(sdr3[3].ToString());
                        lv.SubItems.Add(sdr3[4].ToString());
                        lv.SubItems.Add(sdr3[2].ToString());
                        lv.SubItems.Add(sdr3[5].ToString() + "/" + sdr3[6].ToString());
                        ListView_lesson.Items.Add(lv);
                    }
                    conn3.Close();        //关闭数据库连接
                    #endregion
                    price_sign++;
                    break;
                case 5 when state_sign % 3 == 0:
                    #region 课程信息展示---状态升序
                    ListView_lesson.Items.Clear();
                    //数据处理操作---课程
                    SqlConnection conn4 = new SqlConnection(connstr);
                    conn4.Open();
                    string sql4 = @"SELECT * FROM C_INFO ORDER BY 已报人数 ASC, 人数上限 DESC";
                    SqlCommand sc4 = new SqlCommand(sql4, conn4);
                    SqlDataReader sdr4 = sc4.ExecuteReader();        //得到数据读取器
                    while (sdr4.Read())                                           //读取数据
                    {
                        ListViewItem lv = new ListViewItem(sdr4[0].ToString());

                        lv.SubItems.Add(sdr4[1].ToString());
                        lv.SubItems.Add(sdr4[3].ToString());
                        lv.SubItems.Add(sdr4[4].ToString());
                        lv.SubItems.Add(sdr4[2].ToString());
                        lv.SubItems.Add(sdr4[5].ToString() + "/" + sdr4[6].ToString());
                        ListView_lesson.Items.Add(lv);
                    }
                    conn4.Close();        //关闭数据库连接
                    #endregion
                    state_sign++;
                    break;
                case 5 when state_sign % 3 == 1:
                    #region 课程信息展示---状态降序
                    ListView_lesson.Items.Clear();
                    //数据处理操作---课程
                    SqlConnection conn5 = new SqlConnection(connstr);
                    conn5.Open();
                    string sql5 = @"SELECT * FROM C_INFO ORDER BY 已报人数 DESC, 人数上限 ASC";
                    SqlCommand sc5 = new SqlCommand(sql5, conn5);
                    SqlDataReader sdr5 = sc5.ExecuteReader();        //得到数据读取器
                    while (sdr5.Read())                                           //读取数据
                    {
                        ListViewItem lv = new ListViewItem(sdr5[0].ToString());

                        lv.SubItems.Add(sdr5[1].ToString());
                        lv.SubItems.Add(sdr5[3].ToString());
                        lv.SubItems.Add(sdr5[4].ToString());
                        lv.SubItems.Add(sdr5[2].ToString());
                        lv.SubItems.Add(sdr5[5].ToString() + "/" + sdr5[6].ToString());
                        ListView_lesson.Items.Add(lv);
                    }
                    conn5.Close();        //关闭数据库连接
                    #endregion
                    state_sign++;
                    break;
                case 5 when state_sign % 3 == 2:
                    #region 课程信息展示---状态初态
                    ListView_lesson.Items.Clear();
                    //数据处理操作---课程
                    SqlConnection conn6 = new SqlConnection(connstr);
                    conn6.Open();
                    string sql6 = @"SELECT * FROM C_INFO";
                    SqlCommand sc6 = new SqlCommand(sql6, conn6);
                    SqlDataReader sdr6 = sc6.ExecuteReader();        //得到数据读取器
                    while (sdr6.Read())                                           //读取数据
                    {
                        ListViewItem lv = new ListViewItem(sdr6[0].ToString());

                        lv.SubItems.Add(sdr6[1].ToString());
                        lv.SubItems.Add(sdr6[3].ToString());
                        lv.SubItems.Add(sdr6[4].ToString());
                        lv.SubItems.Add(sdr6[2].ToString());
                        lv.SubItems.Add(sdr6[5].ToString() + "/" + sdr6[6].ToString());
                        ListView_lesson.Items.Add(lv);
                    }
                    conn6.Close();        //关闭数据库连接
                    #endregion
                    state_sign++;
                    break;
            }
        }

    }
}
