using System;

namespace QueueCircularListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, x;
            QueueCL qu = new QueueCL();
            while (true)
            {
                Console.WriteLine("1.Insert an element in the queue");
                Console.WriteLine("2.Delete an element from the queue");
                Console.WriteLine("3.Display an element at the front");
                Console.WriteLine("4.Display all the elements from the queue");
                Console.WriteLine("5.Display the size of queue");
                Console.WriteLine("6.Quit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 6)
                    break;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter element to be inserted:");
                        x = Convert.ToInt32(Console.ReadLine());
                        qu.Insert(x);
                        break;
                    case 2:
                        x = qu.Delete();
                        Console.WriteLine("Element deleted:" + x);
                        break;
                    case 3:
                        Console.WriteLine("Element at the front:" + qu.Peek());
                        break;
                    case 4:
                        qu.Display();
                        break;
                    case 5:
                        Console.WriteLine("Size of the queue:" + qu.size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
