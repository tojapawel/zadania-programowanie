using System.Configuration;

var myConnString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
var albumClass = new Album();
albumClass.Open(myConnString);

bool ifExit = false, verified = false;
int choice;

while (true && ifExit != true) {
    DisplayInfo();

    Console.Write("Wybierz: ");

    while (verified = int.TryParse(Console.ReadLine(), out choice) == false) {
        Console.Write("Blad! Wybierz ponownie: ");
    }
    

    switch (choice) {
        case 1:
            AddSong();
            break;
        case 2:
            RemoveSong();
            break;
        case 3:
            UpdateSong();
            break;
        case 4:
            ShowSongs();
            break;
        case 5:
            ifExit = true;
            break;
        default:
            Console.WriteLine("Blad");
            break;
    }
}

albumClass.Close();

void ShowSongs() {
    Console.Clear();
    Console.WriteLine("Piosenki:");

    albumClass.ShowSongs();

    Console.Write("Kliknij dowolny przycisk aby kontunuować...");
    Console.ReadKey();
}
void UpdateSong() {
    Console.Clear();
    Console.WriteLine("Edytowanie piosenki.");

    albumClass.ShowSongs();

    Console.Write("Podaj id piosenki do edycji: ");
    var songID = int.Parse(Console.ReadLine());

    Console.Write("Podaj nowy tytul: ");
    var title = Console.ReadLine();

    Console.Write("Podaj nowego autora: ");
    var author = Console.ReadLine();

    Console.Write("Podaj nowy album: ");
    var album = Console.ReadLine();

    Console.Write("Podaj nowa date wydania: ");
    var date = Console.ReadLine();

    albumClass.UpdateSong(songID, title, author, album, date);
}
void RemoveSong() {
    Console.Clear();
    Console.WriteLine("Usuwanie piosenki z albumu.");

    albumClass.ShowSongs();

    Console.Write("Podaj id piosenki do usuniecia: ");
    var songID = int.Parse(Console.ReadLine());

    albumClass.RemoveSong(songID);
}
void AddSong() {
    Console.Clear();
    Console.WriteLine("Dodawanie nowej piosenki.");

    Console.Write("Podaj tytul: ");
    var title = Console.ReadLine();

    Console.Write("Podaj autora (autorow - oddzielone przecinkami): ");
    var author = Console.ReadLine();

    Console.Write("Podaj album: ");
    var album = Console.ReadLine();

    Console.Write("Podaj date (DD-MM-YYYY): ");
    var date = Console.ReadLine();

    albumClass.AddSong(title, author, album, date);
}
void DisplayInfo() {
    Console.Clear();
    Console.WriteLine("Opcje");
    Console.WriteLine("1. Dodaj piosenke");
    Console.WriteLine("2. Usun piosenke");
    Console.WriteLine("3. Edytuj piosenke");
    Console.WriteLine("4. Wyswietl piosenki");
    Console.WriteLine("5. Zakoncz\n");
}