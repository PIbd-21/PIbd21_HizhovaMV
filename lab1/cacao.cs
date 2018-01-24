using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_kl_1
{
    class cacao
    {
        //состояние пачки какао(открыта.закрыта)
        public bool state { set; get; }

        //количество насыпанного какао 0-ничего нет, 25-нужно по рецепту
        public int с = 0;

        //если пакет какао открыт  и если нет нужного количества, то насыпаем
        public cacao Getcacao()
        {
            if (state)
            {
                if (с < 25)
                {
                    с = с+ 5;

                }
                return new cacao();
            }
            else
            {
                return null;
            }

        }
    }
}
