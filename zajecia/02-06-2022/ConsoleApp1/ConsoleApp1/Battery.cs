public class Battery {
    public Battery(int iD, int power) {
        ID = iD;
        Power = power;
    }

    public int ID { get; set; }
    public int Power { get; set; }

    public override string ToString() {
        return $"ID: {ID}, Power: {Power}";
    }
}