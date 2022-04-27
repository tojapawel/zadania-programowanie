public class Czolg : pojazd {
    public int _amunicja { get; set; }
    public int _zaloga { get; }
    public Czolg(int amunicja, int zaloga, string nazwa, string kolor, bool kola, string silnik)
        :base(nazwa, kolor, kola, silnik) {
        _amunicja = amunicja;
        _zaloga = zaloga;
    }

    public void Fire() {
        if (_amunicja > 0) {
            _amunicja--;
            Console.WriteLine("Wystrzelil");
        } else {
            Console.WriteLine("brak amunicji");
        }
    }

    public override void GetInfo() {
        Console.WriteLine($"{OnGetInfo()}, {_amunicja}, {_zaloga}");
    }
}
