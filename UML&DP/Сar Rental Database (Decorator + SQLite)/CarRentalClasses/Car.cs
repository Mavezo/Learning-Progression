namespace CarRentalClasses
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string StateRegistrationNumber { get; set; } = null!;
        public double CostOfRentingPerDay { get; set; }
        public double MaxDistance { get; set; }
        public Car() { }
        public Car(Car car)   
        { 
            Id = car.Id;
            Brand = car.Brand;
            Model = car.Model;
            StateRegistrationNumber = car.StateRegistrationNumber;
            CostOfRentingPerDay = car.CostOfRentingPerDay;
            MaxDistance = car.MaxDistance;
        }



    }
}