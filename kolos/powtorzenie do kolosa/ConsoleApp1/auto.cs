public class auto : pojazd{
    public string _model { get; }
    public float _spalanie { get; }

    public auto(string model, float spalanie, string nazwa, string kolor, bool kola, string silnik) : base(nazwa, kolor, kola, silnik) {
        _model = model;
        _spalanie = spalanie;
    }

    public override void GetInfo() {
        Console.WriteLine($"{OnGetInfo()}, {_model}, {_spalanie}");
    }

}
