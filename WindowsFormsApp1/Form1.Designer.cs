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
			this.send.Text = "button1";
			this.send.UseVisualStyleBackColor = true;
			this.send.Click += new System.EventHandler(this.send_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

