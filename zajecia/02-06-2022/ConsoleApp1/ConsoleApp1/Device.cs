public class Device : ICloneable{
    public Device(int iD, string name, int serialNumber, Battery battery) {
        ID = iD;
        Name = name;
        SerialNumber = serialNumber;
        Battery = battery;
    }

    public int ID { get; set; }
    public string Name { get; set; }
    public int SerialNumber { get; set; }
    public Battery Battery { get; set; }

    public object Clone() {
        return this.MemberwiseClone();
    }

    public override string ToString() {
        return $"ID: {ID}, Name: {Name}, SerialNumber: {SerialNumber}, Battery: {Battery}";
    }
}
