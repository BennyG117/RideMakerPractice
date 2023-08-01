public class Vehicle
{

    //FIELDS ----------------------
    public string NameOfVehicle;
    public int NumberOfPassengers;
    public string ColorOfVehicle;
    public bool EnginePowered;
    //Miles traveled field with default start @ 0miles
    public int MilesTraveled;

    //Constructors ----------------------

public Vehicle(string nameOfVehicle, int numberOfPassengers, string colorOfVehicle, bool enginePowered)
{
    NameOfVehicle = nameOfVehicle;
    NumberOfPassengers = numberOfPassengers;
    ColorOfVehicle = colorOfVehicle;
    EnginePowered = enginePowered;
    MilesTraveled = 0;
}

public Vehicle(string nameOfVehicle,string colorOfVehicle)
{
    NameOfVehicle = nameOfVehicle;
    NumberOfPassengers = 2;
    ColorOfVehicle = colorOfVehicle;
    EnginePowered = true;
    MilesTraveled = 0;
}



    //Methods ----------------------
public void ShowInfo()
{
    Console.WriteLine("Name of vehicle: " + NameOfVehicle);
    Console.WriteLine("Can carry " + NumberOfPassengers + " passangers.");
    Console.WriteLine("The color of the vehicle is " + ColorOfVehicle);
    Console.WriteLine("Is the vehicle engine powered? "+ EnginePowered);
    Console.WriteLine("Number of miles the vehicle has currently traveled: " + MilesTraveled);
}

public void Travel(int distance)
{
    MilesTraveled += distance;
    Console.WriteLine(NameOfVehicle + " has now traveled " + MilesTraveled + " miles.");
}
}