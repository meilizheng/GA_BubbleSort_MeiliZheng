namespace GA_BubbleSort_MeiliZheng
{
    public class Program
    {
        // Declare variables
        static Random rand = new Random();
        static int minNum = 1;
        static int maxNum = 101;
        static int arrayLength = 10;

        static void Main(string[] args)
        {
            // Call BubbleSort method             
            BubbleSort(RandomArray());
        }
        static int[] RandomArray()
        {
            // Validate array length and range
            if (arrayLength <= 0 || minNum > maxNum)
            {
                throw new ArgumentException("Invalid arguments");
            }

            // Create a new int array with size 10
            int[] array = new int[arrayLength];

            // Generate random numbers and fill the array
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = rand.Next(minNum, maxNum);
            }

            // Display the unsorted random int array
            Console.WriteLine("Unsorted Random Array:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
            return array;
        }

        // BubbleSort Method
        public static void BubbleSort(int[] arr)
        {
            bool hasSwapped = false;

            // Bubble Sort Algorithm
            // Iterate through the array multiple times until no more swaps are needed
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Flag to track whether any swaps occurred during this iteration
                hasSwapped = false;

                // Iterate through the array, comparing and swapping adjacent elements
                for (int j = i; j < arr.Length; j++)
                {
                    // If the current element is greater than the next one, swap them
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        // Set the flag to indicate a swap has occurred
                        hasSwapped = true;
                    }
                }
            }

            // If no swaps occurred during this iteration, the array is already sorted
            if (!hasSwapped)
            {
                return;
            }

            // Print the sorted array        
            Console.WriteLine("Sorted Array:");
            foreach (int num in arr)
            {
                Console.WriteLine(num);                
            }
            Console.ReadKey();
        }
    }
}



////BubbleSort(arr):
//// Input: Array of comparable elements
//// Output: Sorted array in ascending order

//// Initialize a flag to track swaps
//hasSwapped = true

//    // Repeat until no more swaps are needed
//    while hasSwapped:
//        // Reset swap flag for each iteration
//        hasSwapped = false

//        // Iterate through the array
//        for i from 0 to length(arr) - 1:
//            // Compare adjacent elements
//            if arr[i] > arr[j]:
//                // Swap elements if they are in the wrong order
//                swap(arr[i], arr[j])
//                // Set the flag to indicate a swap has occurred
//                hasSwapped = true

//    // The array is now sorted
//    return arr

//// Example Usage:
//arr = RandomArray()
//Unsorted Random Array: Display arr
//BubbleSort(arr)
//Sorted Array: Display arr
