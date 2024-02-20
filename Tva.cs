using System;
public class Tva
{
    private double taux;


    public Tva(double leTaux)
    {
        this.taux=leTaux;
    }
     public double getType()
    {
        return this.taux;
    }

    public double calculTTC(double prixHT)
    {
        return prixHT+(prixHT*taux);
    }
}