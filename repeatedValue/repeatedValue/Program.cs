namespace repeatedValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 7, 5, 8, 2, 1 };
            int result = notReapeted(arr);
            Console.WriteLine(result);
        }

        static int notReapeted(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool repeated = false;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[j] == arr[i])
                    {
                        repeated = true;
                        break;
                    }
                }

                if (!repeated)
                {
                    return arr[i];
                }
            }

            return 0; // if no non-repeating value is found
        }
    }
}
