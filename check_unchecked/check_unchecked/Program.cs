namespace check_unchecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = int.MaxValue;
            int i = int.MaxValue;

            checked
            {
                unchecked
                {
                    i++;
                }
            }
            Console.WriteLine(i);
            checked
            {
                y++;
                unchecked
                {
                    i++;
                }
            }

            
            Console.WriteLine(y);
            
        }
    }
}