using YeildDemoApp;

Console.WriteLine("Application start !!");

// var people = PersonDataManager.GetPersons().Take(2);
// foreach (var person in people)
// {
//     Console.WriteLine($"Hi this is {person.FirstName} - {person.LastName}");
// }

var primeNumbers = PrimeNumberGenerator.GetPrimeNumbers().Take(10000);
foreach (var primeNumber in primeNumbers)
{
    Console.WriteLine(primeNumber);
}

Console.WriteLine("Application End !!");
Console.Read();