using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    partial class Form_lesson_info1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_lesson_info1));
            this.Sign_up = new System.Windows.Forms.Button();
            this.cidLabel = new System.Windows.Forms.Label();
            this.cidTextBox = new System.Windows.Forms.TextBox();
            this.cnameLabel = new System.Windows.Forms.Label();
            this.cnameTextBox = new System.Windows.Forms.TextBox();
            this.cintroductionLabel = new System.Windows.Forms.Label();
            this.cintroductionTextBox = new System.Windows.Forms.TextBox();
            this.ctimeLabel = new System.Windows.Forms.Label();
            this.ctimeTextBox = new System.Windows.Forms.TextBox();
            this.clocationLabel = new System.Windows.Forms.Label();
            this.clocationTextBox = new System.Windows.Forms.TextBox();
            this.cstateLabel = new System.Windows.Forms.Label();
            this.cpriceLabel = new System.Windows.Forms.Label();
            this.cstateTextBox = new System.Windows.Forms.TextBox();
            this.cpriceTextBox = new System.Windows.Forms.TextBox();
            this.stelLabel = new System.Windows.Forms.Label();
            this.stelTextBox = new System.Windows.Forms.TextBox();
            this.snameLabel = new System.Windows.Forms.Label();
            this.snameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sign_up
            // 
            this.Sign_up.BackColor = System.Drawing.Color.Transparent;
            this.Sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_up.FlatAppearance.BorderSize = 0;
            this.Sign_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Sign_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign_up.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sign_up.ForeColor = System.Drawing.Color.Black;
            this.Sign_up.Location = new System.Drawing.Point(140, 544);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(103, 34);
            this.Sign_up.TabIndex = 0;
            this.Sign_up.Text = "报名";
            this.Sign_up.UseVisualStyleBackColor = false;
            this.Sign_up.Click += new System.EventHandler(this.Sign_up_Click);
            // 
            // cidLabel
            // 
            this.cidLabel.AutoSize = true;
            this.cidLabel.BackColor = System.Drawing.Color.Transparent;
            this.cidLabel.Location = new System.Drawing.Point(33, 3);
            this.cidLabel.Name = "cidLabel";
            this.cidLabel.Size = new System.Drawing.Size(38, 19);
            this.cidLabel.TabIndex = 1;
            this.cidLabel.Text = "编号:";
            // 
            // cidTextBox
            // 
            this.cidTextBox.BackColor = System.Drawing.Color.White;
            this.cidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cidTextBox.Location = new System.Drawing.Point(95, 4);
            this.cidTextBox.Name = "cidTextBox";
            this.cidTextBox.ReadOnly = true;
            this.cidTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.cidTextBox.Size = new System.Drawing.Size(216, 18);
            this.cidTextBox.TabIndex = 2;
            // 
            // cnameLabel
            // 
            this.cnameLabel.AutoSize = true;
            this.cnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.cnameLabel.Location = new System.Drawing.Point(33, 50);
            this.cnameLabel.Name = "cnameLabel";
            this.cnameLabel.Size = new System.Drawing.Size(38, 19);
            this.cnameLabel.TabIndex = 3;
            this.cnameLabel.Text = "名称:";
            // 
            // cnameTextBox
            // 
            this.cnameTextBox.BackColor = System.Drawing.Color.White;
            this.cnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cnameTextBox.Location = new System.Drawing.Point(95, 51);
            this.cnameTextBox.Name = "cnameTextBox";
            this.cnameTextBox.ReadOnly = true;
            this.cnameTextBox.Size = new System.Drawing.Size(216, 18);
            this.cnameTextBox.TabIndex = 4;
            // 
            // cintroductionLabel
            // 
            this.cintroductionLabel.AutoSize = true;
            this.cintroductionLabel.BackColor = System.Drawing.Color.Transparent;
            this.cintroductionLabel.Location = new System.Drawing.Point(33, 160);
            this.cintroductionLabel.Name = "cintroductionLabel";
            this.cintroductionLabel.Size = new System.Drawing.Size(38, 19);
            this.cintroductionLabel.TabIndex = 5;
            this.cintroductionLabel.Text = "详情:";
            // 
            // cintroductionTextBox
            // 
            this.cintroductionTextBox.BackColor = System.Drawing.Color.White;
            this.cintroductionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cintroductionTextBox.Location = new System.Drawing.Point(95, 96);
            this.cintroductionTextBox.Multiline = true;
            this.cintroductionTextBox.Name = "cintroductionTextBox";
            this.cintroductionTextBox.ReadOnly = true;
            this.cintroductionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cintroductionTextBox.Size = new System.Drawing.Size(216, 161);
            this.cintroductionTextBox.TabIndex = 6;
            // 
            // ctimeLabel
            // 
            this.ctimeLabel.AutoSize = true;
            this.ctimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ctimeLabel.Location = new System.Drawing.Point(33, 278);
            this.ctimeLabel.Name = "ctimeLabel";
            this.ctimeLabel.Size = new System.Drawing.Size(38, 19);
            this.ctimeLabel.TabIndex = 7;
            this.ctimeLabel.Text = "时间:";
            // 
            // ctimeTextBox
            // 
            this.ctimeTextBox.BackColor = System.Drawing.Color.White;
            this.ctimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctimeTextBox.Location = new System.Drawing.Point(95, 275);
            this.ctimeTextBox.Name = "ctimeTextBox";
            this.ctimeTextBox.ReadOnly = true;
            this.ctimeTextBox.Size = new System.Drawing.Size(216, 18);
            this.ctimeTextBox.TabIndex = 8;
            // 
            // clocationLabel
            // 
            this.clocationLabel.AutoSize = true;
            this.clocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.clocationLabel.Location = new System.Drawing.Point(33, 325);
            this.clocationLabel.Name = "clocationLabel";
            this.clocationLabel.Size = new System.Drawing.Size(38, 19);
            this.clocationLabel.TabIndex = 9;
            this.clocationLabel.Text = "地点:";
            // 
            // clocationTextBox
            // 
            this.clocationTextBox.BackColor = System.Drawing.Color.White;
            this.clocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clocationTextBox.Location = new System.Drawing.Point(95, 322);
            this.clocationTextBox.Name = "clocationTextBox";
            this.clocationTextBox.ReadOnly = true;
            this.clocationTextBox.Size = new System.Drawing.Size(216, 18);
            this.clocationTextBox.TabIndex = 10;
            // 
            // cstateLabel
            // 
            this.cstateLabel.AutoSize = true;
            this.cstateLabel.BackColor = System.Drawing.Color.Transparent;
            this.cstateLabel.Location = new System.Drawing.Point(33, 411);
            this.cstateLabel.Name = "cstateLabel";
            this.cstateLabel.Size = new System.Drawing.Size(38, 19);
            this.cstateLabel.TabIndex = 11;
            this.cstateLabel.Text = "状态:";
            // 
            // cpriceLabel
            // 
            this.cpriceLabel.AutoSize = true;
            this.cpriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpriceLabel.Location = new System.Drawing.Point(33, 371);
            this.cpriceLabel.Name = "cpriceLabel";
            this.cpriceLabel.Size = new System.Drawing.Size(38, 19);
            this.cpriceLabel.TabIndex = 12;
            this.cpriceLabel.Text = "价格:";
            // 
            // cstateTextBox
            // 
            this.cstateTextBox.BackColor = System.Drawing.Color.White;
            this.cstateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cstateTextBox.Location = new System.Drawing.Point(95, 411);
            this.cstateTextBox.Name = "cstateTextBox";
            this.cstateTextBox.ReadOnly = true;
            this.cstateTextBox.Size = new System.Drawing.Size(216, 18);
            this.cstateTextBox.TabIndex = 13;
            // 
            // cpriceTextBox
            // 
            this.cpriceTextBox.BackColor = System.Drawing.Color.White;
            this.cpriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpriceTextBox.Location = new System.Drawing.Point(95, 368);
            this.cpriceTextBox.Name = "cpriceTextBox";
            this.cpriceTextBox.ReadOnly = true;
            this.cpriceTextBox.Size = new System.Drawing.Size(216, 18);
            this.cpriceTextBox.TabIndex = 14;
            // 
            // stelLabel
            // 
            this.stelLabel.AutoSize = true;
            this.stelLabel.BackColor = System.Drawing.Color.Transparent;
            this.stelLabel.Location = new System.Drawing.Point(33, 509);
            this.stelLabel.Name = "stelLabel";
            this.stelLabel.Size = new System.Drawing.Size(38, 19);
            this.stelLabel.TabIndex = 15;
            this.stelLabel.Text = "电话:";
            // 
            // stelTextBox
            // 
            this.stelTextBox.BackColor = System.Drawing.Color.White;
            this.stelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stelTextBox.Location = new System.Drawing.Point(95, 506);
            this.stelTextBox.Name = "stelTextBox";
            this.stelTextBox.Size = new System.Drawing.Size(216, 18);
            this.stelTextBox.TabIndex = 16;
            // 
            // snameLabel
            // 
            this.snameLabel.AutoSize = true;
            this.snameLabel.BackColor = System.Drawing.Color.Transparent;
            this.snameLabel.Location = new System.Drawing.Point(20, 458);
            this.snameLabel.Name = "snameLabel";
            this.snameLabel.Size = new System.Drawing.Size(51, 19);
            this.snameLabel.TabIndex = 17;
            this.snameLabel.Text = "开课人:";
            // 
            // snameTextBox
            // 
            this.snameTextBox.BackColor = System.Drawing.Color.White;
            this.snameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.snameTextBox.Location = new System.Drawing.Point(95, 458);
            this.snameTextBox.Name = "snameTextBox";
            this.snameTextBox.Size = new System.Drawing.Size(216, 18);
            this.snameTextBox.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cidLabel);
            this.panel1.Controls.Add(this.Sign_up);
            this.panel1.Controls.Add(this.stelTextBox);
            this.panel1.Controls.Add(this.snameTextBox);
            this.panel1.Controls.Add(this.cnameLabel);
            this.panel1.Controls.Add(this.snameLabel);
            this.panel1.Controls.Add(this.cstateTextBox);
            this.panel1.Controls.Add(this.cpriceTextBox);
            this.panel1.Controls.Add(this.stelLabel);
            this.panel1.Controls.Add(this.cintroductionLabel);
            this.panel1.Controls.Add(this.clocationTextBox);
            this.panel1.Controls.Add(this.ctimeLabel);
            this.panel1.Controls.Add(this.ctimeTextBox);
            this.panel1.Controls.Add(this.clocationLabel);
            this.panel1.Controls.Add(this.cintroductionTextBox);
            this.panel1.Controls.Add(this.cpriceLabel);
            this.panel1.Controls.Add(this.cnameTextBox);
            this.panel1.Controls.Add(this.cstateLabel);
            this.panel1.Controls.Add(this.cidTextBox);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 602);
            this.panel1.TabIndex = 19;
            // 
            // Form_lesson_info1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(369, 604);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_lesson_info1";
            this.Text = "详细课程信息";
            this.Load += new System.EventHandler(this.Form_lesson_info1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sign_up;
        private System.Windows.Forms.Label cidLabel;
        private System.Windows.Forms.TextBox cidTextBox;
        private System.Windows.Forms.Label cnameLabel;
        private System.Windows.Forms.TextBox cnameTextBox;
        private System.Windows.Forms.Label cintroductionLabel;
        private System.Windows.Forms.TextBox cintroductionTextBox;
        private System.Windows.Forms.Label ctimeLabel;
        private System.Windows.Forms.TextBox ctimeTextBox;
        private System.Windows.Forms.Label clocationLabel;
        private System.Windows.Forms.TextBox clocationTextBox;
        private System.Windows.Forms.Label cstateLabel;
        private System.Windows.Forms.Label cpriceLabel;
        private System.Windows.Forms.TextBox cstateTextBox;
        private System.Windows.Forms.TextBox cpriceTextBox;
        private System.Windows.Forms.Label stelLabel;
        private System.Windows.Forms.TextBox stelTextBox;
        private System.Windows.Forms.Label snameLabel;
        private System.Windows.Forms.TextBox snameTextBox;
        private System.Windows.Forms.Panel panel1;
    }
}