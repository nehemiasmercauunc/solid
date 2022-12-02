namespace SOLID.L.Solution;

public class TVDevice : IWatchTV, ITurnOff, ITurnOn {

    public void TurnOff() {
        Console.WriteLine("Turn off TV");
    }

    public void TurnOn() {
        Console.WriteLine("Turn on TV");
    }

    public void WatchTV() {
        // Ver TV
        Console.WriteLine("Watching TV");
    }
}