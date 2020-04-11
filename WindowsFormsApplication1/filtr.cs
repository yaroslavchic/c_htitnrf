using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        Pers[] persljud = new Pers[1000];


        public filtr()
        {
            InitializeComponent();

            // persljud[0] = new Pers("Мэйбл", 12, "женский", 0, 0);
            //persljud[1] = new Pers("Диппер", 12, "мужской", 0, 0);
            //persljud[2] = new Pers("Венди", 15, "женский", 0, 0);
            //persljud[3] = new Pers("Стенфорд", 60, "мужской", 0, 0);
            //persljud[4] = new Pers("Стенли", 60, "мужской", 0, 0);
            //persljud[5] = new Pers("Кэнди Чу", 12, "женский", 0, 0);
            //persljud[6] = new Pers("Гидеон", 10, "мужской", 0, 0);
            //persljud[7] = new Pers("Гренда", 12, "женский", 0, 0);
            //persljud[8] = new Pers("Робби", 13 , "мужской", 0, 0);
            //persljud[9] = new Pers("билл сайфер", 1000, "", 0, 0);

            string[] lines = System.IO.File.ReadAllLines("Персы.txt");

            foreach (string str in lines)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                persljud.Add(new persljudr(parts[0], parts[1], Convert.ToInt32(parts[2])));
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