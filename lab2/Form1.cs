using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4_TP
{
    public partial class Form1 : Form
    {
       
        Terrarium terrarium;

        public Form1()
        {
            InitializeComponent();
            
            terrarium = new Terrarium(5);
            
            for (int i = 1; i < 6; i++)
            {
                listBox1.Items.Add("Уровень " + i);
            }
            listBox1.SelectedIndex = terrarium.getCurrentLevel;
            Draw();

        }

       
        private void AddTarantul(IAnimals tarantul)
        {
            if (tarantul != null)
            {
                int place = terrarium.PutTarantulInTerrarium(tarantul);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                else
                {
                    MessageBox.Show("Тарантула не удалось положить");
                }
            }
        }

        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                terrarium.Draw(gr,1000,200);
                pictureBox1.Image = bmp;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var PoisTar = new PoisonousTaranyul(100, 4, 1000, dialog.Color, true, true, dialogDop.Color);
                    int place = terrarium.PutTarantulInTerrarium(PoisTar);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string level = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    IAnimals car = terrarium.GetTarantulInTerrarium(Convert.ToInt32(maskedTextBox1.Text));
                    if (car != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        car.SetPosition(30, 40);
                        car.drawTarantul(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Извинте, на этом месте нет тарантула");
                    }
                }
            }
        }

    

    private void button1_Click(object sender, EventArgs e)
        {
            terrarium.LevelDown();
            listBox1.SelectedIndex = terrarium.getCurrentLevel;
            Draw();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            terrarium.LevelUp();
            listBox1.SelectedIndex = terrarium.getCurrentLevel;
            Draw();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var PoisTar = new PoisonousTaranyul(100, 4, 1000, dialog.Color, true, true, dialogDop.Color);
                    int place = terrarium.PutTarantulInTerrarium(PoisTar);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var tarantul = new Tarantul(100, 4, 1000, dialog.Color);
                int place = terrarium.PutTarantulInTerrarium(tarantul);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }
        }
    }
}
