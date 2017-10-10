using System;


namespace Spiral
{
    class Spiral
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());


            int[,] spiral = new int[N, N];  // Двумерен масив

            string direction = "right";

            int currentRow = 0;
            int currentCol = 0;


            for (int i = 1; i <= N * N; i++)
            {

                if (direction == "right" && (currentCol >= N || spiral[currentRow, currentCol] != 0))
                {
                    direction = "down";
                    currentCol--;
                    currentRow++;
                }
                else if (direction == "down" && (currentRow >= N || spiral[currentRow, currentCol] != 0))
                {
                    direction = "left";
                    currentRow--;
                    currentCol--;
                }
                else if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
                {
                    direction = "up";
                    currentRow--;
                    currentCol++;
                }
                else if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
                {
                    direction = "right";
                    currentRow++;
                    currentCol++;
                }



                spiral[currentRow, currentCol] = i;  //Пълни матрицата





                if (direction == "right")
                {
                    currentCol++;
                }
                else if (direction == "down")
                {
                    currentRow++;
                }
                else if (direction == "left")
                {
                    currentCol--;
                }
                else if (direction == "up")
                {
                    currentRow--;
                }
            }



            //Печатане на матрицата |
            //                      V
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(spiral[i, j] + "  ");
                }

                Console.WriteLine();
            }
        }
    }
}
