
Vehicle BMW = new Vehicle("BMW-F700GS", 2, "Red", true);
// BMW.ShowInfo();
// BMW.Travel(117);
// Console.WriteLine(BMW.MilesTraveled);
// Console.WriteLine("======================");

Vehicle Honda = new Vehicle("CTX-700N", 2, "Black", true);
// Honda.ShowInfo();
// Honda.Travel(9050);
// Console.WriteLine(Honda.MilesTraveled);
// Console.WriteLine("======================");

Vehicle Subaru = new Vehicle("Forester Wilderness ", 5, "Blue", true);
// Subaru.ShowInfo();
// Subaru.Travel(3130);
// Console.WriteLine(Subaru.MilesTraveled);
// Console.WriteLine("======================");

Vehicle Hyundai = new Vehicle("Kona", 5, "Dark Gray", true);
// Hyundai.ShowInfo();
// Hyundai.Travel(10200);
// Console.WriteLine(Hyundai.MilesTraveled);
// Console.WriteLine("======================");

List<Vehicle> vehiclesList = new List<Vehicle>
{
BMW,
Honda,
Subaru,
Hyundai
};

foreach(Vehicle v in vehiclesList)
{
    v.ShowInfo();
    v.Travel(5000);
    Console.WriteLine("=============");
};



    Hyundai.Travel(10200);
    Console.WriteLine("=============");
