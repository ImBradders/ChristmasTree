using System;

namespace ChristmasTree
{
    public class TreeCreator
    {
        protected int treeSize;
        protected bool hasPot;
        
        public TreeCreator()
        {
            Construct(10, true);
        }

        public TreeCreator(int size)
        {
            Construct(size, true);
        }
        
        public TreeCreator(int size, bool hasPot)
        {
            Construct(size, hasPot);
        }

        private void Construct(int size, bool hasPot)
        {
            this.treeSize = size;
            this.hasPot = hasPot;
        }
        
        public void CreateTree()
        {
            PrintTree();
            if (hasPot)
                PrintPlantPot();
            else
                PrintTrunk();
            Console.ForegroundColor = ConsoleColor.White;
        }

        protected virtual void PrintTree()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int spaces = this.treeSize;

            for (int depth = 0; depth < this.treeSize; depth++)
            {
                PrintSpaces(spaces);
                spaces--;
                
                PrintTreeLeft(depth);
                PrintTreeRight(depth);
            }
        }

        protected void PrintSpaces(int amount)
        {
            for (int spaces = 0; spaces < amount; spaces++)
            {
                Console.Write(" ");
            }
        }
        
        protected virtual void PrintTreeLeft(int width)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int counter = 0; counter <= width; counter++)
            {
                Console.Write("*");
            }
        }

        protected virtual void PrintTreeRight(int width)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int counter = 0; counter <= width; counter++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        private void PrintPlantPot()
        {
            int spacesRequired = this.treeSize - 2;
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
        
        private void PrintTrunk()
        {
            int spacesRequired = this.treeSize - 2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int count = 0; count < 3; count++)
            {
                PrintSpaces(spacesRequired);
                Console.WriteLine("  **  ");
            }
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
