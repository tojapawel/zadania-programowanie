using System;
using System.Collections;

namespace FunWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            var myObject = new DataTimeDrawer(new DateTime(2000, 3, 5), new DateTime(2000, 5, 31));

            foreach (var item in myObject)
            {
                Console.WriteLine(item);
            }

            //2000:03:05 - pon
            //2000:03:06 - wt
            //2000:03:07
            //....
            //2000:03:31
            //2000:04:01
            //2000:04:02
            //2000:04:03
            //...
            //2000:04:30
            //2000:05:01


            //var container = new ShapeCollection();
            //foreach (var item in container)
            //{
            //    ((IShape)item).Draw();
            //}
            //Console.WriteLine(new string('-', 40));

            //var enumerator = container.GetEnumerator();
            ////while (enumerator.MoveNext())
            ////{
            ////    IShape currentShape = (IShape)enumerator.Current;
            ////    currentShape.Draw();
            ////}
            //Console.WriteLine(new string('-', 40));

        }

        private static void Print(IShape shape)
        {
            
            shape.Draw();
        }
        private static void Print3D(IShape3D shape)
        {

            shape.Draw3D();
        }

        private static void PrintInfo(IShape shape)
        {
            if(shape is Circle circle)
            {
                Console.WriteLine("Circle!!!!");
                circle.Draw();
            }
            else if(shape is Rec rec)
            {
                Console.WriteLine("Rec");
                rec.Draw();
            }
            else
            {
                Console.WriteLine("nie wiem co to!");
            }

        }
    }

    public interface IShape
    {
        void Draw();
    }

    public interface IShape3D : IShape
    {
        void Draw3D();
    }

    public class Circle : IShape
    {
        public Circle()
        {

        }


        public void Do()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            Console.WriteLine("Rysuje koło");
        }
   }

    public class Rec : IShape
    {
        public Rec()
        {

        }

        public void Draw()
        {
            Console.WriteLine("Rysuje prostokont");
        }
    }

    public class Hexagon : IShape3D
    {
        public void Draw()
        {
            Console.WriteLine("Hexagon draw");
        }

        public void Draw3D()
        {
            Console.WriteLine("Hexagon draw 3d");
        }
    }

    public class ShapeCollection : IEnumerable
    {
        private readonly IShape[] _shapes;
        public ShapeCollection()
        {
            _shapes = new IShape[5]
            {
                new Circle(),
                new Rec(),
                new Hexagon(),
                new Rec(),
                new Hexagon()
            };
        }

        public IEnumerator GetEnumerator()
        {
            return new SomeClass(_shapes);
        }
    }

    public class SomeClass : IEnumerator
    {
        private readonly IShape[] _shapes;
        private int _index = -1;

        public SomeClass(IShape[] shapes)
        {
            _shapes = shapes;
        }

        public object Current
        {
            get
            {
                Console.WriteLine("*** current ***");
                return _shapes[_index];
            }
        }

        public bool MoveNext()
        {
            Console.WriteLine("*** MoveNext ***");


            _index++;
            if(_index <_shapes.Length)
            {
                return true;
                
            }
            return false;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
