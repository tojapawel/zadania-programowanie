// jestem świadomy, że mozna by to było upriścić, a co za tym idzie zoptymalizować, ale brałko czasu

var books = new Book[100];
var authors = new Author[100];

int authorsCount = 0, booksCount = 0, input;

while (true) {
    ShowControls();

    Console.Write("\nTwoj wybor: ");
    int.TryParse(Console.ReadLine(), out input);

    switch (input) {
        case 1:
            AddMenu();
            break;
        case 2:
            EditMenu();
            break;
        case 3:
            ShowMenu();
            break;
        case 4:
            Environment.Exit(0);
            break;
    }
}

void AddMenu() {
    int addInput;
    while (true) {
        Console.Clear();
        Console.WriteLine("Biblioteka");
        Console.WriteLine("\nCo chcesz dodac?");

        Console.WriteLine("1. Dodaj autora");
        Console.WriteLine("2. Dodaj ksiazke");
        Console.WriteLine("3. Powrót");

        Console.Write("\nTwoj wybor: ");
        int.TryParse(Console.ReadLine(), out addInput);

        switch (addInput) {
            case 1:
                AddAuthor();
                break;
            case 2:
                AddBook();
                break;
            case 3:
                return;

        }
    }
}
void EditMenu() {
    int editInput;
    while (true) {
        Console.Clear();
        Console.WriteLine("Biblioteka");
        Console.WriteLine("\nCo chcesz edytowac?");

        Console.WriteLine("1. Informacje o autorze");
        Console.WriteLine("2. Informacje o ksiazce");
        Console.WriteLine("3. Powrót");

        Console.Write("\nTwoj wybor: ");
        int.TryParse(Console.ReadLine(), out editInput);

        switch (editInput) {
            case 1:
                EditAuthor();
                break;
            case 2:
                EditBook();
                break;
            case 3:
                return;

        }
    }
}
void ShowMenu() {
    int showInput;
    while (true) {
        Console.Clear();
        Console.WriteLine("Biblioteka");
        Console.WriteLine("\nCo chcesz wyswietlic?");

        Console.WriteLine("1. Liste autorow");
        Console.WriteLine("2. Liste ksiazek");
        Console.WriteLine("3. Powrót");

        Console.Write("\nTwoj wybor: ");
        int.TryParse(Console.ReadLine(), out showInput);

        switch (showInput) {
            case 1:
                Console.Clear();
                ShowAuthors();

                Console.Write("\nNacisnij dowolny przycisk aby wrocic...");
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
                ShowBooks();

                Console.Write("\nNacisnij dowolny przycisk aby wrocic...");
                Console.ReadKey();
                break;
            case 3:
                return;

        }
    }
}
void ShowControls() {
    Console.Clear();
    Console.WriteLine("Biblioteka");
    Console.WriteLine("\nWybierz opcje:");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("1. Dodaj");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("2. Edytuj");

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("3. Wyswietl");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("4. Zamknij program");

    Console.ResetColor();
}

void AddAuthor() {
    Console.Clear();
    string authorFirstName, authorLastName, authorCountry;

    ShowAuthors();

    Console.WriteLine("\nDodawanie autora:");

    Console.Write("Imie autora: ");
    authorFirstName = Console.ReadLine();

    Console.Write("Nazwisko autora: ");
    authorLastName = Console.ReadLine();

    Console.Write("Kraj pochodzenia autora: ");
    authorCountry = Console.ReadLine();

    authors[authorsCount] = new Author(authorFirstName, authorLastName, authorCountry);
    Console.WriteLine(authors[authorsCount].ReturnAuthor());

    authorsCount++;
}
void AddBook() {
    Console.Clear();
    int authorID, bookReleaseYear, bookPagesCount;
    string bookTitle, bookType, bookCountry;
    bool validInput;

    ShowAuthors();

    Console.WriteLine("\nDodawanie ksiazki");

    do {
        Console.Write("ID Autora: ");
    } while (!int.TryParse(Console.ReadLine(), out authorID));

    Console.Write("Tytul ksiazki: ");
    bookTitle = Console.ReadLine();

    if (bookTitle == null) {
        bookTitle = "";
    }

    Console.Write("Rodzaj ksiazki: ");
    bookType = Console.ReadLine();

    if (bookType == null) {
        bookType = "";
    }

    Console.Write("Kraj wydania ksiazki: ");
    bookCountry = Console.ReadLine();

    if (bookCountry == null) {
        bookCountry = "";
    }

    do {
        Console.Write("Rok wydania ksiazki: ");
    } while (!int.TryParse(Console.ReadLine(), out bookReleaseYear));

    do {
        Console.Write("Liczba stron: ");
    } while (!int.TryParse(Console.ReadLine(), out bookPagesCount));

    books[booksCount] = new Book(authors[authorID-1], bookTitle, bookType, bookCountry, bookReleaseYear, bookPagesCount);
    booksCount++;
}

void EditAuthor() {
    Console.Clear();
    string authorFirstNameNew, authorLastNameNew, authorCountryNew;
    int authorID;

    ShowAuthors();

    Console.WriteLine("\nKtorego autora chcesz edytowac:");

    do {
        Console.Write("ID Autora: ");
    } while (!int.TryParse(Console.ReadLine(), out authorID));

    Console.Write("Nowe imie autora: ");
    authorFirstNameNew = Console.ReadLine();

    if (authorFirstNameNew == null) {
        authorFirstNameNew = "";
    }

    Console.Write("Nowe nazwisko autora: ");
    authorLastNameNew = Console.ReadLine();

    if (authorLastNameNew == null) {
        authorLastNameNew = "";
    }

    Console.Write("Nowy kraj pochodzenia autora: ");
    authorCountryNew = Console.ReadLine();

    if (authorCountryNew == null) {
        authorCountryNew = "";
    }

    authors[authorID - 1].Update(authorFirstNameNew, authorLastNameNew, authorCountryNew);
}
void EditBook() {
    Console.Clear();
    int bookID, authorID, bookReleaseYearNew, bookPagesCountNew;
    string bookTitleNew, bookTypeNew, bookCountryNew;

    ShowBooks();
    ShowAuthors();

    Console.WriteLine("\nKtora ksiazke chcesz edytowac:");

    do {
        Console.Write("ID ksiazki: ");
    } while (!int.TryParse(Console.ReadLine(), out bookID));

    do {
        Console.Write("Nowe ID autora: ");
    } while (!int.TryParse(Console.ReadLine(), out authorID));

    Console.Write("Nowy tytul ksiazki: ");
    bookTitleNew = Console.ReadLine();

    if (bookTitleNew == null) {
        bookTitleNew = "";
    }

    Console.Write("Nowy typ ksiazki: ");
    bookTypeNew = Console.ReadLine();

    if (bookTypeNew == null) {
        bookTypeNew = "";
    }

    Console.Write("Nowy kraj wydania ksiazki: ");
    bookCountryNew = Console.ReadLine();

    if (bookCountryNew == null) {
        bookCountryNew = "";
    }

    do {
        Console.Write("Nowy rok wydania ksiazki: ");
    } while (!int.TryParse(Console.ReadLine(), out bookReleaseYearNew));

    do {
        Console.Write("Nowa ilosc stron ksiazki: ");
    } while (!int.TryParse(Console.ReadLine(), out bookPagesCountNew));


    books[bookID - 1].Update(authors[authorID - 1], bookTitleNew, bookTypeNew, bookCountryNew, bookReleaseYearNew, bookPagesCountNew);
}

void ShowAuthors() {
    if (authorsCount == 0) {
        Console.WriteLine("Brak autorow w bazie danych.");
    } else {
        Console.WriteLine("Autorzy w bazie danych:");
    }

    for (int i = 0; i < authorsCount; i++) {
        Console.WriteLine($"{i+1}. {authors[i].ReturnAuthor()}");
    }

    Console.WriteLine();
}
void ShowBooks() {
    if (booksCount == 0) {
        Console.WriteLine("Brak ksiazek w bazie danych.");
    } else {
        Console.WriteLine("Ksiazki w bazie danych:");
    }

    for (int i = 0; i < booksCount; i++) {
        Console.WriteLine($"{i + 1}. {books[i].ReturnBook()}");
    }

    Console.WriteLine();
}
