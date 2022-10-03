using System;
using System.Reflection;

namespace TaskAttribute
{
    class cAttribute : Attribute
    {
        public cAttribute(string str)
        {
            commentstr = str;
        }

        public string commentstr { get; set; }

    }



    class Student
    {

        [c("Representing\nStudent Roll Number: \n")]
        public int Rollnum { get; set; }

        [c("Representing\nFull Name : \n")]
        public string Fname { get; set; }

        [c("Representing\nStudent's CGPA : \n")]
        public float CGPA  { get; set; }

        [c("Representing\nPrevious Course Status : \n")]
        public string Prevstatus { get; set; }


    }

    class MainProgram
    {
        static void Main(string[] args)
        {
Console.WriteLine("Decorating Function of the Class using Attribute Property\n");

            var properties = typeof(Student).GetProperties();

            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);

                if (Attribute.IsDefined(property, typeof(cAttribute)))
                {
                    Console.WriteLine(property.GetCustomAttribute<cAttribute>().commentstr);
                }

            }

        }
    }
}
