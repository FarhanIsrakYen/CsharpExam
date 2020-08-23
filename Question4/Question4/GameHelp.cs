using System;
using System.Collections.Generic;
using System.Text;

namespace Question4
{
    class GameHelp {
        private char[] locations = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public int WinnerChek()
        {
            if (locations[1] == locations[2] && locations[2] == locations[3])
            {
                return 1;
            }
            else if (locations[4] == locations[5] && locations[5] == locations[6])
            {
                return 1;
            }
            else if (locations[6] == locations[7] && locations[7] == locations[8])
            {
                return 1;
            }
            else if (locations[1] == locations[4] && locations[4] == locations[7])
            {
                return 1;
            }
            else if (locations[2] == locations[5] && locations[5] == locations[8])
            {
                return 1;
            }
            else if (locations[3] == locations[6] && locations[6] == locations[9])
            {
                return 1;
            }
            else if (locations[1] == locations[5] && locations[5] == locations[9])
            {
                return 1;
            }
            else if (locations[3] == locations[5] && locations[5] == locations[7])
            {
                return 1; 
            }
            else if (locations[1] != '1' && locations[2] != '2' && locations[3] != '3' && locations[4] != '4' && locations[5] != '5' && locations[6] != '6' && locations[7] != '7' && locations[8] != '8' && locations[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public void SetBoardofGame()
        {
            Console.WriteLine($"     :     :      ");
            Console.WriteLine($"  {locations[1]}  :  {locations[2]}  :  {locations[3]}");
            Console.WriteLine($"_____:_____:_____ ");
            Console.WriteLine($"     :     :      ");
            Console.WriteLine($"  {locations[4]}  :  {locations[5]}  :  {locations[6]}");
            Console.WriteLine($"_____:_____:_____ ");
            Console.WriteLine($"     :     :      ");
            Console.WriteLine($"  {locations[7]}  :  {locations[8]}  :  {locations[9]}");
            Console.WriteLine($"     :     :      ");
        }
    }
}
