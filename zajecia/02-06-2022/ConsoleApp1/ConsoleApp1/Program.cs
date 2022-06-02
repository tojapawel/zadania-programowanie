using System.Collections;

var employees = GetAllEmployeesDb();
Console.WriteLine(new string('-', 30));
foreach (var item in employees) {
    if (((Employee)item).ID < 115) {
        Console.WriteLine(item);
    } else {
        break;
    }
}

static IEnumerable GetAllEmployeesDb() {
    for (int i = 0; i < 100; i++) {
        yield return new Employee(i + 100, "Test " + i);
        Console.WriteLine("-> " + i);
    }
}