using System.Configuration;

var myConnString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
var carRepo = new CarRepository();
carRepo.Open(myConnString);


while (true) {
    DisplayInfo();
    Console.Write("Wybierz: ");
    var res = int.Parse(Console.ReadLine());

    switch (res) {
        case 1:
            InsertNewCar();
            break;
        case 2:
            RemoveCar();
            break;
        case 3:
            UpdateCar();
            break;
        case 4:
            ShowCars();
            break;
        default:
            Console.WriteLine("Blad");
            break;
    }
}

carRepo.Close();

void RemoveCar() {
    Console.Clear();
    Console.WriteLine("Usuwanie samochodu.");

    Console.Write("Podaj id samochodu do usuniecia: ");
    var car_id = int.Parse(Console.ReadLine());


    //usuwanie z bazy danych

    carRepo.DeleteCar(car_id);
}

void InsertNewCar() {
    Console.Clear();
    Console.WriteLine("Dodawanie nowego samochodu.");

    Console.Write("Podaj brand: ");
    var brand = Console.ReadLine();

    Console.Write("Podaj petName: ");
    var pet_name = Console.ReadLine();

    Console.Write("Podaj color: ");
    var color = Console.ReadLine();


    //dodawanie do bazy danych

    carRepo.AddNewCar(brand, pet_name, color);

}

void UpdateCar() {
    Console.Clear();
    Console.WriteLine("Edytowanie samochodu.");

    Console.Write("Podaj id samochodu do edycji: ");
    var car_id = int.Parse(Console.ReadLine());

    Console.Write("Podaj nowy brand: ");
    var brand = Console.ReadLine();

    Console.Write("Podaj nowy petName: ");
    var pet_name = Console.ReadLine();

    Console.Write("Podaj nowy color: ");
    var color = Console.ReadLine();


    //update do bazy danych

    carRepo.UpdateCar(car_id, brand, pet_name, color);

}

void ShowCars() {
    Console.Clear();
    Console.WriteLine("Samochody:");

    carRepo.ShowCars();
    Console.Write("Kliknij cokolwiek aby kontynuowac: ");
    Console.ReadKey();
}

void DisplayInfo() {
    Console.Clear();
    Console.WriteLine("Opcje");
    Console.WriteLine("1. Dodaj");
    Console.WriteLine("2. Usun");
    Console.WriteLine("3. Edytuj");
    Console.WriteLine("4. Wyswietl");
}