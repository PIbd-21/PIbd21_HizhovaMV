using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr6_tarantul
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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    //количество уровней
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLeveles:" +
                        terrariumStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach (var level in terrariumStages)
                    {
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for (int i = 0; i < countPlace; i++)
                        {
                            var tarantul = level[i];
                            if (tarantul != null)
                            {
                                if (tarantul.GetType().Name == "Tarantul")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Tarantul:");
                                    fs.Write(info, 0, info.Length);

                                }
                                if (tarantul.GetType().Name == "PoisonousTarantul")
                                {
                                    info = new UTF8Encoding(true).GetBytes("PoisonousTarantul:");
                                    fs.Write(info, 0, info.Length);

                                }
                                info = new UTF8Encoding(true).GetBytes(tarantul.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }

                        }
                    }
                }
                return true;
            }
        }
             public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (terrariumStages != null)
                    {
                        terrariumStages.Clear();
                    }
                    terrariumStages = new List<ClassArray<IAnimals>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                for (int i = 1; i < strs.Length; i++)
                {
                    if (strs[i] == "Level")
                    {
                        counter++;
                        terrariumStages.Add(new ClassArray<IAnimals>(countPlace, null));
                    }
                    else if (strs[i].Split(':')[0] == "Tarantul")
                    {
                        IAnimals tarantul = new Tarantul(strs[i].Split(':')[1]);
                        int number = terrariumStages[counter] + tarantul;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                    else if (strs[i].Split(':')[0] == "PoisonousTarantul")
                    {
                        IAnimals tarantul = new Tarantul(strs[i].Split(':')[1]);
                        int number = terrariumStages[counter] + tarantul;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }

            }
            return true;
        }
    }
}



