namespace SOLID.L.Solution;

public class LaptopDevice : ICall, ISendEmail, ITurnOff, ITurnOn {
    public void Call() {
        // Llamar
        Console.WriteLine("Calling");
    }

    public void SendEmail() {
        // Enviar email
        Console.WriteLine("Sending email");
    }

    public void TurnOff() {
        Console.WriteLine("Turn off laptop");
    }

    public void TurnOn() {
        Console.WriteLine("Turn on laptop");
    }
}