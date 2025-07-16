using System;
using System.Reflection;

namespace Demo_C__S05
{
    // ===== Q"1 : Enum Creation =====
    //enum WeekDays
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}

    // ===== Q"2 : Enum Creation =====
    //enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}

    // ===== Q"4 : Enum Creation =====//

    //[Flags]
    //enum Permissions
    //{
    //    None = 0,
    //    Read = 1,
    //    Write = 2,
    //    Delete = 4,
    //    Execute = 8
    //}

    //========Q"5 : Enum Creation =====
    //enum Colors
    //{
    //    Red,
    //    Green,
    //    Blue
    //}

    internal class Program
    {



        static void Main(string[] args)
        {
            //========Part 01 Is The Demo=========//
            //================================================


            //              ================Part 02 (Enum)=================         //

            // Q"1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            // Then, write a C# program that prints out all the days of the week using this enum.

            //Console.WriteLine("Days of the week:");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}


            //Q"2.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)


            //Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string input = Console.ReadLine();


            //bool isValid = Enum.TryParse(input, true, out Season selectedSeason);

            //if (isValid)
            //{
            //    switch (selectedSeason)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }


            //    Console.WriteLine("\nSeason Range Displayed Successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Season Entered. Please Try Again.");
            //}


            //Question 3 Is Not Found In Assignment PDF 


            //Q"4.4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable.
            //check if specific Permission is existed inside variable


            //Permissions userPermissions = Permissions.None;

            ////Add The Authorization
            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;

            //Console.WriteLine("Current Permissions: " + userPermissions);

            //// Remove The Authorization
            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine("After removing Write: " + userPermissions);

            //// Check If There's A Given Authorization 
            //if (userPermissions.HasFlag(Permissions.Read))
            //{
            //    Console.WriteLine("Read permission is present.");
            //}
            //else
            //{
            //    Console.WriteLine("Read permission is NOT present.");
            //}

            //if (userPermissions.HasFlag(Permissions.Delete))
            //{
            //    Console.WriteLine("Delete permission is present.");
            //}
            //else
            //{
            //    Console.WriteLine("Delete permission is NOT present.");
            //}




            //Q"5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.Write("Enter a color name (Red, Green, Blue): ");
            //string input = Console.ReadLine();

            //bool isValid = Enum.TryParse(input, true, out Colors selectedColor);

            //if (isValid)
            //{
            //    Console.WriteLine($"{selectedColor} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is NOT a primary color.");
            //}






        }
    }
}

