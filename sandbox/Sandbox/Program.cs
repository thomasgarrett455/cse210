using System;

class Program
{

    static void Main(string[] args)
    {
        Circle myCircle = new Circle(10);
        Circle myCircle2 = new Circle(5);
        //  myCircle.SetRadius(10.5);
        Console.WriteLine($"{myCircle.GetRadius()}");
        Console.WriteLine($"{myCircle.GetArea()}");
     
        Console.WriteLine($"{myCircle2.GetRadius()}");
        Console.WriteLine($"{myCircle2.GetArea()}");


                Cylinder myCylinder = new Cylinder(100, 5);
        //      myCylinder.SetCircle(myCircle);
        //      myCylinder.SetHeight(10);
                Console.WriteLine($"{myCylinder.GetVolume()}");
    }
}
