namespace MatrixTask;

public class Matrix
{
    private int[,] _data;
    public string Name { get; set; }
    public int Rows { get; }
    public int Columns { get; }

    //constructor for an initial empty matrix
    public Matrix(string name, int rows, int columns)
    {
        if (rows <= 0 || columns <= 0)
        {
            throw new ArgumentException("Amount of rows and columns must > 0");
        }
        Name = name;
        Rows = rows;
        Columns = columns;
        _data = new int[rows, columns];
    }

    // constructor for a predefined matrix we get from somewhere
    public Matrix(string name, int[,] initialData)
    {
        if (initialData == null)
        {
            throw new ArgumentNullException(nameof(initialData), "Initial data of the matrix can't be null.");
        }
        Name = name;
        Rows = initialData.GetLength(0);
        Columns = initialData.GetLength(1);
        _data = (int[,])initialData.Clone();
    }

    public int this[int row, int col]
    {
        get
        {
            if (row < 0 || row >= Rows || col < 0 || col >= Columns)
            {
                throw new IndexOutOfRangeException("The indexes are outside of matrix range.");
            }
            return _data[row, col];
        }
        set
        {
            if (row < 0 || row >= Rows || col < 0 || col >= Columns)
            {
                throw new IndexOutOfRangeException("The indexes are outside of matrix range.");
            }
            _data[row, col] = value;
        }
    }

    #region overloading operators

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
        {
            throw new ArgumentException("Matrixes must be of same size.");
        }

        Matrix result = new Matrix("New Matrix", m1.Rows, m1.Columns);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = m1[i, j] + m2[i, j];
            }
        }
        return result;
    }

    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
        {
            throw new ArgumentException("Matrixes must be of same size.");
        }

        Matrix result = new Matrix("New Matrix", m1.Rows, m1.Columns);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = m1[i, j] - m2[i, j];
            }
        }
        return result;
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
        {
            throw new ArgumentException("Matrixes must be of same size.");
        }

        Matrix result = new Matrix("New Matrix", m1.Rows, m2.Columns);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = m1[i, j] * m2[i, j];
            }
        }
        return result;
    }

    public static Matrix operator *(Matrix m, int scalar)
    {
        Matrix result = new Matrix("New matrix", m.Rows, m.Columns);
        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Columns; j++)
            {
                result[i, j] = m[i, j] * scalar;
            }
        }
        return result;
    }

    public static Matrix operator *(int scalar, Matrix m)
    {
        return m * scalar; 
    }

    public static bool operator ==(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
        {
            return false;
        }

        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                if (m1[i, j] != m2[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool operator !=(Matrix m1, Matrix m2)
    {
        return !(m1 == m2);
    }

    #endregion

    public override bool Equals(object obj)
    {
        return this == (obj as Matrix);
    }

    public override string ToString()
    {
        string matrixString = "";
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                matrixString += $"{_data[i, j],4}"; 
            }
            matrixString += Environment.NewLine;
        }
        return matrixString;
    }
}