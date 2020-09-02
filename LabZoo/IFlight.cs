namespace LabZoo
{
    public interface IFlight
    {
        int FlightDistance { get; }
        int FlightSpeed { get; }

        string Movement();
    }
}