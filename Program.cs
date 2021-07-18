using System;

namespace Sorbo_Assignment_6
{

    class Program
    {
        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");

        }
        public static string DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Rob Sorbo");
            Console.WriteLine("Homework 6");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine("Hit [5] to run Exercise 5.");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;


        }
        private static bool Run(string exeArg)

        {
            switch (exeArg.ToLower())
            {

                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "4":
                    DoExe4();
                    return true;

                case "5":
                    DoExe5();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }
        private static void DoExe1()
        {

            double inputMile;
            double outputKM;

            Console.Write("Enter miles >> ");
            inputMile = Convert.ToDouble(Console.ReadLine());

            outputKM = ConvertMItoKM(inputMile);

            Console.WriteLine($"{inputMile} miles is {outputKM} kilometers");

        }


        private static double ConvertMItoKM(double mile)

        {
            const double Converter = 1.60934;
            double Conversion = mile * Converter;
            return Conversion;
        }


        private static void DoExe2()
        {

            int books, days;

            Console.Write("Enter number of books that are overdue >> ");
            books = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter number of days that the the {books} are overdue >> ");
            days = Convert.ToInt32(Console.ReadLine());

            Fine(books, days);
        }

        private static void Fine(int books, int days)
        {
            const double FINESHORT = .10;
            const double FINELONG = .20;
            double fine;


            if (days > 7)
            {
                fine = books * ((7 * FINESHORT) + ((days - 7) * FINELONG));
            }
            else
            {
                fine = books * days * FINESHORT;
            }

            Console.WriteLine($"The fine for {books} book(s) for {days} day(s) is {fine.ToString("C")}");

        }


        private static void DoExe3()
        {
            double price = 30.00;
            double percentTip = .20;
            int flatTip = 5;

            Tips(price, percentTip);
            Console.WriteLine();
            Tips(price, flatTip);

        }

        private static void Tips(double price, double percentTip)
        {
            double calcTip = price * percentTip;
            double Total = price + calcTip;


            Console.WriteLine($"Meal Price: {price.ToString("C")}. Tip percent: {percentTip,0:0.00}");
            Console.WriteLine($"Tip in dollars: {calcTip.ToString("C")}. Total bill: {Total.ToString("C")}   ");

        }

        private static void Tips(double price, int flatTip)
        {
            double Total = price + flatTip;
            double calcTipPercent = flatTip / price;

            Console.WriteLine($"Meal Price: {price.ToString("C")}. Tip percent: {calcTipPercent,0:0.00}.");
            Console.WriteLine($"Tip in dollars: {flatTip.ToString("C")}. Total bill: {Total.ToString("C")}. ");
        }

        private static void DoExe4()
        {
            int firstInt = 23;
            int middleInt = 45;
            int lastInt = 67;

            Console.WriteLine("The numbers are {0}, {1}, {2}.", firstInt, middleInt, lastInt);
            ReverseInts(ref firstInt, ref middleInt, ref lastInt);
            Console.WriteLine("The numbers are {0}, {1}, {2}.", firstInt, middleInt, lastInt);
        }

        private static void ReverseInts(ref int firstInt, ref int middleInt, ref int lastInt)
        {
            int tempFirst = firstInt;
            int tempLast = lastInt;
            //Mid isn't changing, so no temp field is needed

            lastInt = firstInt;
            firstInt = tempLast;
        }
      

        static void DoExe5()
        {
            FancyDisplay(33);
            FancyDisplay(44, '@');
            FancyDisplay(55.55);
            FancyDisplay(77.77, '*');
            FancyDisplay("hello");
            FancyDisplay("goodbye", '#');
        }

        private static void FancyDisplay(int num, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, num);
        }
        private static void FancyDisplay(double num, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}   {1}   {0}{0}{0}\n", decoration, num.ToString("C"));
        }
        private static void FancyDisplay(string word, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, word);
        }


    }
}