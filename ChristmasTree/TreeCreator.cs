using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class TreeCreator
    {
        Random numberGen;
        int rows;
        public TreeCreator()
        {
            this.numberGen = new Random();
            this.rows = 0;
        }
        public void CreateTree(int rows)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            this.rows = rows;
            PrintTree();
            PrintPlantPot();
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void PrintTree()
        {
            int spaces = this.rows;

            for (int depth = 0; depth < this.rows; depth++)
            {
                for (int whitespace = 0; whitespace < spaces; whitespace++)
                {
                    Console.Write(" ");
                }
                spaces--;

                for (int width = 0; width <= depth; width++)
                {
                    if (numberGen.Next() % 8 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                for (int width = 0; width <= depth; width++)
                {
                    if (numberGen.Next() % 8 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine();
            }
        }

        private void PrintPlantPot()
        {
            int spacesRequired = this.rows - 3;
            PrintSpaces(spacesRequired);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  **  ");
            PrintSpaces(spacesRequired);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("******");
            PrintSpaces(spacesRequired);
            Console.WriteLine("******");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        private void PrintSpaces(int spacesRequired)
        {
            for (int ppSpaces = 0; ppSpaces <= spacesRequired; ppSpaces++)
            {
                Console.Write(" ");
            }
        }
    }
}
