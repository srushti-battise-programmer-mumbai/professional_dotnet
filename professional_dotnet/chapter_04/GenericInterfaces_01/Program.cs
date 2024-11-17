// Program to demonstrate GenericInterfaces in C# using Visual Studio.
// Programmer: Srushti Battise

namespace GenericInterfaces_01
{
    public interface IRepository<T>
    {
        void Add(T item);
        T GetById(int id);
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ProductRepository : IRepository<Product>
    {
        public void Add(Product item)
        {
            Console.WriteLine("Product Added:" + item.Name);
        }
        public Product GetById(int id)
        {
            return new Product { Id = id, Name = "Sample Product" };
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate GenericInterfaces in C# using Visual Studio.\r\n");
            IRepository<Product> productRepo = new ProductRepository();
            Product product = new Product { Id = 1, Name = "Laptop" };
            productRepo.Add(product);
            Console.WriteLine("Retrieved Product: " + productRepo.GetById(1).Name);

        }
    }
}