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

        protected override void PrintAsterisks(int width)
        {
            PrintTreeHalf(width);
            PrintTreeHalf(width);
        }
        protected override void PrintTreeHalf(int width)
        {
            for (int counter = 0; counter <= width; counter++)
            {
                if (numberGen.Next() % 100 < baublePercentage)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("*");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");
                }
            }
        }
    }
}