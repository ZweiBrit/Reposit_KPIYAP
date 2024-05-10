using System;

/// <summary>
/// Представляет информацию о продукте.
/// </summary>
public class Product
{
    private string productName;
    private string storeName;
    private decimal price;

    /// <summary>
    /// Создает новый экземпляр класса Product.
    /// </summary>
    /// <param name="productName">Наименование продукта.</param>
    /// <param name="storeName">Наименование магазина.</param>
    /// <param name="price">Цена продукта.</param>
    public Product(string productName, string storeName, decimal price)
    {
        this.productName = productName;
        this.storeName = storeName;
        this.price = price;
    }

    /// <summary>
    /// Возвращает наименование продукта.
    /// </summary>
    public string ProductName
    {
        get { return productName; }
    }

    /// <summary>
    /// Возвращает наименование магазина.
    /// </summary>
    public string StoreName
    {
        get { return storeName; }
    }

    /// <summary>
    /// Возвращает цену продукта.
    /// </summary>
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
