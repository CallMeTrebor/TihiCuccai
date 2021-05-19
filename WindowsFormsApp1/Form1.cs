using System;
using System.Net.Mail;
using System.Net;
using System.IO;
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
            int counter = 0;
            int i = (int)Int64.Parse(counterBox.Text) - 1;
            var body = bodyBox.Text;
            var emailAdress = emailBox.Text;
            string subject = subjectBox.Text;
            var title = titleBox.Text;
            var recepient = "Buzi";
            var fromAddress = new MailAddress(fromBox.Text, title);
            var toAddress = new MailAddress(emailAdress, recepient);
            string fromPassword = passwordBox.Text;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
            };
            do
            {
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                })
                {
                    smtp.Send(message);
                }
                counter += 1;
                Szamlalo.Text = $"Elküldött Emailok száma {counter}";
                i -= 1;
                Thread.Sleep(1);
            } while (i >= 0);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            sendMail();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        async void ReadLocalData()
        {

        }

        async void WriteLocalData()
        {

        }
    }

    class email
    {
        string body { get; set; }
        string adress { get; set; }
        string subject { get; set; }
        string title { get; set; }
        string recepient { get; set; }
        string fromAddress { get; set; }
        string toAdress { get; set; }
        string fromPassword { get; set; }
    }
}


// hello mizu?
//semmi
// Hogy vagy?
//Jol vagyok
// nincs ennek 2020 valtozata????????????????? Vagy  2021?????????????????????? nincs// MIert?