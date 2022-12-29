using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.ArrProgram
{
    class Multi_Dimensional_Arr
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            Multi_Dimensional_Arr MDA = new Multi_Dimensional_Arr();
            Console.WriteLine("Enter elements in 2D Array:");
            MDA.Accept();
            Console.WriteLine("Matrix is:");
            MDA.Display();
            Console.ReadKey();
        }
    }
    class Sum_2D_row_Arr
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public void Sum_Of_Row()
        {
            int sum;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine("Addition of" + i + "row is" + sum);
            }
        }
        static void Main(string[] args)
        {
            Sum_2D_row_Arr SRA = new Sum_2D_row_Arr();
            Console.WriteLine("Enter elements in 2D Array:");
            SRA.Accept();
            Console.WriteLine("Matrix is:");
            SRA.Display();
            Console.WriteLine("Row wise sum:");
            SRA.Sum_Of_Row();
            Console.ReadKey();
        }
    }
    class Sum_2D_column_Arr
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public void Sum_Of_Column()
        {
            int sum;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine("Addition of" + i + "column is" + sum);
            }
        }
        static void Main(string[] args)
        {
            Sum_2D_column_Arr SCA = new Sum_2D_column_Arr();
            Console.WriteLine("Enter elements in 2D Array:");
            SCA.Accept();
            Console.WriteLine("Matrix is:");
            SCA.Display();
            Console.WriteLine("Column wise sum:");
            SCA.Sum_Of_Column();
            Console.ReadKey();
        }
    }
    class Sum_2D_diagonal_Arr
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public void Sum_Of_Diagonals()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                        sum += matrix[j, i];
                }
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Sum_2D_diagonal_Arr SDA = new Sum_2D_diagonal_Arr();
            Console.WriteLine("Enter elements in 2D Array:");
            SDA.Accept();
            Console.WriteLine("Matrix is:");
            SDA.Display();
            Console.WriteLine(" Sum of main diagonals:");
            SDA.Sum_Of_Diagonals();
            Console.ReadKey();
        }
    }
    class Sum_2D_anti_diagonal_Arr
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public void Sum_Of_Anti_Diagonals()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i + j) == matrix.GetLength(0) - 1)
                        sum += matrix[j, i];
                }
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Sum_2D_anti_diagonal_Arr SADA = new Sum_2D_anti_diagonal_Arr();
            Console.WriteLine("Enter elements in 2D Array:");
            SADA.Accept();
            Console.WriteLine("Matrix is:");
            SADA.Display();
            Console.WriteLine(" Sum of anti diagonals:");
            SADA.Sum_Of_Anti_Diagonals();
            Console.ReadKey();
        }
    }
    class Sum_of_two_matrix
    {
        int[,] matrix1 = new int[3, 3];
        int[,] matrix2 = new int[3, 3];
        int[,] matrix3 = new int[3, 3];
        public void Accept_1()
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Accept_2()
        {
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display_1()
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public void Display_2()
        {
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public void Sum_Of_two_matrices()
        {
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write(matrix3[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            Sum_of_two_matrix SOM = new Sum_of_two_matrix();
            Console.WriteLine("Enter elements for first matrix:");
            SOM.Accept_1();
            Console.WriteLine("Enter elements for second matrix:");
            SOM.Accept_2();
            Console.WriteLine("Matrix 1");
            SOM.Display_1();
            Console.WriteLine("Matrix 2");
            SOM.Display_2();
            Console.WriteLine("Sum of two matrix:");
            SOM.Sum_Of_two_matrices();
            Console.ReadKey();
        }
    }
    class Lower_Triangular_Matrix
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public bool IsLowerTriangular()
        {
            bool lowerTriangular = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        if (matrix[i, j] != 0)
                        {
                            lowerTriangular = false;
                            break;
                        }
                    }
                }
            }
            return lowerTriangular;
        }
        static void Main(string[] args)
        {
            Lower_Triangular_Matrix LTM = new Lower_Triangular_Matrix();
            Console.WriteLine("Enter elements in matrix:");
            LTM.Accept();
            Console.WriteLine("Matrix");
            LTM.Display();
            if (LTM.IsLowerTriangular())
                Console.WriteLine("Given matrix is Lower Triangular Matrix");
            else
                Console.WriteLine("Given matrix is not Lower Triangular Matrix");
            Console.ReadKey();
        }
    }
    class Upper_Triangular_Matrix
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public bool IsUpperTriangularMatrix()
        {
            bool upperTriangular = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        if (matrix[i, j] != 0)
                        {
                            upperTriangular = false;
                            break;
                        }
                    }
                }
            }
            return upperTriangular;
        }
        static void Main(string[] args)
        {
            Upper_Triangular_Matrix UTM = new Upper_Triangular_Matrix();
            Console.WriteLine("Enter elements in matrix:");
            UTM.Accept();
            Console.WriteLine("Matrix");
            UTM.Display();
            if (UTM.IsUpperTriangularMatrix())
                Console.WriteLine("Given matrix is Upper Triangular Matrix");
            else
                Console.WriteLine("Given matrix is not Upper Triangular Matrix");
            Console.ReadKey();
        }
    }
    class Jagged_Matrix_Arr
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 6 };
            jaggedArray[1] = new int[] { 5, 7 };
            jaggedArray[2] = new int[] { 10, 8, 9 };
            Console.WriteLine("Jagged Array :");
            Console.WriteLine();
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                    Console.Write(jaggedArray[i][j] + " ");
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
    class Patterns_Matrix_Arr
    {
        public int[,] matrix = new int[4, 4];
        public void Accept()
        {
            Console.WriteLine("Enter Matrix := ");
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void ExternalArray()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0 || j == 3 || i == 0 || i == 3)
                        Console.Write(matrix[i, j] + "  ");
                    else
                        Console.Write("   ");
                }
                Console.WriteLine();
            }
        }
        public void NPatternArray()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j || j == 0 || j == 3)
                        Console.Write(matrix[i, j] + "  ");
                    else
                        Console.Write("   ");

                }
                Console.WriteLine();
            }
        }
        public void ZPatternArray()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i + j) == matrix.GetLength(0) - 1 || i == 0 || i == 3)
                        Console.Write(matrix[i, j] + "  ");
                    else
                        Console.Write("   ");

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Patterns_Matrix_Arr PMA = new Patterns_Matrix_Arr();
            PMA.Accept();
            PMA.Display();
            PMA.ExternalArray();
            PMA.NPatternArray();
            PMA.ZPatternArray();
            Console.ReadKey();
        }
    }
    class MaxNumberCol_RowWise_Arr
    {
        public int[,] matrix = new int[3, 3];
        public void Accept()
        {
            Console.WriteLine("Enter Matrix := ");
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Matrix is := ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public void Col_WiseMaxNum()
        {
            Console.WriteLine("Column Wise Maximum NUmbers ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int max_col = matrix[0, i];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[j, i] > max_col)
                    {
                        max_col = matrix[j, i];
                    }
                }
                Console.WriteLine("Max number of" + " " + (i + 1) + "st" + " " + "column is" + " " + max_col);
            }
        }
        public void Row_WiseMaxNum()
        {
            Console.WriteLine("Row Wise Maximum Numbers ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int max_row = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max_row)
                    {
                        max_row = matrix[i, j];
                    }
                }
                Console.WriteLine("Max number of" + " " + (i + 1) + "st" + " " + "row is" + " " + max_row);
            }
        }
        static void Main(String[] args)
        {
            MaxNumberCol_RowWise_Arr MAXCR = new MaxNumberCol_RowWise_Arr();
            MAXCR.Accept();
            MAXCR.Display();
            MAXCR.Col_WiseMaxNum();
            MAXCR.Row_WiseMaxNum();
            Console.ReadKey();
        }
    }
}
