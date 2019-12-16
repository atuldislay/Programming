 internal class Spiral
    {
        private static void Main(string[] args)
        {
            int[,] a = new int[4, 4]
            {
                { 1,  2,   3,  4 },
                { 5,  6,   7,  8 },
                { 9,  10,   11, 12 },
                { 13, 14,  15, 16 }

            };

            PrintSpiral(a);
            Console.WriteLine("Hello World!");
        }

        private static void PrintSpiral(int[,] array2D)
        {
            int left = 0, top = 0, right = array2D.GetUpperBound(1), down = array2D.GetUpperBound(1);
            int direction = 0;

            while (top <= down && left <= right)
            {
                if (direction == 0)
                {
                    for (int i = left; i <= right; i++)
                    {
                        Console.Write(array2D[top, i] + " ");
                    }

                    top++;
                }


                else if (direction == 1)
                {
                    for (int i = top; i <= down; i++)
                    {
                        Console.Write(array2D[i, right] + " ");
                    }

                    right--;
                }
                else if (direction == 2)
                {
                    for (int i = right; i >= left; i--)
                    {
                        Console.Write(array2D[down, i] + " ");
                    }

                    down--;
                }
                else if (direction == 3)
                {
                    for (int i = down; i >= top; i--)
                    {
                        Console.Write(array2D[i, left] + " ");
                    }

                    left++;
                }

                direction = (direction + 1) % 4;

            }
        }
    }
