internal class Klient : Czalowiek {

    public Klient(string firstName, string lastName, byte age, byte height, StanCywilny stanCywilny, Plec plec) 
        : base(firstName, lastName, age, height, stanCywilny, plec) {}

    public void GetAge() {
        Console.WriteLine(Age);
    }

    public override void MySuperMethod() {
        Console.WriteLine("jejeje");
    }
}