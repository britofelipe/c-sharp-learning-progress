using System.Globalization;

namespace _02_Products.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name.ToUpper() + " - $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs Fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture); + ")";
        }

        public double TotalPrice()
        {
            return Price;
        }
    }
}
