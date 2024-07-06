using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClass
{
    // The access modifier lets other classes access this class
    public class Product
    {
        // The private access modifier means these properties cannot be accessed from outside this class
        private string code;
        private string description;
        private decimal price;

        // Default constructor
        public Product() { }

        // Custom constructor
        public Product(string code, string description, decimal price)
        {
            this.code = code;
            this.description = description;
            this.price = price;
        }

        // Declarations for three properties of the Product class
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        // This method accepts a string parameter named 'sep'
        // This concatenates with a space
        public string DisplayProductText(string sep)
        {
            return code + sep + price.ToString("c") + sep + description;
        }

        // We have now used 'public' access modifier to allow access from other classes
        // We have used 'private' access modifier to declare fields that we don't
        // want others to access

        // So here, fields can only be accessed through properties defined by 'Product'

        Product cdClassical1A = new Product("Beethoven Sonatas", "Masterful Pieces", 23.54m);
        Product cdClassical2B = new Product("Chamber Music", "Instrumental Works", 34.67m);

        Product cdClassical3A = new Product();
    }
}
