using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
			//09 bmi
            double massInKg = 81.2;
            double heightInM = 1.78;
            double BMI;
            BMI = massInKg / (heightInM * heightInM);
            Console.WriteLine(BMI);

            //12 cuboid
            

			//13 seconds in a day
			int currentHours = 9;
			int currentMinutes = 27;
			int currentSeconds = 14;

			int remainingSeconds = (24 - currentHours) * 60 * 60 + (60 - currentMinutes) * 60 + (60 - currentSeconds);
			Console.WriteLine(remainingSeconds);

			//14 greet user
			Console.WriteLine("Hello darkness, what is your name?");
			string name = Console.ReadLine();

			Console.WriteLine("Hello, " + name);

			//15 km to miles
			Console.WriteLine("Tell me how far is Wonderland? (in kms)");
			string kms = Console.ReadLine();
			int kilo; 
			Int32.TryParse(kms, out kilo);
			double miles;
			miles = kilo * 0.6;
			Console.WriteLine("You mean " + miles + " miles.");

            

			//18 oddeven
			Console.WriteLine("Give me a number");
			string stringNumber = Console.ReadLine();
			int number;
			int.TryParse(stringNumber, out number);
			if (number % 2 == 0) { Console.WriteLine("Even"); }
			else { Console.WriteLine("Odd"); }

			//19 one two a lot
			Console.WriteLine("Give me another number");
			string anotherStringNumber = Console.ReadLine();
			int anotherNumber;
			int.TryParse(anotherStringNumber, out anotherNumber);
			if (anotherNumber <= 0) { Console.WriteLine("Not enough"); }
			else if (anotherNumber == 1) { Console.WriteLine("1"); }
			else if (anotherNumber == 2) { Console.WriteLine("2"); }
			else { Console.WriteLine("A lot"); }

			//20 partyindicator
			Console.WriteLine("How many gals?");
			string stringGirs = Console.ReadLine();
			int girls;
			int.TryParse(stringGirs, out girls);
			Console.WriteLine("How many boys?");
			string stringBoys = Console.ReadLine();
			int boys;
			int.TryParse(stringBoys, out boys);
			if (girls == boys && girls + boys > 20) { Console.WriteLine("The party is excellent!"); }
			else if (girls != boys && girls + boys > 20) { Console.WriteLine("Quite cool party!"); }
			else if (girls + boys < 20 && girls > 0) { Console.WriteLine("Average party..."); }
			else if (girls <= 0) { Console.WriteLine("Sausage party"); }


			//22 conditional variable mutation
			double a = 24;
			int out1 = 0;
			if (a % 2 == 0) { out1++; }
            Console.WriteLine(out1);

			//23 wont cheat exams

            for (int i = 0; i < 100; i++)
			{
                Console.WriteLine("I won't cheat on the exam.");
			}

            //24 print even
            for (int i = 1; i < 250; i++)
			{
                Console.WriteLine(i*2);
			}

            //25 multiplication table
            Console.WriteLine("Give me a number pls");
			string stringYourNumber = Console.ReadLine();
			int yourNumber;
			int.TryParse(stringYourNumber, out yourNumber);
            for (int i = 1; i < 11; i++)
			{
				Console.WriteLine(i + " * " + yourNumber + " = " + i*yourNumber);
			}

            //26 count from to
            Console.WriteLine("Give me a number");
			int aa;
			string aString = Console.ReadLine();
			int.TryParse(aString, out aa);
            Console.WriteLine("Gimme another one");
			int bb;
			string bString = Console.ReadLine();
			int.TryParse(bString, out bb);
			if (bb <= aa) {Console.WriteLine("The second number should be bigger"); }
			else {for (int i = aa+1; i < bb; i++) 
				{
					Console.WriteLine(i);
				}
			}
            
		}
	}
}
