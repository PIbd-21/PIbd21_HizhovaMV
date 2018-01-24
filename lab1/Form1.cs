using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_kl_1
{
    public partial class Form1 : Form
    {
        //кефир 
        private kefir[] kefir;

        //масло 
        private Maslo[] maslo;

        //сахар 
        private Sachar[] sachar;
        //какао в миску
        private cacao[] cacao;

        //сода, гашеная уксусом
        private Soda[] soda;

        //добавить муку
        private Muka[] muka;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addsachar_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Сахар добавлен в миску", 
                "Действие", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
           
        }

        private void addsoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сода добавлена в миску",
               "Действие", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            bool soda1 = true;
        }

        private void addkefir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кефир добавлен в миску",
               "Действие", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            bool kefir1 = true;
        }
        public void razbit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Яйца разбиты",
               "Действие", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (razbit_Click == inter)
            {
                bool razb = true;
            }
            
        }

        public void addegg_Click(object sender, EventArgs e)
        {
            if (razb == true)
            {
                MessageBox.Show("Яйца добавлены в миску",
              "Действие", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                bool egg1 = true;
            }else
            {
                MessageBox.Show("Яйца не могут быть добавлены в миску, так как они не разбиты",
              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void addmaslo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Масло добавлено в миску",
              "Действие", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void naprotiven_Click(object sender, EventArgs e)
        {

        }

        private void addmuka_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мука добавлена в миску",
              "Действие", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void adduksus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уксус добавлен в миску",
              "Действие", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void addkakao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Какао добавлено в миску",
              "Действие", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void razmechat_Click(object sender, EventArgs e)
        {

        }
    }
}
