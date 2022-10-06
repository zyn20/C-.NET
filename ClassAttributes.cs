using System;
using System.Reflection;

namespace app;

internal class Program
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]  //for access of class && for access of method && for access properties
    class myAttribute : Attribute      //create attributes
    {
        public string CommentStr
        {
            get;
            set;
        }
    }
    [my(CommentStr = " CLASS FOR DATA STORE OF  TEACHER")]              //for class
    class University

    {
        public University()
        {


        }
        [my(CommentStr = "Display Function")]             ///for method
        public void funtion()
        {
            string name;
            name = Console.ReadLine();

            Console.WriteLine(name);
        }

        [my(CommentStr = "University Name")]     //for properties
        public string name
        { get; set; }
        [my(CommentStr = "University  DEPT")]
        public string dept
        { get; set; }
        [my(CommentStr = "University CITY")]
        public string city
        { get; set; }
        [my(CommentStr = "University Registration Number")]
        public string reg
        { get; set; }
    }
    static void Main(string[] args)
    {



        Console.WriteLine("LEARNING MANAGEMENT SYSTEM");
        var v1 = typeof(University).Name;                 

        var properties = typeof(University).GetProperties();             //get properties
        var v2 = typeof(University).GetMethods();                      //get method

        var attrib = (myAttribute)Attribute.GetCustomAttribute(typeof(University), typeof(myAttribute)); //for class
        Console.WriteLine(v1); /// display class name
        Console.WriteLine(attrib.CommentStr); // display attributes
        foreach (var prop in properties)                           // display properties
        {
            Console.WriteLine(prop.Name);

            if (Attribute.IsDefined(prop, typeof(myAttribute)))
            {
                Console.WriteLine(prop.GetCustomAttribute<myAttribute>().CommentStr);
            }
        }
        foreach (var prop in v2)                                  //display methods
        {
            Console.WriteLine(prop.Name);
            if (Attribute.IsDefined(prop, typeof(myAttribute)))
            {
                Console.WriteLine(prop.GetCustomAttribute<myAttribute>().CommentStr);
            }
        }
        Console.WriteLine(typeof(University).Name);


    }









}
