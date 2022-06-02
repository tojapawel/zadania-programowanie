public class Customer : IComparable{
    public Customer(int iD, string firstName, int age) {
        ID = iD;
        FirstName = firstName;
        Age = age;
    }

    public int ID { get; set; }
    public string FirstName { get; set; }
    public int Age { get; set; }

    public int CompareTo(object obj) {
        if (obj is Customer customer) {
            if (Age > customer.Age) {
                return 1;
            }else if(Age == customer.Age){
                return -1;
            }else{
                return -1;
            }
        } else {
            return -1;
        }
    }

    public override string ToString() {
        return $"ID: {ID}, Name: {FirstName}, Age: {Age}";
    }
}