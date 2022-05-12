public static class Teenager {
    private static Random random = new Random();

    public static string GetMessage() {
        string[] messages = { "I'm tired!", "yes", "no", "maybe"};

        return messages[random.Next(4)];
    }
} 