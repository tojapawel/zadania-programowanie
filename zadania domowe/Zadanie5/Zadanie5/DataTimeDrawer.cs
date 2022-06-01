public class DataTimeDrawer {
    private DateTime _startDate;
    private DateTime _endDate;

    public DataTimeDrawer(DateTime startDate, DateTime endDate) {
        _startDate = startDate;
        _endDate = endDate;
    }

    public void DrawDate() {
        int dayCount = (int)(_endDate - _startDate).TotalDays;

        var currDate = _startDate;

        DateTime[] daysDateTime = new DateTime[dayCount];
        string[] days = new string[dayCount];


        for (int i = 0; i < dayCount; i++) {
            daysDateTime[i] = currDate;
            days[i] = daysDateTime[i].ToShortDateString();

            currDate = currDate.AddDays(1);
        }

        foreach (var item in days) {
            Console.WriteLine(item);
        }
    }
}
