using System.ComponentModel.DataAnnotations;

namespace Domains
{
    public class Product
    {

        public long Id { get; set; }

        [MinLength(3), MaxLength(200)]
        public string Name { get; set; }
        [MinLength(10), MaxLength(500)]
        public string? Discription { get; set; }

        public int Quantity { get; set; }

        public float UnitPrice { get; set; }

        [Range(0,100)]
        public byte? DiscountPercent { get; set; }

        public bool IsValid { get; set; }

        public Brand Brand { get; set; } // Asocsiation Relation

        public DateTime? InsertingDate { get; set; }

        private readonly IList<Product_Image> images; // For Set intenal and prevent set from external

        
        private readonly IList<Category> categories;

        
        public Product(string name, float unitPrice, bool isValid, int quantity, Category category, Brand brand, string? discription = null, byte? discountPercent = null)
        {
            Name = name;
            Discription = discription;
            UnitPrice = unitPrice;
            DiscountPercent = discountPercent;
            IsValid = isValid;
            Quantity = quantity;
            images = new List<Product_Image>();
            categories = new List<Category>
            {
                category
            };

            Brand = brand;
        }
        // Using Private Constructor For EF Only because the EF not understand objects when create DB 
        private Product() : this(null!, 0!,true!,0!,null!,null!,null,null)
        {

        }
        public IEnumerable<Product_Image> Images { get { return images; } }

        public IEnumerable<Category> Categories { get { return categories; } }

        public bool AddImage(Product_Image image)
        {
            // Check sub category name exist or not
            var imageItem = Images.FirstOrDefault(i => i.Url == image.Url);
            if (imageItem == null)
            {
                images.Add(image);
                return true;
            }
            else
                return false;
        }
        public bool Addcategory(Category category)
        {
            var categoryItem = Categories.FirstOrDefault(c => c.Name == category.Name);
            if (categoryItem == null)
            {
                categories.Add(category);

                return true;
            }
            else
                return false;

        }

    }
}
