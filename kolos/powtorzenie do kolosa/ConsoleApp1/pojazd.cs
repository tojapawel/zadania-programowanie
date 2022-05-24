public abstract class pojazd {
    protected pojazd() {
    }

    protected pojazd(string nazwa, string kolor, bool kola, string silnik) {
        _nazwa = nazwa;
        _kolor = kolor;
        _kola = kola;
        _silnik = silnik;
    }

    public string _nazwa { get; }
    public string _kolor { get; }
    public bool _kola { get; }
    public string _silnik { get; }

    public abstract void GetInfo();

    public string OnGetInfo() {
        return $"{_nazwa}, {_kolor}, {_kola}, {_silnik}";
    }
}