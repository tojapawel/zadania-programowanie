int x=0, y=1, z=2, i=0, j;

while (i < 5) {
    j = 0;
    while (j < 5) {
        if (j % 2 == 0) {
            if (j == 1 || j == 3) {
                Console.WriteLine(x);
            } else {
                Console.WriteLine(z);
            }
        } else {
            if ((j + 1) % 3 != 0) {
                Console.WriteLine(y);
            } else {
                Console.WriteLine(x);
            }
        }
        j++;
    }
    i++;
}