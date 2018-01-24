using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_TP
{
    public abstract class Spider : IAnimals
    {
        protected float startPosX;

        protected float startPosY;

        protected int countEaten;

        public virtual int MaxcountEaten { protected set; get; }

        public virtual int MaxSpeed { protected set; get; }

        public Color ColorBody { protected set; get; }

        public virtual double Weight { protected set; get; }

        public abstract void moveTarantul(Graphics g);

        public abstract void drawTarantul(Graphics g);

        public void SetPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        public void CapacityEaten(int count)
        {
            if (countEaten + count < MaxcountEaten)
            {
                countEaten += count;
            }
        }
        public int getEaten()
        {
            int count = countEaten;
            countEaten = 0;
            return count;
        }

        
    }
}
