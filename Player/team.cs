using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{

    public class Team
    {
        public delegate void MyDelegate(string a);
        public event MyDelegate Notify;
        private Player[] arr = new Player[11]; 
        private int size;
        private string team_name;
        private int goalnum;
        public int GoalNum
        {
            get
            {
                return goalnum;
            }
            set
            {
                goalnum = value;
            }
        }

        public string TName
        {
            get { return team_name; }
            set { team_name = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public Player[] Arr { get => arr; set => arr =  value; }
        
        public Team(string name) //конструктор з параметрами
        {
            Size = 0;
            TName = name;
            this.Notify += Message;
        }
        public Player this[int num]
        {
            get
            {
                if(num > 11 && num < 1)
                {
                    return null;
                }
                else
                {
                    return Arr[num];
                }
            }
            set
            {
                while (num > 11 && num < 1)
                {
                    Notify?.Invoke("There is no player with this number");
                }
                Arr[num] = value;
            }
        }      //індексатор гравця

        public void AddPlayer(Player p)     //включення гравця до команди
        {
            if (Size < 11)
            {
                this[Size] = p;
                p.PlayerNum = Size + 1;
                p.Team = TName;
                Size++;
            }
            else
            {
                Notify?.Invoke("There is a max number of players in this team");
            }
        }
        public void DeletePlayer(Player p)  //видалення гравця
        {
            try
            {
                if (Size == 0) { throw new Exception("There are no players in this team "); }
                else {
                    for (int i = 0; i < Size + 1; i++)
                    {
                        if (this[i].PlayerNum == p.PlayerNum)
                        {
                            while (i != Size)
                            {
                                this[i] = this[i + 1];
                                this[i + 1].PlayerNum--;
                                i++;
                            }
                            Size--;
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
        public void TeamInfo()          // вивід інформації про команду
        {
            int count = 0;
            
            for(int j = 0; j < 11; j++)
            {
                count += Arr[j].GoalNum;
            }

            Console.WriteLine("Team info:");
            Console.WriteLine($"\tName: {TName}");
            Console.WriteLine($"\tGoals of team: {count}");
            Console.WriteLine("\tPlayers:\tGoals:");

            for (int i = 0; i < Size; i++)
            {
                if (i < 9)
                {
                    Console.WriteLine($"\t\t{i + 1}  {this[i].Name}  : {this[i].GoalNum}");
                }
                else
                {
                    Console.WriteLine($"\t\t{i + 1} {this[i].Name} : {this[i].GoalNum}");
                }
            }
        }
        public void Message(string mes)         //метод виводу рядка, який передаємо через параметр
        {
            Console.WriteLine(mes);
        }
    }
}
