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
    public partial class Geroy : Form
    {
        /// <summary>
        /// Текущий персонаж
        /// </summary>
        public Pers pers;

        public Geroy(Pers _pers)
        {
            pers = _pers;
            InitializeComponent();

            Text = pers.name;
            label1.Text = pers.name + "," + pers.vosrast.ToString() + " лет";
            //persljud[i].pic.Load("../../Картинки/" + persljud[i].name + ".jpg");
            pictureBox2.Load("../../Картинки/" + pers.name + ".jpg");
            likeLabel.Text = pers.likes.ToString();
            Dislikelabel.Text = pers.Dislikes.ToString();
            label2.Text = pers.prosmotr.ToString();
            pers.prosmotr = pers.prosmotr + 1;
        }

        private void Geroy_Load(object sender, EventArgs e)
        {

        }

        private void Like_Click(object sender, EventArgs e)
        {
            pers.likes = pers.likes + 1;
            likeLabel.Text = pers.likes.ToString();
        }

        private void Disike_Click(object sender, EventArgs e)
        {
        }

        private void Dislike_Click(object sender, EventArgs e)
        {
            pers.Dislikes = pers.Dislikes + 1;
            Dislikelabel.Text = pers.Dislikes.ToString();

        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void likeLabel_Click(object sender, EventArgs e)
        {


        }
            
    }
}
