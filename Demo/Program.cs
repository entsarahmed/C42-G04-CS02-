namespace Demo
{
    internal class Program
    {
        //Entry Point      --C# KeyWord small Case All
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Comments
            // Single Line Comment
            /**
             * Multi
             * Line
             * Comment
             * 
             * 
             *  */
            #endregion



            #region Variables Declaration
            // PascalCase --> FirstName
            // camelCase  --> firstName
            // Kabab-case --> first-name   [Angular Files Naming]
            // snake_case --> first_name

            //Console.WriteLine(Id); 
            #endregion



            #region ValueType
            // int X;
            // CLR willAllocate 4 UnInitialized Bytes at Stack
            // int : C# Keyword

            // X = 5;

            // Int32 Y = 10;
            // CLR will Allocate 4 UnInitialized Bytes at  Stack
            // Int32 : BCL

            // Y = X; //5

            //  X++;  //6

            // Console.WriteLine(Y);
            #endregion




            #region Reference Type
            // Point P1;
            // Declare for Reference of type 'Point', Refering to Null
            //This Reference 'P1' can Refer to an Object from type "Point" OR another type "Inherting From Point"
            // CLR will Allocate 4 Bytes for the Reference at Stack
            // CLR will Allocate 0 Bytes at Heap
            // 
            #region Object
            // P1 = new Point(); // Has  2  Reference[P1,P2] (اسمين دلع);

            #endregion
            //new 
            /// 1. Allocate Required Number of Bytes in Heap (Object Size + CLR Overhead Variables)
            /// 2. Initialize (cross out) Allocated Bytes with Default Value Of Its Datatype
            /// 3. Call User-Defined Constructor if exists
            /// 4. Assign The  Reference to a allocated Object

            //Console.WriteLine(P1.X);// 0
            //Console.WriteLine(P1.Y);// 0

            //Point P2 = new Point();/* Unreachable Object */
            //P2 = P1;

            // P2.X = 10;
            //Console.WriteLine(P1.X);

            #endregion



            #region Fractions and Discard
            //float X = 5.3F;

            //double Y = 4.34;

            //decimal Z = 9943.4M;

            //// Discard => Just for Reabability
            //long Number = 100_000_000_000;

            //Console.WriteLine(Number); 
            #endregion

            #region Implicit Casting Vs Explicit Casting

            #region example 01
            //int X = 8;
            //long Y = /*(long)*/ X; // 1. Implicit Casting

            //Console.WriteLine(Y); //8



            ////long X = 8;
            ////X = 4354546576567;


            ////int Y = X.GetType() == typeof(int) ? (int) X:0;    // 2. Explicit casting  [Unsafe  Casting]

            ////Console.WriteLine(Y);
            ///
            ////checked
            ////{
            ////    int Y = (int)X; // 2. Explicit casting  [Unsafe  Casting]
            ////    unchecked
            ////    {
            ////        Console.WriteLine(Y);   //8

            ////    }
            ////}

            // Console.WriteLine(int.MaxValue); 
            #endregion


            #region example 02

            //int x = 5;
            //double y =/* (double) */ x;   //1.Implicit Casting
            //Console.WriteLine(y);


            double X = 5.5;

            int Y = (int)X; //2. Explicit Casting

            Console.WriteLine(Y);  // 5


            #endregion





            #endregion




        }
    }
}
