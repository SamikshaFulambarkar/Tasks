using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.ArrProgram
{
    class Assgn_2D_Que1
    // WAP to accept data in 2D array of 3X4 and accept data.
    {
        int[,] matrix = new int[3, 4];
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
            Assgn_2D_Que1 Q1 = new Assgn_2D_Que1();
            Console.WriteLine("Enter elements in 2D Array:");
            Q1.Accept();
            Console.WriteLine("Matrix is:");
            Q1.Display();
            Console.ReadKey();
        }
    }
    class Assgn_2D_Que2
    // WAP to accept data in 2D array where rows are fixed and columns are variable.
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 56, 10, 18, 12, 20 };
            jaggedArray[1] = new int[] { 15, 7 };
            jaggedArray[2] = new int[] { 10, 84, 9 };
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
    class Assgn_2D_Que3
    // WAP to print maximum in rowwise in 2D array.
    {
        int[,] matrix = new int[3, 3];
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
                Console.WriteLine("Max number of" + " " + (i + 1) + " " + "row is" + " " + max_row);
            }
        }
        static void Main(String[] args)
        {
            Assgn_2D_Que3 Q3 = new Assgn_2D_Que3();
            Q3.Accept();
            Q3.Display();
            Q3.Row_WiseMaxNum();
            Console.ReadKey();
        }
    }
    class Assgn_2D_Que4
    // WAP to print minimum in columns.
    {
        int[,] matrix = new int[3, 3];
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
        public void Col_WiseMinNum()
        {
            Console.WriteLine("Column Wise Minimum NUmbers ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min_col = matrix[0, i];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[j, i] < min_col)
                    {
                        min_col = matrix[j, i];
                    }
                }
                Console.WriteLine("Min number of" + " " + (i + 1) + " " + "column is" + " " + min_col);
            }
        }
        static void Main(string[] args)
        {
            Assgn_2D_Que4 Q4 = new Assgn_2D_Que4();
            Q4.Accept();
            Q4.Display();
            Q4.Col_WiseMinNum();
            Console.ReadKey();
        }
    }
    class Assgn_2D_Que5
    // WAP to print outer elements of 2D array of 4X4.
    {
        int[,] matrix = new int[4, 4];
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
        public void Outer_Elements_Arr()
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
        static void Main(string[] args)
        {
            Assgn_2D_Que5 Q5 = new Assgn_2D_Que5();
            Q5.Accept();
            Q5.Display();
            Q5.Outer_Elements_Arr();
            Console.ReadKey();
        }
    }
    class Assgn_2D_Que6
    // WAP to check if a matrix is a Sparse matrix (in which most of the elements are 0).
    // Print “Sparse” if it is Sparse else print “Not sparse” 
    {
        int[,] matrix = new int[3, 3];
        int size, count = 0;
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
        public void Check()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    size = (matrix.GetLength(0) * matrix.GetLength(1));
                    if (matrix[i, j] == 0)
                        count++;
                }
            }
            if (count > (size / 2))
                Console.WriteLine("Sparse");
            else
                Console.WriteLine("Not Sparse");
        }
        static void Main(string[] args)
        {
            Assgn_2D_Que6 Q6 = new Assgn_2D_Que6();
            Q6.Accept();
            Q6.Display();
            Q6.Check();
            Console.ReadKey();
        }
    }
    class Assgn_2D_Que7
    // WAP to create transpose of a matrix (transpose is converting rows to columns) and print it.
    {
        int[,] matrix1 = new int[3, 3];
        int[,] matrix2 = new int[3, 3];
        public void Accept()
        {
            Console.WriteLine("Enter Matrix := ");
            {
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        matrix1[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Matrix before transpose ");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public void Transpose()
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix2[j, i] = matrix1[i, j];
                }
            }
            Console.WriteLine("Matrix after transpose");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            Assgn_2D_Que7 Q7 = new Assgn_2D_Que7();
            Q7.Accept();
            Q7.Display();
            Q7.Transpose();
            Console.ReadKey();
        }
    }
    class Assgn_2D_Que8
    // WAP to subtract two matrices.
    {
        int[,] matrix1 = new int[3, 3];
        int[,] matrix2 = new int[3, 3];
        int[,] matrix3 = new int[3, 3];
        public void Accept()
        {
            Console.WriteLine("Enter elements in matrix 1");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements in matrix 2");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            {
                Console.WriteLine("Matrix 1");
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        Console.Write(matrix1[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
            }
            {
                Console.WriteLine("Matrix 2");
                for (int i = 0; i < matrix2.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        Console.Write(matrix2[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
            }
        }
        public void Subtract_two_matrices()
        {
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix1[i, j] - matrix2[i, j];
                    Console.Write(matrix3[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            Assgn_2D_Que8 Q8 = new Assgn_2D_Que8();
            Q8.Accept();
            Q8.Display();
            Q8.Subtract_two_matrices();
            Console.ReadKey();
        }
    }
    class Assgn_2D_Que9
    // WAP to find sum of each row and column of a matrix.
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            Console.WriteLine("Enter elements in matrix ");
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
            {
                Console.WriteLine("Matrix");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
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
                Console.WriteLine("Addition of" + " " + (i + 1) + " " + "row is" + " " + sum);
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
                Console.WriteLine("Addition of" + " " + (i + 1) + " " + "column is" + " " + sum);
            }
        }
        static void Main(string[] args)
        {
            Assgn_2D_Que9 Q9 = new Assgn_2D_Que9();
            Q9.Accept();
            Q9.Display();
            Console.WriteLine(" ");
            Q9.Sum_Of_Row();
            Console.WriteLine(" ");
            Q9.Sum_Of_Column();
            Console.ReadKey();
        }
    }
    class Assgn_2D_Que10
    // WAP to find sum of main diagonal elements of a matrix.
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            Console.WriteLine("Enter elements in matrix ");
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
            {
                Console.WriteLine("Matrix");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
            }
        }
        public void Sum_Of_main_Diagonals()
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
            Assgn_2D_Que10 Q10 = new Assgn_2D_Que10();
            Q10.Accept();
            Q10.Display();
            Q10.Sum_Of_main_Diagonals();
            Console.ReadKey();
        }
    }
    class Assgn_2D_Que11
    // WAP to find the average of the inner most elements of an array.
    {
        int[,] matrix = new int[4, 4];
        int sum = 0;
        double avg;
        public void Accept()
        {
            Console.WriteLine("Enter elements in matrix ");
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
            {
                Console.WriteLine("Matrix");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
            }
        }
        public void Avgof_inner_most_elements()
        {
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                {
                    if (i == 1 || i == matrix.GetLength(0) / 2)
                        sum = sum + matrix[i, j];
                    avg = sum / 4;
                }
            }
            Console.WriteLine("Average of inner elements =" + avg);
        }
        static void Main(string[] args)
        {
            Assgn_2D_Que11 Q11 = new Assgn_2D_Que11();
            Q11.Accept();
            Q11.Display();
            Q11.Avgof_inner_most_elements();
            Console.ReadKey();
        }
    }
    class Assgn_2D_Que12
    // WAP to print upper triangular matrix.
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            Console.WriteLine("Enter elements in matrix");
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
            Console.WriteLine("Matrix");
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
            Assgn_2D_Que12 Q12 = new Assgn_2D_Que12();
            Q12.Accept();
            Q12.Display();
            if (Q12.IsUpperTriangularMatrix())
                Console.WriteLine("Given matrix is Upper Triangular Matrix");
            else
                Console.WriteLine("Given matrix is not Upper Triangular Matrix");
            Console.ReadKey();
        }
    }
    class Assgn_2D_Que13
    // WAP to find sum of lower triangular matrix.
    {
        int[,] matrix = new int[3, 3];
        int sum = 0;
        public void Accept()
        {
            Console.WriteLine("Enter elements in matrix");
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
            Console.WriteLine("Matrix");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public void Sum_LowerTriangular()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        if (matrix[i, j] != 0)
                        {
                            sum = sum + matrix[i, j];
                        }
                    }
                }
            }
            Console.WriteLine("Sum of Lower triangular matrix =" + sum);
        }
        static void Main(string[] args)
        {
            Assgn_2D_Que13 Q13 = new Assgn_2D_Que13();
            Q13.Accept();
            Q13.Display();
            Q13.Sum_LowerTriangular();
            Console.ReadKey();
        }
    }
}
