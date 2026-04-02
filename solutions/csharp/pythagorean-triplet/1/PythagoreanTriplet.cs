public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        for (int a = 1; a < sum / 3; a++){
            for (int b = 1; b < sum / 2; b++){
                int c = sum - a - b;

                if ((long)a * a + (long)b * b == (long)c * c){
                    if (a<b && b < c){
                        yield return (a, b, c);
                    }
                }
            }
        }
    }
}