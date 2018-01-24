using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_kl_1
{
    //класс, описывающий миску
    class miska
    {
        //кефир 
        private kefir[] kefir;

        //масло 
        private Maslo[] maslo;

        //сахар 
        private Sachar[] sachar;

   
        public void Init()
        {
            maslo = new Maslo[250];
            kefir = new kefir[250];
            sachar = new Sachar[250];
             
        }
        //однородность перемешивания 0-всё отдельно, 10-месиво
        private int odnorodnost = 0;
        //узнаем состояние продуктов
        public int Odnorodnost { get { return odnorodnost; } }
        //продолжакм перемешивать, пока не получим однородную массу
        public void peremechivat()
        {
            if (odnorodnost < 10)
            {
                odnorodnost++;
            }
        }
        //какао в миску
        private cacao[] cacao;

        //сода, гашеная уксусом
        private Soda[] soda;

        public void Init_1()
        {
            cacao = new cacao[25];
            soda = new Soda[10];
          
        }
        private int   odnorodnost_1 = 0;
        public int Odnorodnost_1 { get { return odnorodnost_1; } }
        public void mechat()
        {
            if (odnorodnost_1 < 10)
            {
                odnorodnost_1++;
            }
        }
        //добавить муку
        private Muka[] muka;

        public void Init_2()
        {
            muka= new Muka[1500];
          
        }
        //густота теста 0-плохо перемешано. 10-идеально
        private int gustota = 0;
        public int Gustota { get { return gustota; } }
        public void zamechivat()
        {
            if (gustota < 10)
            {
                gustota++;
            }
        }
       
    }
}
