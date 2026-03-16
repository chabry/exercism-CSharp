public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter){
        // Trouver la position du délimiteur
        int delimiterPosition = str.IndexOf(delimiter);
        
        //Calculer le début du message (position + longueur délimiteur)
        int positionSubstring = delimiterPosition + delimiter.Length;
        
        //Retourne le morceau restant
        return str.Substring(positionSubstring);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string start, string end){
        //Trouver les positions des délimiteurs
        int startPosition = str.IndexOf(start) + start.Length;
        int length = str.IndexOf(end) - startPosition;

        //Retourner le morceau restant
        return str.Substring(startPosition, length);
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.SubstringAfter(": ");

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");

}