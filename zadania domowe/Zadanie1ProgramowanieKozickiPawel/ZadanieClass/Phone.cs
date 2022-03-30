using System;

public class Phone{
	string model;
	string personType;
	string number;

	public Phone(string modelA, string personTypeA, string numberA){
		model = modelA;
		personType = personTypeA;
		number = numberA;
	}

	public string GetModel() {
		return model;
	}

	public string GetPersonType() {
		return personType;
	}

	public string GetNumber() {
		return number;
    }

	public void Show() {
		Console.WriteLine($"\nModel: {this.model}, Opis: {this.personType}, Numer: {this.number}");
    }
}
