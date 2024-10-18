public class MyStack
{
    private Queue<int> queue;
    public MyStack()
    {
        queue = new Queue<int>();
    }

    public void Push(int x)
    {
        queue.Enqueue(x);
    }

    public int Pop()
    {
        queue.();
    }

    public int Top()
    {

    }

    public bool Empty()
    {
        return queue.Any();
    }

    public static void Main(string[] args)
    {


        // Print the result
        Console.WriteLine("PreOrder Traversal:");
        Console.WriteLine();
    }
}
