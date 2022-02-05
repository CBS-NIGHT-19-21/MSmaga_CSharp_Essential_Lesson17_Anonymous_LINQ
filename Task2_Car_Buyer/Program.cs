using Task2_Car_Buyer.Classes;

class Program
{
    static void Main()
    {
        var carList = new List<Car>
        {
            new Car
            { Name = "BMW", Model = "X5", Year = 2007, Color = "White"},
            new Car
            { Name = "Dodge", Model = "Viper", Year = 2015, Color = "Brown"},
            new Car
            { Name = "Audi", Model = "TT", Year = 2021, Color = "Black"}
        };

        var customerList = new List<Customer>
        {
            new Customer
            { Model = "X5", Name = "John", Phone = "33333"},
            new Customer
            { Model = "Viper", Name = "Tom", Phone = "44444"},
            new Customer
            { Model = "TT", Name = "Helen", Phone = "55555"},
        };



        var queryCollection = from car in carList
                              join customer in customerList
                              on car.Model equals customer.Model
                              where car.Year > 2010
                              orderby car.Name
                              select new
                              {
                                  CarName = car.Name,
                                  CarModel = car.Model,
                                  CarYear = car.Year,
                                  CarColor = car.Color,
                                  CustomerName = customer.Name,
                                  CustomerPhone = customer.Phone
                              };

 
        
        foreach (var item in queryCollection)
        {
            Console.WriteLine(item.CarName + "\t" + item.CarModel + "\t" + item.CarYear +
                              item.CarColor + "\t" + item.CustomerName + "\t" + item.CustomerPhone);
        }

        Console.ReadLine();
    }
}