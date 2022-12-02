// See https://aka.ms/new-console-template for more information
namespace SOLID;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("---------------- S - SOLID -----------------");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Forma incorrecta incumpliento la 'S' de SOLID");
        SOLID.S.Problem.TransferService transferServiceProblem = new SOLID.S.Problem.TransferService();
        transferServiceProblem.MakeTransaction("123456789", "987654321", 100);

        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("Forma correcta aplicando la 'S' de SOLID");


        SOLID.S.Solution.EmailService emailService = new SOLID.S.Solution.EmailService();
        SOLID.S.Solution.DBWriterService dbWriterService = new SOLID.S.Solution.DBWriterService();
        SOLID.S.Solution.AccountService accountService = new SOLID.S.Solution.AccountService();

        SOLID.S.Solution.TransferService transferServiceSolution = new SOLID.S.Solution.TransferService(
            emailService, dbWriterService, accountService
        );
        transferServiceSolution.MakeTransaction("123456789", "987654321", 100);

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("---------------- O - SOLID -----------------");
        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("Forma incorrecta incumpliento la 'O' de SOLID");
        SOLID.O.Problem.Payment pago = new SOLID.O.Problem.Payment();
        SOLID.O.Buy buy = new SOLID.O.Buy();
        pago.Pay(buy, SOLID.O.Problem.PaymetType.CreditCard);
        pago.Pay(buy, SOLID.O.Problem.PaymetType.DebitCard);
        pago.Pay(buy, SOLID.O.Problem.PaymetType.Cash);
        pago.Pay(buy, SOLID.O.Problem.PaymetType.QR);

        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("Forma correcta aplicando la 'O' de SOLID");
        SOLID.O.Solution.Payment pagoSolution = new SOLID.O.Solution.Payment(
            new SOLID.O.Solution.PaymentCreditCard()
        );
        pagoSolution.MakePayments(buy);

        pagoSolution = new O.Solution.Payment(
            new SOLID.O.Solution.PaymentDebitCard()
        );
        pagoSolution.MakePayments(buy);

        pagoSolution = new O.Solution.Payment(
            new SOLID.O.Solution.PaymentCash()
        );
        pagoSolution.MakePayments(buy);

        pagoSolution = new O.Solution.Payment(
            new SOLID.O.Solution.PaymentQR()
        );
        pagoSolution.MakePayments(buy);


        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("---------------- L - SOLID -----------------");
        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("Forma incorrecta incumpliento la 'L' de SOLID");
        SOLID.L.Problem.TvDevice tvDevice = new SOLID.L.Problem.TvDevice();
        tvDevice.WatchTV();
        SOLID.L.Problem.PhoneDevice phoneDevice = new SOLID.L.Problem.PhoneDevice();
        phoneDevice.Call();

        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("Forma correcta aplicando la 'L' de SOLID");
        SOLID.L.Solution.TVDevice tvDeviceSolution = new SOLID.L.Solution.TVDevice();
        tvDeviceSolution.WatchTV();
        SOLID.L.Solution.PhoneDevice phoneDeviceSolution = new SOLID.L.Solution.PhoneDevice();
        phoneDeviceSolution.Call();

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("---------------- I - SOLID -----------------");
        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("Forma incorrecta incumpliento la 'I' de SOLID");
        SOLID.I.Problem.SaladOrderService saladOrderService = new SOLID.I.Problem.SaladOrderService();
        saladOrderService.OrderSalad(1);
        //Da error si hago saladOrderService.OrderBurguer(1);
        
        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("Forma correcta aplicando la 'I' de SOLID");
        SOLID.I.Solution.SaladOrderService saladOrderServiceSolution = new SOLID.I.Solution.SaladOrderService();
        saladOrderServiceSolution.OrderSalad(1);
        //No me permite hacer saladOrderService.OrderBurguer(1) porque no existe el metodo
        

          Console.WriteLine("--------------------------------------------");
        Console.WriteLine("---------------- D - SOLID -----------------");
        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("Forma incorrecta incumpliento la 'D' de SOLID");
        SOLID.D.Problem.DataDogService dataDogService = new SOLID.D.Problem.DataDogService();
        SOLID.D.Problem.OrderService orderService = new SOLID.D.Problem.OrderService(dataDogService);
        orderService.GenerateOrder(new SOLID.D.Problem.Order());

        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("Forma correcta aplicando la 'D' de SOLID");
        // SOLID.D.Solution.DataDogService dataDogServiceSolution = new SOLID.D.Solution.DataDogService();
        // SOLID.D.Solution.OrderService orderServiceSolution = new SOLID.D.Solution.OrderService(dataDogServiceSolution);
        SOLID.D.Solution.SmsService smsService = new SOLID.D.Solution.SmsService();
        SOLID.D.Solution.OrderService orderServiceSolution = new SOLID.D.Solution.OrderService(smsService);

        orderServiceSolution.GenerateOrder(new SOLID.D.Solution.Order());
    }
}

