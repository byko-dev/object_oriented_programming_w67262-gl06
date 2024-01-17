using System.Globalization;
using CsvHelper;
using Exception = System.Exception;

namespace object_oriented_programming_w67262_gl06.lab6;

public class CsvService : BaseCsvHelper
{
    public string FilePath { private get; set; } = "sample.csv";
    
    public void ActionProvider(ActionType action)
    {
        switch (action)
        {
            case ActionType.Show:
                ReadAndDisplayDataFromCsv();
                break;
            case ActionType.Add:
                AppendPerson();
                break;
            case ActionType.Delete:
                RemovePerson();
                break;
            case ActionType.Modify:
                ModifyPerson();
                break;
            case ActionType.Exit:
                Environment.Exit(0);
                break;
        }
    }
    
    private void ReadAndDisplayDataFromCsv()
    {
        Console.WriteLine("\nDane odczytane z pliku CSV:");
        foreach (var person in GetAllRecords<Person>())
        {
            Console.WriteLine($"Imię: {person.FirstName}, Nazwisko: {person.LastName}, Wiek: {person.Age}");
        }
    }

    static void SearchDataInCsv(string filePath, string searchTerm)
    {
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<Person>().Where(p => p.FirstName.Contains(searchTerm) || p.LastName.Contains(searchTerm)).ToList();

            Console.WriteLine($"\nWyniki wyszukiwania dla '{searchTerm}':");
            foreach (var person in records)
            {
                Console.WriteLine($"Imię: {person.FirstName}, Nazwisko: {person.LastName}, Wiek: {person.Age}, Pesel: {person.Pesel}, Email: {person.Email}");
            }
        }
    }


    public void AppendPerson()
    {
        Console.WriteLine("Type Firstname: ");
        string firstname =  Console.ReadLine()!;
        Console.WriteLine("Type Lastname: ");
        string lastname =  Console.ReadLine()!;
        Console.WriteLine("Type age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type pesel:");
        string pesel =  Console.ReadLine()!;
        Console.WriteLine("Type email:");
        string email =  Console.ReadLine()!;
        
        List<Person> persons = GetAllRecords<Person>();
        persons.Add(new Person()
        {
            FirstName = firstname,
            LastName = lastname,
            Age = age,
            Pesel = pesel,
            Email = email
        });

        WriteRecords(persons);
    }

    public void RemovePerson()
    {
        Console.WriteLine("Type person's pesel to remove: ");
        string pesel = Console.ReadLine()!;
        
        List<Person?> persons = GetAllRecords<Person>();

        Person? personToRemove = persons.Find(p => p!.Pesel == pesel);

        if (personToRemove == null)
            throw new Exception("Person not found!");

        persons.Remove(personToRemove);
        
        WriteRecords(persons);
    }

    public void ModifyPerson()
    {
        Console.WriteLine("Type person's pesel to modify: ");
        string pesel = Console.ReadLine()!;
        
        List<Person?> persons = GetAllRecords<Person>();

        Person? personToModify = persons.Find(p => p!.Pesel == pesel);
        
        if (personToModify == null)
            throw new Exception("Person not found!");
        
        Console.WriteLine($"Modify FirstName: {personToModify.FirstName} (Set empty field and press Enter to skip modification)");
        string fistName = Console.ReadLine();

        if (!String.IsNullOrEmpty(fistName))
        {
            personToModify.FirstName = fistName;
        }
        
        Console.WriteLine($"Modify LastName: {personToModify.LastName} (Set empty field and press Enter to skip modification)");
        string lastName = Console.ReadLine();
        
        if (!String.IsNullOrEmpty(lastName))
        {
            personToModify.LastName = lastName;
        }
        
        Console.WriteLine($"Modify Age: {personToModify.Age} (Set empty field and press Enter to skip modification)");
        string age = Console.ReadLine();
        
        if (!String.IsNullOrEmpty(age) && int.TryParse(age, out int ageInt))
        {
            personToModify.Age = ageInt;
        }
        
        Console.WriteLine($"Modify Pesel: {personToModify.Pesel} (Set empty field and press Enter to skip modification)");
        string newPesel = Console.ReadLine();
        
        if (!String.IsNullOrEmpty(newPesel))
        {
            personToModify.LastName = newPesel;
        }
        
        Console.WriteLine($"Modify Email: {personToModify.Email} (Set empty field and press Enter to skip modification)");
        string email = Console.ReadLine();
        
        if (!String.IsNullOrEmpty(email))
        {
            personToModify.LastName = email;
        }
        
        WriteRecords(persons);
    }


    public void InitalizeData()
    {

        if (File.Exists(FilePath))
            return;

        List<Person> persons = new List<Person>
        { 
            new Person { FirstName = "John", LastName = "Doe", Age = 25, Pesel = "12345678901", Email = "johnD@gmail.com"},
            new Person { FirstName = "Alice", LastName = "Smith", Age = 30, Pesel = "12345678902", Email = "aliceBraun@gmail.com"},
            new Person { FirstName = "Bob", LastName = "Johnson", Age = 22, Pesel = "12345678903", Email = "bobM@gmail.com"}
        };

        WriteRecords(persons);
    }
}