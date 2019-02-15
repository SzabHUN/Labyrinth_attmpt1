using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_attmpt1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the playfield [x y]");

            String tmp = Console.ReadLine();

            int x = Convert.ToInt32(tmp.Split(' ')[0]), y = Convert.ToInt32(tmp.Split(' ')[1]);
            int iy = 8;

            int[] facing =
            {
                1,   //Vertical - Broken    
                2,   //ALL    
                3,   //South  
                4,   //West   
                5,   //Top-Left
                6,   //Top-Right
                7,   //Bot-Left
                8,   //Bot-Right
                9,   //Right-2
                10,  //Top-2
                11,  //Left-2
                12,  //Bot-2
                13,  //vertical
                14,  //horizontal
            };

            Char[] chars =
            {
                '¦', //broken in middle
                '┼', //all way allowed
                '¦', //broken in middle
                '■', //roadblock
                '┘', 
                '└',
                '┐',
                '┌',
                '├',
                '┴',
                '┤',
                '┬',
                '│',
                '─',
            };
            

            Random rnd = new Random();

            //-----------------------------------------------
            //--------Square around the "playfield"----------

            Console.SetCursorPosition(2,5);
            Console.Write('╔');
            Console.SetCursorPosition(5+x,5);
            Console.Write('╗');
            Console.SetCursorPosition(2, 9 + y);
            Console.Write('╚');
            Console.SetCursorPosition(5 + x, 9 + y);
            Console.Write('╝');

            for (int i = 0; i < x+2; i++)
            {
                Console.SetCursorPosition(i + 3, 5);
                Console.Write('═');

                Console.SetCursorPosition(i + 3, y + 5 + 4);
                Console.Write('═');
            }

            for (int i = 0; i < y+3; i++)
            {
                Console.SetCursorPosition(2,i + 6);
                Console.Write('║');

                Console.SetCursorPosition(x+5,i + 6);
                Console.Write('║');
            }

            Console.SetCursorPosition(5,5);
            Console.Write('█'); //Start
            Console.SetCursorPosition(5, 6);
            Console.Write('█');
            Console.SetCursorPosition(5, 4);
            Console.Write('S');
            Console.SetCursorPosition(2+x,9+y);
            Console.Write('█');
            Console.SetCursorPosition(2 + x, 8 + y);
            Console.Write('█');
            Console.SetCursorPosition(2 + x, 10 + y);
            Console.Write('G'); //Goal

            //-----------------------------------------------

            for (int i = 0; i < y+1; i++)
            {
               Console.SetCursorPosition(4,7+i);
                for (int iq = 0; iq < x; iq++)
                {
                    Console.Write(chars[rnd.Next(0, chars.Length)]);
                }
            }
            

            Console.ReadKey(true);
        }
    }
}
