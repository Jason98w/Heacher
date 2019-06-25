namespace WindowsFormsApp2
{
    partial class Form_user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_user));
            this.User_image = new System.Windows.Forms.PictureBox();
            this.Button_publish = new System.Windows.Forms.Button();
            this.Button_take = new System.Windows.Forms.Button();
            this.Button_revise = new System.Windows.Forms.Button();
            this.Button_feedback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.User_name = new System.Windows.Forms.Label();
            this.User_password = new System.Windows.Forms.Label();
            this.Student_id = new System.Windows.Forms.Label();
            this.Student_name = new System.Windows.Forms.Label();
            this.User_score = new System.Windows.Forms.Label();
            this.User_credit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.User_tell = new System.Windows.Forms.Label();
            this.User_email = new System.Windows.Forms.Label();
            this.Panel_revise = new System.Windows.Forms.Panel();
            this.Submit = new System.Windows.Forms.Button();
            this.Revise_password = new System.Windows.Forms.TextBox();
            this.Revise_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Panel_infomation = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkboxShowPaw = new System.Windows.Forms.CheckBox();
            this.pic_Head = new System.Windows.Forms.PictureBox();
            this.Panel_publish = new System.Windows.Forms.Panel();
            this.listView_publish_reward = new System.Windows.Forms.ListView();
            this.label13 = new System.Windows.Forms.Label();
            this.Publish_score = new System.Windows.Forms.ComboBox();
            this.Publish_finish = new System.Windows.Forms.Button();
            this.Publish_cancel = new System.Windows.Forms.Button();
            this.listview_publish_course = new System.Windows.Forms.ListView();
            this.Panel_take = new System.Windows.Forms.Panel();
            this.listView_take_reward = new System.Windows.Forms.ListView();
            this.label14 = new System.Windows.Forms.Label();
            this.Take_assess = new System.Windows.Forms.ComboBox();
            this.Take_finish = new System.Windows.Forms.Button();
            this.Take_cancel = new System.Windows.Forms.Button();
            this.ListView_take_course = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.User_image)).BeginInit();
            this.Panel_revise.SuspendLayout();
            this.Panel_infomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Head)).BeginInit();
            this.Panel_publish.SuspendLayout();
            this.Panel_take.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // User_image
            // 
            this.User_image.BackColor = System.Drawing.Color.Transparent;
            this.User_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User_image.Location = new System.Drawing.Point(52, 11);
            this.User_image.Name = "User_image";
            this.User_image.Size = new System.Drawing.Size(54, 49);
            this.User_image.TabIndex = 0;
            this.User_image.TabStop = false;
            this.User_image.Click += new System.EventHandler(this.User_image_Click);
            // 
            // Button_publish
            // 
            this.Button_publish.BackColor = System.Drawing.Color.Transparent;
            this.Button_publish.FlatAppearance.BorderSize = 0;
            this.Button_publish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_publish.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_publish.Location = new System.Drawing.Point(3, 66);
            this.Button_publish.Name = "Button_publish";
            this.Button_publish.Size = new System.Drawing.Size(136, 58);
            this.Button_publish.TabIndex = 1;
            this.Button_publish.Text = "已发布悬赏和课程";
            this.Button_publish.UseVisualStyleBackColor = false;
            this.Button_publish.Click += new System.EventHandler(this.Button_publish_Click);
            // 
            // Button_take
            // 
            this.Button_take.BackColor = System.Drawing.Color.Transparent;
            this.Button_take.FlatAppearance.BorderSize = 0;
            this.Button_take.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_take.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_take.Location = new System.Drawing.Point(1, 130);
            this.Button_take.Name = "Button_take";
            this.Button_take.Size = new System.Drawing.Size(136, 66);
            this.Button_take.TabIndex = 2;
            this.Button_take.Text = "已接单悬赏和已报名课程";
            this.Button_take.UseVisualStyleBackColor = false;
            this.Button_take.Click += new System.EventHandler(this.Button_take_Click);
            // 
            // Button_revise
            // 
            this.Button_revise.BackColor = System.Drawing.Color.Transparent;
            this.Button_revise.FlatAppearance.BorderSize = 0;
            this.Button_revise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_revise.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_revise.Location = new System.Drawing.Point(1, 202);
            this.Button_revise.Name = "Button_revise";
            this.Button_revise.Size = new System.Drawing.Size(139, 60);
            this.Button_revise.TabIndex = 3;
            this.Button_revise.Text = "修改个人信息";
            this.Button_revise.UseVisualStyleBackColor = false;
            this.Button_revise.Click += new System.EventHandler(this.Button_revise_Click);
            // 
            // Button_feedback
            // 
            this.Button_feedback.BackColor = System.Drawing.Color.Transparent;
            this.Button_feedback.FlatAppearance.BorderSize = 0;
            this.Button_feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_feedback.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_feedback.Location = new System.Drawing.Point(1, 268);
            this.Button_feedback.Name = "Button_feedback";
            this.Button_feedback.Size = new System.Drawing.Size(139, 60);
            this.Button_feedback.TabIndex = 4;
            this.Button_feedback.Text = "反馈";
            this.Button_feedback.UseVisualStyleBackColor = false;
            this.Button_feedback.Click += new System.EventHandler(this.Button_feedback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "基本信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(94, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "昵称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(94, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(94, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "学号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(94, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "姓名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(94, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "积分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(78, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "信誉度";
            // 
            // User_name
            // 
            this.User_name.AutoSize = true;
            this.User_name.BackColor = System.Drawing.Color.Transparent;
            this.User_name.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_name.Location = new System.Drawing.Point(138, 43);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(65, 27);
            this.User_name.TabIndex = 12;
            this.User_name.Text = "label8";
            // 
            // User_password
            // 
            this.User_password.AutoSize = true;
            this.User_password.BackColor = System.Drawing.Color.Transparent;
            this.User_password.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_password.Location = new System.Drawing.Point(138, 87);
            this.User_password.Name = "User_password";
            this.User_password.Size = new System.Drawing.Size(65, 27);
            this.User_password.TabIndex = 13;
            this.User_password.Text = "label8";
            // 
            // Student_id
            // 
            this.Student_id.AutoSize = true;
            this.Student_id.BackColor = System.Drawing.Color.Transparent;
            this.Student_id.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Student_id.Location = new System.Drawing.Point(138, 130);
            this.Student_id.Name = "Student_id";
            this.Student_id.Size = new System.Drawing.Size(65, 27);
            this.Student_id.TabIndex = 14;
            this.Student_id.Text = "label8";
            this.Student_id.Click += new System.EventHandler(this.Student_id_Click);
            // 
            // Student_name
            // 
            this.Student_name.AutoSize = true;
            this.Student_name.BackColor = System.Drawing.Color.Transparent;
            this.Student_name.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Student_name.Location = new System.Drawing.Point(138, 175);
            this.Student_name.Name = "Student_name";
            this.Student_name.Size = new System.Drawing.Size(65, 27);
            this.Student_name.TabIndex = 15;
            this.Student_name.Text = "label8";
            // 
            // User_score
            // 
            this.User_score.AutoSize = true;
            this.User_score.BackColor = System.Drawing.Color.Transparent;
            this.User_score.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_score.Location = new System.Drawing.Point(138, 227);
            this.User_score.Name = "User_score";
            this.User_score.Size = new System.Drawing.Size(65, 27);
            this.User_score.TabIndex = 16;
            this.User_score.Text = "label8";
            // 
            // User_credit
            // 
            this.User_credit.AutoSize = true;
            this.User_credit.BackColor = System.Drawing.Color.Transparent;
            this.User_credit.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_credit.Location = new System.Drawing.Point(138, 282);
            this.User_credit.Name = "User_credit";
            this.User_credit.Size = new System.Drawing.Size(65, 27);
            this.User_credit.TabIndex = 17;
            this.User_credit.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(13, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "联系信息";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(94, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 27);
            this.label9.TabIndex = 19;
            this.label9.Text = "邮箱";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(78, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 27);
            this.label10.TabIndex = 20;
            this.label10.Text = "手机号";
            // 
            // User_tell
            // 
            this.User_tell.AutoSize = true;
            this.User_tell.BackColor = System.Drawing.Color.Transparent;
            this.User_tell.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_tell.Location = new System.Drawing.Point(138, 396);
            this.User_tell.Name = "User_tell";
            this.User_tell.Size = new System.Drawing.Size(70, 27);
            this.User_tell.TabIndex = 21;
            this.User_tell.Text = "label11";
            // 
            // User_email
            // 
            this.User_email.AutoSize = true;
            this.User_email.BackColor = System.Drawing.Color.Transparent;
            this.User_email.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_email.Location = new System.Drawing.Point(138, 348);
            this.User_email.Name = "User_email";
            this.User_email.Size = new System.Drawing.Size(73, 27);
            this.User_email.TabIndex = 22;
            this.User_email.Text = "label12";
            // 
            // Panel_revise
            // 
            this.Panel_revise.BackColor = System.Drawing.Color.White;
            this.Panel_revise.Controls.Add(this.Submit);
            this.Panel_revise.Controls.Add(this.Revise_password);
            this.Panel_revise.Controls.Add(this.Revise_name);
            this.Panel_revise.Controls.Add(this.label12);
            this.Panel_revise.Controls.Add(this.label11);
            this.Panel_revise.Location = new System.Drawing.Point(230, 34);
            this.Panel_revise.Name = "Panel_revise";
            this.Panel_revise.Size = new System.Drawing.Size(450, 300);
            this.Panel_revise.TabIndex = 23;
            this.Panel_revise.Visible = false;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.Highlight;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(101, 137);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(226, 25);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "提交";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Revise_password
            // 
            this.Revise_password.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Revise_password.Location = new System.Drawing.Point(101, 84);
            this.Revise_password.Multiline = true;
            this.Revise_password.Name = "Revise_password";
            this.Revise_password.Size = new System.Drawing.Size(226, 25);
            this.Revise_password.TabIndex = 3;
            // 
            // Revise_name
            // 
            this.Revise_name.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Revise_name.Location = new System.Drawing.Point(101, 39);
            this.Revise_name.Multiline = true;
            this.Revise_name.Name = "Revise_name";
            this.Revise_name.Size = new System.Drawing.Size(226, 25);
            this.Revise_name.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(44, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 27);
            this.label12.TabIndex = 1;
            this.label12.Text = "密码:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(44, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "昵称:";
            // 
            // Panel_infomation
            // 
            this.Panel_infomation.BackColor = System.Drawing.Color.Transparent;
            this.Panel_infomation.Controls.Add(this.label15);
            this.Panel_infomation.Controls.Add(this.comboBox1);
            this.Panel_infomation.Controls.Add(this.checkboxShowPaw);
            this.Panel_infomation.Controls.Add(this.pic_Head);
            this.Panel_infomation.Controls.Add(this.label1);
            this.Panel_infomation.Controls.Add(this.label2);
            this.Panel_infomation.Controls.Add(this.User_tell);
            this.Panel_infomation.Controls.Add(this.User_email);
            this.Panel_infomation.Controls.Add(this.label10);
            this.Panel_infomation.Controls.Add(this.User_name);
            this.Panel_infomation.Controls.Add(this.label3);
            this.Panel_infomation.Controls.Add(this.User_password);
            this.Panel_infomation.Controls.Add(this.label9);
            this.Panel_infomation.Controls.Add(this.label4);
            this.Panel_infomation.Controls.Add(this.label8);
            this.Panel_infomation.Controls.Add(this.Student_id);
            this.Panel_infomation.Controls.Add(this.User_credit);
            this.Panel_infomation.Controls.Add(this.label5);
            this.Panel_infomation.Controls.Add(this.label7);
            this.Panel_infomation.Controls.Add(this.User_score);
            this.Panel_infomation.Controls.Add(this.Student_name);
            this.Panel_infomation.Controls.Add(this.label6);
            this.Panel_infomation.Location = new System.Drawing.Point(300, 30);
            this.Panel_infomation.Name = "Panel_infomation";
            this.Panel_infomation.Size = new System.Drawing.Size(312, 430);
            this.Panel_infomation.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 130);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 27);
            this.label15.TabIndex = 26;
            this.label15.Text = "头像编号:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(11, 149);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 35);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkboxShowPaw
            // 
            this.checkboxShowPaw.AutoSize = true;
            this.checkboxShowPaw.Location = new System.Drawing.Point(216, 87);
            this.checkboxShowPaw.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxShowPaw.Name = "checkboxShowPaw";
            this.checkboxShowPaw.Size = new System.Drawing.Size(118, 31);
            this.checkboxShowPaw.TabIndex = 24;
            this.checkboxShowPaw.Text = "显示密码";
            this.checkboxShowPaw.UseVisualStyleBackColor = true;
            this.checkboxShowPaw.CheckedChanged += new System.EventHandler(this.checkboxShowPaw_CheckedChanged);
            // 
            // pic_Head
            // 
            this.pic_Head.Location = new System.Drawing.Point(10, 55);
            this.pic_Head.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Head.Name = "pic_Head";
            this.pic_Head.Size = new System.Drawing.Size(79, 58);
            this.pic_Head.TabIndex = 23;
            this.pic_Head.TabStop = false;
            // 
            // Panel_publish
            // 
            this.Panel_publish.BackColor = System.Drawing.Color.Transparent;
            this.Panel_publish.Controls.Add(this.listView_publish_reward);
            this.Panel_publish.Controls.Add(this.label13);
            this.Panel_publish.Controls.Add(this.Publish_score);
            this.Panel_publish.Controls.Add(this.Publish_finish);
            this.Panel_publish.Controls.Add(this.Publish_cancel);
            this.Panel_publish.Controls.Add(this.listview_publish_course);
            this.Panel_publish.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Panel_publish.Location = new System.Drawing.Point(185, 34);
            this.Panel_publish.Name = "Panel_publish";
            this.Panel_publish.Size = new System.Drawing.Size(536, 353);
            this.Panel_publish.TabIndex = 23;
            this.Panel_publish.Visible = false;
            // 
            // listView_publish_reward
            // 
            this.listView_publish_reward.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_publish_reward.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_publish_reward.GridLines = true;
            this.listView_publish_reward.Location = new System.Drawing.Point(15, 127);
            this.listView_publish_reward.Margin = new System.Windows.Forms.Padding(2);
            this.listView_publish_reward.Name = "listView_publish_reward";
            this.listView_publish_reward.Size = new System.Drawing.Size(500, 113);
            this.listView_publish_reward.TabIndex = 6;
            this.listView_publish_reward.UseCompatibleStateImageBehavior = false;
            this.listView_publish_reward.View = System.Windows.Forms.View.SmallIcon;
            this.listView_publish_reward.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_publish_reward_MouseDoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(325, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 31);
            this.label13.TabIndex = 5;
            this.label13.Text = "评价";
            // 
            // Publish_score
            // 
            this.Publish_score.DropDownHeight = 50;
            this.Publish_score.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Publish_score.FormattingEnabled = true;
            this.Publish_score.IntegralHeight = false;
            this.Publish_score.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Publish_score.Location = new System.Drawing.Point(401, 273);
            this.Publish_score.Name = "Publish_score";
            this.Publish_score.Size = new System.Drawing.Size(121, 39);
            this.Publish_score.TabIndex = 4;
            // 
            // Publish_finish
            // 
            this.Publish_finish.FlatAppearance.BorderSize = 0;
            this.Publish_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Publish_finish.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Publish_finish.Location = new System.Drawing.Point(165, 267);
            this.Publish_finish.Name = "Publish_finish";
            this.Publish_finish.Size = new System.Drawing.Size(105, 30);
            this.Publish_finish.TabIndex = 2;
            this.Publish_finish.Text = "结束";
            this.Publish_finish.UseVisualStyleBackColor = true;
            this.Publish_finish.Click += new System.EventHandler(this.Publish_finish_Click);
            // 
            // Publish_cancel
            // 
            this.Publish_cancel.FlatAppearance.BorderSize = 0;
            this.Publish_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Publish_cancel.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Publish_cancel.Location = new System.Drawing.Point(15, 267);
            this.Publish_cancel.Name = "Publish_cancel";
            this.Publish_cancel.Size = new System.Drawing.Size(105, 30);
            this.Publish_cancel.TabIndex = 1;
            this.Publish_cancel.Text = "取消";
            this.Publish_cancel.UseVisualStyleBackColor = true;
            this.Publish_cancel.Click += new System.EventHandler(this.Publish_cancel_Click);
            // 
            // listview_publish_course
            // 
            this.listview_publish_course.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listview_publish_course.BackgroundImage")));
            this.listview_publish_course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listview_publish_course.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listview_publish_course.GridLines = true;
            this.listview_publish_course.Location = new System.Drawing.Point(15, 11);
            this.listview_publish_course.Name = "listview_publish_course";
            this.listview_publish_course.Size = new System.Drawing.Size(500, 113);
            this.listview_publish_course.TabIndex = 0;
            this.listview_publish_course.UseCompatibleStateImageBehavior = false;
            this.listview_publish_course.View = System.Windows.Forms.View.SmallIcon;
            this.listview_publish_course.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listview_publish_course_MouseDoubleClick);
            // 
            // Panel_take
            // 
            this.Panel_take.BackColor = System.Drawing.Color.Transparent;
            this.Panel_take.Controls.Add(this.listView_take_reward);
            this.Panel_take.Controls.Add(this.label14);
            this.Panel_take.Controls.Add(this.Take_assess);
            this.Panel_take.Controls.Add(this.Take_finish);
            this.Panel_take.Controls.Add(this.Take_cancel);
            this.Panel_take.Controls.Add(this.ListView_take_course);
            this.Panel_take.Location = new System.Drawing.Point(185, 34);
            this.Panel_take.Name = "Panel_take";
            this.Panel_take.Size = new System.Drawing.Size(539, 350);
            this.Panel_take.TabIndex = 0;
            this.Panel_take.Visible = false;
            // 
            // listView_take_reward
            // 
            this.listView_take_reward.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_take_reward.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_take_reward.GridLines = true;
            this.listView_take_reward.Location = new System.Drawing.Point(15, 127);
            this.listView_take_reward.Margin = new System.Windows.Forms.Padding(2);
            this.listView_take_reward.Name = "listView_take_reward";
            this.listView_take_reward.Size = new System.Drawing.Size(500, 113);
            this.listView_take_reward.TabIndex = 5;
            this.listView_take_reward.UseCompatibleStateImageBehavior = false;
            this.listView_take_reward.View = System.Windows.Forms.View.SmallIcon;
            this.listView_take_reward.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_take_reward_MouseDoubleClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(318, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 31);
            this.label14.TabIndex = 4;
            this.label14.Text = "评价";
            // 
            // Take_assess
            // 
            this.Take_assess.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Take_assess.FormattingEnabled = true;
            this.Take_assess.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Take_assess.Location = new System.Drawing.Point(394, 287);
            this.Take_assess.Name = "Take_assess";
            this.Take_assess.Size = new System.Drawing.Size(121, 35);
            this.Take_assess.TabIndex = 3;
            // 
            // Take_finish
            // 
            this.Take_finish.FlatAppearance.BorderSize = 0;
            this.Take_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Take_finish.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Take_finish.Location = new System.Drawing.Point(149, 281);
            this.Take_finish.Name = "Take_finish";
            this.Take_finish.Size = new System.Drawing.Size(105, 30);
            this.Take_finish.TabIndex = 2;
            this.Take_finish.Text = "结束";
            this.Take_finish.UseVisualStyleBackColor = true;
            this.Take_finish.Click += new System.EventHandler(this.Take_finish_Click);
            // 
            // Take_cancel
            // 
            this.Take_cancel.FlatAppearance.BorderSize = 0;
            this.Take_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Take_cancel.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Take_cancel.Location = new System.Drawing.Point(15, 281);
            this.Take_cancel.Name = "Take_cancel";
            this.Take_cancel.Size = new System.Drawing.Size(105, 30);
            this.Take_cancel.TabIndex = 1;
            this.Take_cancel.Text = "取消";
            this.Take_cancel.UseVisualStyleBackColor = true;
            this.Take_cancel.Click += new System.EventHandler(this.Take_cancel_Click);
            // 
            // ListView_take_course
            // 
            this.ListView_take_course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView_take_course.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListView_take_course.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListView_take_course.GridLines = true;
            this.ListView_take_course.Location = new System.Drawing.Point(14, 12);
            this.ListView_take_course.Name = "ListView_take_course";
            this.ListView_take_course.Size = new System.Drawing.Size(500, 113);
            this.ListView_take_course.TabIndex = 0;
            this.ListView_take_course.UseCompatibleStateImageBehavior = false;
            this.ListView_take_course.View = System.Windows.Forms.View.SmallIcon;
            this.ListView_take_course.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_take_course_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 362;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 1000;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Panel_infomation);
            this.panel1.Controls.Add(this.User_image);
            this.panel1.Controls.Add(this.Panel_take);
            this.panel1.Controls.Add(this.Panel_publish);
            this.panel1.Controls.Add(this.Button_publish);
            this.panel1.Controls.Add(this.Panel_revise);
            this.panel1.Controls.Add(this.Button_feedback);
            this.panel1.Controls.Add(this.Button_take);
            this.panel1.Controls.Add(this.Button_revise);
            this.panel1.Location = new System.Drawing.Point(1, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 465);
            this.panel1.TabIndex = 25;
            // 
            // Form_user
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(791, 499);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_user";
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.Form_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User_image)).EndInit();
            this.Panel_revise.ResumeLayout(false);
            this.Panel_revise.PerformLayout();
            this.Panel_infomation.ResumeLayout(false);
            this.Panel_infomation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Head)).EndInit();
            this.Panel_publish.ResumeLayout(false);
            this.Panel_publish.PerformLayout();
            this.Panel_take.ResumeLayout(false);
            this.Panel_take.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox User_image;
        private System.Windows.Forms.Button Button_publish;
        private System.Windows.Forms.Button Button_take;
        private System.Windows.Forms.Button Button_revise;
        private System.Windows.Forms.Button Button_feedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label User_name;
        private System.Windows.Forms.Label User_password;
        private System.Windows.Forms.Label Student_id;
        private System.Windows.Forms.Label Student_name;
        private System.Windows.Forms.Label User_score;
        private System.Windows.Forms.Label User_credit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label User_tell;
        private System.Windows.Forms.Label User_email;
        private System.Windows.Forms.Panel Panel_revise;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox Revise_password;
        private System.Windows.Forms.TextBox Revise_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel Panel_infomation;
        private System.Windows.Forms.Panel Panel_publish;
        private System.Windows.Forms.Button Publish_finish;
        private System.Windows.Forms.Button Publish_cancel;
        private System.Windows.Forms.ListView listview_publish_course;
        private System.Windows.Forms.Panel Panel_take;
        private System.Windows.Forms.ComboBox Publish_score;
        private System.Windows.Forms.ListView ListView_take_course;
        private System.Windows.Forms.Button Take_finish;
        private System.Windows.Forms.Button Take_cancel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Take_assess;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView_publish_reward;
        private System.Windows.Forms.ListView listView_take_reward;
        private System.Windows.Forms.PictureBox pic_Head;
        private System.Windows.Forms.CheckBox checkboxShowPaw;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
    }
}