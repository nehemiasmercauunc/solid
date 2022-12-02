namespace SOLID.L.Problem;

internal class PS4Device : Device
{
    public override void PlayGame()
    {
        // Jugar
        Console.WriteLine("Playing game");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Turn off PS4");
    }

    public override void TurnOn()
    {
        Console.WriteLine("Turn on PS4");
    }

    public override void Call()
    {
        throw new NotImplementedException();
    }

    public override void SendEmail()
    {
        throw new NotImplementedException();
    }

    public override void WatchTV()
    {
        throw new NotImplementedException();
    }
}