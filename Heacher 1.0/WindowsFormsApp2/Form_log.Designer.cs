namespace WindowsFormsApp2
{
    partial class Form_Log
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Log));
            this.Button_log = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.User_id = new System.Windows.Forms.TextBox();
            this.Button_register = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.User_password = new System.Windows.Forms.TextBox();
            this.Show_password = new System.Windows.Forms.CheckBox();
            this.btnFindPas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_log
            // 
            this.Button_log.BackColor = System.Drawing.SystemColors.Highlight;
            this.Button_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_log.FlatAppearance.BorderSize = 0;
            this.Button_log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Button_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_log.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_log.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Button_log.Location = new System.Drawing.Point(225, 251);
            this.Button_log.Name = "Button_log";
            this.Button_log.Size = new System.Drawing.Size(145, 30);
            this.Button_log.TabIndex = 3;
            this.Button_log.Text = "登录";
            this.Button_log.UseVisualStyleBackColor = false;
            this.Button_log.Click += new System.EventHandler(this.Button_log_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 1;
            // 
            // User_id
            // 
            this.User_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.User_id.BackColor = System.Drawing.SystemColors.Window;
            this.User_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_id.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.User_id.Location = new System.Drawing.Point(226, 161);
            this.User_id.Multiline = true;
            this.User_id.Name = "User_id";
            this.User_id.Size = new System.Drawing.Size(145, 25);
            this.User_id.TabIndex = 0;
            this.User_id.Tag = "";
            // 
            // Button_register
            // 
            this.Button_register.BackColor = System.Drawing.Color.Transparent;
            this.Button_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_register.FlatAppearance.BorderSize = 0;
            this.Button_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_register.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_register.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Button_register.Location = new System.Drawing.Point(376, 161);
            this.Button_register.Name = "Button_register";
            this.Button_register.Size = new System.Drawing.Size(70, 25);
            this.Button_register.TabIndex = 4;
            this.Button_register.Text = "立即注册";
            this.Button_register.UseVisualStyleBackColor = false;
            this.Button_register.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(182, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "学号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(182, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码:";
            // 
            // User_password
            // 
            this.User_password.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_password.Location = new System.Drawing.Point(226, 192);
            this.User_password.Multiline = true;
            this.User_password.Name = "User_password";
            this.User_password.PasswordChar = '*';
            this.User_password.Size = new System.Drawing.Size(145, 25);
            this.User_password.TabIndex = 1;
            // 
            // Show_password
            // 
            this.Show_password.AutoSize = true;
            this.Show_password.BackColor = System.Drawing.Color.Transparent;
            this.Show_password.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Show_password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Show_password.Location = new System.Drawing.Point(291, 222);
            this.Show_password.Name = "Show_password";
            this.Show_password.Size = new System.Drawing.Size(80, 23);
            this.Show_password.TabIndex = 2;
            this.Show_password.Text = "显示密码";
            this.Show_password.UseVisualStyleBackColor = false;
            this.Show_password.CheckedChanged += new System.EventHandler(this.Show_password_CheckedChanged);
            // 
            // btnFindPas
            // 
            this.btnFindPas.AutoSize = true;
            this.btnFindPas.BackColor = System.Drawing.Color.Transparent;
            this.btnFindPas.FlatAppearance.BorderSize = 0;
            this.btnFindPas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFindPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFindPas.Location = new System.Drawing.Point(376, 191);
            this.btnFindPas.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindPas.Name = "btnFindPas";
            this.btnFindPas.Size = new System.Drawing.Size(71, 29);
            this.btnFindPas.TabIndex = 9;
            this.btnFindPas.Text = "找回密码";
            this.btnFindPas.UseVisualStyleBackColor = false;
            this.btnFindPas.Click += new System.EventHandler(this.btnFindPas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Log
            // 
            this.AcceptButton = this.Button_log;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(468, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFindPas);
            this.Controls.Add(this.Show_password);
            this.Controls.Add(this.User_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_register);
            this.Controls.Add(this.User_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_log);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Log";
            this.ShowInTaskbar = false;
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Log_FormClosing);
            this.Load += new System.EventHandler(this.Form_Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User_id;
        private System.Windows.Forms.Button Button_register;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox User_password;
        private System.Windows.Forms.CheckBox Show_password;
        private System.Windows.Forms.Button btnFindPas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

