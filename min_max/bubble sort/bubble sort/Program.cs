namespace bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine($"enter the num {i+1}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("==========================================================");
            for (int i = 0; i < 10; i++)
            {
                for (int j=0; j<9-i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            print(arr);
        }
        static void print(int [] arr  )
        {
            for (int i = 0;i < arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}