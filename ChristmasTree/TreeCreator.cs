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
        }

        protected virtual void PrintTree()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int spaces = this.treeSize - 1;

            for (int depth = 0; depth < this.treeSize; depth++)
            {
                PrintSpaces(spaces);
                spaces--;
                
                PrintAsterisks(depth);
                Console.WriteLine();
            }
        }

        protected void PrintSpaces(int amount)
        {
            for (int spaces = 0; spaces < amount; spaces++)
            {
                Console.Write(" ");
            }
        }
        
        protected virtual void PrintAsterisks(int width)
        {
            PrintTreeHalf(width);
            PrintTreeHalf(width);
        }
        protected virtual void PrintTreeHalf(int width)
        {
            for (int counter = 0; counter <= width; counter++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("*");
            }
        }

        private void PrintPlantPot()
        {
            PrintSpaces(this.treeSize - 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**");
            PrintSpaces(this.treeSize - 3);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("******");
            PrintSpaces(this.treeSize - 3);
            Console.WriteLine("******");
        }
        
        private void PrintTrunk()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int count = 0; count < 3; count++)
            {
                PrintSpaces(this.treeSize - 1);
                Console.WriteLine("**");
            }
        }
    }
}
