public static class LineUp
{
    public static string Format(string name, int number)
    {
        string suffixe = "th";
        int lastTwoDigits = number % 100;
        int lastDigit = number % 10;
        
        //Mettre de côté les exceptions (11,12,13)
        if(lastTwoDigits is 11 or 12 or 13){
            suffixe = "th";
        }else{
            //Isoler le dernier chiffre du nombre (si 1,2,3 ou les autres)
            switch(lastDigit){
                case 1:
                    suffixe = "st";
                    break;
                case 2:
                    suffixe = "nd";
                    break;
                case 3:
                    suffixe = "rd";
                    break;
                default:
                    suffixe = "th";
                    break;
            }
        }

        //Retourner la phrase avec interpolation
        return $"{name}, you are the {number}{suffixe} customer we serve today. Thank you!";
        
    }
}
