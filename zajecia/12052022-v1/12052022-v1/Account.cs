public class Account {
    private static decimal _rate;

    static Account() {
        Console.WriteLine("Jestem w konstruktorze statycznym.");

        //pobieram zmienna z bazy danych
        _rate = .4m;
    }

    public Account(decimal balance) {
        Balance = balance;
    }

    public decimal Balance { get; }

    public decimal GetBalance() {
        return Balance * _rate;
    }

    public static decimal GetRate() {
        return _rate;
    }

    public static void SetRate(decimal newRate) {
        _rate = newRate;
    }

    public decimal GetRateObj() {
        return _rate;
    }

    public void SetRateObj(decimal newRate) {
        _rate = newRate;
    }
}