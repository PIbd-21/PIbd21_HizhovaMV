using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_kl_1
{
    class Soda
    {
        //состояние пачки соды(открыта.закрыта)
        public bool state { set; get; }

        //количество насыпанной соды 0-ничего нет, 10-нужно по рецепту
        public int sod = 0;

        //если пачка соды открыта  и если нет нужного количества, то насыпаем
        public Soda GetSoda()
        {
            if (state)
            {
                if (sod < 10)
                {
                    sod = sod + 1;

                }
                return new Soda();
            }
            else
            {
                return null;
            }

        }
        //уксус к соде
        private Uksus[] uksus;
        //степень загашенности соды 0-нет, 10-готово
        private int gasit = 0;
        //узнаем состояние соды
        public int Gasit { get { return gasit; } }
        //продолжакм ждать, пока не получим загашенную соду
        public void gasitsa()
        {
            if (gasit < 10)
            {
                gasit++;
            }
        }
    }
}
