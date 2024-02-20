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
        
        Banane banane1;
        banane1 = new Banane("BananeMiam",11,tva,21,5);
        
        Console.WriteLine(banane1.calculTTCauPoids());
    }

Main();