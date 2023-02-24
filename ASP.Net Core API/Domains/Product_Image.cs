namespace Domains
{
    public class Product_Image
    {
        public Guid Id { get; set; }
        public string Url { get; private set; }
        public Product Product { get; private set; } // Asocsiation Relation
        public Product_Image(string url, Product product)
        {
            Url = url;
            Product = product;

        }
        // Using Private Constructor For EF Only because the EF not understand objects when create DB 
        private Product_Image() : this(null!, null!)
        {

        }


    }
}
