int[] caffeinе = Console.ReadLine().Split(", ").Select(int.Parse).ToArray(); // stack
int[] drinks = Console.ReadLine().Split(", ").Select(int.Parse).ToArray(); // queue

int caffTaken = 0; // max 300

Stack<int> stack = new Stack<int>(caffeinе);
Queue<int> queue = new Queue<int>(drinks);

while (stack.Count > 0 && queue.Count > 0)
{
    int currCaff = stack.Pop();
    int currDrink = queue.Dequeue();
    int sum = currCaff * currDrink;

    if (sum + caffTaken <= 300)
    {
        caffTaken += sum;
    }
    else
    {
        queue.Enqueue(currDrink);
        caffTaken -= 30;

        if (caffTaken < 0) caffTaken = 0;
        continue;
    }

}

if (queue.Count > 0)
{
    Console.WriteLine($"Drinks left: {string.Join(", ", queue)}");
}
else
{
    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
}

Console.WriteLine($"Stamat is going to sleep with {caffTaken} mg caffeine.");
