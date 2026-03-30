public class Player
{
    //Instanciation de l'objet random
    private static readonly Random _rnd = new();
    
    public int RollDie() => _rnd.Next(1,19);

    public double GenerateSpellStrength() => _rnd.NextDouble() * 100.0;
}
