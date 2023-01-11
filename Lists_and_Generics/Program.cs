//reference: https://www.youtube.com/watch?v=aNTDJ9bnRU4
using System;


//Supposed we want to display a list of numbers. However, while 1 list is using int, another is using double, string, etc. 
//If we are to print those numbers, how can we prevent the redundancy and make an efficent code by using only 1 method displayList? This is where generic comes in.
class Program {  
    static void Main(string[] args)
    {
        List<int> intList = new List<int>(){1,2,3};     //This is how to create a list
        intList.Add(4);                                 // Adding an item to the list
        List<double> doubleList = new List<double>{1.0, 2.0, 3.0};
        doubleList.Add(5.0);
        List<string> stringList = new List<string>{"1","2","3"};
        stringList.Add("7");

        //with generics implemented in the method displayList(),  all types of list can share the same method
        displayList(intList);
        displayList(doubleList);
        displayList(stringList);
        
    }

    public static void displayList<T>(List<T> numberList)   // <T> beside the method name is how we declare a generic. with this any 'List' of data type can use this method
    {
        foreach(var items in numberList){
            Console.Write(items+" ");
        }
        Console.WriteLine();
    }

    //Without using generics, we would create each method to accommodate each data type

    // public static void displayList(List<int> intList)
    // {
    //     foreach(var items in intList){
    //         Console.Write(items+" ");
    //     }
    //     Console.WriteLine();
    // }

    // public static void displayList(List<double> doubleList)
    // {
    //     foreach(var items in doubleList){
    //         Console.Write(items+" ");
    //     }
    //     Console.WriteLine();
    // }

    // public static void displayList(List<string> stringList)
    // {
    //     foreach(var items in stringList){
    //         Console.Write(items+" ");
    //     }
    //     Console.WriteLine();
    // }
}

