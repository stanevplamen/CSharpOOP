using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class MainTest
    {
        static void Main()   
        {
            Console.WriteLine("Please wait few seconds for the first set of tests...");
            // First set of tests
            TestOne(new int[] { 2, 1, 3, 4 });

            for (int count = 0; count < 1000; count++)
            {
                int[] test = new int[100];
                Random random = new Random();
                int numb = 0;
                for (int i = 0; i < test.Length; i++)
                {
                    numb = random.Next();
                    test[i] = numb;
                }
                TestOne(test);
            }

            // Second set of tests
            TestTwo();
        }

        #region Tree implementation tests

        static void TestOne(int[] values)
        {
            AATree<int, int> tree = new AATree<int, int>();
            for (int i = 0; i < values.Length; i++)
            {
                if (!tree.Add(values[i], (i + 1)))
                {
                    throw new TreeInvalidOperationException(string.Format("Failed to insert value: {0}", values[i]));
                }
            }

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (tree[values[j]] != 0)
                    {
                        throw new TreeInvalidOperationException(string.Format("Deleted key has been found: {0}", values[j]));
                    }
                }
                for (int j = i; j < values.Length; j++)
                {
                    if (tree[values[j]] != (j + 1))
                    {
                        throw new TreeInvalidOperationException(string.Format("Could not find key: {0}", values[j]));
                    }
                }
                if (!tree.Remove(values[i]))
                {
                    throw new TreeInvalidOperationException(string.Format("Invalid delete operation of element: {0}", values[i]));
                }
            }
        }

        #endregion Tree implementation tests

        #region Tree additional methods tests

        private static void TestTwo()
        {
            AATree<int, int> treeOne = new AATree<int, int>();
            AATree<int, int> treeTwo = new AATree<int, int>();
            AATree<int, int> treeThree = new AATree<int, int>();

            List<int> listOne = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8};
            List<int> listThree = new List<int>() { 1, 2, 3, 4, 5, 6, 20};

            for (int i = 0; i < listOne.Count; i++)
            {
                if (!treeOne.Add(listOne[i], (i + 1))) { };
            }
            for (int i = 0; i < listThree.Count; i++)
            {
                if (!treeThree.Add(listThree[i], (i + 1))) { };
            }
            treeTwo = treeOne.Clone();

            if (treeOne == treeTwo)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tree one({0})\n and\nTree two({1})", treeOne, treeTwo);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("are equal\n");
            }
            else if (treeOne != treeTwo)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tree one({0})\n and\nTree two({1})", treeOne, treeTwo);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("are NOT equal\n");
            }

            if (treeOne == treeThree)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tree one({0})\n and\nTree three({1})", treeOne, treeThree);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("are equal\n");
            }
            else if (treeOne != treeThree)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tree one({0})\n and\nTree three({1})", treeOne, treeThree);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("are NOT equal\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var node in treeTwo)
            {
                Console.Write("{0}, ", node.Key);
            }
        }

        #endregion Tree additional methods tests    
    }
}
