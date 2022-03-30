internal abstract class Czalowiek {
    private string _firstName, _lastName;
    private byte _age, _height;
    private StanCywilny _stanCywilny;
    private Plec _plec;

    protected Czalowiek(string firstName, string lastName, byte age, byte height, StanCywilny stanCywilny, Plec plec) {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _height = height;
        _stanCywilny = stanCywilny;
        _plec = plec;
    }

    protected void ShowName() {
        Console.WriteLine(_firstName);
    }

    public abstract void MySuperMethod(); //wymusza kto po mnie dziedziczy to musi to zaimplementowac

    public virtual void MySuperMethodTwo() {
        Console.WriteLine("czlowiek podstawowy text ");
    }

    public string FirstName { get => _firstName; }
    public string LastName { get => _lastName; }
    public byte Age { get => _age; }
    public byte Height { get => _height; }
    internal StanCywilny StanCywilny { get => _stanCywilny; set => _stanCywilny = value; }
    internal Plec Plec { get => _plec; }

}