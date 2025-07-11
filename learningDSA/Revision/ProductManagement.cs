//Product Management
// Scenario 
// In an e-commence app you have products, categories and users.
// you need a generic repository that works for all of them.

//generic repository interface:

class Products
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public double Price { get; set; }
}

interface IProductRepository<T>
{
    void Add(T item);
    List<T> GetAll();
    List<T> GetProductById(Func<T, bool> predicate);
}

class ProductRepository : IProductRepository<Products>
{
    private List<Products> prods = new List<Products>();
    public void Add(Products item)
    {
        prods.Add(item);
    }
    public List<Products> GetAll()
    {
        return prods;
    }
    public List<Products> GetProductById(Func<Products,bool> predicate)
    {
        return prods.Where(predicate).ToList();
    }
}