using System.Diagnostics;
using System.Xml.Linq;

namespace CommonInterfacesTask1;

public class CarComparer : IComparer<Car>
{
    public enum CompareField
    {
        Name,
        MaxMph,
        HorsePower,
        Price
    }

    public CompareField SortBy = CompareField.Name;
    public int Compare(Car? x, Car? y)
    {
        switch (SortBy)
        {
            case CompareField.Name:
                return x.Name.CompareTo(y.Name);
            case CompareField.MaxMph:
                return x.MaxMph.CompareTo(y.MaxMph);
            case CompareField.HorsePower:
                return x.Horsepower.CompareTo(y.Horsepower);
            case CompareField.Price:
                return x.Price.CompareTo(y.Price);
            default:
                throw new ArgumentNullException("");
        }
    }
}
