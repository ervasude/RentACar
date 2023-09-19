
using RentACar.Enum;

List<string> availableCars = new List<string>();
List<string> rentedCars = new List<string>();
List<string> Car = new List<string>();


Car car1 = new Car("Toyota", "Camry", 3, 40000, Status.Used, Damage.Damaged);
Car car2 = new Car("Honda", "Civic", 2, 30000, Status.New, Damage.NotDamaged);
Car car3 = new Car("Ford", "Focus", 5, 60000, Status.Damaged, Damage.NotDamaged);

availableCars.Add(car1.Brand + " " + car1.Model);
availableCars.Add(car2.Brand + " " + car2.Model);
availableCars.Add(car3.Brand + " " + car3.Model);

Console.WriteLine("Welcome to the Car Rental System");
bool exit = false;

while (!exit)
{
    Console.WriteLine("1. Rent a car");
    Console.WriteLine("2. Return a car");
    Console.WriteLine("3. List available cars");
    Console.WriteLine("4. Exit");
    Console.Write("Please select an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            RentCar();
            break;
        case "2":
            ReturnCar();
            break;
        case "3":
            ListAvailableCars();
            break;
        case "4":
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}

void RentCar()
{
    Console.WriteLine("Enter the car you want to rent: ");
    string carToRent = Console.ReadLine();

    if (availableCars.Contains(carToRent))
    {
        availableCars.Remove(carToRent);
        rentedCars.Add(carToRent);
        Console.WriteLine("You have rented a " + carToRent);
    }
    else
    {
        Console.WriteLine("Sorry, the selected car is not available.");
    }
}

void ReturnCar()
{
    Console.WriteLine("Enter the car you want to return: ");
    string carToReturn = Console.ReadLine();

    if (rentedCars.Contains(carToReturn)!)
    {
        rentedCars.Remove(carToReturn);
        availableCars.Add(carToReturn);
        Console.WriteLine("You have returned a " + carToReturn);
    }
    else
    {
        Console.WriteLine("Sorry, you did not rent this car from us.");
    }
}

void ListAvailableCars()
{
    Console.WriteLine("Available cars:");
    foreach (var car in availableCars)
    {
        Console.WriteLine(car);
    }
}


