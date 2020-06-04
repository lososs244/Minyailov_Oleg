using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
    public class Season
    {
        Random rnd = new Random((int)DateTime.Now.Ticks);
        public Season Next { get; set; }
        private Team[] arr = new Team[4];
        public int SeasonNum { get; set; }

        public Team[] Arr
        {
            get
            {
                return arr;
            }
            set
            {
                arr = value;
            }
        }


        public Season(Team a, Team b, Team c, Team d)
        {
            Arr[0] = a;
            Arr[1] = b;
            Arr[2] = c;
            Arr[3] = d;
            INIT();
        }

        public void INIT()          //ініціалізація голів для кожної команди
        {
            for (int i = 0; i < 4; i++)
            {
                Arr[i].GoalNum = rnd.Next(7);
            }
        }

        public void ShowSeasonInfo()        //вивід інформації про сезон
        {
            Team temp;
            for (int j = 0; j <= Arr.Length - 2; j++)          //сортування команд за кількістю голів у сезоні
            {
                for (int i = 0; i <= Arr.Length - 2; i++)
                {
                    if (Arr[i].GoalNum < Arr[i + 1].GoalNum)
                    {
                        temp = Arr[i + 1];
                        Arr[i + 1] = Arr[i];
                        Arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("Season Info: ");
            Console.WriteLine($"\tPlace\t\t\tTeam\t\t\tGoal number");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"\t{i+1}\t\t\t{Arr[i].TName}\t\t\t{Arr[i].GoalNum}");
            }
        }
    }
}
