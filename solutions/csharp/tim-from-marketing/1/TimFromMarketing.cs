public static class Badge
{
        public static string Print(int? id, string name, string? department)
    {
        //Gérer une valeur par défaut pour le dept s'il est nul
        string formattedDept = (department ?? "OWNER").ToUpper();
        //Gerer l'ID
        string idPart = (id == null) ? "" : $"[{id}] - ";

        return $"{idPart}{name} - {formattedDept}";
    }
}