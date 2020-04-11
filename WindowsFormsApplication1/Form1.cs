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
    public struct Vopr
    {
        
    public string name;
        public string o1;
        public string o2;
        public string o3;
    public Button btn;

public Vopr(string NameVopr, string o1Vopr, string o2Vopr, string o3Vopr)
    {
        name = NameVopr;
           o1 = o1Vopr;
            o2 = o2Vopr;
            o3 = o3Vopr;
        btn = new Button();
    }

}
    public partial class Form1 : Form
    {
        int nomer_voprosa = 1;
        int nomer_otveta = 1;
        int ugadal = 0;
        
        int startTime;

        
        public void f1(string name1, int nomer_otveta)
        {
           // int nomer_otveta = 1;
        }

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

        void vopros1(string text)
        {
            try
            {
                label2.Text = text;
                pictureBox1.Load("../../Картинки/" + text + ".jpg");
                string[] stroki =
                    System.IO.File.ReadAllLines("../../Картинки/" + text + ".txt");
                button1.Text = stroki[0];
                button2.Text = stroki[1];
                button3.Text = stroki[2];
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender.Equals(button1))
                nomer_otveta = 1;
            if (sender.Equals(button2))
                nomer_otveta = 2;
            if (sender.Equals(button3))
                nomer_otveta = 3;


            if (nomer_voprosa >= 11)
            {
                return;
            }
            
            if (nomer_voprosa == 0)
            {
              if (nomer_otveta == 1) ugadal = ugadal + 1;
                vopros1("Кто изображен на картинке");
            }
           if (nomer_voprosa == 1)
            {
                 if (nomer_otveta == 1) ugadal = ugadal + 1;
                vopros1("Автор дневников");
            }

            if (nomer_voprosa == 2 )
            {
                if (nomer_otveta == 2) ugadal = ugadal + 1;
                vopros1("Мейблленд что это");
            }

            else if (nomer_voprosa == 3 )
            {
                 if (nomer_otveta == 3) ugadal = ugadal + 1;
                vopros1("Сколько Форд был в другом измерении");
            }

            else if (nomer_voprosa == 4 )
            {
                 if (nomer_otveta == 1) ugadal = ugadal + 1;
                vopros1("Кто такая Пухля");
            }

            else if (nomer_voprosa == 5)
            {
               if (nomer_otveta == 2) ugadal = ugadal + 1;
                vopros1("Какой дневник у Диппера");
            }
             else if (nomer_voprosa == 6 )
            {
                 if (nomer_otveta == 3) ugadal = ugadal + 1;
                vopros1("Какой дневник у Гидеона");
            }
             else if (nomer_voprosa == 7 )
            {
                if (nomer_otveta == 2) ugadal = ugadal + 1;
                vopros1("Странногедон что такое");
            }
             else if (nomer_voprosa == 8 )
            {
                 if (nomer_otveta == 2) ugadal = ugadal + 1;
                vopros1("Сколько лет Дипперу и Мейбел");
            }
            else if (nomer_voprosa == 9 )
            {
                 if (nomer_otveta == 3) ugadal = ugadal + 1;
                vopros1("Кто такой Блэндин");
            }
            else if (nomer_voprosa == 10 && nomer_otveta == 2)
            {
                 if (nomer_otveta == 2) ugadal = ugadal + 1;
                MessageBox.Show("Ты заслуживаешь таких же проблем как у Диппера и Мейбл Пайнс");
            }
           


            nomer_voprosa = nomer_voprosa + 1;
            if (nomer_voprosa < 11)
                nVoprosaLabel.Text = "Вопрос " + nomer_voprosa.ToString() + "/10";
            label1.Text = "Правильных " + ugadal.ToString() + "/10 ";


        }
        private void button4_Click(object sender, EventArgs e)
        {
            //Form2 helpForm = new Form2();
            //helpForm.Show();
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
            recordsForm helpForm = new recordsForm();
            helpForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            filtr d = new filtr();
            d.Show();
        }
    }
}
