namespace MCalc
{
    // Класс для работы с матрицами.
    public class MatrixMath
    {

        #region TRANSPOSE
        
        public static int[,] transpose(int[,] matrix)
        {
            //Определение количества строк
            int height = matrix.GetLength(0);

            //Определение количество столбцов
            int width = matrix.GetLength(1);

            int[,] array1 = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    array1[i, j] = matrix[j, i];
                }
            }
            return array1;
        }

        public static double[,] transpose(double[,] matrix)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            double[,] array1 = new double[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    array1[i, j] = matrix[j, i];
                }
            }
            return array1;
        }

        #endregion TRANSPOSE

        #region SIGNCHANGE

        public static int[,] signChange(int[,] matrix)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = matrix[i, j] * -1;
                }
            }
            return matrix;
        }

        public static double[,] signChange(double[,] matrix)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = matrix[i, j] * -1;
                }
            }
            return matrix;
        }

        #endregion SIGNCHANGE

        #region ADDITION

        public static int[,] addition(int[,] matrix1, int[,] matrix2)
        {
            int n = matrix1.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix1[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix1;
        }

        public static double[,] addition(double[,] matrix1, double[,] matrix2)
        {
            int n = matrix1.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix1[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix1;
        }

        public static double[,] addition(int[,] matrix1, double[,] matrix2)
        {
            int n = matrix1.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix2[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix2;
        }

        #endregion ADDITION

        #region SUBSTRACTION

        public static int[,] subtraction(int[,] matrix1, int[,] matrix2)
        {
            int n = matrix1.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix1[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return matrix1;
        }

        public static double[,] subtraction(double[,] matrix1, double[,] matrix2)
        {
            int n = matrix1.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix1[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return matrix1;
        }

        public static double[,] subtraction(int[,] matrix1, double[,] matrix2)
        {
            int n = matrix1.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix2[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return matrix2;
        }

        #endregion SUBSTRACTION

        #region MULTIPLICATION

        //Умножение матрицы на матрицу
        public static int[,] multiplication(int[,] matrix1, int[,] matrix2)
        {
            int height_matrix1 = matrix1.GetLength(0);
            int n = matrix1.GetLength(1);
            int width_matrix2 = matrix2.GetLength(1);

            int[,] matrix3 = new int[height_matrix1, width_matrix2];

            for (int i = 0; i < height_matrix1; i++)
            {
                for (int j = 0; j < width_matrix2; j++)
                {
                    for (int r = 0; r < n; r++)
                    {
                        matrix3[i, j] = matrix3[i, j] + (matrix1[i, r] * matrix2[r, j]);
                    }
                }
            }
            return matrix3;
        }

        public static double[,] multiplication(double[,] matrix1, double[,] matrix2)
        {
            int height_matrix1 = matrix1.GetLength(0);
            int n = matrix1.GetLength(1);
            int width_matrix2 = matrix2.GetLength(1);

            double[,] matrix3 = new double[height_matrix1, width_matrix2];

            for (int i = 0; i < height_matrix1; i++)
            {
                for (int j = 0; j < width_matrix2; j++)
                {
                    for (int r = 0; r < n; r++)
                    {
                        matrix3[i, j] = matrix3[i, j] + (matrix1[i, r] * matrix2[r, j]);
                    }
                }
            }
            return matrix3;
        }

        //Умножение матрицы на число
        public static int[,] multiplication(int[,] matrix, int number)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = matrix[i, j] * number;
                }
            }
            return matrix;
        }

        public static double[,] multiplication(int[,] matrix, double number)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            double[,] array1 = new double[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array1[i, j] = matrix[i, j] * number;
                }
            }
            return array1;
        }

        public static double[,] multiplication(double[,] matrix, double number)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = matrix[i, j] * number;
                }
            }
            return matrix;
        }

        #endregion MULTIPLICATION

        #region TRACE OF THE MATRIX

        public static int traceOfTheMatrix(int[,] matrix)//След матрицы
        {
            int n = matrix.GetLength(0);
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = sum + matrix[i, i];
            }

            return sum;
        }

        public static double traceOfTheMatrix(double[,] matrix)//След матрицы
        {
            int n = matrix.GetLength(0);
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = sum + matrix[i, i];
            }

            return sum;
        }

        #endregion TRACE OF THE MATRIX
    }
}
