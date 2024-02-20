using System;
void Main()
    {
        Tva tva;
        tva = new Tva(0.2);
        
        Produit ordinateur; // déclaration d'un nouvel objet
        ordinateur = new Produit("MSI",999,tva); // instanciation de cet objet

        Console.WriteLine(ordinateur.getNom());
        Console.WriteLine(ordinateur.getPrixHT());
        Console.WriteLine(ordinateur.getTypeTva());
        Console.WriteLine(ordinateur.calculTTC());

        Panier panier1 = new Panier();
        panier1.ajoutPanier(ordinateur);
        panier1.afficherPanier();
    }

Main();