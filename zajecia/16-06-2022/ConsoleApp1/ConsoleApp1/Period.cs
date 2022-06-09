using System.Collections;

public class Period : IEnumerable{

    private DateTime dateTime1;
    private DateTime dateTime2;

    public Period(DateTime dateTime1, DateTime dateTime2) {
        this.dateTime1 = dateTime1;
        this.dateTime2 = dateTime2;
    }

    public IEnumerator GetEnumerator() {
        for (var date = dateTime1; date <= dateTime2; date = date.AddDays(1)) {
            yield return date;
        }
    }
}