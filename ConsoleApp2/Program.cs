namespace ConsoleApp2;
class Program
{
    static void Main()
    {
        int[] nums = { 1, 7, 2, 0, 43, 21, 8, 9, 9, -3 };
        
        
        Console.WriteLine("Before:");
        foreach (int num in nums)
            Console.Write(num + " ");
        Console.WriteLine();
        
        BubbleSort(nums);
        
        Console.WriteLine("After:");
        foreach (int num in nums)
            Console.Write(num + " ");
        Console.WriteLine();
        
    }
    
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;
    
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
        
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }
}