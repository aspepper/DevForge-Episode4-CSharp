class Person(string name, int age)
{
    private string Name { get; set; } = name;
    private int Age { get; set; } = age;

    public string Greeting() {
        return $"Hello, my name is {Name} and I am {Age} years old.";
    }
}
