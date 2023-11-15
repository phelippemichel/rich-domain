namespace PaymentContext.Domain.Entities
{
    public class PaypalPayment : Payment
    {
        public TransactionCode(string TransactionCode)
        :base(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
        {
            TransactionCode = transactionCode;
        }
        public string TransactionCode { get; private set; }
    }
}