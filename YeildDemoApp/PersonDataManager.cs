public static class PersonDataManager
{
    public static IEnumerable<Person> GetPersons()
    {
        yield return new Person(1,"Bruce", "Wayne");
        yield return new Person(2,"Clark", "Kent");
        yield return new Person(3,"Diana", "Prince");
        yield return new Person(4,"Willy", "Wonka");
        yield return new Person(5,"Jack", "Sparrow");
        yield return new Person(6,"Deepika", "Padukoon");
    }

    public static IEnumerable<Person> GetPersonsUnlimited()
    {
        var currentId = 1;
        while (true)
        {
            yield return new Person(currentId, $"Firstname{currentId}", $"Lastname{currentId}");
            currentId++;
        }
    }
}