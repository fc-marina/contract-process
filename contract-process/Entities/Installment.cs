using System.Globalization;

namespace contract_process.Entities
{
    class Installment
    {
        public DateTime InstallmentDate { get; private set; }
        public double InstallmentPrice { get; private set; }

        public Installment(DateTime installmentDate, double installmentPrice)
        {
            InstallmentDate = installmentDate;
            InstallmentPrice = installmentPrice;
        }

        public override string ToString()
        {
            return InstallmentDate.ToString("dd/MM/yyyy") + " - " + InstallmentPrice.ToString("F2", CultureInfo.InvariantCulture); ;
        }
    }
}
