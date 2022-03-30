public class Book {
    private Author _author;
    private string _title, _type, _country;
    private int _pagesCount, _releaseYear;

    public Book(Author author, string title, string type, string country, int releaseYear, int pagesCount) {
        _author = author;
        _title = title;
        _type = type;
        _country = country;
        _releaseYear = releaseYear;
        _pagesCount = pagesCount;
    }

    public Author Author { get { return _author; } }
    public string Title { get { return _title; } }
    public string Type { get { return _type; } }
    public string Country { get { return _country; } }
    public int ReleaseYear { get { return _releaseYear; } }
    public int PagesCount { get { return _pagesCount; } }

    public void Update(Author author, string title, string type, string country, int releaseYear, int pagesCount) {
        this._author = author;
        this._title = title;
        this._type = type;
        this._country = country;
        this._releaseYear = releaseYear;
        this._pagesCount = pagesCount;
    }

    public string ReturnBook() {
        return $"\"{_title}\", {_type} Autor: {_author.ReturnAuthor()}, Wydana: {_releaseYear}r. w {_country}. Strony: {_pagesCount}";
    }

}