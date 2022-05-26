public class Pracownik : IPerson {

    public Pracownik(string name) {
        Name = name;
    }

    public string Name { get; }

    public void ShowInfo() {
        Console.WriteLine($"Pracownik : {Name}");
    }
}