namespace SearchInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i=0; i<n; i++)
            {
                Console.WriteLine($"enter the num {i+1}");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("enter the search number:-");
            int search_number = int.Parse(Console.ReadLine());
            int index = 0;
            for (int i = 0; i < n; i++)
            {
               if(search_number == arr[i])
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine($"index of the search number {search_number} :-  {index} " );
        }
    }
}