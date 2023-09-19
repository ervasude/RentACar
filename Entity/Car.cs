
using RentACar.Entity;
using RentACar.Enum;


internal class Car
{

    public string Brand { get; set; }

    public string Model { get; set; }

    public int Age { get; set; }
    public int KM { get; set; }

    public DamageRecord DamageR { get; set; }
    public Status Status { get; set; }
    public Damage Damage { get; set; }

    public Car(string brand, string model, int age, int km, Status status, Damage damage)
    {
        Brand = brand;
        Model = model;
        Age = age;
        KM = km;
        Status = status;
        DamageR = new(DateTime.Now, "Sorunsuz", "Emsalsiz");
        Damage = damage;
    }

    public Car()
    {
    }
}
