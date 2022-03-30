public class Author {
    private string _firstName, _lastName, _country;

    public Author(string firstName, string lastName, string country) {
        _firstName = firstName;
        _lastName = lastName;
        _country = country;

        Console.WriteLine("test");
    }

    public string FirstName { get { return _firstName; } }
    public string LastName { get { return _lastName; } }
    public string Country { get { return _country; } }

    public void Update(string firstName, string lastName, string country) {
        this._firstName = firstName;
        this._lastName = lastName;
        this._country = country;
    }

    public string ReturnAuthor() {
        return $"{_firstName} {_lastName}, {_country}";
    }
}