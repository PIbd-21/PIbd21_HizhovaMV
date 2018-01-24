using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l_r_2_tarantul
{
    public partial class Form1 : Form
    {
        Color color;
        Color dopColor;
        int maxSpeed;
        int maxCounteaen;
        int Weight;

        private IAnimals inter;

     

        public Form1()
        {
            InitializeComponent();
            color = Color.Brown;
            dopColor = Color.Red;
            maxSpeed = 150;
            maxCounteaen = 3;
            Weight = 1500;
            button1.BackColor = color;
            button2.BackColor = dopColor;


        }
        
       

        private void move_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveTarantul(gr);
                pictureBox1.Image = bmp;
            }


        }

        private void PoisonousTarantul_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new PoisonousTaranyul(maxSpeed, maxCounteaen, Weight, color, 
                    checkBox1.Checked, checkBox2.Checked, dopColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawTarantul(gr);
                pictureBox1.Image = bmp;
            }



        }

        private void Tarantul_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Tarantul(maxSpeed, maxCounteaen, Weight, color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawTarantul(gr);
                pictureBox1.Image = bmp;
            }


        }
        private bool checkFields()
        {

            if (!int.TryParse(textBox1.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBox2.Text, out maxCounteaen))
            {
                return false;
            }
            if (!int.TryParse(textBox.Text, out Weight))
            {
                return false;
            }
            return true;

        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                button1.BackColor = color;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                button2.BackColor = dopColor;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
