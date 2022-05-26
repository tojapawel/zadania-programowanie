public class Klient : IPerson {
    public Klient(string name) {
        Name = name;
    }

    public string Name { get; }

    public void ShowInfo() {
        Console.WriteLine($"Klient : {Name}");
    }
}