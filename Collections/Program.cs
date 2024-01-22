using Collections;

namespace Collections;
class Program
{
    // Создание словаря для хранения товаров. Ключ - уникальный идентификатор товара. Значение - информация о товаре.
    static Dictionary<int, Product> inventory = new Dictionary<int, Product>();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить товар");
            Console.WriteLine("2. Отобразить список товаров");
            Console.WriteLine("3. Поиск товара по идентификатору");
            Console.WriteLine("4. Обновить информацию о товаре");
            Console.WriteLine("5. Удалить товар");
            Console.WriteLine("6. Выход");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct(); 
                    break;
                case 2:
                    DisplayProducts(); 
                    break;
                case 3:
                    SearchById(); 
                    break;
                case 4:
                    UpdateProduct(); 
                    break;
                case 5:
                    RemoveProduct(); 
                    break;
                case 6:
                    Environment.Exit(0); 
                    break;
                default:
                    Console.WriteLine("Неверный ввод. Укажите другое значение!");
                    break;
            }
        }
    }
    static void AddProduct()
    {
        //ID товара
        Random random = new Random();
        int productId = random.Next(10, 100);

        Console.Write("Введите название товара: ");
        string name = Console.ReadLine();

        Console.Write("Введите цену товара: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Введите количество товара на складе: ");
        int quantity = int.Parse(Console.ReadLine());

        // Создание нового товара и добавление его в словарь
        Product newProduct = new Product(productId, name, price, quantity);
        inventory.Add(productId, newProduct);

        Console.WriteLine("Товар успешно добавлен в инвентарь!");
    }
    static void DisplayProducts()
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("Инвентарь пуст.");
            return;
        }

        Console.WriteLine("Список товаров в инвентаре:");
        foreach (var product in inventory.Values)
        {
            Console.WriteLine(product);  
        }
    }
    static void SearchById()
    {
        Console.Write("Введите ID товара: ");
        int productId = int.Parse(Console.ReadLine());

        if (inventory.ContainsKey(productId))
        {
            Console.WriteLine("Информация о товаре:");
            Console.WriteLine(inventory[productId]);  
        }
        else
        {
            Console.WriteLine($"Товар с ID {productId} не найден!");
        }
    }
    static void UpdateProduct()
    {
        Console.Write("Введите ID товара для обновления: ");
        int productId = int.Parse(Console.ReadLine());

        if (inventory.ContainsKey(productId))
        {
            Product productToUpdate = inventory[productId];

            Console.WriteLine($"Текущая информация о товаре: {productToUpdate}");
            Console.Write("Введите новую цену товара: ");
            double newPrice = double.Parse(Console.ReadLine());

            Console.Write("Введите новое количество товара на складе: ");
            int newQuantity = int.Parse(Console.ReadLine());

            productToUpdate.Update(newPrice, newQuantity); 

            Console.WriteLine("Информация о товаре обновлена!");
        }
        else
        {
            Console.WriteLine($"Товар с ID {productId} не найден");
        }
    }
    static void RemoveProduct()
    {
        Console.Write("Введите ID товара для удаления: ");
        int productId = int.Parse(Console.ReadLine());

        if (inventory.ContainsKey(productId))
        {
            inventory.Remove(productId); 
            Console.WriteLine("Товар удален!");
        }
        else
        {
            Console.WriteLine($"Товар с ID {productId} не найден!");
        }
    }
}