internal class Pracownik : Czalowiek{
    private string _teamName;
    private Pracownik _przelozony;
    private byte _expirience;
    private int _salary;
    private PoziomUprawnien _uprawnienie;

    public Pracownik(string firstName, string lastName, byte age, byte height, StanCywilny stanCywilny, Plec plec, string teamName, Pracownik przelozony, byte expirience, int salary, PoziomUprawnien uprawnienie) 
        : base (firstName, lastName, age, height, stanCywilny, plec)
    {
        TeamName = teamName;
        Przelozony = przelozony;
        Expirience = expirience;
        Salary = salary;
        Uprawnienie = uprawnienie;
    }

    public string TeamName { get => _teamName; set => _teamName = value; }
    public byte Expirience { get => _expirience; set => _expirience = value; }
    public int Salary { get => _salary; set => _salary = value; }
    internal Pracownik Przelozony { get => _przelozony; set => _przelozony = value; }
    internal PoziomUprawnien Uprawnienie { get => _uprawnienie; set => _uprawnienie = value; }

    public override void MySuperMethod() {
        Console.WriteLine("fum fum");
    }
}


enum PoziomUprawnien { 
    A1,
    A2,
    A3
}

enum StanCywilny {
    Kawaler,
    Panna,
    Żonaty,
    Zamężna
}

enum Plec {
    Mazczyzna,
    Kobieta
}