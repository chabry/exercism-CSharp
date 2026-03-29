public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        int[] valeurs = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5,4, 1 };
        string[] symboles = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        
        int reste = value;
        string resultat = "";
        
        for (int i = 0; i < valeurs.Length; i++){
            while(reste >= valeurs[i]){
                resultat += symboles[i];
                reste -= valeurs[i];
            }
        }
        return resultat;
    }
}