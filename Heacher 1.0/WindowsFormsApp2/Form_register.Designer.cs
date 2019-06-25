namespace WindowsFormsApp2
{
    partial class Form_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_register));
            this.Student_id = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Student_name = new System.Windows.Forms.TextBox();
            this.Student_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_verify = new System.Windows.Forms.Button();
            this.True_green = new System.Windows.Forms.PictureBox();
            this.True_gray = new System.Windows.Forms.PictureBox();
            this.False_red = new System.Windows.Forms.PictureBox();
            this.False_gray = new System.Windows.Forms.PictureBox();
            this.User_name = new System.Windows.Forms.TextBox();
            this.User_password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Tell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_register = new System.Windows.Forms.Button();
            this.Button_back = new System.Windows.Forms.Button();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.True_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.True_gray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.False_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.False_gray)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Student_id
            // 
            this.Student_id.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Student_id.Location = new System.Drawing.Point(192, 61);
            this.Student_id.Multiline = true;
            this.Student_id.Name = "Student_id";
            this.Student_id.Size = new System.Drawing.Size(250, 25);
            this.Student_id.TabIndex = 1;
            this.Student_id.TextChanged += new System.EventHandler(this.Student_id_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 106);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(2, 2);
            this.textBox2.TabIndex = 1;
            // 
            // Student_name
            // 
            this.Student_name.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Student_name.Location = new System.Drawing.Point(192, 98);
            this.Student_name.Multiline = true;
            this.Student_name.Name = "Student_name";
            this.Student_name.Size = new System.Drawing.Size(250, 25);
            this.Student_name.TabIndex = 2;
            // 
            // Student_password
            // 
            this.Student_password.BackColor = System.Drawing.SystemColors.Window;
            this.Student_password.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Student_password.Location = new System.Drawing.Point(192, 132);
            this.Student_password.Multiline = true;
            this.Student_password.Name = "Student_password";
            this.Student_password.PasswordChar = '*';
            this.Student_password.Size = new System.Drawing.Size(250, 25);
            this.Student_password.TabIndex = 3;
            this.Student_password.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(138, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(138, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(112, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "教务密码：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Button_verify
            // 
            this.Button_verify.BackColor = System.Drawing.Color.Transparent;
            this.Button_verify.FlatAppearance.BorderSize = 0;
            this.Button_verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_verify.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_verify.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Button_verify.Location = new System.Drawing.Point(192, 173);
            this.Button_verify.Name = "Button_verify";
            this.Button_verify.Size = new System.Drawing.Size(114, 30);
            this.Button_verify.TabIndex = 7;
            this.Button_verify.Text = "验证";
            this.Button_verify.UseVisualStyleBackColor = false;
            this.Button_verify.Click += new System.EventHandler(this.Button_verify_Click);
            // 
            // True_green
            // 
            this.True_green.BackColor = System.Drawing.SystemColors.Control;
            this.True_green.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("True_green.BackgroundImage")));
            this.True_green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.True_green.Location = new System.Drawing.Point(345, 173);
            this.True_green.Name = "True_green";
            this.True_green.Size = new System.Drawing.Size(40, 30);
            this.True_green.TabIndex = 8;
            this.True_green.TabStop = false;
            // 
            // True_gray
            // 
            this.True_gray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("True_gray.BackgroundImage")));
            this.True_gray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.True_gray.Location = new System.Drawing.Point(345, 173);
            this.True_gray.Name = "True_gray";
            this.True_gray.Size = new System.Drawing.Size(40, 30);
            this.True_gray.TabIndex = 9;
            this.True_gray.TabStop = false;
            // 
            // False_red
            // 
            this.False_red.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("False_red.BackgroundImage")));
            this.False_red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.False_red.Location = new System.Drawing.Point(402, 173);
            this.False_red.Name = "False_red";
            this.False_red.Size = new System.Drawing.Size(40, 30);
            this.False_red.TabIndex = 10;
            this.False_red.TabStop = false;
            // 
            // False_gray
            // 
            this.False_gray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("False_gray.BackgroundImage")));
            this.False_gray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.False_gray.Location = new System.Drawing.Point(402, 173);
            this.False_gray.Name = "False_gray";
            this.False_gray.Size = new System.Drawing.Size(40, 30);
            this.False_gray.TabIndex = 11;
            this.False_gray.TabStop = false;
            // 
            // User_name
            // 
            this.User_name.Enabled = false;
            this.User_name.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.User_name.Location = new System.Drawing.Point(192, 270);
            this.User_name.Multiline = true;
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(250, 25);
            this.User_name.TabIndex = 12;
            this.User_name.Enter += new System.EventHandler(this.User_name_Enter);
            this.User_name.Leave += new System.EventHandler(this.User_name_Leave);
            // 
            // User_password
            // 
            this.User_password.Enabled = false;
            this.User_password.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.User_password.Location = new System.Drawing.Point(192, 311);
            this.User_password.Multiline = true;
            this.User_password.Name = "User_password";
            this.User_password.PasswordChar = '*';
            this.User_password.Size = new System.Drawing.Size(250, 25);
            this.User_password.TabIndex = 13;
            this.User_password.Enter += new System.EventHandler(this.User_password_Enter);
            this.User_password.Leave += new System.EventHandler(this.User_password_Leave);
            // 
            // Email
            // 
            this.Email.Enabled = false;
            this.Email.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Email.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Email.Location = new System.Drawing.Point(192, 393);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(250, 25);
            this.Email.TabIndex = 14;
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // Tell
            // 
            this.Tell.Enabled = false;
            this.Tell.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tell.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Tell.Location = new System.Drawing.Point(192, 427);
            this.Tell.Multiline = true;
            this.Tell.Name = "Tell";
            this.Tell.Size = new System.Drawing.Size(250, 25);
            this.Tell.TabIndex = 15;
            this.Tell.Enter += new System.EventHandler(this.Tell_Enter);
            this.Tell.Leave += new System.EventHandler(this.Tell_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(138, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "昵称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(138, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(138, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "邮箱：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(125, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "手机号：";
            // 
            // Button_register
            // 
            this.Button_register.BackColor = System.Drawing.Color.Transparent;
            this.Button_register.FlatAppearance.BorderSize = 0;
            this.Button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_register.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_register.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Button_register.Location = new System.Drawing.Point(192, 474);
            this.Button_register.Name = "Button_register";
            this.Button_register.Size = new System.Drawing.Size(114, 30);
            this.Button_register.TabIndex = 20;
            this.Button_register.Text = "注册";
            this.Button_register.UseVisualStyleBackColor = false;
            this.Button_register.Click += new System.EventHandler(this.Button_register_Click);
            // 
            // Button_back
            // 
            this.Button_back.BackColor = System.Drawing.Color.Transparent;
            this.Button_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_back.BackgroundImage")));
            this.Button_back.FlatAppearance.BorderSize = 0;
            this.Button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_back.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_back.Location = new System.Drawing.Point(329, 474);
            this.Button_back.Name = "Button_back";
            this.Button_back.Size = new System.Drawing.Size(113, 30);
            this.Button_back.TabIndex = 21;
            this.Button_back.Text = "取消";
            this.Button_back.UseVisualStyleBackColor = false;
            this.Button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // txtRePassword
            // 
            this.txtRePassword.Enabled = false;
            this.txtRePassword.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRePassword.Location = new System.Drawing.Point(192, 353);
            this.txtRePassword.Multiline = true;
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(250, 25);
            this.txtRePassword.TabIndex = 13;
            this.txtRePassword.Enter += new System.EventHandler(this.User_password_Enter);
            this.txtRePassword.Leave += new System.EventHandler(this.txtRePassword_Leave);
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRePassword.Image = ((System.Drawing.Image)(resources.GetObject("lblRePassword.Image")));
            this.lblRePassword.Location = new System.Drawing.Point(112, 356);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(74, 19);
            this.lblRePassword.TabIndex = 17;
            this.lblRePassword.Text = "确认密码：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(447, 131);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 23);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "显示密码";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(447, 341);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 23);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "显示密码";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Button_register);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Button_back);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Tell);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRePassword);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.User_password);
            this.panel1.Controls.Add(this.lblRePassword);
            this.panel1.Controls.Add(this.User_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Student_id);
            this.panel1.Controls.Add(this.Student_name);
            this.panel1.Controls.Add(this.False_gray);
            this.panel1.Controls.Add(this.Student_password);
            this.panel1.Controls.Add(this.False_red);
            this.panel1.Controls.Add(this.Button_verify);
            this.panel1.Controls.Add(this.True_gray);
            this.panel1.Controls.Add(this.True_green);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 525);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 252);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 132);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // Form_register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_register";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.Form_register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.True_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.True_gray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.False_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.False_gray)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Student_id;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Student_name;
        private System.Windows.Forms.TextBox Student_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_verify;
        private System.Windows.Forms.PictureBox True_green;
        private System.Windows.Forms.PictureBox True_gray;
        private System.Windows.Forms.PictureBox False_red;
        private System.Windows.Forms.PictureBox False_gray;
        private System.Windows.Forms.TextBox User_name;
        private System.Windows.Forms.TextBox User_password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Tell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Button_register;
        private System.Windows.Forms.Button Button_back;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}