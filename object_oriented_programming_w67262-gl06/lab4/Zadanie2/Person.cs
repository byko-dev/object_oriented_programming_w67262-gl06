namespace object_oriented_programming_w67262_gl06.lab4.Zadanie2;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Pesel { get; set; }
    public string Id { get; set; }
    
    public int getAge()
    {
        if (Pesel.Length != 11)
        {
            throw new ArgumentException("Nieprawidłowa długość numeru PESEL.");
        }

        int year = Convert.ToInt32(Pesel.Substring(0, 2));
        int month = Convert.ToInt32(Pesel.Substring(2, 2));
        int day = Convert.ToInt32(Pesel.Substring(4, 2));

        if (month > 80)
        {
            year += 1800;
            month -= 80;
        }
        else if (month > 60)
        {
            year += 2200;
            month -= 60;
        }
        else if (month > 40)
        {
            year += 2100;
            month -= 40;
        }
        else if (month > 20)
        {
            year += 2000;
            month -= 20;
        }
        else
        {
            year += 1900;
        }

        DateTime birthDate = new DateTime(year, month, day);
        DateTime currentDate = DateTime.Now;

        int age = currentDate.Year - birthDate.Year;
        if (birthDate > currentDate.AddYears(-age))
        {
            age--;
        }

        return age;
    }

    public string getGender()
    {
        return int.Parse(this.Id.Substring(9, 1)) % 2 == 0 ? "Women" : "Men";
    }

    public virtual string GetEducationInfo()
    {
        return "";
    }
    
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public virtual bool CanGoAloneToHome()
    {
        return getAge() > 13;
    }
}