using System;
using System.ComponentModel;
using System.Data.SqlTypes;

namespace ttt
{
    internal class Program
    {
        static String[,] board = new string[3, 3];
        static void Main(string[] args)
        {
            Intro();
            Game();
        }

        static void ShowBoard()
        {
            Console.Clear();

            Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
            Console.WriteLine(" ---------");
            Console.WriteLine($" {board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
            Console.WriteLine(" ---------");
            Console.WriteLine($" {board[2, 0]} | {board[2, 1]} | {board[2, 2]}");
        }

        static void Win()
        {
            int is_end = 0;
            String who = "";
            //첫번째
            if (board[0,0] == board[0,1] && board[0,1] == board[0,2]) 
            {
                if (board[0,0] == "O")
                {
                    is_end = 1;
                    who = "O";
                }
                else if (board[0,0] == "X")
                {
                    is_end = 1;
                    who = "X";
                }
            }else if (board[1,0] == board[1,1] && board[1,1] == board[1,2] )
            {
                if (board[1, 0] == "O")
                {
                    is_end = 1;
                    who = "O";
                }
                else if (board[1, 0] == "X")
                {
                    is_end = 1;
                    who = "X";
                }
            }
            else if (board[2,0] == "O" && board[2,1] == "O" && board[2,2] == "O")
            {
                if (board[2, 0] == "O")
                {
                    is_end = 1;
                    who = "O";
                }
                else if (board[2, 0] == "X")
                {
                    is_end = 1;
                    who = "X";
                }
            }else if (board[0,0] == board[1,0] && board[1,0] == board[2,0])
            {
                if (board[0, 0] == "O")
                {
                    is_end = 1;
                    who = "O";
                }
                else if (board[0, 0] == "X")
                {
                    is_end = 1;
                    who = "X";
                }
            }else if (board[0,1] == board[1,1] && board[1,1] == board[2, 1])
            {
                if (board[0, 1] == "O")
                {
                    is_end = 1;
                    who = "O";
                }
                else if (board[0, 1] == "X")
                {
                    is_end = 1;
                    who = "X";
                }
            }else if (board[0,2] == board[1,2] && board[1,2] == board[2, 2])
            {
                if (board[0, 2] == "O")
                {
                    is_end = 1;
                    who = "O";
                }
                else if (board[0,2] == "X")
                {
                    is_end = 1;
                    who = "X";
                }
            }else if (board[0,0] == board[1,1] && board[1,1] == board[2, 2])
            {
                if (board[0, 0] == "O")
                {
                    is_end = 1;
                    who = "O";
                }
                else if (board[0, 0] == "X")
                {
                    is_end = 1;
                    who = "X";
                }
            }else if (board[2,0] == board[1,1] && board[1,1] == board[0, 2])
            {
                if (board[2, 0] == "O")
                {
                    is_end = 1;
                    who = "O";
                }
                else if (board[2,0] == "X")
                {
                    is_end = 1;
                    who = "X";
                }
            }

            if(is_end == 1)
            {
                Console.WriteLine("게임이 끝났습니다.");
                Console.WriteLine(who + "님이 이기셨습니다.");
            }
        }

        static void Game()
        {

            //초기화
            int i, j;
            for(i = 0; i < 3; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    board[i, j] = " ";
                }
            }
            
            ShowBoard();

            //내가 먼저 한다. 나는 O

            //turn이 0이면 나 1이면 상대
            int turn = 0;
            String me = "O";
            String you = "X";

            while (true)
            {
            String input = Console.ReadLine();

            int x = 0;
            int y = 0 ;

                switch (input)
                {
                case "1":
                    x = 0;
                    y = 0;
                    break;
                case "2":
                    x = 0;
                    y = 1;
                    break;
                case "3":
                    x = 0;
                    y = 2;
                    break;
                case "4":
                    x = 1;
                    y = 0;
                    break;
                case "5":
                    x = 1;
                    y = 1;
                    break;
                case "6":
                    x = 1;
                    y = 2;
                    break;
                case "7":
                    x = 2;
                    y = 0;
                    break;
                case "8":
                    x = 2;
                    y = 1;
                    break;
                case "9":
                    x = 2;
                    y = 2;
                    break;
                default:
                    break;
            }

                if(turn == 0)
                {
                    board[x, y] = me;
                    turn = 1;
                }
                else
                {
                    board[x, y] = you;
                    turn = 0;
                }
            
                ShowBoard();
                Win();
            }
            
        }



        static void Intro()
        {
            Console.WriteLine("┌  ─  ─  ─  ─  ─  ─  ─  ┐");
            Console.WriteLine("│                       │");
            Console.WriteLine("│       TICKTACTOK      │");
            Console.WriteLine("│                       │");
            Console.WriteLine("└  ─  ─  ─  ─  ─  ─  ─  ┘");


            String s = Console.ReadLine();
            Console.Clear();
        }
    }
}
