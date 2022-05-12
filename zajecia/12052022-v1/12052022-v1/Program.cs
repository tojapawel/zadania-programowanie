/*StaticBasic();*/
using System.Collections;

static void StaticBasic() {
    for (int i = 0; i < 7; i++) {
        Console.WriteLine(Teenager.GetMessage());
    }

    Console.WriteLine(new string('-', 30));

    Console.WriteLine("Pobranie rate ze zmiennej statycznej {0}", Account.GetRate());
    var account = new Account[] {
    new Account(10),
    new Account(35),
    new Account(42),
    new Account(1000.4m),
    new Account(70)
};

    foreach (var item in account) {
        Console.WriteLine(item.GetBalance());
    }

    Console.WriteLine(new string('-', 30));

    Console.WriteLine("Static rate from static method: {0}", Account.GetRate());
    Console.WriteLine("Set rate by static method to 1.7");
    Account.SetRate(1.7m);
    Console.WriteLine("Static rate from static method: {0}", Account.GetRate());

    Console.WriteLine(new string('-', 30));

    foreach (var item in account) {
        Console.WriteLine(item.GetRateObj());
    }

    Console.WriteLine("Set rate by instances method");
    account[0].SetRateObj(1.0m);
    account[1].SetRateObj(2.0m);
    account[2].SetRateObj(3.0m);
    account[3].SetRateObj(4.0m);
    account[4].SetRateObj(5.0m);
    var newAccount = new Account(123m);

    Console.WriteLine("rate for 1: {0}", account[0].GetRateObj());
    Console.WriteLine("rate for 2: {0}", account[1].GetRateObj());
    Console.WriteLine("rate for 3: {0}", account[2].GetRateObj());
    Console.WriteLine("rate for 4: {0}", account[3].GetRateObj());
    Console.WriteLine("rate for 5: {0}", account[4].GetRateObj());
}

/*var name = "Pawel";
Console.WriteLine(name.WielkimiLiterami().DwaRazy());

Console.WriteLine(name.WieleRazy(3));
Console.WriteLine(name.GetCount());


var p1 = new Point(2, 15);
var p2= new Point(7, 12);

var a = "jacek";
var b = "john";

Console.WriteLine(a == b);
Console.WriteLine(a + b);

Console.WriteLine(p1 + p2);
Console.WriteLine(p1 - p2);
Console.WriteLine(p1 * p2);

Console.WriteLine(p1 == p2);
Console.WriteLine(p1 != p2);


Console.WriteLine();

var array = new ArrayList();
array.Add(new Point(1, 1));

var firstPoint = array[0];

var myFloat = 1.7f;
int myInt = (int)myFloat;


C1 c1 = new C1();
C2 c2 = new C2();
C3 c3 = new C3();

object obj = c1;
C1 c11 = (C1)obj;

C1 c111 = c3;
c3 = (C3)c1;*/


var p1 = new Point(100, 10);
int a = (int)p1;

Console.WriteLine(a);