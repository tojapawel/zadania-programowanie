using System.Collections;

public class CustomerFirstNameComparer : IComparer {
    public int Compare(object x, object y) {
        if (x is Customer xCustomer && y is Customer yCustomer) {
            return xCustomer.FirstName.CompareTo(yCustomer.FirstName);
        }

        return -1;
    }
}
