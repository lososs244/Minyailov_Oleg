using System;
using System.Collections.Generic;
using classes;

namespace Maj
{

    class Program
    {
        static void Main(string[] args)
        {
            Team Alfa = new Team("Alfa"); // створення чотирьох початкових команд
            Team Beta = new Team("Beta"); 
            Team Gamma = new Team("Gamma"); 
            Team Delta = new Team("Delta"); 

            //PlayersA          створення кожного гравця та додавання до команди
            Player playerA1 = new Player("playerA1", 0);
            Player playerA2 = new Player("playerA2", 2);
            Player playerA3 = new Player("playerA3", 1);
            Player playerA4 = new Player("playerA4", 0);
            Player playerA5 = new Player("playerA5", 4);
            Player playerA6 = new Player("playerA6", 0);
            Player playerA7 = new Player("playerA7", 1);
            Player playerA8 = new Player("playerA8", 0);
            Player playerA9 = new Player("playerA9", 0);
            Player playerA10 = new Player("playerA10", 2);
            Player playerA11 = new Player("playerA11", 0);

            //PlayersB
            Player playerB1 = new Player("playerB1", 1);
            Player playerB2 = new Player("playerB2", 0);
            Player playerB3 = new Player("playerB3", 1);
            Player playerB4 = new Player("playerB4", 0);
            Player playerB5 = new Player("playerB5", 2);
            Player playerB6 = new Player("playerB6", 0);
            Player playerB7 = new Player("playerB7", 2);
            Player playerB8 = new Player("playerB8", 1);
            Player playerB9 = new Player("playerB9", 3);
            Player playerB10 = new Player("playerB10", 2);
            Player playerB11 = new Player("playerB11", 0);

            //PlayersG
            Player playerG1 = new Player("playerG1", 1);
            Player playerG2 = new Player("playerG2", 0);
            Player playerG3 = new Player("playerG3", 2);
            Player playerG4 = new Player("playerG4", 1);
            Player playerG5 = new Player("playerG5", 1);
            Player playerG6 = new Player("playerG6", 0);
            Player playerG7 = new Player("playerG7", 1);
            Player playerG8 = new Player("playerG8", 2);
            Player playerG9 = new Player("playerG9", 0);
            Player playerG10 = new Player("playerG10", 2);
            Player playerG11 = new Player("playerG11", 0);

            //PlayersD
            Player playerD1 = new Player("playerD1", 0);
            Player playerD2 = new Player("playerD2", 1);
            Player playerD3 = new Player("playerD3", 2);
            Player playerD4 = new Player("playerD4", 1);
            Player playerD5 = new Player("playerD5", 0);
            Player playerD6 = new Player("playerD6", 0);
            Player playerD7 = new Player("playerD7", 1);
            Player playerD8 = new Player("playerD8", 1);
            Player playerD9 = new Player("playerD9", 1);
            Player playerD10 = new Player("playerD10", 2);
            Player playerD11 = new Player("playerD11", 0);

            //Adding players to A
            Alfa.AddPlayer(playerA1);
            Alfa.AddPlayer(playerA2);
            Alfa.AddPlayer(playerA3);
            Alfa.AddPlayer(playerA4);
            Alfa.AddPlayer(playerA5);
            Alfa.AddPlayer(playerA6);
            Alfa.AddPlayer(playerA7);
            Alfa.AddPlayer(playerA8);
            Alfa.AddPlayer(playerA9);
            Alfa.AddPlayer(playerA10);
            Alfa.AddPlayer(playerA11);

            //Adding players to B
            Beta.AddPlayer(playerB1);
            Beta.AddPlayer(playerB2);
            Beta.AddPlayer(playerB3);
            Beta.AddPlayer(playerB4);
            Beta.AddPlayer(playerB5);
            Beta.AddPlayer(playerB6);
            Beta.AddPlayer(playerB7);
            Beta.AddPlayer(playerB8);
            Beta.AddPlayer(playerB9);
            Beta.AddPlayer(playerB10);
            Beta.AddPlayer(playerB11);

            //Adding players to G
            Gamma.AddPlayer(playerG1);
            Gamma.AddPlayer(playerG2);
            Gamma.AddPlayer(playerG3);
            Gamma.AddPlayer(playerG4);
            Gamma.AddPlayer(playerG5);
            Gamma.AddPlayer(playerG6);
            Gamma.AddPlayer(playerG7);
            Gamma.AddPlayer(playerG8);
            Gamma.AddPlayer(playerG9);
            Gamma.AddPlayer(playerG10);
            Gamma.AddPlayer(playerG11);

            //Adding players to D
            Delta.AddPlayer(playerD1);
            Delta.AddPlayer(playerD2);
            Delta.AddPlayer(playerD3);
            Delta.AddPlayer(playerD4);
            Delta.AddPlayer(playerD5);
            Delta.AddPlayer(playerD6);
            Delta.AddPlayer(playerD7);
            Delta.AddPlayer(playerD8);
            Delta.AddPlayer(playerD9);
            Delta.AddPlayer(playerD10);
            Delta.AddPlayer(playerD11);

            List SeasonL = new List();                              //створення чотирьох початкових сезонів
            SeasonL.AddSeason(Alfa, Delta, Gamma, Beta);  
            SeasonL.AddSeason(Beta, Alfa, Delta, Gamma);
            SeasonL.AddSeason(Delta, Gamma, Beta, Alfa);
            SeasonL.AddSeason(Gamma, Beta, Alfa, Delta);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\t\t\t\t\t\tMinyailov Oleg IS-92");
            char ExKey = 'c'; // змінна для виходу з программи
            char key;         // змінна для виконання необхідних задач
            while(ExKey == 'c')
            {
                Console.WriteLine("Show list of seasons --> press 'l'");            // список можливих дій
                Console.WriteLine("Show list of teams   --> press 't'");
                Console.WriteLine("Show season info     --> press 's'");
                Console.WriteLine("Show team info       --> press 'i'");
                Console.WriteLine("Show player info     --> press 'p'");

                key = Convert.ToChar(Console.ReadLine());           //  користувач вводить літеру, яка відповідає дії зі списку

                switch (key)
                {
                    case 'l':
                        SeasonL.SeasonList();           //вивід всіх сезонів та їх результатів
                        break;
                    case 't':
                        SeasonL.TeamList();         // вивід списку всіх команд
                        break;
                    case 's':
                        Console.WriteLine("Enter the number of season");
                        SeasonL.SeasonInfo(Convert.ToInt32(Console.ReadLine())); //вивід результатів певного сезона
                        break;
                    case 'i':
                        Console.WriteLine("Enter the name of team");            
                        string n;                                               // задання змінної для збереження назви команди
                        n = Console.ReadLine();                                 // зчитування назви команди
                        switch(n)
                        {
                            case "Alfa":
                            case "alfa":
                                Alfa.TeamInfo();
                                break;
                            case "Beta":
                            case "beta":
                                Beta.TeamInfo();
                                break;
                            case "Gamma":
                            case "gamma":
                            case "gama":
                                Gamma.TeamInfo();
                                break;
                            case "Delta":
                            case "delta":
                                Delta.TeamInfo();
                                break;
                            default:
                                Console.WriteLine("There is no team with this name!!!");
                                break;
                        }                                            //вивід інформації про команду, відповідно до введеної користувачем назви
                        break;
                    case 'p':
                        Console.WriteLine("Enter the name of team");
                        string a = Console.ReadLine();                          //зчитування назви команди
                        Console.WriteLine("Enter the number of player");        
                        int b = Convert.ToInt32(Console.ReadLine());            //зчитування номера гравця
                        while(b > 11 && b < 1)                                  //перевірка на номер, що було введено
                        {                                                       //якщо було помилково введено неможливий номер, то дається змога повторного вводу номера
                            Console.WriteLine("There is no player with this number\nEnter a player number correctly!");
                            b = Convert.ToInt32(Console.ReadLine());            //зчитування повторного вводу номера гравця
                        }
                        switch (a)
                        {
                            case "Alfa":
                            case "alfa":
                                Alfa[b - 1].PlayerInfo();
                                break;
                            case "Beta":
                            case "beta":
                                Beta[b - 1].PlayerInfo();
                                break;
                            case "Gamma":
                            case "gamma":
                                Gamma[b - 1].PlayerInfo();
                                break;
                            case "Delta":
                            case "delta":
                                Delta[b - 1].PlayerInfo();
                                break;
                            default:
                                Console.WriteLine("There is no team with this name!!!");
                                break;
                        }           //вивід інформації певного гравця певної команди
                        break;
                    default:
                        Console.WriteLine("Wrong key"); //якщо користувач натиснув на літеру, яка не виконує жодної дії, то виводиться повідомлення про помилку 
                        break;
                }
                Console.WriteLine("Press c to continue");
                ExKey = Convert.ToChar(Console.ReadLine()); //зчитування літери, яку було натиснуто для подальшої дії, або завершення программи
            }
        }
    }
}
