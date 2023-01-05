
using System;

class Program {         
        static void Main(string[] args)
        {
            Vehicle v = new Car("medium car size");
            v.displaySize(); // displays Car size
            v = new Vehicle("Standard car size");
            v.displaySize(); // displays Vehicle size
            //v.callBaseDisplaySize()  //this won't work because vehicle does not contain 'callBaseDisplaySize' method.
            Car c = new Car("super car size");
            c.callBaseDisplaySize();    //this will be able to call callBaseDisplaySize because we instantiated its own class type
        }
}

class Vehicle {

    public string vehicleSize {get;set;}
    public Vehicle(string vehicleSize)
    {
        this.vehicleSize = vehicleSize;
    }

    public virtual void displaySize()   //virtual keyword is needed so that its child classes can override this method
    {
        Console.WriteLine("Vehicle Size: " + vehicleSize);
    }
}

class Car:Vehicle {
    public Car(string carSize):base(carSize)    //by using :base(carSize) The car Constructor  will call the superclass's constructor passing its paramater carSize 
    {

    }  
    
    public override void displaySize()  //override keyword is need to override the same method name it parent's class has1
    {
        Console.WriteLine("Car Size: " + vehicleSize);
    }
    public void callBaseDisplaySize()
    {
        base.displaySize();   //this will call the Car's parent class makeSound which will displaye "Vehicle sound"
    }
}