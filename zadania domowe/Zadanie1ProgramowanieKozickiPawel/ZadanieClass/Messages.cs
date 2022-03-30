using System;

public class Message{
	int id;

	string senderNumber;
	string receiverNumber;

	string content;

	DateTime sendTime = DateTime.Now;

	public Message(int idA, string senderNumberA, string receiverNumberA, string contentA) {
		id = idA;
		senderNumber = senderNumberA;
		receiverNumber = receiverNumberA;
		content = contentA;
	}

	public void Show() {
        Console.WriteLine($"\n[ ID: {this.id}, Nadawca: {this.senderNumber}, Odbiorca: {this.receiverNumber}, Czas wysłania: {this.sendTime} ]");
        Console.WriteLine($"Wiadomość: {this.content}");
	}
}