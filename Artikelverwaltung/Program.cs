using System;

namespace Artikelverwaltung                                     //Das Programm wurde bis und mit "Mehrere Preise" geschrieben
{
    class Program
    {
    	
        
        static void Main(string[] args)
        {
        	string[] artikelname = new string[10];
    		double[] artikeleinkaufspreis = new double[10];
            double[] artikelverkaufspreis = new double[10];     //Deklaration der Benötigten Arrays
        
       		int counter = 0;
            while (true)                                        //Der gesamte Code wird wiederholt, damit wenn funktionen
            {                                                   //ausgeführt werden, das ganze sich nicht einfach beendet
            Console.Clear();
            Console.WriteLine("ARTIKELVERWALTUNG");
            Console.WriteLine("-----------------");
            Console.WriteLine("HAUPTMENU:");
            Console.WriteLine("----------");
            Console.WriteLine("Optionen:");
            Console.WriteLine("*** Artikel erfassen (1)");
            Console.WriteLine("*** Alle erfassten Artikel anzeigen (2)");
            Console.WriteLine("*** Anzahl erfassten Artikel anzeigen (3)");
            Console.WriteLine("*** Artikel nach Artikelname suchen (4)");
            Console.WriteLine("*** Lagerplatz freigeben (5)");
            Console.WriteLine("*** Artikel Aktualisieren (6)");
            Console.WriteLine("*** Programm beenden (q)");
            Console.Write("Option eingeben: ");                 //Ausgabe des Hauptmenüs.
            string eingabe = Console.ReadLine();                
           
            switch (eingabe)
            {
                case "1":										//Artikel Erfassen
            		Console.Clear();
                    Console.WriteLine("Artikel Erfassen");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Artikel Name: ");		//Erste Ausgabe bis zum input für den Namen
                    string ArtName = Console.ReadLine();
                    artikelname[counter] = ArtName;				//Der eingegebene Name wird ins array gespeichert
                    Console.WriteLine("Einkaufspreis: ");
                    while (true)
                    {
                        try
                        {
                            double ArtPreis = Convert.ToDouble(Console.ReadLine());
                            artikeleinkaufspreis[counter] = ArtPreis;			//dasselbe nur mit dem einkaufs Preis
                            Console.WriteLine("Verkaufspreis: ");
                            double verPreis = Convert.ToDouble(Console.ReadLine());

                            try
                            {

                                artikelverkaufspreis[counter] = verPreis;			//dasselbe nur mit dem verkaufs Preis
                                if (verPreis < ArtPreis)
                                {
                                    Console.WriteLine("Viel Spass im Minus!");
                                }
                                Console.WriteLine("");
                                Console.WriteLine("Erfasster Artikel: ");   //Hier wird der gerade eingegebene Artikel noch einmal wiederholt
                                Console.WriteLine("-------------------");
                                Console.WriteLine("Artikel: {0} einkaufspreis: {1}  verkaufspreis: {2}", artikelname[counter], artikeleinkaufspreis[counter] + "Fr", artikelverkaufspreis[counter] + "Fr");
                                Console.WriteLine("-------------------");
                                counter++;
                                Console.ReadKey();
                                break;
                            }

                            catch
                            {
                                Console.WriteLine("Zahl eingeben bitte: ");
                            }
                        }
                        
                        catch
                        {
                            Console.WriteLine("Bitte Zahl eingeben: ");
                        }
                    }
                    break;

                case "2":                                        //Alle Artikel anzeigen
                    Console.Clear();
                    Console.WriteLine("Lagerplatz	Artikelname einkaufspreis   verkaufspreis");
                    Console.WriteLine("------------------------------------------------------");
                    for (int x = 0; x < 10; x++ ) {
                        Console.WriteLine("{0}                {1}     {2}             {3}", x+1, artikelname[x], Convert.ToDouble(artikeleinkaufspreis[x]), Convert.ToDouble(artikelverkaufspreis[x]));
                    }
                    Console.ReadKey();
                    break;

                case "3":                                        //Gibt aus, wieviele Artikel erfasst wurden. 
                    Console.Clear();
                    if (counter != 0) {
                    	Console.WriteLine("Anzahl Artikel: " + Convert.ToString(counter));
                    	Console.ReadKey();
                    }
                    else {
                    	Console.WriteLine("Keine Artikel erfasst!");
                    	Console.ReadKey();
                    }
                    break;
                
                case "4":                                           //Suche. Vergleicht immer die eingabe mit den
                    Console.Clear();                                //vorhandenen Artikelnamen, falls eine Übereinstimmung
                    Console.WriteLine("Suchbegriff: ");             //eintrifft, wird der Artikel ausgegeben.
                    string search = Console.ReadLine();
                    for (int i = 0; i <= 3; i++) {
                    	bool check = search == artikelname[i];
                    	if (check == true) {
                    		Console.WriteLine("----------------------");
                    		Console.WriteLine("Artikel: {0}	Einkaufspreis: {1} Verkaufspreis: {2}", artikelname[i], Convert.ToString(artikeleinkaufspreis[i]), Convert.ToString(artikelverkaufspreis[i]));
                    		Console.WriteLine("----------------------");
                    		Console.ReadKey();
                    		break;
                    	}
                    	else if (i == 3) {
                    		Console.WriteLine("Artikel nicht gefunden");
                    		Console.ReadKey();
                    	}
                    	
                    }
                    break;
                    
                case "5":                                              //Löschvorgang.
                    Console.Clear();
                    Console.WriteLine("Lagerplatz	Artikelname	Einkaufspreis   Verkaufspreis");
                    Console.WriteLine("-------------------------------------");
                    for (int x = 0; x < 10; x++)
                    {
                        Console.WriteLine("{0}                {1}     {2}             {3}", x + 1, artikelname[x], Convert.ToDouble(artikeleinkaufspreis[x]), Convert.ToDouble(artikelverkaufspreis[x]));
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Welchen Artikel möchten Sie entfernen?");
                    Console.WriteLine("Artikelnummer eingeben: ");
                    int del = Convert.ToInt32(Console.ReadLine());
                    if (del > 4 || del < 1) {
                    	Console.WriteLine("Ungültige Artikelnummer! ");
                    }
                    else {
                    	del--;
                    	artikelname[del] = "NULL";
                    	artikeleinkaufspreis[del] = 0;
                        artikelverkaufspreis[del] = 0;
                        Console.WriteLine("Lagerplatz	Artikelname	Einkaufspreis   Verkaufspreis");
                        Console.WriteLine("-------------------------------------");
                        for (int x = 0; x < 10; x++)
                        {
                            Console.WriteLine("{0}                {1}     {2}             {3}", x + 1, artikelname[x], Convert.ToDouble(artikeleinkaufspreis[x]), Convert.ToDouble(artikelverkaufspreis[x]));
                        }

                        Console.WriteLine("");
            	        }
                    Console.ReadKey();
                    break;

                case "6":                                           //Artikel Aktualisieren
                    Console.Clear();
                    Console.WriteLine("Artikel Aktualisieren");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Welchen Artikel möchten Sie aktualisieren? (Artikelname eingeben): ");
                    string tempsearch = Console.ReadLine();
                    for (int i = 0; i <= 3; i++) {
                    	bool check = tempsearch == artikelname[i];
                    	if (check == true) {
                    		Console.WriteLine("----------------------");
                            Console.WriteLine("Artikel: {0}	Einkaufspreis: {1}, Verkaufspreis: {2}", artikelname[i], Convert.ToString(artikeleinkaufspreis[i]), Convert.ToString(artikelverkaufspreis[i]));
                    		Console.WriteLine("----------------------");
                            Console.WriteLine("Neuer Artikelname: ");
                            string newname = Console.ReadLine();
                            Console.WriteLine("Neuer Einkaufspreis: ");
                            double newprice = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Neuer Verkaufspreis: ");
                            double newprice2 = Convert.ToDouble(Console.ReadLine());
                            artikelname[i] = newname;
                            artikeleinkaufspreis[i] = newprice;
                            artikelverkaufspreis[i] = newprice2;
                    		break;
                    	}
                    	else if (i == 3) {
                    		Console.WriteLine("Artikel nicht gefunden");
                    		Console.ReadKey();
                    	}
                    	
                    }
                    break;

                case "q":                       //Beenden des Programms.
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                
                default:
                    Console.WriteLine("Ungülige Eingabe! Entweder 1-6 oder q!");
                    break;
                    
            }
            }
           
        }
    }
}
