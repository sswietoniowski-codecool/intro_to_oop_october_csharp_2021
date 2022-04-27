namespace HelloOOP;

public class Program
{
    public static void Main()
    {
        //string firstName = "John";
        //string lastName = "Doe";
        //int age = 30;
        Person person = new Person("John", "Doe", 30);
        Console.WriteLine($"Liczba osób: {Person.numberOfPeople}");
        //person.firstName = "John";
        //person.lastName = "Doe";
        //person.age = 30;
        //person.PrintPersonInfo();

        //string firstName2 = "Jane";
        //string lastName2 = "Smith";
        //int age2 = 20;
        Person person2 = new Person("Jane", "Smith", 20);
        Console.WriteLine($"Liczba osób: {Person.numberOfPeople}");
        //person2.firstName = "Jane";
        //person2.lastName = "Smith";
        //person2.age = 20;

        //PrintPersonInfo(firstName, lastName, age);
        //PrintPersonInfo(firstName, lastName2, age2);
        //Person.PrintPersonInfo(person);
        //Person.PrintPersonInfo(person2);
        person.PrintPersonInfo();
        person2.PrintPersonInfo();

        //person.firstName = "";
        person.lastName = "";
        person.age = -1;

        person.PrintPersonInfo();

        Person wrongPerson = new Person("", "", -1);
        wrongPerson.PrintPersonInfo();
        wrongPerson.SetFirstName("");
        Console.WriteLine(wrongPerson.GetFirstName());
        //wrongPerson.firstName = "";
        wrongPerson.PrintPersonInfo();
        wrongPerson.SetFirstName("John");
        Console.WriteLine(wrongPerson.GetFirstName());
        wrongPerson.FirstName = "Jane";
        Console.WriteLine(wrongPerson.FirstName);
        Console.WriteLine($"Liczba osób: {Person.numberOfPeople}");

        //Math.Cos(1.0);

        //Random rnd = new Random();
        //rnd.Next();
    }

    public static void PrintPersonInfo(string firstName, string lastName, int age)
    {
        Console.WriteLine($"{firstName} {lastName} is {age} years old.");
    }

    //public static void PrintPersonInfo(Person person)
    //{
    //    Console.WriteLine($"{person.firstName} {person.lastName} is {person.age} years old.");
    //}
}