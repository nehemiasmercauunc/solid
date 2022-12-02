namespace SOLID.L.Solution;

public class PhoneDevice : ICall, IPlayGame, ISendEmail, ITurnOff, ITurnOn {
    public void Call() {
        // Llamar
        Console.WriteLine("Calling");
    }

    public void PlayGame() {
        // Jugar
        Console.WriteLine("Playing game");
    }

    public void SendEmail() {
        // Enviar email
        Console.WriteLine("Sending email");
    }

    public void TurnOff() {
        Console.WriteLine("Turn off phone");
    }

    public void TurnOn() {
        Console.WriteLine("Turn on phone");
    }

}