namespace Vendering_Machine
{
    abstract class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public abstract void DisplayInfo();
    }
}
