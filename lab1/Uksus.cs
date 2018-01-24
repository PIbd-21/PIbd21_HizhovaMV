using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_kl_1
{
    class Uksus
    {
        //состояние бутылки уксуса(открыт.закрыт)
        public bool state { set; get; }

        //количество налитого уксуса 0-ничего нет, 9-нужно по рецепту
        public int uks = 0;

        //если  бутылка открыта   и если нет нужного количества, то насыпаем
        public Uksus GetUksus()
        {
            if (state)
            {
                if (uks < 9)
                {
                    uks = uks + 1;

                }
                return new Uksus();
            }
            else
            {
                return null;
            }

        }

    }
}
