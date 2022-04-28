public class Prostokat {
    private int _dlugosc;
    private int _szerokosc;

    public Prostokat(int dlugosc, int szerokosc) {
        _dlugosc = dlugosc;
        _szerokosc = szerokosc;
    }

    private int Powierzchnia() {
        return _dlugosc * _szerokosc;
    }

    private int Obwod() {
        return 2 * _dlugosc + 2 * _szerokosc;
    }

    public void Prezentuj() {
        Console.WriteLine($"Powierzchnia: {Powierzchnia()}, Obwod: {Obwod()}");
    }
}