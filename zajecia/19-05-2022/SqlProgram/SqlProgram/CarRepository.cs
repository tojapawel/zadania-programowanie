using Microsoft.Data.Sqlite;

internal class CarRepository {

    private SqliteConnection _sqliteConnection = new SqliteConnection();

    public void Open(string connetcionString) {
        _sqliteConnection.ConnectionString = connetcionString;
        _sqliteConnection.Open();
    }

    public void Close() { 
        _sqliteConnection.Close();
    }

    public void AddNewCar(string brand, string petName, string color) {
        var sqlQuerry = $"INSERT INTO car (car_id, brand, petName, color) VALUES (null, '{brand}', '{petName}', '{color}')";

        using (var command = new SqliteCommand(sqlQuerry, _sqliteConnection)) {
            command.ExecuteNonQuery();
        }
    }

    public void DeleteCar(int car_id) {
        var sqlQuerry = $"DELETE FROM car WHERE `car_id` = '{car_id}'";

        using (var command = new SqliteCommand(sqlQuerry, _sqliteConnection)) {
            command.ExecuteNonQuery();
        }
    }

    public void UpdateCar(int car_id, string brand, string petName, string color) {
        var sqlQuerry = $"UPDATE car SET `brand` = '{brand}', `petName` = '{petName}', `color` = '{color}' WHERE `car_id` = '{car_id}'";

        using (var command = new SqliteCommand(sqlQuerry, _sqliteConnection)) {
            command.ExecuteNonQuery();
        }
    }

    public void ShowCars() {
        var sqlQuerry = "SELECT * FROM car";

        using var cmd = new SqliteCommand(sqlQuerry, _sqliteConnection);
        using SqliteDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read()) {
            Console.WriteLine($"\nid: {rdr.GetInt32(0)}\nbrand: {rdr.GetString(1)}\npetName: {rdr.GetString(2)}\ncolor: {rdr.GetString(3)}\n");
        }
    }

}
