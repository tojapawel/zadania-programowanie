//data i godzina - poziom logowania, klasa, metoda, linijka, message

using AP.Logger;

public class Matematyka {
    private MyLogger _logger;

    public Matematyka(MyLogger logger) {
        _logger = logger;
    }

    public int Dodawanie(int a, int b) {
        _logger.LogInformation($"parametry a = {a}, b = {b}");
        return a + b;
    }
    public int Podziel(int a, int b) {
        _logger.LogInformation($"parametry a = {a}, b = {b}");
        try
        {
            return a / b;
        }
        catch(Exception exception)
        {
            //_logger.LogError("blad: " + exception.Message);
            throw exception;
        }
    }
}