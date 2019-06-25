namespace WindowsFormsApp2
{
    partial class publish_reward_user_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(publish_reward_user_info));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colunm1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunm2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunm3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label_RSTATE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_RID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Rname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable_Rprice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Rtime = new System.Windows.Forms.Label();
            this.label_Rlocation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label_RSTATE);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_RID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label_Rname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lable_Rprice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_Rtime);
            this.panel1.Controls.Add(this.label_Rlocation);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 349);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 349);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(300, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "（1代表已被接单，0代表未被接单）";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunm1,
            this.colunm2,
            this.colunm3});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(246, 349);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colunm1
            // 
            this.colunm1.Text = "接单人学号";
            this.colunm1.Width = 118;
            // 
            // colunm2
            // 
            this.colunm2.Text = "接单人电话";
            this.colunm2.Width = 126;
            // 
            // colunm3
            // 
            this.colunm3.Text = "接单人邮箱";
            this.colunm3.Width = 216;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(300, 216);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "是否已被接单：";
            // 
            // label_RSTATE
            // 
            this.label_RSTATE.AutoSize = true;
            this.label_RSTATE.Location = new System.Drawing.Point(404, 216);
            this.label_RSTATE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RSTATE.Name = "label_RSTATE";
            this.label_RSTATE.Size = new System.Drawing.Size(42, 19);
            this.label_RSTATE.TabIndex = 0;
            this.label_RSTATE.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(326, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "悬赏编号：";
            // 
            // label_RID
            // 
            this.label_RID.AutoSize = true;
            this.label_RID.Location = new System.Drawing.Point(404, 2);
            this.label_RID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RID.Name = "label_RID";
            this.label_RID.Size = new System.Drawing.Size(42, 19);
            this.label_RID.TabIndex = 0;
            this.label_RID.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(326, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "悬赏名称：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(352, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "价格：";
            // 
            // label_Rname
            // 
            this.label_Rname.AutoSize = true;
            this.label_Rname.Location = new System.Drawing.Point(404, 58);
            this.label_Rname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Rname.Name = "label_Rname";
            this.label_Rname.Size = new System.Drawing.Size(42, 19);
            this.label_Rname.TabIndex = 0;
            this.label_Rname.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(326, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "上课时间：";
            // 
            // lable_Rprice
            // 
            this.lable_Rprice.AutoSize = true;
            this.lable_Rprice.Location = new System.Drawing.Point(404, 270);
            this.lable_Rprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_Rprice.Name = "lable_Rprice";
            this.lable_Rprice.Size = new System.Drawing.Size(42, 19);
            this.lable_Rprice.TabIndex = 0;
            this.lable_Rprice.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(326, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "上课地点：";
            // 
            // label_Rtime
            // 
            this.label_Rtime.AutoSize = true;
            this.label_Rtime.Location = new System.Drawing.Point(404, 117);
            this.label_Rtime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Rtime.Name = "label_Rtime";
            this.label_Rtime.Size = new System.Drawing.Size(42, 19);
            this.label_Rtime.TabIndex = 0;
            this.label_Rtime.Text = "label1";
            // 
            // label_Rlocation
            // 
            this.label_Rlocation.AutoSize = true;
            this.label_Rlocation.Location = new System.Drawing.Point(404, 166);
            this.label_Rlocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Rlocation.Name = "label_Rlocation";
            this.label_Rlocation.Size = new System.Drawing.Size(42, 19);
            this.label_Rlocation.TabIndex = 0;
            this.label_Rlocation.Text = "label1";
            // 
            // publish_reward_user_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 373);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "publish_reward_user_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "已发布悬赏详细信息";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colunm1;
        private System.Windows.Forms.ColumnHeader colunm2;
        private System.Windows.Forms.ColumnHeader colunm3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_RSTATE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_RID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Rname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable_Rprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Rtime;
        private System.Windows.Forms.Label label_Rlocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}