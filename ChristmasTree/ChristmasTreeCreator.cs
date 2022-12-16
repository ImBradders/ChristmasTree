using System;

namespace ChristmasTree
{
    public class ChristmasTreeCreator : TreeCreator
    {
        private Random numberGen;
        private int baublePercentage;
        
        public ChristmasTreeCreator()
        {
            Construct(10, true, 10);
        }

        public ChristmasTreeCreator(int size)
        {
            Construct(size, true, 10);
        }

        public ChristmasTreeCreator(int size, bool hasPot)
        {
            Construct(size, hasPot, 10);
        }
        
        public ChristmasTreeCreator(int size, int baublePercentage)
        {
            Construct(size, true, baublePercentage);
        }
        
        public ChristmasTreeCreator(int size, bool hasPot, int baublePercentage)
        {
            Construct(size, hasPot, baublePercentage);
        }

        private void Construct(int size, bool hasPot, int baublePercentage)
        {
            this.numberGen = new Random();
            this.treeSize = size;
            this.hasPot = hasPot;
            this.baublePercentage = baublePercentage;
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