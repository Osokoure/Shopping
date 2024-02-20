public class Banane:Produit
{
    private double prixKgHT;
    private double poids;

    public Banane(string nomDefaut,Tva tvaProduit,double prixAuKiloHorsTaxes,double lePoids)
    : base(nomDefaut,prixAuKiloHorsTaxes*lePoids,tvaProduit)

    {
        prixKgHT = prixAuKiloHorsTaxes;
        poids = lePoids;
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