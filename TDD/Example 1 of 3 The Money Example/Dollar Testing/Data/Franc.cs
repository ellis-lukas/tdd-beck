namespace Dollar_Testing.Data
{
    class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency) { }

        public override Money Times(int multiplier)
        {
            return Money.Franc(Amount * multiplier);
        }
    }
}
