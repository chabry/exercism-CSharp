public static class Darts
{
    public static int Score(double x, double y)
    {
        //Déclaration variable à retourner
        int score;
        //Calculer la distance entre le point 0.0 et la flechette
        double distance = Math.Sqrt(x*x + y*y); //On utilise pythagore
        //Conditions par rapport à la distance pour le score
        return distance switch{
                <= 1 => 10, // >= 1 on retourne 10 etc.
                <= 5 => 5,
                <= 10 => 1,
                _    => 0
        };
    }
}
