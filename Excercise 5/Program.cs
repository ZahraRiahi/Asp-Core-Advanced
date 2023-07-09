 class Program
    {
        static void Main(string[] args)
        {
            Product  product=new Product("cellphone" ,2500,"samsung");
            System.Console.WriteLine(product.GetName());
            System.Console.WriteLine(product.GetPrice());
            System.Console.WriteLine(product.GetDescription());
            product.SetName("TV");
            product.SetPrice(1200000);
            product.SetDescription("LG");
            System.Console.WriteLine(product.GetName());
            System.Console.WriteLine(product.GetPrice());
            System.Console.WriteLine(product.GetDescription());
        }
    }
