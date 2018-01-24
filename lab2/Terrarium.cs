using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_r_3_tp
{
    class Terrarium
    {
        ClassArray<IAnimals> terrarium;
        int countPlace = 10;
        int placeSizeWidht = 200;
        int placeSizeHeight = 100;

        public Terrarium()
        {
            terrarium = new ClassArray<IAnimals>(countPlace, null);
        }

        public int PutTarantulInTerrarium(IAnimals tarantul)
        {
            return terrarium + tarantul;
        }

        public IAnimals GetTarantulInTerrarium(int ticket)
        {
            return terrarium - ticket;
        }
        public void Draw(Graphics g, int width,int heigth)
        {
            DrawMarking(g);
            for(int i = 0; i < countPlace; i++)
            {
                var tarantul = terrarium.getObject(i);
                if (tarantul != null)
                {
                    tarantul.SetPosition(5 + i / 5 * placeSizeWidht + 5, i % 5 * placeSizeHeight + 40);
                    tarantul.drawTarantul(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (countPlace / 5) * placeSizeWidht, 480);
            for(int i=0;i<countPlace / 5; i++)
            {
                for(int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidht, j * placeSizeHeight,
                        i * placeSizeWidht + 110, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidht, 0, i * placeSizeWidht, 400);
            }
        }
    }
}
