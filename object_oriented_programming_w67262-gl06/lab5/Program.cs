using object_oriented_programming_w67262_gl06.lab5.Zadanie1;
using object_oriented_programming_w67262_gl06.lab5.Zadanie2;

namespace object_oriented_programming_w67262_gl06.lab5;

public partial class Program
{

    public static void Process(String[] args)
    {
        //Zadanie 1 
        A a = new A();
        A a1 = new A();
        A a2 = new A();

        B b = new B();
        B b1 = new B();
        B b2 = new B();
         
        C c = new C();
        C c1 = new C();
        C c2 = new C();

        List<A> listA = new List<A> { a, a1, a2, b, b1, b2, c, c1, c2 };
        List<B> listB = new List<B> { b, b1, b2, c, c1, c2 };
        List<C> listC = new List<C> { c, c1, c2 };

        foreach (var af in listA)
        {
            af.Method1();
            af.Method2();
        }
        
        //Zadanie 2
        Circle circle = new Circle();
        circle.InputData();
        circle.PrintingResult();
    }
}