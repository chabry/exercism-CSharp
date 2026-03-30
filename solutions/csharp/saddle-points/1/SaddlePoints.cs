public static class SaddlePoints
{
    private static bool IsSaddlePoint(int[,] matrix, int r, int c, int val, int rows, int cols)
{
    var rowValues = Enumerable.Range(0, cols).Select(i => matrix[r, i]);
    bool isMaxInRow = rowValues.All(v => val >= v);

    var colValues = Enumerable.Range(0, rows).Select(i => matrix[i, c]);
    bool isMinInCol = colValues.All(v => val <= v);

    return isMaxInRow && isMinInCol;
}
    
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        var points = new List<(int, int)>();
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for(int r = 0; r < rows; r++){
            for(int c = 0; c < cols; c++){
                int currentTree = matrix[r, c];

                if(IsSaddlePoint(matrix, r, c, currentTree, rows, cols)){
                    points.Add((r + 1, c + 1));
                }
            }
        }
        return points;
    }
}
