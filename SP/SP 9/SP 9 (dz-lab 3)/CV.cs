using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_9__dz_lab_3_
{
    public class CV
    {
        public string Text { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public double Age { get; set; }
        public double Experience { get; set; } 
        public double Salary { get; set; }


        public CV(string text) 
        {
            Text = text;
            getStatistic();
        }

        public void getStatistic()
        {
            string[] lines = Text.Split("\r\n");
            if (lines.Length > 6)
            {
                FullName = lines[0].Split(' ').Last() + " " + lines[1].Split(' ').Last();
                string[] city = lines[2].Split(' ');
                City = string.Empty;
                for(int i = 1; i < city.Length; i++)
                {
                    City += city[i] + " ";
                }
                City= City.Trim();
                Age = double.Parse(lines[3].Split(' ').Last());
                Experience = double.Parse(lines[4].Split(' ').Last());
                Salary = double.Parse(lines[5].Split(' ').Last());
            }
            else
            {
                MessageBox.Show("Bad CV!");
            }
        }






    }
}
