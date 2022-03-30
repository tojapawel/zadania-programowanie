public abstract class Samochod {
    public abstract bool Brudny { get; internal set; }

    internal abstract void RozbijamSie();

    internal virtual void Przyspiesz() 
        {
        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Przyspieszam "+ i*10);
            Thread.Sleep(2000);
        }
        }

    internal virtual void JestemMyty() 
        {
        Console.WriteLine("Jestem domyslnie myty");
        }
}