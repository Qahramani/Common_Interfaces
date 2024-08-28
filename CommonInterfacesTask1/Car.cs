namespace CommonInterfacesTask1;

public class Car : IComparable<Car>, IEquatable<Car>, ICloneable
{
    public string Name { get; set; }
    public int MaxMph { get; set; }
    public int Horsepower { get; set; }
    public decimal Price { get; set; }

    public Car()
    {
        
    }
    public Car(string name, int maxMph, int horsepower, decimal price)
    {
        Name = name;
        MaxMph = maxMph;
        Horsepower = horsepower;
        Price = price;
    }

    public override string ToString()
    {
        return $"Name : {Name}, MaxMph : {MaxMph}, HorsePower : {Horsepower}, Prcide : {Price}";
    }

    public int CompareTo(Car? other)
    {
        if (other is null)
            throw new NullReferenceException();

        return Name.CompareTo(other.Name);
    }

    public bool Equals(Car? other)
    {
        return Name == other.Name && MaxMph == other.MaxMph && Horsepower == other.Horsepower && Price == other.Price;
    }

    public object Clone()
    {
        Car car = new Car();
        car.Name = Name;
        car.MaxMph = MaxMph;
        car.Horsepower = Horsepower;
        car.Price = Price;

        return car;
    }
}
