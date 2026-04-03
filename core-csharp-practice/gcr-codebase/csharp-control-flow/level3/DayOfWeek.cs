using System;
class DayOfWeek
{
    static void Main(String[] args)
    {
        // Check if three command-line arguments are provided
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: <month> <day> <year>");
            return;
        }

        int m = int.Parse(args[0]); // month
        int d = int.Parse(args[1]); // day
        int y = int.Parse(args[2]); // year

        // Gregorian calendar calculations

        // Adjust the year based on the month
        int y0 = y - (14 - m) / 12;

        // Compute leap year corrections
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;

        // Adjust the month value
        int m0 = m + 12 * ((14 - m) / 12) - 2;

        // Calculate the day of the week
        int d0 = (d + x + (31 * m0) / 12) % 7;

        // Print the result
        Console.WriteLine(d0);
    }
}
