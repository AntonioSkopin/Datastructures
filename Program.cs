using DataStructures.Queues;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new();
            queue.Enqueue(3);
            queue.Enqueue(53);
            queue.Enqueue(2);
            queue.Dequeue();

            Console.WriteLine(queue.Peek());
        }
    }
}
