namespace Collections;

public class Product
{
    //свойства
    public int Id { get; }
    public string Name { get; }
    public double Price { get; private set; }
    public int Quantity { get; private set; }
    //конструктор
    public Product(int id, string name, double price, int quantity)
    {
        Id = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    //метод Update
    public void Update(double price, int quantity)
    {
        Price = price;
        Quantity = quantity;
    }
    //метод для вывода информации
    public override string ToString()
    {
        return $"{Name} (ID: {Id}, Цена: {Price:C}, Количество: {Quantity})";
    }
}