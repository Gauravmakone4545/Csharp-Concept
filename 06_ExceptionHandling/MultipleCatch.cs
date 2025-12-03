using System;

class MultipleCatch
{
    static void Main()
    {
        try
        {
            int[] nums = { 1, 2, 3 };
            Console.WriteLine(nums[5]); // index error
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Index error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General error: " + ex.Message);
        }
    }
}
