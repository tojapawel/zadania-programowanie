Playlist[] playlist = new Playlist[100];
int songIndex = 0;

bool validChoice = false;
int choice;

while (true) {
    Console.Clear();
    Console.WriteLine("Wybierz opcję: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("1. Dodaj piosenke");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("2. Edytuj piosenke");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("3. Wyswietl playliste");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("4. Zakoncz dzialanie programu");
    Console.ResetColor();

    Console.Write("\nTwoj wybor: ");

    validChoice = int.TryParse(Console.ReadLine(), out choice);

    switch (choice) {
        case 1:
            NewSong();
            break;
        case 2:
            EditSongShow();
            break;
        case 3:
            ShowPlaylist(playlist);
            break;
        case 4:
            Environment.Exit(0);
            break;
    }
}

void NewSong() {
    Console.Clear();
    string name, artist, album, date;

    Console.WriteLine("Dodaj nowa piosenke: \n");

    Console.Write("Nazwa piosenki: ");
    name = Console.ReadLine();

    Console.Write("Wykonawca piosenki: ");
    artist = Console.ReadLine();

    Console.Write("Album: ");
    album = Console.ReadLine();

    Console.Write("Data wydania piosenki (DD.MM.RRRR): ");
    date = Console.ReadLine();

    playlist[songIndex] = new Playlist(songIndex, new Song(name, artist, album, date));
    songIndex++;
}

void EditSongShow() {
    Console.Clear();

    Console.WriteLine("Edytuj piosenke: ");

    Console.WriteLine("#. zamist '#' podaj numer piosenki do edycji");
    Console.WriteLine("x. Wroc do poczatku");

    Console.Write("\nTwoj wybor: ");

    bool editValidChoice;
    int editChoice;

    editValidChoice = int.TryParse(Console.ReadLine(), out editChoice);

    switch (editValidChoice) {
        case false:
            Console.WriteLine("x");
            break;
        case true:
            EditSong(editChoice);
            break;
    }

}

void EditSong(int songIndex) {
    Console.Clear();

    string name, artist, album, date;

    Console.WriteLine("Podaj informacje o nowej piosence:\n");

    Console.Write("Nazwa piosenki: ");
    name = Console.ReadLine();

    Console.Write("Wykonawca piosenki: ");
    artist = Console.ReadLine();

    Console.Write("Album: ");
    album = Console.ReadLine();

    Console.Write("Data wydania piosenki (DD.MM.RRRR): ");
    date = Console.ReadLine();

    playlist[songIndex - 1].SwapSong(new Song(name, artist, album, date));

}

void ShowPlaylist(Playlist[] songss) {
    Console.Clear();

    int tempI = 0;
    Console.WriteLine($"Playlista (ilosc: {songIndex}): \n");

    while (tempI < songIndex) {
        playlist[tempI].DisplayInfo();
        tempI++;
    }

    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\n\nNacisnij dowolny przycisk aby wrocic...");
    Console.ReadKey();
    Console.ResetColor();
}