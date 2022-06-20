Period p1 = new Period(new DateTime(2002,02,13), new DateTime(2003,10,20));

foreach(DateTime date in p1) {
    Console.WriteLine(date.ToShortDateString());
}