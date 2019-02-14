using System;

namespace Month
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number of the month: ");

            // Save the input to a variable.
            int month = int.Parse(Console.ReadLine());

            // Use the if statment to update the monthName variable based on the user's input.
            string monthName = string.Empty;
            if (month == 1)
                monthName = "January";
            if (month == 2)
                monthName = "February";
            if (month == 3)
                monthName = "March";
            if (month == 4)
                monthName = "April";
            if (month == 5)
                monthName = "May";
            if (month == 6)
                monthName = "June";
            if (month == 7)
                monthName = "July";
            if (month == 8)
                monthName = "August";
            if (month == 9)
                monthName = "September";
            if (month == 10)
                monthName = "October";
            if (month == 11)
                monthName = "November";
            if (month == 12)
                monthName = "December";

            Console.WriteLine($"The name of the month you entered is {monthName}");

            Console.ReadLine();
        }
    }
}
