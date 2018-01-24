using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_kl_1
{
    //класс, описывающий масло
    class Maslo
    {
        //состояние бутылки масла(открыта/закрыта)
        public bool state { set; get; }
        //количество налитого масла 0-ничего нет, 250-нужно по рецепту
        public int mas = 0;
        
        //если бутылка масла открыта и если нет нужного количества, то наливаем
        public Maslo GetMaslo()
        {
            if (state)
            {
                if (mas < 250)
                {
                    mas = mas + 10;

                }
                return new Maslo();
            }
            else
            {
                return null;
            }

        }

    }
}
