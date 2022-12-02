namespace SOLID.L.Solution;

public class PS4Device : IPlayGame, ITurnOff, ITurnOn {
   

    public void PlayGame() {
        // Jugar
        Console.WriteLine("Playing game");
    }


    public void TurnOff() {
        Console.WriteLine("Turn off phone");
    }

    public void TurnOn() {
        Console.WriteLine("Turn on phone");
    }

}