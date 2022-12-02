namespace SOLID.L.Problem;

internal class TvDevice : Device
{
    public override void WatchTV()
    {
        // Ver TV
        Console.WriteLine("Watching TV");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Turn off TV");
    }

    public override void TurnOn()
    {
        Console.WriteLine("Turn on TV");
    }

    public override void Call()
    {
        throw new NotImplementedException();
    }

    public override void PlayGame()
    {
        throw new NotImplementedException();
    }

    public override void SendEmail()
    {
        throw new NotImplementedException();
    }


}