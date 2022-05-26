//przyklad z person

/*var person1 = new Pracownik("Adam");
var person2 = new Klient("Marek");

Show(person1);
Show(person2);

static void Show(IPerson person) {
    person.ShowInfo();
}*/


//przyklad z ksztalt

var c1 = new Circle();
var c2 = new Circle();

var r1 = new Rectangle();

IShape[] shapes = new IShape[2];
shapes[0] = c1;
shapes[1] = c2;

foreach (var item in shapes) {
    Print(item);
}

static void Print(IShape shape) {
    if (shape is Circle circle) {
        Console.WriteLine("Circle");
        circle.Draw();
    } else if (shape is Rectangle rectangle) {
        Console.WriteLine("Rectangle");
        rectangle.Draw();
    } else {
        Console.WriteLine("nie wiem co to");
    }
}



//przyklad z shape3D, dziedziczenie po interface

var hex1 = new Hexagon();
var hex2 = new Hexagon();

IShape3D[] shapes3Ds = new IShape3D[2];
shapes3Ds[0] = hex1;
shapes3Ds[1] = hex2;

foreach (var item in shapes3Ds) {
    Show3D(item);
}

static void Show3D(IShape3D shape3d) {
    shape3d.Draw3D();
}


//wersja 1
var container = new ShapeCollection();
foreach (var item in container) {
    ((IShape)item).Draw();
}

//wersja 2
var enumerator = container.GetEnumerator();
while (enumerator.MoveNext()) { 
    IShape currentShape = (IShape)enumerator.Current;
    currentShape.Draw();
}

//wersja 1 i 2 dzialaja dokladnie tak samo