using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Project
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
    public class CardPayment : IPaymentStrategy
    {
        private string cardNumber;

        public CardPayment(string cardNumber)
        {
            this.cardNumber = cardNumber;
        }

        public void Pay(decimal amount)
        {
            MessageBox.Show($"Paid {amount:C} using Card: {cardNumber}");
        }
    }

    public class OnlineBankPayment : IPaymentStrategy
    {
        private string bankName;

        public OnlineBankPayment(string bankName)
        {
            this.bankName = bankName;
        }

        public void Pay(decimal amount)
        {
            MessageBox.Show($"Paid {amount:C} via Online Bank Transfer to {bankName}.");
        }
    }

    public class PaymentContext
    {
        private IPaymentStrategy _strategy;

        public PaymentContext(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecutePayment(decimal amount)
        {
            _strategy.Pay(amount);
        }
    }

}
