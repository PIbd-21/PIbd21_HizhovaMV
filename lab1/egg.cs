using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_kl_1
{
    class egg
    {
        //состояние яйца(цело.разбито)
        public bool state { set; get; }

        //если яйцо разбито, то отделяем желток
        public egg Getegg()
        {
            if (state)
            {

                return null;
                
            }
            else
            {
                return new egg();
            }

        }
        //состояние выполениея действия. 0-яйцо не разделено, 10-выделен желток
        private int otdeleno = 0;
        public int Otdeleno { get { return otdeleno; } }
        public void yellow()
        {
            if (otdeleno < 10)
            {
                otdeleno++;
            }
        }
    }
}
