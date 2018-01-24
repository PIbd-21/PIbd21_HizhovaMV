using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_r_2_tarantul
{
    interface IAnimals
    {
        void moveTarantul(Graphics g);
        void drawTarantul(Graphics g);
        void SetPosition(int x, int y);
        void CapacityEaten(int count);
        int getEaten();
    }
}
