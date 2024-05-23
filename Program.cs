namespace DelegatesTask
{
    internal class Program
    {
        // Write code below this line

        // Write code above this line

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(arrayMethod(max, nums));
            Console.WriteLine(arrayMethod(avg, nums));
        }

        static float arrayMethod(Operation opr, int[] nums)
        {
            return opr(nums);
        }

        static int max(int[] nums)
        {
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
                if (max < nums[i])
                    max = nums[i];
            return max;
        }

        static float avg(int[] nums)
        {
            float sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];
            return sum / nums.Length;
        }
    }
}