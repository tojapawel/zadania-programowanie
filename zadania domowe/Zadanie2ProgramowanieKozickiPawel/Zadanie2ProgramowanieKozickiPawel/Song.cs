internal class Song {
    public string Name, Artist, Album, Date;

    public Song(string name, string artist, string album, string date) {
        Name = name;
        Artist = artist;
        Album = album;
        Date = date;
    }

    public void DisplaySong() {
        Console.WriteLine($"{Name}, {Artist}, {Album}, {Date}");
    }
}