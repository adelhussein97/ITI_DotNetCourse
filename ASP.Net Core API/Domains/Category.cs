using System.ComponentModel.DataAnnotations;

namespace Domains
{
    public class Category
    {
        public int Id { get; set; }
        [MinLength(5),MaxLength(100)]
        public string Name { get; set; }

        public Category? ParentCategories { get; set; }
        private readonly IList<Category> subcategories;

        private readonly IList<Product> products; // Prevent Add External 

        public IEnumerable<Category> SubCategories{ get {return subcategories; } }

        public IEnumerable<Product> Products{ get { return products; } }
        public Category(string name, Category? parentCategories = null)
        {

            Name = name;
            ParentCategories = parentCategories;
            subcategories = new List<Category>();
            products = new List<Product>();
        }

        // Using Private Constructor For EF Only because the EF not understand objects when create DB 
        private Category() : this(null !,null)
        {

        }

        public bool AddSubCategory(Category subcategory)
        {
            // Check sub category name exist or not
            var category = SubCategories.FirstOrDefault(c => c.Name == subcategory.Name);
            if (category == null)
            {
                subcategories.Add(subcategory);
                return true;
            }
            else
                return false;
        }
        public bool AddProducts(Product _products)
        {
            var product = Products.FirstOrDefault(p => p.Name == _products.Name);
            if (product == null)
            {
                products.Add(_products);

                return true;
            }
            else
                return false;

        }


    }
}
