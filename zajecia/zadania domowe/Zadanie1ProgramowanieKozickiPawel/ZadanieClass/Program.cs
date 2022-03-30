Phone[] osoba = new Phone[2];

osoba[0] = new Phone("Samsung", "nadawca", "952156127");
osoba[1] = new Phone("Xiaomi", "odbiorca", "425435216");

osoba[0].Show();
osoba[1].Show();

int osobaIndex = 0;

string[] texts = {
    "Cześć jak tam u ciebie?",
    "Bardzo dobrze, a tobie jak leci?",
    "U mnie też dobrze. Piszę, bo chciałem zapytać czy miałbyś może niepotrzebny kabel HDMI?",
    "No pewnie. Ale mam tylko 2m. Może być?",
    "Oczywiście. Porzebuję go tylko na 2 dni. Zaraz u ciebie będę."
};

Message[] messages = new Message[5];

for (int i = 0; i < texts.Length; i++) {
    if (osobaIndex == 0) {
        messages[i] = new Message(i, osoba[0].GetNumber(), osoba[1].GetNumber(), texts[i]);
        osobaIndex = 1;
    } else if (osobaIndex == 1) {
        messages[i] = new Message(i, osoba[1].GetNumber(), osoba[0].GetNumber(), texts[i]);
        osobaIndex = 0;
    }

    messages[i].Show();
}