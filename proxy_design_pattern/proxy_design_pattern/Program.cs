namespace proxy_design_pattern
{
    class Program
    {//ctrl+k+d->kodu düzenler
         static void Main(String[] args)
        {
            IBasbakan basbakan = new GercekBasbakan();
            BasbakanlikKalemi kalem = new BasbakanlikKalemi(basbakan);//vatandas basbakanlik akalemi uzerinden basbakanla iletisimde
            Vatandas vatandas = new Vatandas(kalem);

            vatandas.DerdiniAnlat();
            vatandas.IsIste();
        }
    }
}
