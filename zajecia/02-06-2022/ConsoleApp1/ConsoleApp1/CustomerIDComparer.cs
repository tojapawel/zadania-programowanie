using System.Collections;

public class CustomerIDComparer : IComparer{
    public int Compare(object x, object y) {
        if (x is Customer xCustomer && y is Customer yCustomer) {
            return xCustomer.ID > yCustomer.ID ? -1 : xCustomer.ID == yCustomer.ID ? 0 : -1;
        }

        return -1;
    }
}