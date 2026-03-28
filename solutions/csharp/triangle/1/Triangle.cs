public static class Triangle
{
    private static bool IsValidTriangle(double side1, double side2, double side3)
    {
        // Tous les côtés > 0
        if (side1 <= 0 || side2 <= 0 || side3 <= 0) return false;
        // La somme de deux côtés >= au 3e côté
        return (side1 + side2 >= side3) &&
                (side2 + side3 >= side1) &&
                (side1 + side3 >= side2);
    }
    
    public static bool IsScalene(double side1, double side2, double side3)
    {
        //Est-ce un triangle ?
        if (!IsValidTriangle(side1, side2, side3)){
            return false;
        }
        //Logique de scalène
        return (side1 != side2 && side2 != side3 && side3 != side1);
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        //Est-ce un triangle ?
        if (!IsValidTriangle(side1, side2, side3)){
            return false;
        }
        //Logique de Isocèle
        return (side1 == side2 || side2 == side3 || side3 == side1);
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        //Est-ce un triangle ?
        if (!IsValidTriangle(side1, side2, side3)){
            return false;
        }
        //Logique de l'équilatéral (tous cotés égaux)
        return (side1 == side2 && side2 == side3);
    }
}