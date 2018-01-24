using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_kl_1
{
    class protiven
    {
        //степень размазанности масла 0-не готово, 10-полностью покрыто дно
        private int razmazan = 0;

        //узнаем состояние 
        public int Razmazan { get { return razmazan; } }

        //размазываем
        public void razmaz()
        {
            if (razmazan < 10)
            {
                razmazan++;
            }
        }
        //шарики из миски
        private Testo[] Testo;

        public void Init()
        {
            Testo = new Testo[24];
            
        }


        public void Addmiska(Testo m)
        {
            for(int i = 0; i < Testo.Length; i++)
            {
                if (Testo[i] == null)
                {
                    Testo[i] = m;
                    return;
                }
            }
        }

    }
}
