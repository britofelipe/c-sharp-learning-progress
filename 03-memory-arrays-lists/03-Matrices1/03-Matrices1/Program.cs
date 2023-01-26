namespace _03_Matrices1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the matrix dimension: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Console.WriteLine("Write values of each row separated by a space (' '):");
            // Input
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            // Output
            Console.Write("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }
            int numberOfNegativeNumbers = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        numberOfNegativeNumbers++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers: " + numberOfNegativeNumbers);
        }
    }
}