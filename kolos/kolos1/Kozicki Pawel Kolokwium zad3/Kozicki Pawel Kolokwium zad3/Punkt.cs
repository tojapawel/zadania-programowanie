public class Punkt {
    public int _posX;
    public int _posY;

    public Punkt(int posX, int posY) {
        _posX = posX;
        _posY = posY;
    }

    public void Przesun(PosType pos, int value) {
        if (pos == PosType.posX) {
            _posX += value;
            Console.WriteLine($"Przesunieto posX o {value}");
        } else if (pos == PosType.posY) {
            _posY += value;
            Console.WriteLine($"Przesunieto posY o {value}");
        }
    }

    public void Wyswietl() {
        Console.WriteLine($"Pozycja punktu: ({_posX}, {_posY})");
    }
}

public enum PosType {
    posX,
    posY
}