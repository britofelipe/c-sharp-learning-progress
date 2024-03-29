﻿using System.Globalization;

namespace _04_Orders.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem() { }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Price = product.Price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return (Product.Name + ", "
                + "$" + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: " + Quantity)
                + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
