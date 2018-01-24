using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_r_3_tp
{
    public class PoisonousTaranyul : Tarantul
    {
        private Color dopColor;
        private bool fangs;
        private bool riskily;

        public PoisonousTaranyul(int maxSpeed, int maxcountEaten, double weight,
            Color color, bool fangs, bool riskily, Color dopColor) :
            base(maxSpeed, maxcountEaten, weight, color)
        {
            this.fangs = fangs;
            this.riskily = riskily;
            this.dopColor = dopColor;
        }
        protected override void drawNormalTarantul(Graphics g)
        {

            if (fangs)
            {
                Pen pen = new Pen(Color.Red, 5);
                g.DrawLine(pen, startPosX + 40, startPosY + 58, startPosX + 68, startPosY + 58);

                Pen pen2 = new Pen(Color.FromArgb(59, 54, 54), 2);
                g.DrawLine(pen2, startPosX + 68, startPosY + 58, startPosX + 82, startPosY + 58);

            }
            base.drawNormalTarantul(g);
            Brush telo = new SolidBrush(ColorBody);
            g.FillEllipse(telo, startPosX, startPosY - 15, 60, 50);

            Brush glaza = new SolidBrush(Color.Red);
            g.FillEllipse(glaza, startPosX + 88, startPosY - 1, 8, 8);
            g.FillEllipse(glaza, startPosX + 88, startPosY + 12, 8, 8);
            if (riskily)
            {
                //крест
                Pen pen1 = new Pen(dopColor, 4);
                g.DrawLine(pen1, startPosX + 15, startPosY + 10, startPosX + 45, startPosY + 10);
                g.DrawLine(pen1, startPosX + 30, startPosY - 5, startPosX + 30, startPosY + 25);
            }

        }
    }
}
