public class Person
{
    public Person(long id, string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        Console.WriteLine($"Initialize person {firstName}");
    }

    public long Id { get; set; } = 0;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
}