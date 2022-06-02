public class Employee {
    public Employee(int iD, string firstName) {
        ID = iD;
        FirstName = firstName;
    }

    public int ID { get; }
    public string FirstName { get; }

    public override string ToString() {
        return $"ID: {ID}, FirstName: {FirstName}";
    }
}