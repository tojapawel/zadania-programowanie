var pracownik = new Pracownik("Adam", "Kowalski", 32, 200, StanCywilny.Kawaler, Plec.Kobieta,
    "Nazwadruzyny", null, 10, 3100, PoziomUprawnien.A1);

var klient = new Klient("Patryk", "Kozicki", 21, 168, StanCywilny.Kawaler, Plec.Kobieta);

var superKlient = new SuperKlient("Paweł", "Kozicki", 21, 168, StanCywilny.Kawaler, Plec.Mazczyzna);

var myLudzie = new Czalowiek[5] { pracownik, pracownik, klient, superKlient, klient };

/*var czlowiek = new Czalowiek("Piotr", "Nowak", 55, 174, StanCywilny.Żonaty, Plec.Mazczyzna);

var czlowiek2 = Czalowiek.CreateCzlowiek("Piotr", "Nowak", 55, 174, StanCywilny.Żonaty, Plec.Mazczyzna);
*/

useAbstractMethod(klient);
useAbstractMethod(pracownik);
useAbstractMethod(superKlient);

useAbstractMethodTwo(klient);
useAbstractMethodTwo(pracownik);
useAbstractMethodTwo(superKlient);

void useAbstractMethod(Czalowiek czlowiekA) {
    czlowiekA.MySuperMethod();
}

void useAbstractMethodTwo(Czalowiek czlowiekA) {
    czlowiekA.MySuperMethodTwo();
}

/*GetLudzie(myLudzie);


void GetLudzie(Czalowiek[] czlowieks) {
    foreach (var item in czlowieks) {
        if (item is SuperKlient) {
            var prefix = item.Plec == Plec.Mazczyzna ? "Pan" : "Pani";
            Console.WriteLine($"{prefix} SuperKlient {item.FirstName}");
        } else if (item is Klient) {
            var prefix = item.Plec == Plec.Mazczyzna ? "Pan" : "Pani";
            Console.WriteLine($"{prefix} klient {item.FirstName}");
        } else if (item is Pracownik) {
            var prefix = item.Plec == Plec.Mazczyzna ? "Pan" : "Pani";
            Console.WriteLine($"{prefix} pracownik {item.FirstName}");
        } 
    }
}*/



void DisplayInfo(Czalowiek variable) {
    Console.WriteLine(variable.GetType().Name);
}

















/*Console.WriteLine("pracownk");
Console.WriteLine(pracownik is object);     //true
Console.WriteLine(pracownik is Pracownik);  //true
Console.WriteLine(pracownik is Klient);     //false
Console.WriteLine(pracownik is Czalowiek);  //true

Console.WriteLine("\nKlient");
Console.WriteLine(klient is object);        //true
Console.WriteLine(klient is Pracownik);     //false
Console.WriteLine(klient is Klient);        //true
Console.WriteLine(klient is Czalowiek);     //true

Console.WriteLine("\nCzlowiek");

Console.WriteLine(czlowiek is object);      //true
Console.WriteLine(czlowiek is Pracownik);   //false
Console.WriteLine(czlowiek is Klient);      //false
Console.WriteLine(czlowiek is Czalowiek);   //true*/



