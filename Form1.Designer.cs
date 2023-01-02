namespace assignment8_AndreiKazakov
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.StringTextBox1 = new System.Windows.Forms.TextBox();
            this.CheckButton1 = new System.Windows.Forms.Button();
            this.FileNameLabel1 = new System.Windows.Forms.Label();
            this.SelectFileButton1 = new System.Windows.Forms.Button();
            this.SelectFileButton2 = new System.Windows.Forms.Button();
            this.FileNameLabel2 = new System.Windows.Forms.Label();
            this.CheckButton2 = new System.Windows.Forms.Button();
            this.StringTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File 1:";
            // 
            // StringTextBox1
            // 
            this.StringTextBox1.Enabled = false;
            this.StringTextBox1.Location = new System.Drawing.Point(54, 10);
            this.StringTextBox1.Name = "StringTextBox1";
            this.StringTextBox1.Size = new System.Drawing.Size(100, 20);
            this.StringTextBox1.TabIndex = 1;
            // 
            // CheckButton1
            // 
            this.CheckButton1.Enabled = false;
            this.CheckButton1.Location = new System.Drawing.Point(160, 7);
            this.CheckButton1.Name = "CheckButton1";
            this.CheckButton1.Size = new System.Drawing.Size(75, 23);
            this.CheckButton1.TabIndex = 2;
            this.CheckButton1.Text = "Check!";
            this.CheckButton1.UseVisualStyleBackColor = true;
            this.CheckButton1.Click += new System.EventHandler(this.CheckButton1_Click);
            // 
            // FileNameLabel1
            // 
            this.FileNameLabel1.AutoSize = true;
            this.FileNameLabel1.Location = new System.Drawing.Point(242, 13);
            this.FileNameLabel1.Name = "FileNameLabel1";
            this.FileNameLabel1.Size = new System.Drawing.Size(0, 13);
            this.FileNameLabel1.TabIndex = 3;
            this.FileNameLabel1.Visible = false;
            // 
            // SelectFileButton1
            // 
            this.SelectFileButton1.Location = new System.Drawing.Point(241, 7);
            this.SelectFileButton1.Name = "SelectFileButton1";
            this.SelectFileButton1.Size = new System.Drawing.Size(75, 23);
            this.SelectFileButton1.TabIndex = 4;
            this.SelectFileButton1.Text = "Select file";
            this.SelectFileButton1.UseVisualStyleBackColor = true;
            this.SelectFileButton1.Click += new System.EventHandler(this.SelectFileButton1_Click);
            // 
            // SelectFileButton2
            // 
            this.SelectFileButton2.Location = new System.Drawing.Point(241, 38);
            this.SelectFileButton2.Name = "SelectFileButton2";
            this.SelectFileButton2.Size = new System.Drawing.Size(75, 23);
            this.SelectFileButton2.TabIndex = 9;
            this.SelectFileButton2.Text = "Select file";
            this.SelectFileButton2.UseVisualStyleBackColor = true;
            this.SelectFileButton2.Click += new System.EventHandler(this.SelectFileButton2_Click);
            // 
            // FileNameLabel2
            // 
            this.FileNameLabel2.AutoSize = true;
            this.FileNameLabel2.Location = new System.Drawing.Point(242, 43);
            this.FileNameLabel2.Name = "FileNameLabel2";
            this.FileNameLabel2.Size = new System.Drawing.Size(0, 13);
            this.FileNameLabel2.TabIndex = 8;
            this.FileNameLabel2.Visible = false;
            // 
            // CheckButton2
            // 
            this.CheckButton2.Enabled = false;
            this.CheckButton2.Location = new System.Drawing.Point(160, 37);
            this.CheckButton2.Name = "CheckButton2";
            this.CheckButton2.Size = new System.Drawing.Size(75, 23);
            this.CheckButton2.TabIndex = 7;
            this.CheckButton2.Text = "Check!";
            this.CheckButton2.UseVisualStyleBackColor = true;
            this.CheckButton2.Click += new System.EventHandler(this.CheckButton2_Click);
            // 
            // StringTextBox2
            // 
            this.StringTextBox2.Enabled = false;
            this.StringTextBox2.Location = new System.Drawing.Point(54, 40);
            this.StringTextBox2.Name = "StringTextBox2";
            this.StringTextBox2.Size = new System.Drawing.Size(100, 20);
            this.StringTextBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 70);
            this.Controls.Add(this.SelectFileButton2);
            this.Controls.Add(this.FileNameLabel2);
            this.Controls.Add(this.CheckButton2);
            this.Controls.Add(this.StringTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectFileButton1);
            this.Controls.Add(this.FileNameLabel1);
            this.Controls.Add(this.CheckButton1);
            this.Controls.Add(this.StringTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "assignment8_AndreiKazakov";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StringTextBox1;
        private System.Windows.Forms.Button CheckButton1;
        private System.Windows.Forms.Label FileNameLabel1;
        private System.Windows.Forms.Button SelectFileButton1;
        private System.Windows.Forms.Button SelectFileButton2;
        private System.Windows.Forms.Label FileNameLabel2;
        private System.Windows.Forms.Button CheckButton2;
        private System.Windows.Forms.TextBox StringTextBox2;
        private System.Windows.Forms.Label label2;
    }
}

