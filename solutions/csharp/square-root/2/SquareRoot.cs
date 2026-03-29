public static class SquareRoot
{
    public static int Root(int number)
    {
        //Cas ou si c'est 0 ou 1
        if(number < 2) return number;

        long x = number / 2;

        while (x * x != number){
            x = (x + (number/x)) / 2;
        }

        return (int)x;
    }
}
