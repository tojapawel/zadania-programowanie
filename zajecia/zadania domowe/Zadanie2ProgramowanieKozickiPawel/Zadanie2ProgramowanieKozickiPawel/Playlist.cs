internal class Playlist {
    int ID;
    Song Song;

    public Playlist(int iD, Song song) {
        ID = iD;
        Song = song;
    }

    public void SwapSong(Song song) {
        this.Song = song;
    }

    public void GetSong() {
        Console.WriteLine($"{Song.Name}, {Song.Artist}, {Song.Album}, {Song.Date}");
    }

    public void DisplayInfo() {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("ID: ");

        Console.ResetColor();
        Console.Write(this.ID + 1);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\tNazwa: ");

        Console.ResetColor();
        Console.Write(Song.Name);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" Wykonawca: ");

        Console.ResetColor();
        Console.Write(Song.Artist);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" Album: ");

        Console.ResetColor();
        Console.Write(Song.Album);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" Data wydania: ");

        Console.ResetColor();
        Console.Write(Song.Date);

        Console.WriteLine();
    }
}