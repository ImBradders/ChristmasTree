using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeCreator tree = new TreeCreator();
            tree.CreateTree();

            ChristmasTreeCreator cTree = new ChristmasTreeCreator();
            cTree.CreateTree();
        }
    }
}
