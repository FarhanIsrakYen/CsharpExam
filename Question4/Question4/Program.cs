using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            GameHelp game = new GameHelp();
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int player = 1;  
            int flag = 0;
            do
            {
                Console.WriteLine("Player1:X and Player2:O");
                if (player % 2 == 0)
                { 
                    Console.WriteLine("2nd Player now");
                }
                else
                {
                    Console.WriteLine("1st Player now");
                }
                game.SetBoardofGame();
                int choice = Convert.ToInt32(Console.ReadLine());
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) 
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else 
                {
                    Console.WriteLine($"Row {choice} is already marked with {arr[choice]}");
                }
                flag = game.WinnerChek();
            } 
            while (flag != 1 && flag != -1);
            game.SetBoardofGame();  
            if (flag == 1) 
            {
                Console.WriteLine($"Player {(player % 2) + 1} has won");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
