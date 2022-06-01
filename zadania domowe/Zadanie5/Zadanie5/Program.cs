Console.Write("Podaj date poczatkowa (YYYY,MM,DD): ");
var startDateString = Console.ReadLine();

Console.Write("Podaj date koncowa (YYYY,MM,DD): ");
var endDateString = Console.ReadLine();

int[] startDate = new int[3];
int[] endDate = new int[3];

for (int i = 0; i < 3; i++) {
    startDate[i] = int.Parse(startDateString.Split('\u002C')[i]);
    endDate[i] = int.Parse(endDateString.Split('\u002C')[i]);
}

var date = new DataTimeDrawer(new DateTime(startDate[0], startDate[1], startDate[2]), new DateTime(endDate[0], endDate[1], endDate[2]));

date.DrawDate();