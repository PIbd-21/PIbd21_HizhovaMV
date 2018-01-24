using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_r_5_tp
{
    public class Terrarium
    {

        List<ClassArray<IAnimals>> terrariumStages;

        int countPlace = 10;
        int placeSizeWidht = 200;
        int placeSizeHeight = 100;

        int currentLevel;

        public int getCurrentLevel { get { return currentLevel; } }

        public void LevelUp()
        {
            if (currentLevel + 1 < terrariumStages.Count)
            {
                currentLevel++;
            }
        }
        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;

            }
        }

        public Terrarium(int countStages)
        {
            terrariumStages = new List<ClassArray<IAnimals>>();
            for (int i = 0; i < countStages; i++)
            {
                terrariumStages.Add(new ClassArray<IAnimals>(countPlace, null));
            }
        }

        public int PutTarantulInTerrarium(IAnimals tarantul)
        {
            return terrariumStages[currentLevel] + tarantul;
        }

        public IAnimals GetTarantulInTerrarium(int ticket)
        {
            return terrariumStages[currentLevel] - ticket;
        }


        public void Draw(Graphics g, int width, int heigth)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlace; i++)
            {
                var tarantul = terrariumStages[currentLevel][i];
                if (tarantul != null)
                {
                    tarantul.SetPosition(5 + i / 5 * placeSizeWidht + 25, i % 5 * placeSizeHeight + 35);
                    tarantul.drawTarantul(g);
                }
            }
        }



        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue),
                (countPlace / 5) * placeSizeWidht, 480);
            g.DrawRectangle(pen, 0, 0, (countPlace / 5) * placeSizeWidht, 480);
            for (int i = 0; i < countPlace / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidht, j * placeSizeHeight,
                        i * placeSizeWidht + 110, j * placeSizeHeight);
                    if (j < 5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue),
                            i * placeSizeWidht + 30, j * placeSizeHeight + 20);
                    }
                }
                g.DrawLine(pen, i * placeSizeWidht, 0, i * placeSizeWidht, 400);
            }
        }
    }
}
