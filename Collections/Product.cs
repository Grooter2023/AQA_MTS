namespace Collections;

public class Product
{
    //��������
    public int Id { get; }
    public string Name { get; }
    public double Price { get; private set; }
    public int Quantity { get; private set; }
    //�����������
    public Product(int id, string name, double price, int quantity)
    {
        Id = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    //����� Update
    public void Update(double price, int quantity)
    {
        Price = price;
        Quantity = quantity;
    }
    //����� ��� ������ ����������
    public override string ToString()
    {
        return $"{Name} (ID: {Id}, ����: {Price:C}, ����������: {Quantity})";
    }
}