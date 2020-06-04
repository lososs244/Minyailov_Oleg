using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
    public class List
    {
        Season head;
        public int SeasonCounter { get; set; }

        
        public List()       // конструктор
        {
            head = null;
            SeasonCounter = 0;
        }
        public void TeamList()          //вивід списку команд
        {
            Season p = head;
            Console.WriteLine("Teams:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"\t{p.Arr[i].TName}");
            }
        }
        public void AddSeason(Team a, Team b, Team c, Team d)       //додавання сезону у список
        {
            Season s = new Season(a, b, c, d);
            if (head == null)
            {
                head = s;
                head.Next = null; 
            }
            else
            {
                s.Next = head;
                head = s;
            }
            SeasonCounter++;
            s.SeasonNum = SeasonCounter;

        }

        public void SeasonList()        //вивід інформації про всі сезони, що відбулися
        {
            Season p = head;
           
            while(p != null)
            {
                Console.WriteLine($"Season : {p.SeasonNum}");
                p.INIT();
                p.ShowSeasonInfo();
                p = p.Next;
            }
        }

        public void SeasonInfo(int num)   //інформація про сезон
        {
            try
            {
                Season p = head;
                if (num > 0 && num <= SeasonCounter)
                {
                    while (p.SeasonNum != num)
                    {
                        p = p.Next;
                    }
                    Console.WriteLine($"Season : {p.SeasonNum}");
                    p.ShowSeasonInfo();
                }
                else
                {
                    throw new Exception("There is no such season");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}
