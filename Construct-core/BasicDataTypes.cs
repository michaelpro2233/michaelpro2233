﻿
using System;
using System.Numerics;


namespace ConstructsCore
{
    static class BasicDataTypes
    {
        public static object BigInteger { get; private set; }

        static void Main(string[] args)
        {
        }

        static void LocalVarDeclaration()
        {
            Console.WriteLine("***** Fun with Basic Data Type *****\n");

	   LocalVarDeclarations();
	   NewingDataTypes();
	   ObjectFunctionality();
	   DataTypeFunctionality();
	   CharFunctionality();
	   ParseFromStrings();
	   UseDatesAndTimes();
	   UseBigInteger();

	   Console.ReadLine();

	   }
         
	   static void LocalVarDeclarations()
	   {
	     Console.WriteLine("=> Data Declarations");

		// Local variables are declared and initialized as follows:
		// dataType varName = initialValue;
		int myInt = 0;
        
		string myString;
        myString = "This is my character data";

        // Declare 3 bools on a single line
        bool b1 = true, b2 = false, b3 = b1;

		// Use System Data type to declare a bool
	   
        System.Boolean b4 = false;
		
        Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
		
        Console.WriteLine();
        }
		
		static void NewingDataTypes()
		{
			Console.WriteLine("=> Using new to create variables");
			
			bool b = new bool();			// Set to false
			int i = new int();				// Set to 0
			double d = new double();		// Set to 0
			DateTime dt = new DateTime(); 	// Set to 1/1/0001 12:00:00 AM
			
			Console.WriteLine();
		}
		
		static void ObjectFunctionality()
		{
			Console.WriteLine("=> System.Object Functionality");
			
			// A C# int is really a shorthand for System.Int32 which inherits the following members from Systen.Object
			Console.WriteLine("12.GetHashcode() = {0}", 12.GetHashCode());
			Console.WriteLine("12.Equals(2) = {0}", 12.Equals(23));
			Console.WriteLine("12.ToString() = {0}", 12.ToString());
			Console.WriteLine("12.GetType() = {0}", 12.GetType());
			
			Console.WriteLine();
		}
		
		static void DataTypeFunctionality()
		{
			Console.WriteLine("=> Data type functionality");
			
			Console.WriteLine("Max of int: {0}", int.MaxValue);
			Console.WriteLine("Min of int: {0}", int.MinValue);
			Console.WriteLine("Max of double: {0}", double.MaxValue);
			Console.WriteLine("Min of double: {0}", double.MinValue);
			Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
			Console.WriteLine("double.PositivInfinity: {0}", double.PositiveInfinity);
			Console.WriteLine("double.NegativInfinity: {0}", double.NegativeInfinity);
			Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
			Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
			
			Console.WriteLine();
		}
		
		private static void CharFunctionality()
		{
            Console.WriteLine("=> char type functionality");
			
			const char myChar = 'a';
			
			Console.WriteLine("char.IsDigit('{0}'): {1}", myChar, char.IsDigit(myChar));
			Console.WriteLine("char.IsLetter('{0}'): {1}", myChar, char.IsLetter(myChar));
			Console.WriteLine("char.IsWhiteSpace('Hello There', 5) : {0}", char.IsWhiteSpace("Hello There", 5));
			Console.WriteLine("char.IsWhiteSpace('Hello There', 6) : {0}", char.IsWhiteSpace("Hello There", 6));
			Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
			
			Console.WriteLine();
		}
		
		private static void ParseFromStrings()
		{
			Console.WriteLine("=> Data type parsing");
			
			bool b = bool.Parse("True");
			Console.WriteLine("Value of b: {0}", b);
			
			double d = double.Parse("99,884");
			Console.WriteLine("Value of d: {0}", d);
			
			int i = int.Parse("8");
			Console.WriteLine("Value of i: {0}", i);
			
			char c = Char.Parse("w");
			Console.WriteLine("Value of c: {0}", c);
			
			Console.WriteLine();
		}
		
		private static void UseDatesAndTimes()
		{
			Console.WriteLine("=> Dates and times");
			
			// This constructor takes year, month, day
			
			var dt = new DateTime(2016, 12, 17);
			
			// What day of the month is this?
			Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            // Month is now
            dt = dt.AddMonths(4);
			Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
			
			// This constructor takes hours, minutes, seconds
			var ts = new TimeSpan(5, 44, 0);
			Console.WriteLine(ts);
			
			// Subtract 15 minuts from the current TimeSpan and print the result
			Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
			
			Console.WriteLine();
		}
		
		private static void UseBigInteger()
		{
			Console.WriteLine("=> Use BigInteger");
			
			var some9 = System.Numerics.BigInteger.Parse("99999999999999999999999999999999999999999999999999999999999999");
			Console.WriteLine("Value of biggy is {0}", some9);
			Console.WriteLine("Is biggy an even value?: {0}", some9.IsEven);
			Console.WriteLine("Is biggy a power of two?: {0}", some9.IsPowerOfTwo);
			
			var some8 = System.Numerics.BigInteger.Parse("888888888888888888888888888888888888888888888888888888888");
			var reallyBig = System.Numerics.BigInteger.Multiply(some9, some8);
			Console.WriteLine("Value of reallyBig is {0}", reallyBig);
		}
	}	
}