//zad2

float start = 0, actual = 0;
bool validStart = false, validActual = false;


while (!validStart) {
    Console.Write("Podaj poczatkowy stan licznika: ");
    validStart = float.TryParse(Console.ReadLine(), out start);
    if (!validStart) {
        Console.WriteLine("Podano bledna liczbe");
    }
}

while (!validActual) {
    Console.Write("Podaj aktualny stan licznika: ");
    validActual = float.TryParse(Console.ReadLine(), out actual);
    if (!validActual) {
        Console.WriteLine("Podano bledna liczbe");
    }
}

Console.Clear();

var licznik = new Energy(start, actual);

licznik.GetInfo();
licznik.EnergyUsed();