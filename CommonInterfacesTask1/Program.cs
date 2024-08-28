namespace CommonInterfacesTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW",1000,3,80.000m);
            Car car2 = new Car("Mercedes",2000,1,50.000m);
            Car car3 = new Car("Mitsubishi",5000,13,100.000m);
            Car car4 = new Car("Mitsubishi",5000,13,100.000m);
            
            CarComparer carComparer = new CarComparer();
            carComparer.SortBy = CarComparer.CompareField.Price;

            Car[] cars = {car1,car2,car3};
            


            Console.WriteLine("Returns : " + car1.CompareTo(car2));
            
            Array.Sort(cars,carComparer);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine(car3.Equals(car4));


            Console.WriteLine("-------------------------------");
            Car clonedCar = (Car)car1.Clone();

            car1.Price = 200.000m;


            Console.WriteLine(clonedCar.Price);

        }
    }
}
