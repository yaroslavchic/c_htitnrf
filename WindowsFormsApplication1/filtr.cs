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
    public struct Pers
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string name;
        public int vosrast;
        public string pol;
        /// <summary>
        /// Количество лайков
        /// </summary>
        public int likes;
        public int Dislikes;

        public Label lbl;
        public PictureBox pic;
        public int  prosmotr;
        public Pers(string name1 , int vosrast1 , string pol1, int likes1, int Dislikes1)
        {
            name = name1;
            vosrast = vosrast1;
            likes = likes1;
            Dislikes = Dislikes1;
            pol = pol1;
            prosmotr = 0;
            lbl = new Label();
            pic = new PictureBox();
        }
    }


    public partial class filtr : Form
    {
       List< Pers> persljud = new List <Pers>();


        public filtr()
        {
            InitializeComponent();

            

            string[] lines = System.IO.File.ReadAllLines("../../Картинки/Персы.txt");

            foreach (string str in lines)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                persljud.Add(new Pers(parts[0],
                    Convert.ToInt32(parts[1]),
                    parts[2],
                    Convert.ToInt32(parts[3]),
                    Convert.ToInt32(parts[4])));
            }


            int x = 10;
            for (int i = 0; i < 10; i++)
            {
                persljud[i].lbl.Location = new Point(x, 100);
                persljud[i].lbl.Size = new Size(80, 20);
                persljud[i].lbl.Text = persljud[i].name;
                persljud[i].lbl.Click += new EventHandler(openGeroy);
                panel2.Controls.Add(persljud[i].lbl);

                persljud[i].pic.Location = new Point(x, 30);
                persljud[i].pic.Size = new Size(80, 60);
                persljud[i].pic.SizeMode = PictureBoxSizeMode.Zoom;
                persljud[i].pic.Click += new EventHandler(openGeroy);
                try
                {
                    persljud[i].pic.Load("../../Картинки/" + persljud[i].name + ".jpg");
                }
                catch (Exception) { }
                panel2.Controls.Add(persljud[i].pic);

                x = x + 100;
            }
        }

        private void openGeroy(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (sender == persljud[i].lbl ||
                    sender == persljud[i].pic)
                {
                    Geroy helpForm = new Geroy(persljud[i]);
                    helpForm.ShowDialog();
                    persljud[i] = helpForm.pers;
                    break;
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            for (int i = 0; i < 10; i=i+1)
            {
                persljud[i].lbl.Visible = true;
                persljud[i].pic.Visible = true;

                if (vozrastTextBox.Text != "" &&
                    persljud[i].vosrast > Convert.ToInt32(vozrastTextBox.Text))   
                {
                    persljud[i].lbl.Visible = false;
                    persljud[i].pic.Visible = false;
                }

                else if (
                    polComboBox.Text != "" &&
                    polComboBox.Text != "мне по фигу" &&
                    persljud[i].pol != (polComboBox.Text))
                {
                    persljud[i].lbl.Visible = false;
                    persljud[i].pic.Visible = false;
                }

                if (persljud[i].lbl.Visible)
                {
                    persljud[i].lbl.Location = new Point(x, 20);
                    persljud[i].pic.Location = new Point(x, 60);
                    x = x + 100;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void SWYAZ_Click(object sender, EventArgs e)
        {


            MailAddress fromMailAddress = new MailAddress("yaroslav_pronin2005@mail.com", "Михаил Абрамов");
            MailAddress toAddress = new MailAddress("beavisabra@gmail.com", "Михаил Абрамов");





            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))


            using (SmtpClient smtpClient = new SmtpClient())


            {


                mailMessage.Subject = "Привет";


                mailMessage.Body = "рпвпкдшг";


               // mailMessage.Attachments.Add(new Attachment("Авто.txt"));





                smtpClient.Host = "smtp.gmail.com";


                smtpClient.Port = 587;


                smtpClient.EnableSsl = true;


                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;


                smtpClient.UseDefaultCredentials = false;


                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "swallow");





                smtpClient.Send(mailMessage);
                MessageBox.Show("отправилось");
                


            }


        }
    }
}
/*for (int i = 0; i< 6; i++)
            {
                cars[i].btn.Visible = true;

                if (minPriceTextBox.Text != "" &&
                    cars[i].price<Convert.ToInt32(minPriceTextBox.Text))
                {
                    cars[i].btn.Visible = false;
                }
                {
                */