using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr6_tarantul
{
    public interface IAnimals
    {
        void moveTarantul(Graphics g);
        void drawTarantul(Graphics g);
        void SetPosition(int x, int y);
        void CapacityEaten(int count);
        int getEaten();

        void SetMainColor(Color Color);

        string getInfo();
    }
}
