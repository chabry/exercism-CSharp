public static class SquareRoot
{
    public static int Root(int number)
    {
        //Cas ou si c'est 0 ou 1
        if(number < 2) return number;

        long left = 1;
        long right = number;

        while (left <= right){
            long mid = (left+right) / 2;
            long squared = mid * mid;

            if (squared == number) return (int)mid;

            if(squared < number){
                left = mid + 1;
            } else{
                right = mid -1;
            }
        }
        return (int) right;
        
    }
}
