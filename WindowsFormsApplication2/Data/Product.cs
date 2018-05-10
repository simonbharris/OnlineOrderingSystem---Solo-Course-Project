using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Product
    {
        int id;
        string name;
        double price;
        string description;
        int quantity = 0;   // default 0 for catalog purposes / ToString purposes (See this ToString override method)
                            // Quantity is for tracking cart info, not storage.

        #region Accessor/Mutators

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
        #endregion

        #region Constructors
        public Product()
        {
            Name = "";
            Price = 0;
            Description = "";
        }

        public Product(string name, double price, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }

        public Product(int id, string name, double price, string description)
        {
            this.Id = id;
            this.name = name;
            this.price = price;
            this.description = description;
        }
        #endregion

        #region Formatting Methods
        private double TotalCost()
        {
            return this.price * (double)this.quantity;
        }

        // This ToString will give flexiblity in both showing the cost of a single item for catalog purposes
        // And also give total cost for a single item stack in the cart. IE: "5 apples for $10.00"
        // ... I'll admit this looks ugly and should be redone.
        public override string ToString()
        {
            if (this.quantity == 0)
            {
                // Catalog ToString
                return String.Format("{0} | {1}", this.Name, this.Price.ToString("C"));
            } else
            {
                // Cart ToString
                return String.Format("{2} {0} for {1}", this.Name, this.TotalCost().ToString("C"), this.Quantity);
            }
        }
        #endregion

        // Used for customer cart to find total cart value.
        public static double CalculateCartValue(List<Product> products)
        {
            double total = 0;
            foreach (Product p in products)
            {
                total += p.Price * p.Quantity;
            }
            return total;
        }

    }
}
