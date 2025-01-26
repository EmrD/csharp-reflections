class MyClass
{
    public int Age { get; set; }
    public string? Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int randomNumber = rand.Next(1, 100);

        MyClass myClass = new MyClass();

        myClass.Age = randomNumber;
        myClass.Name = "Test Name";

        var props = myClass.GetType().GetProperties().ToList();

        foreach (var prop in props)
        {
            var value = prop.GetValue(myClass)?.ToString();
            Console.WriteLine($"Name: {prop.Name}, Value: {value}");
        }
    }
}