var employees = GetAllEmployeesDb();
Console.WriteLine(new string('-', 30));
foreach (var item in employees) {
    Console.WriteLine(item);
}

static Employee[] GetAllEmployeesDb() {
    var lenght = 100;
    var array = new Employee[lenght];

    for (int i = 0; i < lenght; i++) {
        Console.WriteLine("-> " + i);
        array[i] = new Employee(i+100, "Test " + i);
    }
    return array;
}

