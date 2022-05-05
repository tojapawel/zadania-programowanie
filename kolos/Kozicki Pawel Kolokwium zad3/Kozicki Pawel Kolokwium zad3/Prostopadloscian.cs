public class Prostopadloscian {
    private Odcinek _odcinek1;
    private Odcinek _odcinek2;
    private Odcinek _odcinek3;
    private float v1;
    private float v2;
    private float v3;

    public Prostopadloscian(Odcinek odcinek1, Odcinek odcinek2, Odcinek odcinek3) {
        _odcinek1 = odcinek1;
        _odcinek2 = odcinek2;
        _odcinek3 = odcinek3;
    }

    public float Objetosc() {
        return _odcinek1.DlugoscOdcinka() * _odcinek2.DlugoscOdcinka() * _odcinek3.DlugoscOdcinka();
    }

    public void WyswietlObjetosc() {
        Console.WriteLine($"Objetosc: {Objetosc()}");
    }
}