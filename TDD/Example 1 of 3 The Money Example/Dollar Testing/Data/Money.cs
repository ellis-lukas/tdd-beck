namespace Dollar_Testing.Data
{
    public abstract class Money
    {
        public Money(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        protected internal int Amount;

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount && GetType().Equals(money.GetType());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public abstract Money Times(int multiplier);

        protected internal string _currency;

        public string Currency()
        {
            return _currency;
        }
    }
}
