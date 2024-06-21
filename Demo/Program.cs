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


            //double X = 5.5;

            //int Y = (int)X; //2. Explicit Casting

            //Console.WriteLine(Y);  // 5


            #endregion





            #endregion



            #region Convert

            // //**   Convert : is a Class Containing Set of Methods used for casting from datatype to another.

            // Console.Write("Please Enter Your Name: ");

            // //string? Name= Console.ReadLine();

            // string Name = Console.ReadLine() ?? "NA";  //Coalescing Operator

            // Console.Write("Please Enter Your Age");
            // int Age = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Please Enter Your Salary");
            // decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //// Console.Clear();

            // Console.Beep(324, 3000);
            // Console.WriteLine("Your Name is " + Name);
            // Console.WriteLine("Your Age is " + Age);
            // Console.WriteLine("Your Salary is " + Salary);


            #endregion


            #region Parse
            //Parse : is a Method used for casting from string to the caller Datatype



            //Console.Write("Please Enter Your Name: ");

            ////string? Name= Console.ReadLine();

            //string Name = Console.ReadLine() ?? "NA";  //Coalescing Operator

            //Console.Write("Please Enter Your Age");
            //int Age = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Please Enter Your Salary");
            //decimal Salary = decimal.Parse(Console.ReadLine() ?? "0");

            //// Console.Clear();

            //Console.Beep(324, 3000);
            //Console.WriteLine("Your Name is " + Name);
            //Console.WriteLine("Your Age is " + Age);
            //Console.WriteLine("Your Salary is " + Salary);
            #endregion

            #region Convert and Parse

            //string X = "5";
            //X = "Ahmed";
            //int Y = int.Parse(X);
            //Console.WriteLine(Y);


            //string X = "true";
            //bool Flag = Convert.ToBoolean(X);
            //Console.WriteLine(Flag);  //true

            #endregion

            #region Unary Operators
            // Unary Operators  => works on one operand (Variable)
            //int x = 10;
            //// 1. ++
            ////1.1 Prefix [Increment and then print]
            //Console.WriteLine(++x); //print 11
            //                // 1.2 postfix  [Print and then Increment]
            //Console.WriteLine(x++); //print 10

            ////2. --
            ////2.1 Prefix [Decrement and then print]
            //Console.WriteLine(--x); //print 9
            //                    //2.2 Postfix [print and then Decrement]
            //Console.WriteLine(x--); // print 10
            #endregion

            #region Binary Operators
            ////Unary Operators ==> works on Two Operands(Variables)
            //int Sum, Mul, Div, Sub, Mod;
            //int Num01 = 2, Num02 = 6;
            //Sum = Num01 + Num02;
            //Sub = Num02 - Num01;
            //Mul = Num01 * Num02;

            //Div = Num01 / Num02;
            //Mod = Num02 % Num01;  //6 % 4 =2
            #endregion

            #region Assignment Operator
            //int X;
            //X = 4;
            //X += 2; // X=X+2
            //X -= 2; //X=X-2
            //X *= 2; //X=X*2
            //X /= 2; //X=X/2
            //X %= 2; //X=X%2

            #endregion


            #region  Relational Operators [compersion]

            //int X = 6, Y = 5;
            //Console.WriteLine( X == Y); //Equal
            //Console.WriteLine(X != Y); //Not Equal
            //Console.WriteLine(X > Y); //More Than
            //Console.WriteLine(X >= Y); //More Than or Equal
            //Console.WriteLine(X < Y); //Less Than
            //Console.WriteLine(X <= Y); /// Less Than or Equal
            #endregion


            #region Logical Operators
            //Console.WriteLine(!false);
            //Console.WriteLine(false && true); // Short Circuit
            //Console.WriteLine(true || false);

            //Console.WriteLine(4 < 5 && 7 < 9)
            #endregion


            #region Bitwise Operators
            //Console.WriteLine(~0);
            //Console.WriteLine(false & true);  //Long CirCuit
            //Console.WriteLine(true | false);
            //// Console.WriteLine(4 < 5 & 7 < 9);
            #endregion



            #region Ternary Operator [Conditional Operator]

            //int X = 5, Y = 5;

            //string Message = X > Y ? "X is more than Y" : X < Y? "X is less then Y":"X equals Y";
            //if (X > Y)
            //{
            //    Message = "X is more than Y";
            //}
            //else if(X < Y)
            //{
            //    Message = "X is less then Y";
            //}
            #endregion



            #region TryParse

            ////string X = "10";
            //string X = "Ahmed";
            //int Y;
            //bool flag = int.TryParse(X, out Y);  //if casting failed, No Exception will be thrown  

            //Console.WriteLine(flag);  //true

            //Console.WriteLine(Y);    //10 
            #endregion



        }
    }
}
