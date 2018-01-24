using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_kl_1
{
    class Sachar
    {
        //состояние пакета сахара(открыт.закрыт)
        public bool state { set; get; }

        //количество насыпанного сахара 0-ничего нет, 250-нужно по рецепту
        public int sach = 0;

        //если пакет сахара открыт  и если нет нужного количества, то насыпаем
        public Sachar GetSachar()
        {
            if (state)
            {
                if (sach < 250)
                {
                    sach = sach + 10;

                }
                return new Sachar();
            }
            else
            {
                return null;
            }

        }
    }
}
