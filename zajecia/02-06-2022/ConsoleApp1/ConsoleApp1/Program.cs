using System.Collections;

Customer[] customers = new Customer[10] {
    new Customer(1, "BTest", 25),
    new Customer(2, "CTest", 10),
    new Customer(3, "GTest", 32),
    new Customer(4, "ZTest", 68),
    new Customer(5, "RTest", 8),
    new Customer(6, "ETest", 30),
    new Customer(7, "UTest", 23),
    new Customer(8, "ITest", 32),
    new Customer(9, "KTest", 68),
    new Customer(10, "FTest", 384)
};

foreach (var item in customers) {
    Console.WriteLine(item);
}

Array.Sort(customers);

foreach (var item in customers) {
    Console.WriteLine(item);
}


//IEnum();
static IEnumerable GetAllEmployeesDb() {
    for (int i = 0; i < 100; i++) {
        yield return new Employee(i + 100, "Test " + i);
        Console.WriteLine("-> " + i);
    }
}
static void IEnum() {
    var employees = GetAllEmployeesDb();
    Console.WriteLine(new string('-', 30));
    foreach (var item in employees) {
        if (((Employee)item).ID < 115) {
            Console.WriteLine(item);
        } else {
            break;
        }
    }
}

//Clone();
static void Clone() {
    var p1 = new Point(5, 10);
    var p2 = (Point)p1.Clone();

    Console.WriteLine(p1);
    Console.WriteLine(p2);
    p2.X = 25;
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.ReadLine();
}

//AdvancedClone();
static void AdvancedClone() {
    var d1 = new Device(1, "Test", 69, new Battery(1, 100));
    var d2 = (Device)d1.Clone();

    Console.WriteLine(d1);
    Console.WriteLine(d2);

    d2.Name = "Nowy";
    d2.Battery.Power = 120;

    Console.WriteLine(d1);
    Console.WriteLine(d2);
}