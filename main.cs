/*Author Charles Yingling     Date 9/27/2021
1. Create a new repl called Lab5a in C# to calculate the speed of 7 cars in a race.*/
using System;

class Program {
  public static void Main (string[] args) {
        int carcounter = 0;
        double total = 0;

    while (carcounter < 7) { //do, for, while
    carcounter++;
    //get inputs for each car
      Console.WriteLine ($"Enter the distance covered by Car#{carcounter}");
        double dist = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine ($"Enter the time taken by Car#{carcounter}");
        double time = Convert.ToDouble(Console.ReadLine());
    //Calculate the speed for each car
        double speed = dist / time;
    //Display the speed for each car.    
      Console.WriteLine ($"The speed of this car is {speed} miles per hour");
        total = total + speed;
     }
     //Calculate the average speed of the 7 cars and display it (outside the loop)
        double average = total / carcounter;
      Console.WriteLine ($"The average speed of the cars is {average} miles per hour");
  }
}