namespace _04_Matrices02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matrix setup
            Console.Write("Write the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Write the number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            // Input
            Console.WriteLine();
            Console.WriteLine("Write values of each row separated by a space (' '):");
            for (int i = 0; i < rows; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            // Searching for X and adjacencies
            Console.Write("Write the number to be searched: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Adjacencies found: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == x)
                    {
                        Console.WriteLine("Position (" + i + ", " + j + "): ");
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Left: " + matrix[i, j - 1] + ";");
                        }
                        if (j + 1 < columns)
                        {
                            Console.WriteLine("Right: " + matrix[i, j + 1] + ";");
                        }
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Up: " + matrix[i - 1, j] + ";");
                        }
                        if (i + 1 < rows)
                        {
                            Console.WriteLine("Down: " + matrix[i + 1, j] + ";");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}