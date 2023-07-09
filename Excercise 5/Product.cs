class Product : IProduct
{
    private string name;
    private double price;
    private string description;

    public Product(string name, double price, string description)
    {
        this.name = name;
        this.price = price;
        this.description = description;
    }

    public double GetPrice()
    {
        return price;
    }

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }
}