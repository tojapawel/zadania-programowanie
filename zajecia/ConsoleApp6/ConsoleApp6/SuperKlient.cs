internal class SuperKlient : Klient{

    public SuperKlient(string firstName, string lastName, byte age, byte height, StanCywilny stanCywilny, Plec plec) 
        : base(firstName, lastName, age, height, stanCywilny, plec)
    {
        ShowName();
    }

    public override void MySuperMethodTwo() {
        Console.WriteLine("metoda virtualna override w superklient");
    }

}