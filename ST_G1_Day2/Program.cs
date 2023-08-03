using System.Linq.Expressions;

namespace ST_G1_Day2
{
    internal class Program
    {
        // Entry point for our application
        static void Main(string[] args)
        {
            #region Validation using do while

            ////note: application user must be between 18 and 25 years old
            //int age;
            //do {
            //    Console.WriteLine("Enter your age:");
            //    age = int.Parse(Console.ReadLine());
            //} while (age<18 || age>25);

            //// age>=18 && age<=25

            //Console.WriteLine("Welcome to our application");
            //// application code
            #endregion

            #region checked & uncheked
            //int i = int.MaxValue-1;
            //Console.WriteLine(i);

            ////i++;  // overflow

            //int y = int.MaxValue;

            //checked
            //{
            //    i++;  // overflowException
            //    unchecked
            //    {
            //        y += 10;
            //    }
            //    Console.WriteLine(i);
            //    Console.WriteLine(y);
            //}

            ////unchecked
            ////{
            ////    i++;
            ////}
            #endregion

            #region Exception Handling

            //// Error
            //// try catch
            //int i = int.MaxValue;

            ////try
            ////{
            ////    i = i / 0;
            ////}catch(Exception ex)
            ////{
            ////    Console.WriteLine(ex.Message);
            ////}

            ////Console.WriteLine("Enter any number");
            ////int a3 = int.Parse(Console.ReadLine());
            //try
            //{
            //    checked
            //    {
            //       // i++;
            //    }
            //    //i = i / 0;

            //    Console.WriteLine("Enter any number");
            //    int a = int.Parse(Console.ReadLine());
            //}
            //catch(OverflowException ex)
            //{
            //    // code when overflow
            //    Console.WriteLine("Overflow");
            //    Console.WriteLine(ex.Message);

            //}
            //catch (DivideByZeroException ex)
            //{
            //    // code when divide by zero
            //    Console.WriteLine("Divide by zero");
            //    Console.WriteLine(ex.Message);

            //}
            //catch (Exception ex)
            //{
            //    // code when general exception
            //    Console.WriteLine(ex.Message);
            //}




            //Console.WriteLine("End of application");
            #endregion

            #region Casting
            // conversion from DT to another DT


            //int -> byte 
            //double -> float
            //string -> int
            //int -> string

            //Implicit casting
            //done by compliler
            // when converting from small DT to larger DT
            //byte x = 10;
            //int y = x;

            //float s = 20.5f;
            //double d = s;

            //Explicit casting
            // Done by programmer
            // when converting from large DT to small DT
            //int b = int.MaxValue-10;

            //byte m = (byte)b;

            //Console.WriteLine(b);
            //Console.WriteLine(m);

            //casting using helper classes
            //string s1 = "123";
            //int j = (int)s1;

            //string s1 = null;
            //double f = 10;
            //// convert
            //int z = Convert.ToInt32(f);

            //// s1 = "123t" => System.FormatException
            //// s1 = null   => can handel null but zero
            //// f = double.MaxValue => System.OverflowException
            //Console.WriteLine(++z);

            // parse function
            //string s1 = "1111111111111111111111111";
            ////double f = double.MaxValue;
            //int x = int.Parse(s1);

            //double y = double.Parse(s1);

            /////  convert from string only
            ////// s1 = "123t" => System.FormatException
            /////  s1 = null   => System.ArgumentNullException
            /////  s1 = "1111111111111111111111111" => System.OverflowException
            //Console.WriteLine(x);
            //Console.WriteLine(y);


            // try parse

            //string s1 = "123";
            //int x; 
            // bool isConverted = int.TryParse(s1, out x);

            //if (isConverted)
            //{
            //    Console.WriteLine("Casting done");
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine("Can't convert");
            //}
            #endregion

            #region Array
            int x = 10;

            // students ages and grade
            // 10 student

            // students name and ages

            // Data:
            // homogenus ot hetrogenous
            // homo same data type
            // hetero different data type


            // Array homogenous Data type
            // Declaration
            //int[] ages;
            //ages = new int[10];
            //ages = new int[10] { 10, 20, 23, 15, 16, 12, 14, 23, 21, 26 };
            //ages = new int[] { 10, 20, 14, 13, 23 };
            //int[] ages2 = { 10, 20, 14, 13, 23 };

            //// get and set values
            //ages[1] = 5;
            //ages[2] = 10;
            //ages[0] = 3;

            //Console.WriteLine(ages[2]);

            // Read and write values from user
            Console.WriteLine("Enter students ages:");
            int[] ages = new int[5];
            Console.WriteLine(ages.Length);
            // read values from user
            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine($"Enter student {i+1} age:");
                ages[i] = int.Parse(Console.ReadLine());
            }

            // print values 
            PrintArray(ages);


            Console.WriteLine("Sort student ages");

            //for (int i = 0; i < ages.Length; i++)
            //{
            //    for (int j = 0; j < ages.Length; j++)
            //    {
            //        if (ages[i] > ages[j])
            //        {
            //            int temp = ages[i];
            //            ages[i] = ages[j];
            //            ages[j] = temp;
            //        }
            //    }
            //}




            // Array helpers
            Console.WriteLine("Reverse array");
            Array.Reverse(ages);
            PrintArray(ages);

            Array.Sort(ages);
            PrintArray(ages);
            Console.WriteLine("Reverse array");
            Array.Reverse(ages);
            PrintArray(ages);
            #endregion
        }


        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Student {i + 1} age is {arr[i]}");
            }
        }
    }
}