using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Principal;


namespace TaskCsharp
{

    class Program
    {
        class obj1
        {
            public int x;
            public int y;

        }
        static void Main() 
        {
            #region problem1 and Q1
            ///*
            // Declare Tow variables x with value 10 And y with value 20
            // int x = 10; 
            // int y = 20;
            //*/
            //int sum = x + y; // Sum two variables
            //Console.WriteLine(sum);  // print Sum 

            //---------------
            //Q1
            //What is the shortcut to comment and uncomment a selected block of code in Visual  Studio ?
            // Ctrl + K + Ctrl + C  Comment
            //Ctrl + K + Ctrl + U   Uncomment

            #endregion

            #region Problem2 And Q2
            ////The mistake is passing a text value to a variable of type int
            ////After the repair:
            //int x = 10;

            //The mistake is not defining the variable y
            //After the repair:
            //int y = 20;

            // Writing the letter c in the word console in lowercase
            //After the repair:
            //Console.WriteLine(x + y);

            //----------------------
            //Q2
            // Logical Errpr : A mistake in the program’s logic. The code runs successfully but produces the wrong result
            //     int x = 10;
            //     int y = 20;
            //     int sum = x - y; // Logical Error: should be x + y
            //     Console.WriteLine(sum); 

            ////Runtime Error : An error that occurs while the program is running 
            //    int x = 10;
            //    int y = 0;
            //    int result = a / b; // Runtime Error: Division by zero
            //    Console.WriteLine(result);

            #endregion

            #region Problem3 And Q3

            //// Store your full name
            //string FullName = "Adham Mohamed";
            //// Store your age
            //int Age = 22;
            //// Store your monthly salary
            //float MonthlySalary = 5000.00f;
            //// Store whether you are a student
            //bool IsStudent = true;

            ////--------------
            ////Q3 :Why is it important to follow naming conventions such as PascalCase in c#
            ///*
            //Because through it the code becomes more:
            // 1- Readability    2-Consistency
            // 3- Maintainability   4-Professionalism 
            // */


            #endregion

            #region Problem4 And Q4

            //obj1 O = new obj1();
            //Console.WriteLine(O.x);   
            //Console.WriteLine(O.y);

            //obj1 O2 = O;

            //O2.x = 10;
            //O2.y = 20;

            //Console.WriteLine(O.x);
            //Console.WriteLine(O.y);

            //----------------------------- 

            //Q4 

            //Question: Explain the difference between value types and
            //reference types in terms of memory allocation ?
            /*
               Value Types :

               Storage: They are stored directly in the stack.

               Independence: Each variable has its own independent copy of the value.
               So if you have two int variables, changing one won’t affect the other.

               Default values: If you don’t give them a value,
               they take the default value (for example, int = 0).
               
               Examples: int, double, bool, struct.
             */

            /*
             Reference Types :

             Storage: The object itself is stored in the heap
             and the variable stores the address (reference) 
             that points to the object.

             Sharing: Multiple variables can point to the same object.
             Any modification through one will show up for the others because they share the same reference.

             Default values: If you don't give a value, 
             the reference takes the default value null
             (meaning it doesn’t point to any object).

             Examples: class, array, string, object.
            
             */

            #endregion

            #region Problem5 And Q5
            //int x = 15;
            //int y = 4;

            //int sum, Difference, Product,Remainder;
            //float DivisionResult;
            //sum = x + y;
            //Difference = x - y;
            //Product = x * y;
            //DivisionResult = (float) x / y;
            //Remainder = x % y;

            //Console.WriteLine(sum);
            //Console.WriteLine(Difference);
            //Console.WriteLine(Product);
            //Console.WriteLine(DivisionResult);
            //Console.WriteLine(Remainder);

            // -----------------------------
            // Q5

            // What will be the output of the following code?
            // Explain why: 
            //int a = 2, b = 7;
            //Console.WriteLine(a % b);

            // Result = 2 
            //Because the Remainder gives
            //the remainder of dividing the first number by the second,
            //and in the example, the first number is less than the second,
            //so the remainder is the first number itself.


            #endregion

            #region Problem6 And Q6

            //int num;
            //num = int.Parse (Console.ReadLine());

            //if (num > 10 && num % 2 == 0)
            //   Console.WriteLine(num);
            //else
            //    Console.WriteLine("Error");
            //------------------------------------

            //Q6

            /*
             (Logical AND &&):

              It's used in conditional logic.
              If the first condition comes out false,
              it doesn't go on to check the second condition
              (it does a short-circuit).
              This saves time and prevents potential errors.
             
            (Bitwise AND  & ):

             If you use it with integers (int), 
             it performs a bitwise operation on the bits.
             Example: 5 & 3 → compares the bits and gives 1.

             If you use it with logical conditions (bool), 
             it does a normal AND 
             but without short-circuit → meaning it always 
             checks both conditions even if the first one is false.

             */


            #endregion

            #region Problem7 And Q7 
            //double input ;
            //input = double.Parse (Console.ReadLine());

            //int Exp =  (int)input;
            //Console.WriteLine(Exp);

            //double Imp = Exp;
            //Console.WriteLine(Imp);
            //------------------
            //Q7 
            //Why is explicit casting required
            //when converting a double to an int?
            /*
             Because converting a double to an int involves potential data loss 
             (truncating the decimal part the compiler will not perform this conversion implicitly. 
             Therefore, explicit casting is required to confirm the conversion.
             */
            #endregion

            #region Problem8 And Q8
            //string Input;
            //Console.Write("Enter Your Age :");
            //Input = Console.ReadLine();


            //if (int.TryParse(Input, out int Age))
            //{
            //    if (Age > 0 )
            //    {
            //        Console.WriteLine("Age Valid");
            //    }
            //    else
            //        Console.WriteLine("Age Not Valid");

            //}
            //else
            //    Console.WriteLine("Age Must Be Number");

            //---------------
            //Q8
            // What exception might occur if the input is invalid and how can you handle it ?
            /*
            The mistake that could happen if the user enters a string or a space, 
            and it can be handled using TryParse
            */

            #endregion

            #region problem9 And Q9

            //int x = 5;
            //Console.WriteLine(x++); // print 5 & update X to 6 
            //Console.WriteLine(++x); // update x to 7 & print 7

            //---------------------
            //   Q9:
            //Given the code below, what is the value of x after execution? Explain why 
            int x = 5;
            int y = ++x + x++;
            Console.WriteLine(x);
            /*
             the value of x after execution = 7 :
             Because x was increased by 1 before the addition ,
             it became 6, and then the value of x, which is 6, was added to 
             so it became 12, and then x was increased by 1 again, so it became 7
             */



            #endregion

        }


    }

}