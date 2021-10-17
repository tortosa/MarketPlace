using Marketplace.Framework;
using System;

namespace Marketplace.Domain
{
    public class Money : Value<Money>
    {
        private const int decimalsAllowed = 2;
        public decimal Amount { get; }

        public static Money FromDecimal(decimal amount) => new Money(amount);
        public static Money FromString(string amount) => new Money(decimal.Parse(amount));

        protected Money(decimal amount)
        {
            if(decimal.Round(amount, decimalsAllowed) != amount)
                throw new ArgumentOutOfRangeException(nameof(amount), $"Amount cannot have more than {decimalsAllowed} decimals"); 

            Amount = amount;
        }

        public Money Add(Money summand) => new Money(Amount + summand.Amount);

        public Money Substract(Money subtrahend) => new Money(Amount - subtrahend.Amount);

        public static Money operator +(Money summand1, Money summand2) => summand1.Add(summand2);

        public static Money operator -(Money minuend, Money subtrahend) => minuend.Substract(subtrahend);
    }
}