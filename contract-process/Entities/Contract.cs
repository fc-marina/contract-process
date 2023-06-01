namespace contract_process.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double price)
        {
            Number = number;
            Date = date;
            Price = price;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

    }
}
