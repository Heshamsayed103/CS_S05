using System;
using System.Reflection;

namespace Demo_C__S05
{
    internal class Program
    {
        //static void DoSomeCode()
        //{
        //    try {
        //        int X, Y, Z;
        //        X = int.Parse(Console.ReadLine());
        //        Y = int.Parse(Console.ReadLine());
        //        Z = X / Y;

        //        int[] Arr = { 1, 2, 3 };

        //        Arr[99] = 10;
        //    }
        //    catch(Exception e ) {

        //        Console.WriteLine(e.Message);
        //    }
        //    catch (Exception e)
        //    {

        //        Console.WriteLine(e.Message);
        //    }
        //    catch (FormatException e)
        //    {

        //        Console.WriteLine(e.Message);
        //    }
        //    catch (DivideByZeroException E)
        //    {

        //        Console.WriteLine(E.Message);
        //    }
        //    catch (IndexOutOfRangeException E)
        //    {

        //        Console.WriteLine(E.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Finally");
                
                //Release | Deallocate | Disconnect | Dispose UnManged Resource 
            
        
        static void Main(string[] args)
        {
            #region Boxing And UnBoxing


            // Boxing : Casting From ValueType To ReferenceType
            // UnBoxing : Casting From ReferenceType To ValueType

            object obj = 0;

            ///01 => Can Refer To Instance Of "Object" Or Any Instance of Any Type

            ///01 = 1;
            ///01 = "Ahmed";

            //01 = 3;    // Cast From ValueType[int] To ReferenceType[object] => Boxing
            //01 = 1.5;    // Cast From ValueType[double] To ReferenceType[object] => Boxing
            //01 = 'A';    // Cast From ValueType[char] To ReferenceType[object] => Boxing
            //01 = true;    // Cast From ValueType[bool] To ReferenceType[object] => Boxing
            //01 = new DateTime();   // Cast From ValueType[DateTime] To ReferenceType[object] => Boxing


            int X = 5;

            object Q1 = /*(object)*/ X;

            // Implicit Casting  
            // Safe Casting  
            // Boxing  
            // Parent = Child => Child is Parent  
            // Animal = Dog => Dog is Animal


            //object Q1 = 3;

            //int X = (int)Q1;

            // Explicit Casting
            // UnSafe Casting [May Throw Exception]
            // UnBoxing
            // Dog = (Dog) Animal => Animal is Dog


            //object Q1 = 3;

            //int X = (int)Q1;

            //Explicit Casting
            //Unsafe Casting [May Throw Exception]
            //UnBoxing 
            //Dog = (Dog) Animal =? Animal is Dog
            //Child = Parent => Parent is Child

            #endregion


            #region Nullable Types
            //Nullable Types 

            //Value Type
            //Reference Type 
            #endregion


            #region Nullable Value Types
            // Nullable Types

            // Value Type
            // Reference Type

            //int X = 6;

            //X = null; // Not Valid


            //Nullable Value Type => Value Type Allow Null as Valid Value

            // Nullable<int> : Allow Int Value or Null as Valid Value
            //int? Age = 20;

            //Age = null;

            // Nullable<double> : Allow double value or Null As Valid Value
            //double? Salary = 4000.5;

            //Salary = null;


            //int X = 5;

            //// Y : Nullable<int>
            //// Y : Allow int Value or Null

            //int? Y = /*(int?)*/ X;

            //// Implicit Casting
            //// Safe Casting

            //Console.WriteLine(Y);


            //int? X = 5;


            //X = null;
            // Y : int
            // Y : Allow int Value Only

            //int X;

            // Explicit Casting
            // May Throw Exception

            // Defensive Code
            //if (X != null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            //=========================


            //if (X is not null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            // ---

            //if (X.HasValue)
            //    Y = X.Value;
            //else
            //    Y = 0;

            // ---

            // ____________________

            // Y = X.HasValue ? X.Value : 0;

            // ____________________

            // Y = X is not null ? X.Value : 0;

            // ____________________

            // Null Coalescing Operator ?? 

            // Y = X ?? 0; // Syntax Sugar : X is not null ? X.Value : 0

            //Console.WriteLine(Y);

            #endregion


            #region Nullable Reference Type [C# 10.0 .NET 6.0]

            // Nullable Reference Type [C# 10.0 .NET 6.0]

            // string Message01 = null; // Required

            // string? Message02 = null; // Nullable

            // Console.WriteLine(Message01.Length);

            // Console.WriteLine(Message02);

            #endregion


            #region Null Propagation Operator
            // double X = default; // 0

            // bool C = default;

            // Console.WriteLine(C);

            //int[] Arr = default; // null

            //// int[] Arr = {1, 2, 3, 4, 5 }; // null

            //// Best Practice
            //if (Arr is not null)
            //{
            //    for (int i = 0; i < Arr.Length; i++)
            //        Console.WriteLine(Arr[i]);
            //}

            //// for(int i = 0; (Arr is not null) && i < Arr.Length; i++)
            //// Console.WriteLine(Arr[i]);


            //// for (int i = 0; i < Arr.Length; i++)
            //// Console.WriteLine(Arr[i]);

            //// E?.Department?.DeptName

            //// int Len = Arr is not null ? Arr.Length : 0;

            //// int? Len = Arr?.Length;

            //// int Len = Arr?.Length is not null ? Arr.Length : 0 ;

            //int Len = Arr?.Length ?? -1;

            //Console.WriteLine(Len);

            #endregion


            #region Exception Handling And Protective Code
            //// DoSomeCode();
            //// DoSomeProtectiveCode();

            //Console.WriteLine("Hello After Exception");

            //// Exception
            //// 1. SystemException
            //// 1.1. FormatException
            //// 1.2. IndexOutOfRangeException
            //// 1.3. NullReferenceException
            //// 1.4. ArithmeticException
            //// 1.4.1. OverflowException

            #endregion


            #region Access Modifiers
            void Fun01()
            {
                TypeA typeA = new TypeA();
                TypeB typeB = new TypeB(); // Valid

                // typeB.X = 12; // Invalid : private
                typeB.Y = 12; // valid
                typeB.Z = 12; // valid
            }
            #endregion


            #region Enum : Value Types
            // STACK

            // int Number = 10;

            //Season S01 = Season.Autumn;
            //S01 = Season.Summer;

            //Console.WriteLine(S01);

            // STACK
            // CLR Represent Enum As Integer Value In Memory

            // Gender G01 = (Gender) 10;

            // Console.WriteLine(G01);

            // Gender G01 = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine(), true);
            //Gender G01;
            //Enum.TryParse(typeof(Gender), value: Console.ReadLine(), ignoreCase: true, out object o1);
            //G01 = (Gender)o1;

            //Console.WriteLine(G01);


            // Genders G02 = (Genders) Enum.Parse(typeof(Genders), "Male");
            // Console.WriteLine(G02);

            // Enum.TryParse(typeof(Genders), Console.ReadLine(), true, out object o1);
            // Genders G03 = (Genders)o1;

            // Console.WriteLine(o1);

            // Parent = Child
            // Child = (Child)Parent

            //Permissions Per01 = Permissions.Read;
            //Per01 ^= Permissions.Delete; // Toggle

            // Per01 |= Permissions.Delete; // Add Permission

            // Console.WriteLine(Per01); // Delete , Read

            // Per01 ^= Permissions.Delete; // Toggle

            // Console.WriteLine(Per01); // Read

            //Console.WriteLine(Per01); // Delete , Read

            //Per01 &= ~(Permissions.Delete); // ~ Not Bitwise

            // & -> Check Permissions
            // if (Per01 & Permissions.Delete)


            //// if (Per01 & Permissions.Delete) == Permissions.Delete)
            //if ((Per01 & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Exists");
            //}
            //// else
            //else
            //{
            //    Console.WriteLine("Not Exists"); 
            #endregion
        




    }
    }
}
