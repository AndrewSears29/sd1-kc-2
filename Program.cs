using System;
using Knowledge_Check_2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Coupe>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var coupe = new Coupe();

    Console.WriteLine("Enter the value for number of seats.. ");
    coupe.NumberSeats = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the value for number of doors.. ");
    coupe.NumberDoors = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the value for number of cylinders.. ");
    coupe.NumberCylinders = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter 'automatic' or 'manual' for transmission type.. ");
    coupe.Transmission = Console.ReadLine();


    recordList.Add(coupe);
}

// Print out the list of records using Console.WriteLine()
recordList.ForEach(Console.WriteLine);

Console.WriteLine("Press ENTER to exit..");
Console.ReadLine();