internal class Myjnia 
    {
        public void Myj(Samochod samochod) {
            if (samochod.Brudny) 
            {
            samochod.JestemMyty();
            samochod.Brudny = false;
            }
        CzyCzysty(samochod);
        }

    private void CzyCzysty(Samochod samochod) {
        throw new NotImplementedException();
    }
}
