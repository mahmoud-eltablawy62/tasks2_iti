namespace ConsoleApp1
{
    internal class Program
    {    static void Main(string[] args)
        {
            int[] arr = new int[10];
            int max = 0;
            int min = 2000000000;
            for (int i=0; i < arr.Length; i++)
            {
                Console.WriteLine($"enter the num {i+1} :- ");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
            Console.WriteLine($"max_number ==> {max} /n min_number==> {min} ");
        }
    }
}