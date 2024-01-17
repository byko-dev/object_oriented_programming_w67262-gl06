namespace object_oriented_programming_w67262_gl06.lab6;

public class Program
{
    public static void Process(String[] args)
    {
        (new CsvService()).InitalizeData();

        int seletedOption = 0;
        do
        {
            seletedOption = ContextMenu();

            Console.Clear();
            
            new CsvService().ActionProvider((ActionType) seletedOption);

        } while (seletedOption != 5);
    }
    
    private  static int  ContextMenu()
    {
        Console.WriteLine("\n1. Wyswietl dane");
        Console.WriteLine("2. Dodaj osobe");
        Console.WriteLine("3. Modyfikuj osobe");
        Console.WriteLine("4. Usun osobe");
        Console.WriteLine("5. Exit");

        Console.WriteLine("Select option 1 - 5");
        
        try
        {
            return Convert.ToInt32(Console.ReadLine());

        }catch(Exception ex){

            Console.WriteLine("Exception Cannot format input to int");

            return 0;
        }
    }
}