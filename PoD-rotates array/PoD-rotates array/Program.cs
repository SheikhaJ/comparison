namespace PoD_rotates_array
{
   
class Program
        {
            static void Main()
            {
                int[] myArray = { 1, 2, 3, 4, 5 };
                int rotations = 2;

                RotateArrayLeft(myArray, rotations);

                Console.WriteLine("Rotated Array:");
                foreach (int num in myArray)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine();
                Console.WriteLine("Number of rotations: " + rotations);
            }

            static void RotateArrayLeft(int[] arr, int rotations)
            {
                int length = arr.Length;
                rotations = rotations % length;

                for (int i = 0; i < rotations; i++)
                {
                    int temp = arr[0];
                    for (int j = 0; j < length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[length - 1] = temp;
                }
            }
        }

    }
