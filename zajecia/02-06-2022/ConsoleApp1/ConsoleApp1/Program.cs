using System.Collections;

var p1 = new Point(5, 10);
var p2 = (Point)p1.Clone();

Console.WriteLine(p1);
Console.WriteLine(p2);
p2.X = 25;
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.ReadLine();







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