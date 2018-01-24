using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_kl_1
{
    class duhovka
    {
        //состояние духовки(включена.выключена)
        public bool state { set; get; }
        public duhovka GetDuhovka()
        {
            if (state)
            {

                return new duhovka();
            }
            else
            {
                return null;
            }

        }

        //температура разогрева духовки 0-начало,200-нужно по рецепту
        private int temper = 0;

        //узнаем температуру духовки
        public int Temper { get { return temper; } }

        //повышаем температуру духовки
        public void tempduc()
        {
            if (temper < 200)
            {
                temper = temper + 20;
            }
        }

        private protiven[] protiven;

        public void Init()
        {
            protiven = new protiven[24];
        }
        //свойство получения и возврата противня
        public protiven Protiven { set { Protiven = value; } get { return Protiven; } }

    }
}
