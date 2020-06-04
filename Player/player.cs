using System;

namespace classes
{
    public class Player
    {
        public delegate void MyDelegate(string a);
        public event MyDelegate Notify;
        private string name, team;
        private int goal_num, p_num;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }           //ім'я гравця
        public string Team
        {
            get { return team; }
            set { team = value; }
        }           //команда, в якій грає гравець
        public int GoalNum
        {
            get { return goal_num; }
            set { goal_num = value; }
        }           //кількість забитих голів
        public int PlayerNum
        {
            get { return p_num; }
            set { p_num = value; }
        }         //номер гравця у команді

        public Player(string name, int goal)    // конструктор з параметрами
        {
            Name = name;
            Team = team;
            GoalNum = goal;
        }
        public void PlayerInfo()        //вивід повної інформації про гравця
        {
            Console.WriteLine("Player info :");
            Console.WriteLine($"\tName : {Name}");
            Console.WriteLine($"\tTeam : {Team}");
            Console.WriteLine($"\tPlayer number : {PlayerNum}");
            Console.WriteLine($"\tGoals: {GoalNum}");
        }
        public void Message(string mes)         //метод виводу рядка, який передаємо через параметр
        {
            Console.WriteLine(mes);
        }
    }
}
