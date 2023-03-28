namespace _01_Outsourced.Entities
{
    internal class Outsourced : Employee
    {
        public double AdditionalCharge { get; set; }

        public Outsourced() { }

        public Outsourced(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour) 
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (1.1 * AdditionalCharge);
        }
    }
}
