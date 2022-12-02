namespace SOLID.L.Problem;

public abstract class Device
{   
    public virtual void Call(){
        // Llamar
        Console.WriteLine("Calling");
    }

    public virtual void WatchTV(){
        // Ver TV
        Console.WriteLine("Watching TV");
    }

    public virtual void PlayGame(){
        // Jugar
        Console.WriteLine("Playing game");
    }

    public virtual void SendEmail(){
        // Enviar email
        Console.WriteLine("Sending email");
    }

    public virtual void TurnOn()
    {
        // Encender dispositivo
        Console.WriteLine("Turn on device");
    }

    public virtual void TurnOff()
    {
        // Apagar dispositivo
        Console.WriteLine("Turn off device");
    }
}