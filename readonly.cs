using System;
namespace app;

class Student
{
    private readonly string Id = "20F-0277 ";
    public string ID                         //properties
    {

        get { return Id; }
    }
    static void Main(string[] args)

    {
        var ob = new Student();
    
       

        Console.WriteLine("ID :: " + ob.ID);
    }


}
