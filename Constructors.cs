using System;
namespace Task;

class Vehicle
{
    public string carname;
    public string carmodel;
    public string color;
    public string speed;    
    public int year;

    public Vehicle(string n,string r,int m,string s,string c)
    {
        this.carname = n;
        this.carmodel= r;  
        this.year = m;
        this.speed = s;
        this.color = c;
    }//parametrized constructor
    public void print()
    {
        Console.WriteLine("Car Name : " + carname);
        Console.WriteLine("Car's Model Number : " + carmodel); 
        Console.WriteLine( "Manufacturing's Year : " + year);
        Console.WriteLine("Max Speed :  " + speed);
        Console.WriteLine("Vechicle Color : " + color);
  
    }
  public Vehicle(Vehicle v)
    {
        this.speed= v.speed;
        this.color = v.color;
        this.carname= v.carname;    
        this.carmodel= v.carmodel;  
        this.year= v.year;  
    }
    //copy constructor
    static void Main(string[] args)
    {
        Vehicle mehran = new Vehicle("Mehran The Boss", "Vxr Fully Modified alloy Choray Rims ", 1990, "200 km/h", "Gulabi");
        Vehicle car = new Vehicle(mehran);
        car.print();
        Console.WriteLine("Mehran Properties : ");
        mehran.print(); 

    }


}


/*Explanation for Copy Construcotor Lets supose we have a parent class of vehicle that includes all type pf attributes
 instead of creating another class for the same type of vehcile we just create the object of the parent class
in order to Avoid the complexity and to keep the things simple for the same type of things */
