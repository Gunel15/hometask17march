namespace hometask17march
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 4, 7, 45, 32, 1, 97 };
            int minimum = Min(arr);
            Console.WriteLine(minimum);
        }
        static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                { min = arr[i]; }
            }
            return min;
        }
    }
}










