using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_r_5_tp
{
    public class Tarantul : Spider
    {
        private Color color;
        private Color dopColor;

        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }

            protected set
            {
                if (value > 0 && value < 200)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 100;
                }

            }
        }

        public override int MaxcountEaten
        {
            get
            {
                return base.MaxcountEaten;
            }

            protected set
            {
                if (value > 0 && value < 3)
                {
                    base.MaxcountEaten = value;
                }
                else
                {
                    base.MaxcountEaten = 2;
                }

            }
        }
        public override double Weight
        {
            get
            {
                return base.Weight;
            }

            protected set
            {
                if (value > 10 && value < 90)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 40;
                }
            }
        }

        public Tarantul(int maxSpeed, int maxcountEaten, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxcountEaten = maxcountEaten;
            this.Weight = weight;
            this.ColorBody = color;
            this.countEaten = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);

        }

        public override void moveTarantul(Graphics g)
        {
            startPosX += (MaxSpeed * 50 / (float)Weight);
            drawTarantul(g);
        }

        public override void drawTarantul(Graphics g)
        {
            drawNormalTarantul(g);

        }
        protected virtual void drawNormalTarantul(Graphics g)
        {
            //туловище
            Brush telo = new SolidBrush(ColorBody);
            g.FillEllipse(telo, startPosX, startPosY - 10, 55, 40);
            //голова
            g.FillEllipse(telo, startPosX + 45, startPosY - 5, 45, 30);
            //лапки
            Pen pen = new Pen(Color.Black, 3);
            //те, которые от середины
            g.DrawLine(pen, startPosX + 50, startPosY + 20, startPosX + 50, startPosY + 50);
            g.DrawLine(pen, startPosX + 50, startPosY - 30, startPosX + 50, startPosY);
            g.DrawLine(pen, startPosX + 50, startPosY + 48, startPosX + 58, startPosY + 58);
            g.DrawLine(pen, startPosX + 50, startPosY - 28, startPosX + 58, startPosY - 38);
            //те, которые совсем задние
            g.DrawLine(pen, startPosX + 30, startPosY - 10, startPosX, startPosY - 30);
            g.DrawLine(pen, startPosX + 30, startPosY + 30, startPosX, startPosY + 45);
            g.DrawLine(pen, startPosX, startPosY - 30, startPosX, startPosY - 40);
            g.DrawLine(pen, startPosX, startPosY + 45, startPosX, startPosY + 55);

            // передние лапки
            g.DrawLine(pen, startPosX + 70, startPosY - 5, startPosX + 100, startPosY - 15);
            g.DrawLine(pen, startPosX + 70, startPosY + 25, startPosX + 100, startPosY + 40);
            g.DrawLine(pen, startPosX + 100, startPosY - 15, startPosX + 110, startPosY - 15);
            g.DrawLine(pen, startPosX + 100, startPosY + 40, startPosX + 110, startPosY + 40);

            //глазки
            Brush glaza = new SolidBrush(Color.Blue);
            g.FillEllipse(glaza, startPosX + 88, startPosY - 1, 8, 8);
            g.FillEllipse(glaza, startPosX + 88, startPosY + 12, 8, 8);


        }
    }
}
