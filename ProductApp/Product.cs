namespace ProductApp
{
    public class Product
    {
        public int ProdID { get; private set; }
        public string ProdName { get; private set; }
        public decimal ItemPrice { get; private set; }
        public int StockAmount { get; private set; }

        public Product(int prodID, string prodName, decimal itemPrice, int stockAmount)
        {
            if (prodID < 5 || prodID > 50000) throw new ArgumentOutOfRangeException(nameof(prodID));
            if (itemPrice < 5 || itemPrice > 5000) throw new ArgumentOutOfRangeException(nameof(itemPrice));
            if (stockAmount < 5 || stockAmount > 500000) throw new ArgumentOutOfRangeException(nameof(stockAmount));

            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        public void IncreaseStock(int amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be greater than 0.");
            StockAmount += amount;
        }

        public void DecreaseStock(int amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be greater than 0.");
            if (StockAmount - amount < 0) throw new InvalidOperationException("Stock cannot be negative.");
            StockAmount -= amount;
        }
    }
}
