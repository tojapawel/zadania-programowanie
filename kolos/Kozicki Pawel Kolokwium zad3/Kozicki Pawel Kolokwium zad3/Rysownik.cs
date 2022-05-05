public class Rysownik {
    private Punkt _punkt;
    private Odcinek _odcinek;
    private Prostopadloscian _prostopadloscian;

    public Rysownik(Punkt punkt, Odcinek odcinek, Prostopadloscian prostopadloscian) {
        _punkt = punkt;
        _odcinek = odcinek;
        _prostopadloscian = prostopadloscian;
    }

    public void Rysuj() {
        Console.WriteLine($"Punkt: ({_punkt._posX}, {_punkt._posY})\nOdcinek: dlugosc {_odcinek.DlugoscOdcinka()}\nProstopadloscian: objetosc {_prostopadloscian.Objetosc()}");
    }
}