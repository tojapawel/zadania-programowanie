using System.Collections;

public class ShapeCollection : IEnumerable {

    private readonly IShape[] _shapes;

    public ShapeCollection() {
        _shapes = new IShape[5] {
            new Circle(),
            new Rectangle(),
            new Hexagon(),
            new Rectangle(),
            new Hexagon()
        };
    }

    public IEnumerator GetEnumerator() {
        return _shapes.GetEnumerator();
    }
}
