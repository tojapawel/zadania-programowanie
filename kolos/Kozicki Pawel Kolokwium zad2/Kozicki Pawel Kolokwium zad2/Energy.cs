public class Energy {
    private float _energyStart;
    private float _energyNow;

    public Energy(float energyStart, float energyNow) {
        _energyStart = energyStart;
        _energyNow = energyNow;
    }

    public void GetInfo() {
        Console.WriteLine($"Stan poczatkowy licznika: {_energyStart}, Stan aktualny licznika: {_energyNow}");
    }

    public void EnergyUsed() {
        Console.WriteLine($"Zuzyta energia: {_energyNow - _energyStart}");
    }
}
