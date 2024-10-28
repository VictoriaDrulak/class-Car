public class Car
{
    public string Name { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public const string CompanyName = "My Car Company";

    public Car()
    {
        Name = "Unknown";
        Color = "Unknown";
        Price = 0;
    }
    public Car(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }
    public void Input()
    {
        Console.WriteLine("Введіть назву авто");
        Name = Console.ReadLine();

        Console.WriteLine("Введіть колір авто");
        Color = Console.ReadLine();

        Console.WriteLine("Введіть ціну авто");
        Price = Convert.ToDouble(Console.ReadLine());
    }

    public void Print()
    {
        Console.WriteLine($"Назва: {Name} , Колір:{Color} , Ціна:{Price} , Компанія: {CompanyName}");
    }

    public void ChangePrice(double x)
    {
        Price = Price - (Price * (x / 100));
    }

    public void ChangeColor(string newColor)
    {
        if (Color.ToLower() == "Білий")
        {
            Color = newColor;
            Console.WriteLine($"Автомобіль{Name} пофарбовано у новий колір {newColor}");
        }
    }

    public string PrintInfo()
    {
        return $"Назва {Name}, колір {Color} , ціна {Price} , компанія {CompanyName}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car[] cars = new Car[3];
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = new Car();
            Console.WriteLine($"\nВведіть дані про автомобіль #{i + 1}");
            cars[i].Input();
        }
        Console.WriteLine("\nЦіна після зменшення на 10%");
        foreach (var car in cars)
        {
            car.ChangePrice(10);
            car.Print();
        }
        Console.WriteLine("\nВведіть новий колір для авто з кольором 'white'");
        string newColor = Console.ReadLine();

        foreach (var car in cars)
        {
            car.ChangeColor(newColor);
        }

        Console.WriteLine("\nЗмінені дані про авто:");
        foreach (var car in cars)
        {
            Console.WriteLine(car.PrintInfo());
        }
    }
}
