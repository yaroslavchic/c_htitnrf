using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

            MailAddress fromMailAddress = new MailAddress("beavisabra@gmail.com");
            MailAddress toAddress = new MailAddress("yaroslav_pronin2005@mail.com");

            MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress);
            SmtpClient smtpClient = new SmtpClient();

            mailMessage.Subject = "Новый отзыв";
            mailMessage.Body =
                "Раздел: " + comboBox2.Text + Environment.NewLine +
               // "Как связаться: " + textBox.Text + Environment.NewLine +
                Environment.NewLine +
                "Сообщение:" + Environment.NewLine + textBox2.Text;

            if (address1 != "")
                mailMessage.Attachments.Add(new Attachment(address1));
            if (address2 != "")
                mailMessage.Attachments.Add(new Attachment(address2));

            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials =
                new NetworkCredential(fromMailAddress.Address,
                    //clan.password);

            smtpClient.Send(mailMessage);
            MessageBox.Show("Спасибо за отзыв");
        }

        string address1 = "";
        string address2 = "";
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //adress1 = openFileDialog1.FileName;
               // pictureBox1.Load(adress1);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               // adress2 = openFileDialog2.FileName;
               // pictureBox2.Load(adress2);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
