namespace BasicArray
{
    public class Program
    {
        public static void Display(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

        }
        public static void Main(string[] args)
        {

            int[,] sem1Marks =
            {
            { 1, 2,3},
            { 4, 5,6},
            { 7, 8,9} 
        };

            int[,] sem2Marks =
            {
            { 1, 2,3},
            { 4, 5,6},
            { 7, 8,9}
        };


          
            Console.WriteLine("Sem 1 Marks");
            Display(sem1Marks);

            Console.WriteLine("\nSem 2 Marks");
            Display(sem2Marks);



            // matrix addition
            int[,] totalMarks = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    totalMarks[i, j] = sem1Marks[i, j] + sem2Marks[i, j];
                }
            }


            Console.WriteLine("\nTotal Marks");
            Display(totalMarks);



            // transpose matrix
            int[,] transposeMatrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    transposeMatrix[i, j] = sem1Marks[j, i];
                }
            }

            Console.WriteLine("\nTranspose matrix");
            Display(transposeMatrix);



            // diagonal matrix
            int[,] diagonalMatrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        diagonalMatrix[i, j] = sem1Marks[i, j];
                    }
                    else
                    {
                        diagonalMatrix[i, j] = 0;
                    }
                }
            }


            Console.WriteLine("\ndiagonal matrix");
            Display(diagonalMatrix);


            //upper triangular matrix
            int[,] upperTriangularMatrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i <= j)
                    {
                        upperTriangularMatrix[i, j] = sem1Marks[i, j];
                    }
                    else
                    {
                        upperTriangularMatrix[i, j] = 0;
                    }
                }
            }

            Console.WriteLine("\nUpper triangular matrix");
            Display(upperTriangularMatrix);

            //lower triangular matrix
            int[,] lowerTriangularMatrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i >= j)
                    {
                        lowerTriangularMatrix[i, j] = sem1Marks[i, j];
                    }
                    else
                    {
                        lowerTriangularMatrix[i, j] = 0;
                    }
                }
            }

            Console.WriteLine("\nLower triangular matrix");
            Display(lowerTriangularMatrix);

            // matrix multiplication
            int[,] matrixMultiplication = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {   
                    for (int k = 0; k < 3; k++)
                    {
                      matrixMultiplication[i,j]+=sem1Marks[i,k]*sem2Marks[k,j];
                    }
                }
            }
            Console.WriteLine("\n matrix multiplication");
            Display(matrixMultiplication);


     

        }
    }
}