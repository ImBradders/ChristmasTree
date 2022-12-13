using System;

namespace ChristmasTree
{
    public class ChristmasTreeCreator : TreeCreator
    {
        Random numberGen;
        int baublePercentage;
        
        public ChristmasTreeCreator()
        {
            Construct(10, 10, true);
        }

        public ChristmasTreeCreator(int size)
        {
            Construct(size, 10, true);
        }

        public ChristmasTreeCreator(int size, int baublePercentage)
        {
            Construct(size, baublePercentage, true);
        }
        
        public ChristmasTreeCreator(int size, int baublePercentage, bool hasPot)
        {
            Construct(size, baublePercentage, hasPot);
        }

        private void Construct(int size, int baublePercentage, bool hasPot)
        {
            this.numberGen = new Random();
            this.treeSize = size;
            this.baublePercentage = baublePercentage;
            this.hasPot = hasPot;
        }

        protected override void PrintTree()
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

        protected override void PrintTreeLeft(int width)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int counter = 0; counter <= width; counter++)
            {
                if (numberGen.Next() % 100 < baublePercentage)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write("*");
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }

        protected override void PrintTreeRight(int width)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int counter = 0; counter <= width; counter++)
            {
                if (numberGen.Next() % 100 < baublePercentage)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write("*");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine();
        }
    }
}