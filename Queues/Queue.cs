namespace DataStructures.Queues
{
    internal class Queue
    {
        public static readonly int LIMIT = 1000;
        public int size = 0;
        public Node head;
        public Node tail;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              

        // Inserting
        public void Enqueue(int value)
        {
            Node temp = new(value);

            // Check if queue is full
            if (!HasSpace())
                Console.WriteLine("Stack Overflow.");
            

        }

        // Removing
        public void Dequeue()
        {

        }

        // Retrieving
        public int Peek()
        {
            return head.data;
        }

        // Helpers
        public int GetSize()
        {
            return size;
        }

        public bool HasSpace()
        {
            return LIMIT > size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
    }
}
