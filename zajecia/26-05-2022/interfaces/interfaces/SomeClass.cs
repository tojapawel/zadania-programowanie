using System.Collections;

public class SomeClass : IEnumerator {

    private readonly IShape[] _shapes;
    private int _index = -1;

    public SomeClass(IShape[] shapes) {
        _shapes = shapes;
    }

    public object Current {
        get {
            Console.WriteLine("*** current ***");
            return _shapes[_index];
        }
    }

    public bool MoveNext() {
        Console.WriteLine("*** moveNext ***");

        _index++;
        if (_index < _shapes.Length) {
            return true;
        } else {
            return false;
        }
    }

    public void Reset() {
        _index = -1;
    }
}
