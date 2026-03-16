public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        //Vérifier que le numéro vient de NY
        bool IsNewYork = phoneNumber.StartsWith("212");

        //Vérifier si il est fake
        bool IsFake = phoneNumber.Substring(4, 3) == "555";

        //Récuper les 4 derniers chiffres
        string LocalNumber = phoneNumber.Substring(8);

        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
