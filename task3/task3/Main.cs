using System;

class Task3_Main
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 12, 18, 5, 20 };

        Console.Write("Even= ");
        NumberProcessor.ProcessNumbers(nums, n => n % 2 == 0);

        Console.Write("\nGreater than 10= ");
        NumberProcessor.ProcessNumbers(nums, n => n > 10);
    }
}
