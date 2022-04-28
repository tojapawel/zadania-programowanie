//zad1

var prostokaty = new Prostokat[3];

prostokaty[0] = new Prostokat(2, 5);
prostokaty[1] = new Prostokat(3, 6);
prostokaty[2] = new Prostokat(4, 4);

foreach (var prostokat in prostokaty) {
    prostokat.Prezentuj();
}