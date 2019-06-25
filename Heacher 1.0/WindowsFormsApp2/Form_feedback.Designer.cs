namespace WindowsFormsApp2
{
    partial class Form_feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_feedback));
            this.Question_suggestion = new System.Windows.Forms.Button();
            this.Function_feedback = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Messagebox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question_suggestion
            // 
            this.Question_suggestion.BackColor = System.Drawing.Color.Transparent;
            this.Question_suggestion.FlatAppearance.BorderSize = 0;
            this.Question_suggestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Question_suggestion.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Question_suggestion.ForeColor = System.Drawing.Color.Gray;
            this.Question_suggestion.Location = new System.Drawing.Point(50, 1);
            this.Question_suggestion.Name = "Question_suggestion";
            this.Question_suggestion.Size = new System.Drawing.Size(108, 40);
            this.Question_suggestion.TabIndex = 0;
            this.Question_suggestion.Text = "问题建议";
            this.Question_suggestion.UseVisualStyleBackColor = false;
            this.Question_suggestion.Click += new System.EventHandler(this.Question_suggestion_Click);
            // 
            // Function_feedback
            // 
            this.Function_feedback.BackColor = System.Drawing.Color.Transparent;
            this.Function_feedback.FlatAppearance.BorderSize = 0;
            this.Function_feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Function_feedback.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Function_feedback.ForeColor = System.Drawing.Color.Gray;
            this.Function_feedback.Location = new System.Drawing.Point(323, 3);
            this.Function_feedback.Name = "Function_feedback";
            this.Function_feedback.Size = new System.Drawing.Size(104, 40);
            this.Function_feedback.TabIndex = 1;
            this.Function_feedback.Text = "功能反馈";
            this.Function_feedback.UseVisualStyleBackColor = false;
            this.Function_feedback.Click += new System.EventHandler(this.Function_feedback_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Transparent;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Submit.ForeColor = System.Drawing.Color.Black;
            this.Submit.Location = new System.Drawing.Point(365, 377);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(62, 40);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "提交";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(235, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "|\r\n|\r\n|";
            // 
            // Messagebox
            // 
            this.Messagebox.BackColor = System.Drawing.Color.White;
            this.Messagebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Messagebox.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Messagebox.Location = new System.Drawing.Point(50, 78);
            this.Messagebox.Multiline = true;
            this.Messagebox.Name = "Messagebox";
            this.Messagebox.Size = new System.Drawing.Size(377, 293);
            this.Messagebox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.Messagebox);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 464);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 25);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.Question_suggestion);
            this.panel2.Controls.Add(this.Function_feedback);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 50);
            this.panel2.TabIndex = 7;
            // 
            // Form_feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(474, 461);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_feedback";
            this.Text = "反馈";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Question_suggestion;
        private System.Windows.Forms.Button Function_feedback;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Messagebox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}