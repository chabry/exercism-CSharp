public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        string[] milliers  = { "", "M", "MM", "MMM" };
string[] centaines = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
string[] dizaines  = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
string[] unites    = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        int m = value / 1000;
        int c = (value / 100) % 10;
        int d = (value / 10) % 10;
        int u = value % 10;

        return milliers[m] + centaines[c] + dizaines[d] + unites[u];
    }
}