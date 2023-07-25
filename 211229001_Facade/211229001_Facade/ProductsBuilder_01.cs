namespace _211229001_Facade
{
    public class ProductsBuilder_01
    {
        private Beverages_01 beverages;
        private Confections_01 confections;
        private GrainsCereals_01 grainsCereals;
        private ProductsBuilder_01 builder ;
        
        public ProductsBuilder_01() { }

        public ProductsBuilder_01(List<Products_01> ProductsList)
        {

            beverages = new Beverages_01(ProductsList);
            confections = new Confections_01(ProductsList);
            grainsCereals = new GrainsCereals_01(ProductsList);//ürünlerin kendi kategorilerinde oluşturulduğu yer
        }



    }
}
