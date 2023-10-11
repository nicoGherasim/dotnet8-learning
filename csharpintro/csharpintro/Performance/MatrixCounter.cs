namespace csharpintro.Performance
{
    public class MatrixCounter
    {
        public int CountPositiveNumbersByRow(int[,] matrix)
        {
            var counter = 0;
            var length = matrix.GetLength(0);

            for(var i = 0; i < length; i++)
            {
                for(var j = 0; j < length; j++)
                {
                    if (matrix[i,j] > 0)
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }

        public int CountPositiveNumbersByColumn(int[,] matrix)
        {
            var counter = 0;
            var length = matrix.GetLength(0);

            for (var i = 0; i < length; i++)
            {
                for (var j = 0; j < length; j++)
                {
                    if (matrix[j, i] > 0)
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
