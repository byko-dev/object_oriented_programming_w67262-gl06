namespace object_oriented_programming_w67262_gl06.lab4.Zadanie2;

public class Student : Person
{
    private string School { get; set; }

    private bool CanGoAloneToHomeValue { get; set; }

    public override bool CanGoAloneToHome()
    {
        return CanGoAloneToHomeValue = (getAge() > 13);
    }

    public void SetCanGoHomeAlone(bool value)
    {
        CanGoAloneToHomeValue = value;
    }
}