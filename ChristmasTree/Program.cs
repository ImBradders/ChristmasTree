using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int treeSize;
            bool validInput = false;
            bool running = true;
            while (running)
            {
                do
                {
                    Console.Write("How large would you like your tree? ");
                    userInput = Console.ReadLine();

                    if (!int.TryParse(userInput, out treeSize))
                    {
                        validInput = false;
                        Console.WriteLine("You need to enter a number!");
                    }
                    else
                    {
                        if (treeSize < 2)
                        {
                            Console.WriteLine("Tree too small!");
                            validInput = false;
                        }
                        else if (treeSize > 110)
                        {
                            Console.WriteLine("PBCAK");
                            validInput = false;
                        }
                        else
                        {
                            validInput = true;
                        }
                    }
                } while (!validInput);

                Console.WriteLine();

                TreeCreator myTree = new TreeCreator();
                myTree.CreateTree(treeSize);

                Console.Write("Create another tree? Y = yes: ");
                userInput = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine();
                running = (userInput == "y" || userInput == "Y");
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
