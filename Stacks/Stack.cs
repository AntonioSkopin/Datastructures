namespace DataStructures.Stacks
{
    public class Stack
    {
        public static readonly int LIMIT = 1000;
        public int size = 0;
        public Node? topItem;

        public Stack()
        {
            topItem = null;
        }

        // Inserting
        public void Push(int value)
        {
            Node temp = new(value);

            // Check if stack is full
            if (!HasSpace())
                Console.WriteLine("Stack Overflow.");

            temp.link = topItem;
            topItem = temp;
            size += 1;
        }

        // Removing
        public Node? Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return null;
            }

            topItem = topItem?.link;
            size -= 1;
            return topItem;
        }

        // Retrieving
        public void PrintStack()
        {
            while (topItem != null)
            {
                Console.WriteLine($"[ {topItem.data} ]");
                topItem = topItem.link;
            }
        }

        public int Peek()
        {
            return topItem.data;
        }

        public int GetSize()
        {
            return size;
        }

        // Helpers
        public bool HasSpace()
        {
            return size < LIMIT;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
    }
}
