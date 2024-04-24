using System.Globalization;


namespace ExercicioProposto1
{
    internal class Product
    {
        string name;
        double price, totalPrice;
        int quantity;

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public void totalValueStock()
        {
            totalPrice = price * quantity;
            Console.WriteLine($"VALOR TOTAL EM ESTOQUE R$ {totalPrice.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void addProducts(int stock)
        {
            quantity = quantity + stock;
        }

        public void removeProducts(int removeStock)
        {
            quantity = quantity - removeStock;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
