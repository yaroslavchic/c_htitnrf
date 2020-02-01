оusing System;
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
    public partial class Form1 : Form
    {
        int nomer_voprosa = 1;
        int nomer_otveta = 1;

        int startTime;

        public Form1()
        {
            InitializeComponent();
            startTime = Environment.TickCount;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender.Equals(button1))
                nomer_otveta = 1;
            if (sender.Equals(button2))
                nomer_otveta = 2;
            if (sender.Equals(button3))
                nomer_otveta = 3;


            if (nomer_voprosa >= 3)
            {
                return;
            }
            nomer_voprosa = nomer_voprosa + 1;
            label3.Text = "Вопрос " + nomer_voprosa.ToString() + "/10" + 
            (Environment.TickCount - startTime).ToString();

            if (nomer_voprosa == 1 && nomer_otveta == 1)
            {
                button1.Text = "Билл Шифр";
                button2.Text = "Стэнфорд";
                button3.Text = "Старик Макгакет";
                label2.Text = "Кто изображен на картинке";
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            if (nomer_voprosa == 2)
            {
                button1.Text = "Мейбл";
                button2.Text = "Стэнфорд";
                button3.Text = "Старик Макгакет";
                label2.Text = "Автор дневников";
                nomer_otveta = 2;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }

            if (nomer_voprosa == 3)
            {
                button1.Text = "демон";
                button2.Text = "Стэнфорд";
                button3.Text = "Ловушка для мэйбл";
                label2.Text = "Мейблленд что это";
                nomer_otveta = 3;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 helpForm = new Form2();
            helpForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "кто изображён на картинке")
            {
                MessageBox.Show("Ты не прав");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 helpForm = new Form3();
            helpForm.Show();
        }
    }
}
