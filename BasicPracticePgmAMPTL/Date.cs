using System;

class NextDate
{
    static void Main()
    {
        
        Console.Write("Input a year: ");
        int year = int.Parse(Console.ReadLine());

        
        Console.Write("Input a month [1-12]: ");
        int month = int.Parse(Console.ReadLine());

        
        Console.Write("Input a day [1-31]: ");
        int day = int.Parse(Console.ReadLine());

        try
        {
            
            DateTime inputDate = new DateTime(year, month, day);

            
            DateTime nextDay = inputDate.AddDays(1);

            
            Console.WriteLine("The next date is [yyyy-mm-dd]: " + nextDay.ToString("yyyy-MM-dd"));
        }
        catch (ArgumentOutOfRangeException)
        {
            
            Console.WriteLine("The entered date is invalid. Please check your input.");
        }
    }
}
