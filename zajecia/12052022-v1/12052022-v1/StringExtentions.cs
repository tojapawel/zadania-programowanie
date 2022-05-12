public static class StringExtentions {
    public static string WielkimiLiterami(this string value) {
        return value.ToUpper();
    }

    public static string DwaRazy(this string value) {
        return value + " " + value;
    }

    public static string WieleRazy(this string value, int count) {
        var res = value;

        for (int i = 0; i < count-1; i++) {
            res += value;
        }

        return res;
    }

    public static int GetCount(this string value) {
        return value.Count();
    }
}
