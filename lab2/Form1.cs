﻿using l_r_2_tarantul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l_r_3_tp
{
    public partial class Form1 : Form
    {
        Terrarium terrarium;

        public Form1()
        {
            InitializeComponent();
            terrarium = new Terrarium();
            Draw();

        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            terrarium.Draw(gr, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
            if (maskedTextBox1.Text != "")
            {
                var tarantul = terrarium.GetTarantulInTerrarium(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                tarantul.SetPosition(40, 40);
                tarantul.drawTarantul(gr);
                pictureBox2.Image = bmp;
                Draw();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
