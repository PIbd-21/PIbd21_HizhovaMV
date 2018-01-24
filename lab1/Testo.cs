using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_kl_1
{
    class Testo
    {
        private miska[] miska;

        public void Init()
        {
            miska = new miska[24];

        }


        public void Addmiska(miska m)
        {
            for (int i = 0; i < miska.Length; i++)
            {
                if (miska[i] == null)
                {
                    miska[i] = m;
                    return;
                }
            }
        }
        //разделение теста на шарики 0-их нет, 24-готово
        private int balloons = 0;
        //проверяем состояние теста
        public int Balloons { get { return balloons; } }
        public void razdel()
        {
            balloons++;
        }
    }
}
