
using System;

class Program {         
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("Standard vehicle size");
            v.displaySize(); // displays Vehicle size
            Vehicle w = new Car("Medium car size",100); // is this possible that the child constructor can have more or parameters than its parent class
            w.displaySize(); // displays Car size 
            //Console.WriteLine(w.cost);     //this won't work because vehicle does not contain the property 'cost.
            //w.callBaseDisplaySize();  //this won't work because vehicle does not contain the 'callBaseDisplaySize' method.
            Car c = new Car("Super car size",500);  //
            c.callBaseDisplaySize();    //this will be able to call callBaseDisplaySize because we instantiated its own class type
            c.displayCost();

            Vehicle[] vehicles = {v,w};
            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.displaySize();
            }

        }
}

class Vehicle {

    protected string vehicleSize {get;set;}
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
    public int cost {get;set;}
    public Car(string carSize, int cost):base(carSize)    //by using :base(carSize) The car Constructor  will call the superclass's constructor passing its paramater carSize 
    {
        this.cost = cost;
    }  
    
    public override void displaySize()  //override keyword is need to override the same method name it parent's class has
    {
        Console.WriteLine("Car Size: " + vehicleSize);
    }
    public void callBaseDisplaySize()
    {
        base.displaySize();   //this will call the Car's parent class makeSound which will displaye "Vehicle sound"
    }
    public void displayCost()
    {
        Console.WriteLine("Car cost is: " + cost);
    }
}