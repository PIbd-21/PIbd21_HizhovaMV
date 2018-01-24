using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_kl_1
{
    //класс, описывающий кефир
    class kefir
    {
        //состояние пакета кефира(открыт.закрыт)
        public bool state {set; get;}

        //количество налитого кефира 0-ничего нет, 250-нужно по рецепту
        public int k = 0;

        //если пакет кефира открыт  и если нет нужного количества, то наливаем
        public kefir Getkefir()
        {
            if (state)
            {
                if (k < 250) {
                    k = k + 10;
                   
                }
                return new kefir();
            }
            else
            {
                return null;
            }

        }

    }
}
