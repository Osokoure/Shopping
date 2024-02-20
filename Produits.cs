using System;
public class Produit
{
    private string nom;
    private double prixHT;
    private Tva tva;

    public Produit(string nomDefaut,double prixDefaut,Tva tvaProduit)
    {
        this.nom=nomDefaut;
        this.prixHT=prixDefaut;
        this.tva=tvaProduit;
    }
    
    public override string ToString(){
        return(this.nom);
    }

    public string getNom()
    {
        return this.nom;
    }

    public double getPrixHT()
    {
        return this.prixHT;
    }

    public double getTypeTva()
    {
        return tva.getType();
    }

    public double calculTTC()
    {
        return this.tva.calculTTC(this.prixHT);
    }

}