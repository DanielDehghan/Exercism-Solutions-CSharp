using System;
class Program
{
    static void Main(string[] args)
    {
        int speed = 5;
        int batteryDrain = 2;
        var car = new RemoteControlCar(speed, batteryDrain);

        int distance = 100;
        var raceTrack = new RaceTrack(distance);

       var res=  raceTrack.TryFinishTrack(car);
        Console.WriteLine(res);
    }
}
class RemoteControlCar
{
    private int Speed;
    private int BatteryDrain;
    private int distanceDriven;
    private int batteryPercentage = 100;
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
         Speed = speed;
         BatteryDrain = batteryDrain;
    }
    public bool BatteryDrained()
    {
        if (batteryPercentage < BatteryDrain || batteryPercentage == 0)
        {
            return true;
        }
        return false;
    }

    public int DistanceDriven()
    {
        return distanceDriven;

    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceDriven += Speed;
            batteryPercentage -= BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }

}
class RaceTrack
{
    private int Distance;
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        Distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
            while (!car.BatteryDrained())
            {
                car.Drive();
            }

            return car.DistanceDriven() >= Distance;
    }
}