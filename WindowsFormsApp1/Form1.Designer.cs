namespace WindowsFormsApp1
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
			this.emailBox = new System.Windows.Forms.TextBox();
			this.bodyBox = new System.Windows.Forms.TextBox();
			this.fromBox = new System.Windows.Forms.TextBox();
			this.subjectBox = new System.Windows.Forms.TextBox();
			this.titleBox = new System.Windows.Forms.TextBox();
			this.counterBox = new System.Windows.Forms.TextBox();
			this.send = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// emailBox
			// 
			this.emailBox.Location = new System.Drawing.Point(298, 123);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(194, 20);
			this.emailBox.TabIndex = 0;
			this.emailBox.Text = "to";
			// 
			// bodyBox
			// 
			this.bodyBox.Location = new System.Drawing.Point(298, 159);
			this.bodyBox.Name = "bodyBox";
			this.bodyBox.Size = new System.Drawing.Size(194, 20);
			this.bodyBox.TabIndex = 1;
			this.bodyBox.Text = "body";
			// 
			// fromBox
			// 
			this.fromBox.AccessibleDescription = "";
			this.fromBox.Location = new System.Drawing.Point(298, 88);
			this.fromBox.Name = "fromBox";
			this.fromBox.Size = new System.Drawing.Size(194, 20);
			this.fromBox.TabIndex = 2;
			this.fromBox.Text = "from";
			// 
			// subjectBox
			// 
			this.subjectBox.Location = new System.Drawing.Point(298, 239);
			this.subjectBox.Name = "subjectBox";
			this.subjectBox.Size = new System.Drawing.Size(194, 20);
			this.subjectBox.TabIndex = 3;
			this.subjectBox.Text = "subject";
			// 
			// titleBox
			// 
			this.titleBox.Location = new System.Drawing.Point(298, 198);
			this.titleBox.Name = "titleBox";
			this.titleBox.Size = new System.Drawing.Size(194, 20);
			this.titleBox.TabIndex = 4;
			this.titleBox.Text = "title";
			// 
			// counterBox
			// 
			this.counterBox.Location = new System.Drawing.Point(298, 277);
			this.counterBox.Name = "counterBox";
			this.counterBox.Size = new System.Drawing.Size(194, 20);
			this.counterBox.TabIndex = 5;
			this.counterBox.Text = "counter";
			// 
			// send
			// 
			this.send.Location = new System.Drawing.Point(298, 329);
			this.send.Name = "send";
			this.send.Size = new System.Drawing.Size(194, 23);
			this.send.TabIndex = 6;
			this.send.Text = "Send";
			this.send.UseVisualStyleBackColor = true;
			this.send.Click += new System.EventHandler(this.send_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(186, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Andress to send from";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(203, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Adress to send to";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(185, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Message of the email";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(208, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Title of the email";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(192, 246);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Subject of the email";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(92, 280);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(200, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Number of times the email should be sent";
			// 
			// passwordBox
			// 
			this.passwordBox.AccessibleDescription = "";
			this.passwordBox.Location = new System.Drawing.Point(297, 57);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(194, 20);
			this.passwordBox.TabIndex = 13;
			this.passwordBox.Text = "password";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(169, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(122, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Passsword of the adress";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.send);
			this.Controls.Add(this.counterBox);
			this.Controls.Add(this.titleBox);
			this.Controls.Add(this.subjectBox);
			this.Controls.Add(this.fromBox);
			this.Controls.Add(this.bodyBox);
			this.Controls.Add(this.emailBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox bodyBox;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox counterBox;
        private System.Windows.Forms.Button send;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Label label7;
	}
}

