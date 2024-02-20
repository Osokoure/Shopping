using System;
public class Panier
{

        
    // Création et initialisation du tableau d'objets
    Produit[] tabPanier = new Produit[16];
    public void afficherPanier()
    {
                //parcourir le tableau d'objets
            foreach(var i in tabPanier) 
            { 
                    Console.WriteLine(i); 
            } 
    }    

    public void ajoutPanier(Produit ordinateur)
    {
        for (int k = 0; k < tabPanier.Length; k++)
        {
            Console.WriteLine(tabPanier[k]);
            if (tabPanier[k] == null)
            {
                tabPanier[k] = ordinateur;
                break; 
            }
        }
    }

    public double sommePanier()
    {
        double somme=0;
        foreach(var i in tabPanier)
        {
            if (i!=null){
            somme+=i.calculTTC();
            }
        } 
        return somme;
    }
}