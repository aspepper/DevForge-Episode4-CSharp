class Program
{
    private static readonly List<int> numbers = [];
    static void Main(string[] args)
    {
        Random numberRandom = new();
        Person person1 = new("Alex", 51);
        Console.WriteLine(person1.Greeting());

        int bigger = 0;
        // Example of a for loop
        for (int i = 0; i < 10; i++)
        {
            int n = numberRandom.Next(1000);
            Console.WriteLine($"Number {n}");
            numbers.Add(n);
        }

        // Get the bigger number
        numbers.ForEach((e) =>
        {
            if (e > bigger) { bigger = e; }
        });

        Console.WriteLine($"The bigger number is {bigger}.");
    }
}
