using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        //The ? defines a nullable type that allows definition of the value
        //or a null value. So if the code needs to distinguish between not set
        //and zero, you can use a nullable value. 

        public Decimal? CurrentPrice { get; set; }

        public int ProductId { get; private set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }
            if (CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
