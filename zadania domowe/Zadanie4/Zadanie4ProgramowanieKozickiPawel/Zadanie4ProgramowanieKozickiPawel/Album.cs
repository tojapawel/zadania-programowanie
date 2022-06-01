using Microsoft.Data.Sqlite;

internal class Album {
    private SqliteConnection _sqliteConnection = new SqliteConnection();

    public void Open(string connetcionString) {
        _sqliteConnection.ConnectionString = connetcionString;
        _sqliteConnection.Open();
    }

    public void Close() {
        _sqliteConnection.Close();
    }

    public void AddSong(string title, string author, string album, string date) {
        var sqlQuerry = $"INSERT INTO songs VALUES (null, '{title}', '{author}', '{album}', '{date}');";

        using (var command = new SqliteCommand(sqlQuerry, _sqliteConnection)) {
            command.ExecuteNonQuery();
        }
    }

    public void ShowSongs() {
        var sqlQuerry = "SELECT * FROM songs";

        using var command = new SqliteCommand(sqlQuerry, _sqliteConnection);
        using SqliteDataReader rdr = command.ExecuteReader();

        while (rdr.Read()) {
            Console.WriteLine($"\nid: {rdr.GetInt32(0)}\ntitle: {rdr.GetString(1)}\nauthor: {rdr.GetString(2)}\nalbum: {rdr.GetString(3)}\nreleaseDate: {rdr.GetString(4)}\n");
        }
    }

    public void RemoveSong(int songID) {
        var sqlQuerry = $"DELETE FROM songs WHERE `ID` = '{songID}'";

        using (var command = new SqliteCommand(sqlQuerry, _sqliteConnection)) {
            command.ExecuteNonQuery();
        }
    }

    public void UpdateSong(int songID, string? title, string? author, string? album, string? date) {
        var sqlQuerry = $"UPDATE songs SET `title` = '{title}', `author` = '{author}', `album` = '{album}', `releaseDate` = '{date}' WHERE `ID` = '{songID}'";

        using (var command = new SqliteCommand(sqlQuerry, _sqliteConnection)) {
            command.ExecuteNonQuery();
        }
    }
}