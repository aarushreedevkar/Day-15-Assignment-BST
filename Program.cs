namespace BinarySearchTree1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------Welcome To Binary Search Tree--------");
            Console.WriteLine();
            BST<int> bST = new BST<int>(56);
            bST.Insert(30);
            bST.Insert(70);
            bST.Display();
           

            Console.Read();
        }
    }
}
