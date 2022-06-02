public class Point : ICloneable{
    public Point(int x, int y) {
        X = x;
        Y = y;
    }

    public int X { get; set; }
    public int Y { get; set; }

    public object Clone() {
        // lub: return new Point(X, Y);
        return this.MemberwiseClone();
    }

    public override string ToString() {
        return $"x: {X}, y: {Y}";
    }
}
