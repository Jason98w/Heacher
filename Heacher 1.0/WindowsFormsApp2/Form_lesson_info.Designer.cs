using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    partial class Form_lesson_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_lesson_info));
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
            this.SuspendLayout();
            // 
            // Sign_up
            // 
            this.Sign_up.BackColor = System.Drawing.SystemColors.Highlight;
            this.Sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_up.FlatAppearance.BorderSize = 0;
            this.Sign_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign_up.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sign_up.ForeColor = System.Drawing.Color.White;
            this.Sign_up.Location = new System.Drawing.Point(134, 505);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(150, 34);
            this.Sign_up.TabIndex = 0;
            this.Sign_up.Text = "报名";
            this.Sign_up.UseVisualStyleBackColor = false;
            this.Sign_up.Click += new System.EventHandler(this.Sign_up_Click);
            // 
            // cidLabel
            // 
            this.cidLabel.AutoSize = true;
            this.cidLabel.Location = new System.Drawing.Point(43, 24);
            this.cidLabel.Name = "cidLabel";
            this.cidLabel.Size = new System.Drawing.Size(59, 20);
            this.cidLabel.TabIndex = 1;
            this.cidLabel.Text = "编号:";
            // 
            // cidTextBox
            // 
            this.cidTextBox.Location = new System.Drawing.Point(110, 21);
            this.cidTextBox.Name = "cidTextBox";
            this.cidTextBox.ReadOnly = true;
            this.cidTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.cidTextBox.Size = new System.Drawing.Size(216, 30);
            this.cidTextBox.TabIndex = 2;
            // 
            // cnameLabel
            // 
            this.cnameLabel.AutoSize = true;
            this.cnameLabel.Location = new System.Drawing.Point(43, 79);
            this.cnameLabel.Name = "cnameLabel";
            this.cnameLabel.Size = new System.Drawing.Size(59, 20);
            this.cnameLabel.TabIndex = 3;
            this.cnameLabel.Text = "名称:";
            // 
            // cnameTextBox
            // 
            this.cnameTextBox.Location = new System.Drawing.Point(110, 69);
            this.cnameTextBox.Name = "cnameTextBox";
            this.cnameTextBox.ReadOnly = true;
            this.cnameTextBox.Size = new System.Drawing.Size(216, 30);
            this.cnameTextBox.TabIndex = 4;
            // 
            // cintroductionLabel
            // 
            this.cintroductionLabel.AutoSize = true;
            this.cintroductionLabel.Location = new System.Drawing.Point(43, 142);
            this.cintroductionLabel.Name = "cintroductionLabel";
            this.cintroductionLabel.Size = new System.Drawing.Size(59, 20);
            this.cintroductionLabel.TabIndex = 5;
            this.cintroductionLabel.Text = "详情:";
            // 
            // cintroductionTextBox
            // 
            this.cintroductionTextBox.Location = new System.Drawing.Point(110, 122);
            this.cintroductionTextBox.Multiline = true;
            this.cintroductionTextBox.Name = "cintroductionTextBox";
            this.cintroductionTextBox.ReadOnly = true;
            this.cintroductionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cintroductionTextBox.Size = new System.Drawing.Size(299, 161);
            this.cintroductionTextBox.TabIndex = 6;
            // 
            // ctimeLabel
            // 
            this.ctimeLabel.AutoSize = true;
            this.ctimeLabel.Location = new System.Drawing.Point(43, 318);
            this.ctimeLabel.Name = "ctimeLabel";
            this.ctimeLabel.Size = new System.Drawing.Size(59, 20);
            this.ctimeLabel.TabIndex = 7;
            this.ctimeLabel.Text = "时间:";
            // 
            // ctimeTextBox
            // 
            this.ctimeTextBox.Location = new System.Drawing.Point(110, 315);
            this.ctimeTextBox.Name = "ctimeTextBox";
            this.ctimeTextBox.ReadOnly = true;
            this.ctimeTextBox.Size = new System.Drawing.Size(216, 30);
            this.ctimeTextBox.TabIndex = 8;
            // 
            // clocationLabel
            // 
            this.clocationLabel.AutoSize = true;
            this.clocationLabel.Location = new System.Drawing.Point(43, 369);
            this.clocationLabel.Name = "clocationLabel";
            this.clocationLabel.Size = new System.Drawing.Size(59, 20);
            this.clocationLabel.TabIndex = 9;
            this.clocationLabel.Text = "地点:";
            // 
            // clocationTextBox
            // 
            this.clocationTextBox.Location = new System.Drawing.Point(110, 366);
            this.clocationTextBox.Name = "clocationTextBox";
            this.clocationTextBox.ReadOnly = true;
            this.clocationTextBox.Size = new System.Drawing.Size(216, 30);
            this.clocationTextBox.TabIndex = 10;
            // 
            // cstateLabel
            // 
            this.cstateLabel.AutoSize = true;
            this.cstateLabel.Location = new System.Drawing.Point(43, 459);
            this.cstateLabel.Name = "cstateLabel";
            this.cstateLabel.Size = new System.Drawing.Size(59, 20);
            this.cstateLabel.TabIndex = 11;
            this.cstateLabel.Text = "状态:";
            // 
            // cpriceLabel
            // 
            this.cpriceLabel.AutoSize = true;
            this.cpriceLabel.Location = new System.Drawing.Point(43, 414);
            this.cpriceLabel.Name = "cpriceLabel";
            this.cpriceLabel.Size = new System.Drawing.Size(59, 20);
            this.cpriceLabel.TabIndex = 12;
            this.cpriceLabel.Text = "价格:";
            // 
            // cstateTextBox
            // 
            this.cstateTextBox.Location = new System.Drawing.Point(158, 456);
            this.cstateTextBox.Name = "cstateTextBox";
            this.cstateTextBox.ReadOnly = true;
            this.cstateTextBox.Size = new System.Drawing.Size(100, 30);
            this.cstateTextBox.TabIndex = 13;
            // 
            // cpriceTextBox
            // 
            this.cpriceTextBox.Location = new System.Drawing.Point(158, 411);
            this.cpriceTextBox.Name = "cpriceTextBox";
            this.cpriceTextBox.ReadOnly = true;
            this.cpriceTextBox.Size = new System.Drawing.Size(100, 30);
            this.cpriceTextBox.TabIndex = 14;
            // 
            // Form_lesson_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(454, 566);
            this.Controls.Add(this.cpriceTextBox);
            this.Controls.Add(this.cstateTextBox);
            this.Controls.Add(this.cpriceLabel);
            this.Controls.Add(this.cstateLabel);
            this.Controls.Add(this.clocationTextBox);
            this.Controls.Add(this.clocationLabel);
            this.Controls.Add(this.ctimeTextBox);
            this.Controls.Add(this.ctimeLabel);
            this.Controls.Add(this.cintroductionTextBox);
            this.Controls.Add(this.cintroductionLabel);
            this.Controls.Add(this.cnameTextBox);
            this.Controls.Add(this.cnameLabel);
            this.Controls.Add(this.cidTextBox);
            this.Controls.Add(this.cidLabel);
            this.Controls.Add(this.Sign_up);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_lesson_info";
            this.Text = "详细课程信息";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}