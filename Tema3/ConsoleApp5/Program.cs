using System;

public class Product
{
    private string productName;
    private string storeName;
    private decimal price;

    public Product(string productName, string storeName, decimal price)
    {
        this.productName = productName;
        this.storeName = storeName;
        this.price = price;
    }

    public string ProductName
    {
        get { return productName; }
    }

    public string StoreName
    {
        get { return storeName; }
    }

    public decimal Price
    {
        get { return price; }
    }
}

class Program
{
    static void Main()
    {
        Product product1 = new Product("Ноутбук", "ТехноМир", 49999.99m);
        Product product2 = new Product("Смартфон", "МобиМаркет", 29999.99m);

        Console.WriteLine($"Товар: {product1.ProductName}, Магазин: {product1.StoreName}, Цена: {product1.Price} руб.");
        Console.WriteLine($"Товар: {product2.ProductName}, Магазин: {product2.StoreName}, Цена: {product2.Price} руб.");
    }
}
