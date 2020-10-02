using System;
using System.Net.Mail;
using System.Net;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void sendMail()
		{
			int i;
			int counter;
			var body;
			var emailAdress;
			string subject;
			var title;
			var recepient;
			do
			{
				var fromAddress = new MailAddress("halorenzo6@gmail.com", title);
				var toAddress = new MailAddress(emailAdress, recepient);
				const string fromPassword = "anyuka1212";
				var smtp = new SmtpClient
				{
					Host = "smtp.gmail.com",
					Port = 587,
					EnableSsl = true,
					DeliveryMethod = SmtpDeliveryMethod.Network,
					UseDefaultCredentials = false,
					Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
				};
				using (var message = new MailMessage(fromAddress, toAddress)
				{
					Subject = subject,
					Body = body,
				})
				{
					smtp.Send(message);
				}
				counter += 1;
				i -= 1;
				Console.WriteLine(b + " emails have been sent");
				Thread.Sleep(1);
			} while (i >= 0);
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{

		}
	}
}
