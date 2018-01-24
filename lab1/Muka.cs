using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_kl_1
{
    class Muka
    {
        //состояние пакета муки(открыт.закрыт)
        public bool state { set; get; }

        //количество насыпанной муки 0-ничего нет, 250-нужно по рецепту
        public int muk = 0;

        //если пакет муки открыт  и если нет нужного количества, то насыпаем
        public Muka GetMuka()
        {
            if (state)
            {
                if (muk < 1500)
                {
                    muk = muk + 100;

                }
                return new Muka();
            }
            else
            {
                return null;
            }

        }
    }
}
