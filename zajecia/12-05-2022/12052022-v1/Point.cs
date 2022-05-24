public class Point {
    int _x, _y;

    public Point(int x, int y) {
        _x = x;
        _y = y;
    }

    //jawna
/*    public static explicit operator int(Point point) {
        return point._x;
    }*/


    //niejawna
    public static implicit operator int(Point point) {
        return point._x;
    }

    public static Point operator + (Point a, Point b) { 
        return new Point(a._x + b._x, a._y + b._y); 
    }

    public static Point operator -(Point a, Point b) {
        return new Point(a._x - b._x, a._y - b._y);
    }

    public static Point operator *(Point a, Point b) {
        return new Point(a._x * b._x, a._y * b._y);
    }

    public static bool operator ==(Point a, Point b) {
        if (a._x == b._x && a._y == b._y) {
            return true;
        }
        return false;
    }

    public static bool operator !=(Point a, Point b) {
        if (a._x != b._x && a._y != b._y) {
            return true;
        }
        return false;
    }

    public override string ToString() {
        return $"[({_x},{_y})]";
    }
}