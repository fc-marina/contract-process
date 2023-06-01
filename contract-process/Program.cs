using contract_process.Entities;
using contract_process.Services;
using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Contract contract = new Contract(number, date, price);

Console.Write("Enter number of installments: ");
int numberOfInstallments = int.Parse(Console.ReadLine());

PaypalService paypalService = new PaypalService();
ContractService service = new ContractService(paypalService);

service.ProcessContract(contract, numberOfInstallments);

Console.WriteLine("Installments: ");
foreach (Installment installment in contract.Installments)
{
    Console.WriteLine(installment);
}