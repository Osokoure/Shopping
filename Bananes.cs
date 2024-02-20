public class Banane:Produit
{
    private double prixKgHT;
    private double poids;

    public Banane(string nomDefaut,double prixDefaut,Tva tvaProduit,double prixAuKiloHorsTaxes,double lePoids)
    : base(nomDefaut,prixDefaut,tvaProduit)

    {
        prixKgHT = prixAuKiloHorsTaxes;
        poids = lePoids;
    }

    public double calculTTCauPoids()
    {
        return this.calculTTC()*this.getPoids();        
    }
    
    public double getPrixKgHT()
    {
        return this.prixKgHT;
    }

    public double getPoids()
    {
        return this.poids;
    }

}