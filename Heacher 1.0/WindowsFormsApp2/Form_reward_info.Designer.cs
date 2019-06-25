namespace WindowsFormsApp2
{
    partial class Form_reward_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_reward_info));
            this.Accept = new System.Windows.Forms.Button();
            this.rpriceTextBox = new System.Windows.Forms.TextBox();
            this.rpriceLabel = new System.Windows.Forms.Label();
            this.rlocationTextBox = new System.Windows.Forms.TextBox();
            this.rlocationLabel = new System.Windows.Forms.Label();
            this.rtimeTextBox = new System.Windows.Forms.TextBox();
            this.rtimeLabel = new System.Windows.Forms.Label();
            this.rintroductionTextBox = new System.Windows.Forms.TextBox();
            this.rintroductionLabel = new System.Windows.Forms.Label();
            this.rnameTextBox = new System.Windows.Forms.TextBox();
            this.rnameLabel = new System.Windows.Forms.Label();
            this.ridTextBox = new System.Windows.Forms.TextBox();
            this.ridLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.SystemColors.Highlight;
            this.Accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Accept.FlatAppearance.BorderSize = 0;
            this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accept.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Accept.ForeColor = System.Drawing.Color.White;
            this.Accept.Location = new System.Drawing.Point(160, 481);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(150, 34);
            this.Accept.TabIndex = 1;
            this.Accept.Text = "接单";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // rpriceTextBox
            // 
            this.rpriceTextBox.Location = new System.Drawing.Point(160, 417);
            this.rpriceTextBox.Name = "rpriceTextBox";
            this.rpriceTextBox.ReadOnly = true;
            this.rpriceTextBox.Size = new System.Drawing.Size(100, 30);
            this.rpriceTextBox.TabIndex = 28;
            // 
            // rpriceLabel
            // 
            this.rpriceLabel.AutoSize = true;
            this.rpriceLabel.Location = new System.Drawing.Point(45, 420);
            this.rpriceLabel.Name = "rpriceLabel";
            this.rpriceLabel.Size = new System.Drawing.Size(59, 20);
            this.rpriceLabel.TabIndex = 26;
            this.rpriceLabel.Text = "价格:";
            // 
            // rlocationTextBox
            // 
            this.rlocationTextBox.Location = new System.Drawing.Point(112, 363);
            this.rlocationTextBox.Name = "rlocationTextBox";
            this.rlocationTextBox.ReadOnly = true;
            this.rlocationTextBox.Size = new System.Drawing.Size(216, 30);
            this.rlocationTextBox.TabIndex = 24;
            // 
            // rlocationLabel
            // 
            this.rlocationLabel.AutoSize = true;
            this.rlocationLabel.Location = new System.Drawing.Point(45, 366);
            this.rlocationLabel.Name = "rlocationLabel";
            this.rlocationLabel.Size = new System.Drawing.Size(59, 20);
            this.rlocationLabel.TabIndex = 23;
            this.rlocationLabel.Text = "地点:";
            // 
            // rtimeTextBox
            // 
            this.rtimeTextBox.Location = new System.Drawing.Point(112, 309);
            this.rtimeTextBox.Name = "rtimeTextBox";
            this.rtimeTextBox.ReadOnly = true;
            this.rtimeTextBox.Size = new System.Drawing.Size(216, 30);
            this.rtimeTextBox.TabIndex = 22;
            // 
            // rtimeLabel
            // 
            this.rtimeLabel.AutoSize = true;
            this.rtimeLabel.Location = new System.Drawing.Point(45, 312);
            this.rtimeLabel.Name = "rtimeLabel";
            this.rtimeLabel.Size = new System.Drawing.Size(59, 20);
            this.rtimeLabel.TabIndex = 21;
            this.rtimeLabel.Text = "时间:";
            // 
            // rintroductionTextBox
            // 
            this.rintroductionTextBox.Location = new System.Drawing.Point(112, 116);
            this.rintroductionTextBox.Multiline = true;
            this.rintroductionTextBox.Name = "rintroductionTextBox";
            this.rintroductionTextBox.ReadOnly = true;
            this.rintroductionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rintroductionTextBox.Size = new System.Drawing.Size(299, 161);
            this.rintroductionTextBox.TabIndex = 20;
            // 
            // rintroductionLabel
            // 
            this.rintroductionLabel.AutoSize = true;
            this.rintroductionLabel.Location = new System.Drawing.Point(45, 136);
            this.rintroductionLabel.Name = "rintroductionLabel";
            this.rintroductionLabel.Size = new System.Drawing.Size(59, 20);
            this.rintroductionLabel.TabIndex = 19;
            this.rintroductionLabel.Text = "详情:";
            // 
            // rnameTextBox
            // 
            this.rnameTextBox.Location = new System.Drawing.Point(112, 63);
            this.rnameTextBox.Name = "rnameTextBox";
            this.rnameTextBox.ReadOnly = true;
            this.rnameTextBox.Size = new System.Drawing.Size(216, 30);
            this.rnameTextBox.TabIndex = 18;
            // 
            // rnameLabel
            // 
            this.rnameLabel.AutoSize = true;
            this.rnameLabel.Location = new System.Drawing.Point(45, 73);
            this.rnameLabel.Name = "rnameLabel";
            this.rnameLabel.Size = new System.Drawing.Size(59, 20);
            this.rnameLabel.TabIndex = 17;
            this.rnameLabel.Text = "名称:";
            // 
            // ridTextBox
            // 
            this.ridTextBox.Location = new System.Drawing.Point(112, 15);
            this.ridTextBox.Name = "ridTextBox";
            this.ridTextBox.ReadOnly = true;
            this.ridTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ridTextBox.Size = new System.Drawing.Size(216, 30);
            this.ridTextBox.TabIndex = 16;
            // 
            // ridLabel
            // 
            this.ridLabel.AutoSize = true;
            this.ridLabel.Location = new System.Drawing.Point(45, 18);
            this.ridLabel.Name = "ridLabel";
            this.ridLabel.Size = new System.Drawing.Size(59, 20);
            this.ridLabel.TabIndex = 15;
            this.ridLabel.Text = "编号:";
            // 
            // Form_reward_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(454, 542);
            this.Controls.Add(this.rpriceTextBox);
            this.Controls.Add(this.rpriceLabel);
            this.Controls.Add(this.rlocationTextBox);
            this.Controls.Add(this.rlocationLabel);
            this.Controls.Add(this.rtimeTextBox);
            this.Controls.Add(this.rtimeLabel);
            this.Controls.Add(this.rintroductionTextBox);
            this.Controls.Add(this.rintroductionLabel);
            this.Controls.Add(this.rnameTextBox);
            this.Controls.Add(this.rnameLabel);
            this.Controls.Add(this.ridTextBox);
            this.Controls.Add(this.ridLabel);
            this.Controls.Add(this.Accept);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_reward_info";
            this.Text = "详细悬赏信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.TextBox rpriceTextBox;
        private System.Windows.Forms.Label rpriceLabel;
        private System.Windows.Forms.TextBox rlocationTextBox;
        private System.Windows.Forms.Label rlocationLabel;
        private System.Windows.Forms.TextBox rtimeTextBox;
        private System.Windows.Forms.Label rtimeLabel;
        private System.Windows.Forms.TextBox rintroductionTextBox;
        private System.Windows.Forms.Label rintroductionLabel;
        private System.Windows.Forms.TextBox rnameTextBox;
        private System.Windows.Forms.Label rnameLabel;
        private System.Windows.Forms.TextBox ridTextBox;
        private System.Windows.Forms.Label ridLabel;
    }
}