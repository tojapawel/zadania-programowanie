using System.Collections;

var myArray = new ArrayList();

for (int i = 0; i < 10; i++) {
    myArray.Add( new Person { Name = "test" + i });
}
myArray.Add(5);
myArray.RemoveAt(5);
foreach (var item in myArray) {
    Console.WriteLine(((Person)item).Name);
}

public class MyBookLibrary {
    private ArrayList _myBooks;

    public MyBookLibrary() {
        _myBooks = new ArrayList();
    }

    public void Add(Person person) {
        _myBooks.Add(person);
    }
    public Person GetPersonFormPosition(int pos) {
        var result = _myBooks[pos];
        return (Person)result;
    }

}