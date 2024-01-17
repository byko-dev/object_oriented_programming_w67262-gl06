using System.Globalization;
using CsvHelper;

namespace object_oriented_programming_w67262_gl06.lab6;

public abstract class BaseCsvHelper
{
    public string FilePath { private get; set; } = "sample.csv";


    protected List<T> GetAllRecords<T>()
    {
        using (var reader = new StreamReader(FilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            return csv.GetRecords<T>().ToList();
        }
    }

    protected void WriteRecords<T>(List<T> records)
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(records);
        }
    }
    
}