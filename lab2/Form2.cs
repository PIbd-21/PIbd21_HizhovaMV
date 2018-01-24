using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l_r_5_tp
{
    public partial class Form2 : Form
    {
        IAnimals tarantul = null;

        public IAnimals getTarantul { get { return tarantul; } }

        private void DrawTarantul()
        {
            if (tarantul != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                tarantul.SetPosition(30, 40);
                tarantul.drawTarantul(gr);
                pictureBox1.Image = bmp;
            }
        }
        private event myDel eventAddTarantul;

        public void AddEvent(myDel ev)
        {
            if (eventAddTarantul == null)
            {
                eventAddTarantul = new myDel(ev);
            }else
            {
                eventAddTarantul += ev;
            }
        }

        public Form2()
        {
            InitializeComponent();
            Black.MouseDown += panelColor_MouseDown;
            White.MouseDown += panelColor_MouseDown;
            Red.MouseDown += panelColor_MouseDown;
            Blue.MouseDown += panelColor_MouseDown;
            Yellow.MouseDown += panelColor_MouseDown;
            Green.MouseDown += panelColor_MouseDown;
            Purple.MouseDown += panelColor_MouseDown;
            Peach.MouseDown += panelColor_MouseDown;

            otmena.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void NormalTarantul_MouseDown(object sender, MouseEventArgs e)
        {
            NormalTarantul.DoDragDrop(NormalTarantul.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }


        private void AddTarantul_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        private void AddTarantul_DragDrop(object sender, DragEventArgs e)
        {
            switch(e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный":
                    tarantul = new Tarantul(50, 5, 10, Color.Brown);
                    break;
                case "Крестовик":
                    tarantul = new PoisonousTaranyul(60, 7, 20, Color.Brown, true, true, Color.Red);
                    break;
            }
            DrawTarantul();
        }

       

        private void PoisonousTarantul_MouseDown(object sender, MouseEventArgs e)
        {
            PoisonousTarantul.DoDragDrop(PoisonousTarantul.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void BaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        private void BaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (tarantul != null)
            {
                tarantul.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTarantul();
            }
        }

       

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void DopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }


        private void DopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (tarantul != null)
            {
                if (tarantul is PoisonousTaranyul)
                {
                    (tarantul as PoisonousTaranyul).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTarantul();
                }
            }

        }

       
        private void Add_Click(object sender, EventArgs e)
        {
            if (eventAddTarantul != null)
            {
                eventAddTarantul(tarantul);
            }
            Close();
        }

        
    }
}
