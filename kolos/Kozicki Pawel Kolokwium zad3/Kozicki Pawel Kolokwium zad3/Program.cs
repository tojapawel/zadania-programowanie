//zad3

var odcinki = new Odcinek[3];

var punkt1 = new Punkt(0, 0);

for (int i = 0; i < 3; i++) {
    var rng = new Random();

    punkt1 = new Punkt(rng.Next(0, 10), rng.Next(0, 10));
    var punkt2 = new Punkt(rng.Next(0, 10), rng.Next(0, 10));

    punkt2.Wyswietl();

    punkt2.Przesun(PosType.posX, rng.Next(0, 10));
    punkt2.Przesun(PosType.posY, rng.Next(0, 10));

    punkt2.Wyswietl();

    

    odcinki[i] = new Odcinek(punkt1, punkt2);
    Console.WriteLine(odcinki[i].DlugoscOdcinka());

    Console.WriteLine();
}

var objetosc = new Prostopadloscian(odcinki[0], odcinki[1], odcinki[2]);

Console.WriteLine();

objetosc.WyswietlObjetosc();

var rysowanie = new Rysownik(punkt1, odcinki[0], objetosc);

Console.WriteLine("\n");

rysowanie.Rysuj();