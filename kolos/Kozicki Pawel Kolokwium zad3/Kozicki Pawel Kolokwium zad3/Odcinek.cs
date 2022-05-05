public class Odcinek {
    private Punkt _punktA;
    private Punkt _punktB;

    public Odcinek(Punkt punkt1, Punkt punkt2) {
        _punktA = punkt1;
        _punktB = punkt2;
    }

    public float DlugoscOdcinka() {
        return (float)Math.Sqrt(Math.Pow(_punktB._posX - _punktA._posX, 2) + Math.Pow(_punktB._posY - _punktA._posY, 2));
    }
}