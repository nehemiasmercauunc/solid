namespace SOLID.L.Problem;

internal class LaptopDevice : Device
{
    public override void Call()
    {
        // Llamar
        Console.WriteLine("Calling");
    }

    public override void PlayGame()
    {
        // Jugar
        Console.WriteLine("Playing game");
    }

    public override void SendEmail()
    {
        // Enviar email
        Console.WriteLine("Sending email");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Turn off laptop");
    }

    public override void TurnOn()
    {
        Console.WriteLine("Turn on laptop");
    }

    public override void WatchTV()
    {
        throw new NotImplementedException();
    }
}